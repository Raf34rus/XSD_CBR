using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using XSD_CBR.utils;

namespace XSD_CBR
{
    public class Validator
    {
        XmlSchemaSet schemaset;
        StringBuilder errors, warnings;
        static Validator instance;
        static object lockObject = new Object();
        public string ErrorMessage { get; set; }
        public string WarningMessage { get; set; }
        

        public static Validator Instance
        {
            get { return instance; }
        }

        public Validator(string schemaPath)
        {
            WarningAsErrors = true;
            schemaset = new XmlSchemaSet();
            foreach (string s in Directory.GetFiles(schemaPath, "*.xsd"))
            {
                schemaset.Add(XmlSchema.Read(XmlReader.Create(s), new ValidationEventHandler((ss, e) => OnValidateReadSchema(ss, e))));
            }
            instance = this;
        }

        private void OnValidateReadSchema(object ss, ValidationEventArgs e)
        {
            Log.Write(e);
        }
        public bool WarningAsErrors { get; set; }
        private string FormatLineInfo(XmlSchemaException xmlSchemaException)
        {
            return string.Format(" Line:{0} Position:{1}", xmlSchemaException.LineNumber, xmlSchemaException.LinePosition);
        }
        protected void OnValidate(object ss, ValidationEventArgs vae)
        {
            Log.Write(vae);
            if (vae.Severity == XmlSeverityType.Error || WarningAsErrors)
                errors.AppendLine(vae.Message + FormatLineInfo(vae.Exception));
            else
                warnings.AppendLine(vae.Message + FormatLineInfo(vae.Exception));
        }
        public void Validate(String doc)
        {
            lock (lockObject)
            {
                errors = new StringBuilder();
                warnings = new StringBuilder();
                
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.CloseInput = true;
                settings.ValidationEventHandler += new ValidationEventHandler((o, e) => OnValidate(o, e));  // Your callback...
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
                    errors.AppendLine(string.Format("Error at line:{0} Posizione:{1}", e.LineNumber, e.LinePosition));
                }
                ErrorMessage = errors.ToString();
                WarningMessage = warnings.ToString();
            }
        }

    }
}
