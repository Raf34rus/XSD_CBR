using System;
using System.IO;
using System.Windows.Forms;
using XSD_CBR.utils;

namespace XSD_CBR
{
    /// <summary>
    /// Строковые константы
    /// </summary>
    public static class CommonConst
    {
        public const string constFolderLog = "Log";
        public const string constFolderDownload = "Download";
        public const string constFolderFiles = "Files";
        public const string constFolderXSD = "xsd";
        public static string AppPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string AppPathLog = Path.Combine(AppPath, constFolderLog);
        public static string AppPathDownload = Path.Combine(AppPath, constFolderDownload);
        public static string AppPathFiles = Path.Combine(AppPath, constFolderFiles);
        public static string AppPathXSD = Path.Combine(AppPath, constFolderXSD);

        public static string GetUniqueFileName()
        {
            return string.Format(@"{0}.xml", Guid.NewGuid());
        }
    }
    /// <summary>
    /// Сообщения
    /// </summary>
    public static class CommonMsg
    {
        public static void ShowMessage(string msg)
        {
            Log.Write(msg);
            MessageBox.Show(
                msg, "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        public static DialogResult ShowQuestionYesNo(string msg)
        {
            return MessageBox.Show(
                msg, "Вопрос",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        public static void ShowError(Exception ex)
        {
            Log.Write(ex);
            MessageBox.Show(
                string.Format("ERROR! {0}", ex.Message),
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
