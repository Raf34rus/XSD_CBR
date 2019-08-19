using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using XSD_CBR.utils;

namespace XSD_CBR
{
    /// <summary>
    /// Проверить валидность XML по схемам XSD
    /// </summary>
    public class ValidatorXML
    {
        XmlSchemaSet schemaset;
        StringBuilder errors;
        StringBuilder warnings;
        static ValidatorXML instance;
        static object lockObject = new Object();
        public string ErrorMessage { get; set; }
        public string WarningMessage { get; set; }
        public bool WarningAsErrors { get; set; }

        public static ValidatorXML Instance
        {
            get { return instance; }
        }
        public bool IsExistError()
        {
            return (errors.Length > 0) || (warnings.Length > 0);
        }
        /// <summary>
        /// Загрузить схемы XSD 
        /// </summary>
        public ValidatorXML(string schemaPath)
        {
            WarningAsErrors = true;
            schemaset = new XmlSchemaSet();
            foreach (string s in Directory.GetFiles(schemaPath, "*.xsd"))
            {
                schemaset.Add(XmlSchema.Read(XmlReader.Create(s), new ValidationEventHandler((ss, e) => OnValidateReadSchema(ss, e))));
            }
            instance = this;
        }
        /// <summary>
        /// Ловим ошибки валидации
        /// </summary>
        private void OnValidateReadSchema(object ss, ValidationEventArgs e)
        {
            Log.Write(e);
        }
        /// <summary>
        /// Координаты ошибки 
        /// </summary>
        private string FormatLineInfo(XmlSchemaException xmlSchemaException)
        {
            return string.Format(" Строка:{0} Позиция:{1}", xmlSchemaException.LineNumber, xmlSchemaException.LinePosition);
        }
        /// <summary>
        /// Собитие перехвата ошибок при построчном чтении XML
        /// </summary>
        protected void OnValidate(object ss, ValidationEventArgs vae)
        {
            Log.Write(vae);
            if (vae.Severity == XmlSeverityType.Error || WarningAsErrors)
                errors.AppendLine(vae.Message + FormatLineInfo(vae.Exception));
            else
                warnings.AppendLine(vae.Message + FormatLineInfo(vae.Exception));
        }
        /// <summary>
        /// Валидация строки XML документа
        /// </summary>
        public bool Validate(String doc)
        {
            lock (lockObject)
            {
                errors = new StringBuilder();
                warnings = new StringBuilder();
                
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.CloseInput = true;
                settings.ValidationEventHandler += new ValidationEventHandler((o, e) => OnValidate(o, e));  // Событие 
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas.Add(schemaset);
                settings.ValidationFlags =
                  XmlSchemaValidationFlags.ReportValidationWarnings |
                  XmlSchemaValidationFlags.ProcessIdentityConstraints |
                  XmlSchemaValidationFlags.ProcessInlineSchema |
                  XmlSchemaValidationFlags.ProcessSchemaLocation;

                // Обернуть документ в метода XmlNodeReader и запустить проверку 
                try
                {
                    using (XmlReader validatingReader = XmlReader.Create(new StringReader(doc), settings))
                    {
                        while (validatingReader.Read()) { /* цикл через документ */ }
                    }
                }
                catch (XmlException e)
                {
                    errors.AppendLine(string.Format("Ошибка в строке:{0} Позиция:{1}", e.LineNumber, e.LinePosition));
                }
                ErrorMessage = errors.ToString();
                WarningMessage = warnings.ToString();
            }
            return !IsExistError();
        }

    }
}
