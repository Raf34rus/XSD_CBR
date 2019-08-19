using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using XSD_CBR;

namespace ClassByXSD
{
    #region ������� ����� ���������
    public partial class EntityBase<T>

    {
        private static XmlSerializer serializer;
        private static XmlSerializer Serializer
        {
            get
            {
                if (serializer == null)
                {
                    serializer = new XmlSerializerFactory().CreateSerializer(typeof(T));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// ����������� ������� ������ EntityBase � ������ XML
        /// </summary>
        /// <returns>��������� �������� XML</returns>
        public virtual string Serialize()
        {
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try
            {
                memoryStream = new MemoryStream();
                System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
                System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
                Serializer.Serialize(xmlWriter, this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }
        /// <summary>
        /// ������������� ������� ������ EntityBase � ������ XML
        /// </summary>
        public static bool Deserialize(string input, out T obj, out Exception exception)
        {
            exception = null;
            obj = default(T);
            try
            {
                obj = Deserialize(input);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string input, out T obj)
        {
            Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public static T Deserialize(string input)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(input);
                return ((T)(Serializer.Deserialize(XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static T Deserialize(Stream s)
        {
            return ((T)(Serializer.Deserialize(s)));
        }
        #endregion Serialize/Deserialize
        /// <summary>
        /// ����������� ������� ������ EntityBase � ����
        /// </summary>
        /// <param name="fileName">������ ���� � ���������� xml-�����</param>
        /// <param name="exception">�������� �������� ����������, ���� �� �������</param>
        /// <returns>true, ���� ����� ������������� � ��������� � ����; � ��������� ������, false</returns>
        public virtual bool SaveToFile(string fileName, out Exception exception)
        {
            exception = null;
            try
            {
                
                if (!Directory.Exists(Path.GetDirectoryName(fileName)))
                    Directory.CreateDirectory(Path.GetDirectoryName(fileName)); // ������� ����������, ���� �����
                SaveToFile(fileName);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }
        /// <summary>
        /// ��������� � ����
        /// </summary>
        public virtual void SaveToFile(string fileName)
        {
            StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize();
                if (!ValidatorXML.Instance.Validate(xmlString))
                {
                    fResult.Show(ValidatorXML.Instance);
                    throw new Exception("������ ���������");
                }
                FileInfo xmlFile = new FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }
        }
        /// <summary>
        /// ��������� �� �����
        /// </summary>
        public static bool LoadFromFile(string fileName, out T obj, out Exception exception)
        {
            exception = null;
            obj = default(T);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out T obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static T LoadFromFile(string fileName)
        {
            FileStream file = null;
            StreamReader sr = null;
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
    }
    #endregion
}
