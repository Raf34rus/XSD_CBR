using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace XSD_CBR.utils
{
    class Log
    {
        private static object sync = new object();
        private static string GetFullPath()
        {
            string pathToLog = Path.Combine(Application.UserAppDataPath, "Log");
            if (!Directory.Exists(pathToLog))
                Directory.CreateDirectory(pathToLog); // Создаем директорию, если нужно
            string filename = Path.Combine(pathToLog, string.Format("day_{0:dd.MM.yyy}.log", DateTime.Now));

            return filename;
        }
        private static void AppendText(string msg)
        {
            try
            {
                lock (sync)
                {
                    File.AppendAllText(GetFullPath(), msg, Encoding.GetEncoding("Windows-1251"));
                }
            }
            catch
            {
                // Перехватываем все и ничего не делаем
            }
        }
        public static void DeleteLog()
        {
            string val = GetFullPath();
            if (File.Exists(val))
                File.Delete(val);
        }
        public static void Write(Exception ex)
        {
            string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] [{1}.{2}()] {3}\r\n", DateTime.Now, ex.TargetSite.DeclaringType, ex.TargetSite.Name, ex.Message);
            AppendText(fullText);
        }
        public static void Write(string msg)
        {
            string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n", DateTime.Now, msg);
            AppendText(fullText);
        }
        public static void Write(ValidationEventArgs e)
        {
            string fullText = string.Empty;
            if (e.Severity == XmlSeverityType.Error)
                fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] ОШИБКА: {1}\r\n", DateTime.Now, e.Message);
            else
                fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] ПРЕДУПРЕЖДЕНИЕ: {1}\r\n", DateTime.Now, e.Message);
            AppendText(fullText);
        }

    }
}
