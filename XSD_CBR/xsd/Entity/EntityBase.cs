
namespace XSD_CBR
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Collections.Generic;

#region Базовый класс сущностей
public partial class EntityBase<T>

{
    
    private static XmlSerializer serializer;
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(T));
            }
            return serializer;
        }
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Сериализует текущий объект EntityBase в строку XML
    /// </summary>
    /// <returns>строковое значение XML</returns>
    public virtual string Serialize()
    {
        System.IO.StreamReader streamReader = null;
        System.IO.MemoryStream memoryStream = null;
        try
        {
            memoryStream = new System.IO.MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            streamReader = new System.IO.StreamReader(memoryStream);
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
    /// Десериализует разметку рабочего процесса в объект EntityBase
    /// </summary>
    /// <param name="input">строка разметки рабочего процесса для десериализации</param>
    /// <param name="obj">Выходной объект EntityBase</param>
    /// <param name="exception">выходное значение исключения, если не удалось десериализовать</param>
    /// <returns>true, если этот сериализатор может десериализовать объект; в противном случае false</returns>
    public static bool Deserialize(string input, out T obj, out System.Exception exception)
    {
        exception = null;
        obj = default(T);
        try
        {
            obj = Deserialize(input);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool Deserialize(string input, out T obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public static T Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
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
    
    public static T Deserialize(System.IO.Stream s)
    {
        return ((T)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Сериализует текущий объект EntityBase в файл
    /// </summary>
    /// <param name="fileName">полный путь к исходящему xml-файлу</param>
    /// <param name="exception">выходное значение исключения, если не удалось</param>
    /// <returns>true, если можно сериализовать и сохранить в файл; в противном случае, false</returns>
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName);
            return true;
        }
        catch (System.Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual void SaveToFile(string fileName)
    {
        System.IO.StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize();
            System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
            streamWriter = xmlFile.CreateText();
            streamWriter.WriteLine(xmlString);
            streamWriter.Close();
        }
        finally
        {
            if ((streamWriter != null))
            {
                streamWriter.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Десериализует XML-разметку из файла в объект EntityBase
    /// </summary>
    /// <param name="fileName">строковый xml-файл для загрузки и десериализации</param>
    /// <param name="obj">Выходной объект EntityBase</param>
    /// <param name="exception">выходное значение исключения, если не удалось десериализовать</param>
    /// <returns>true, если этот сериализатор может десериализовать объект; в противном случае false</returns>
    public static bool LoadFromFile(string fileName, out T obj, out System.Exception exception)
    {
        exception = null;
        obj = default(T);
        try
        {
            obj = LoadFromFile(fileName);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out T obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static T LoadFromFile(string fileName)
    {
        System.IO.FileStream file = null;
        System.IO.StreamReader sr = null;
        try
        {
            file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new System.IO.StreamReader(file);
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

