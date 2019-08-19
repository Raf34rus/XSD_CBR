using System;
using System.Windows.Forms;
using System.Net;
using ClassByXSD;
using System.IO;

namespace XSD_CBR
{
    /// <summary>
    /// Форма загрузки документа по ссылке
    /// </summary>
    public partial class fDownload : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public fDownload()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Проверить и сохраниьт файл
        /// </summary>
        private bool SaveFile(string url)
        {
            var ed = new ED542();
            Exception ex = null;
            using (var client = new WebClient())
            {
                string xmlString = client.DownloadString(url);
                
                if (!ValidatorXML.Instance.Validate(xmlString))
                {
                    fResult.Show(ValidatorXML.Instance);
                    return false;
                }
                string fullPath = Path.Combine(CommonConst.AppPathFiles, CommonConst.GetUniqueFileName());
                FileInfo xmlFile = new FileInfo(fullPath);
                var streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
                CommonMsg.ShowMessage(string.Format("Файл {0} успешно загружен", fullPath));
                return true;
            }
            
        }
        /// <summary>
        /// Показать форму
        /// </summary>
        public static bool ShowForm()
        {
            var t = new fDownload();
            DialogResult res = t.ShowDialog();
            if (res == DialogResult.OK)
            {
                return t.SaveFile(t.textBoxURL.Text);
            }
            return false ;
        }
    }
}
