using System;
using System.Windows.Forms;
using XSD_CBR.utils;
using ClassByXSD;
using System.IO;


namespace XSD_CBR
{
    public partial class fMain : Form
    {
        ValidatorXML validator;
        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public fMain()
        {
            InitializeComponent();
            Log.Write("Запуск программы");
            validator = new ValidatorXML(CommonConst.AppPathXSD);
            UpdateFileList();
        }

        /// <summary>
        /// Обновление списка файла
        /// </summary>
        public void UpdateFileList()
        {
            listBoxFiles.BeginUpdate();
            try
            {
                listBoxFiles.Items.Clear();
                string[] filesname = Directory.GetFiles(CommonConst.constFolderFiles);
                foreach (var item in filesname)
                {
                    listBoxFiles.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                CommonMsg.ShowError(ex);
            }
            finally
            {
                listBoxFiles.EndUpdate();
            }
        }
        /// <summary>
        /// Событие нажатия на кнопку добавить
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Log.Write("Begin: Добавление файла");
            var ed = new ED542();
            try
            {
                bool res = fEdit.Show(ed);
                if (res)
                {
                    Log.Write("End: Добавление файла");
                    UpdateFileList();
                }
            } catch (Exception ex)
            {
                CommonMsg.ShowError(ex);
            }
        }
        /// <summary>
        /// Событие нажатия на кнопку редактировать
        /// </summary>
        private void buttonEdit_Click(object sender, EventArgs e)
        {            
            var t = (string) listBoxFiles.SelectedItem;
            var ed = new object();
            try
            {
                Log.Write(string.Format("Редактирование файла {0}", t));
                ed = EntityBase<EDRefID>.LoadFromFile(t);
                fEdit.Show((ED542)ed);
            }
            catch (Exception ex)
            {
                CommonMsg.ShowError(ex);
            }
        }
        /// <summary>
        /// Событие изменение выделения в списке файлов
        /// </summary>
        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = listBoxFiles.SelectedItem != null;
            buttonDel.Enabled = buttonEdit.Enabled;
        }
        /// <summary>
        /// Событие нажатия на кнопку удалить
        /// </summary>
        private void buttonDel_Click(object sender, EventArgs e)
        {            
            var t = (string)listBoxFiles.SelectedItem;
            if (CommonMsg.ShowQuestionYesNo(string.Format("Вы уверены, что хотите удалить файл \"{0}\"?", t)) != DialogResult.Yes)
                return;
            Log.Write(string.Format("Удаление файла {0}", t));
            listBoxFiles.Items.Remove(listBoxFiles.SelectedItem);
            if (File.Exists(t))
                File.Delete(t);
        }
        /// <summary>
        /// Событие нажатия на кнопку скачать
        /// </summary>
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Write("Begin:Скачивание файла");
                var res = fDownload.ShowForm();
                if (res)
                {
                    Log.Write("End: Скачивание файла");
                    UpdateFileList();
                }
            }
            catch (Exception ex)
            {
                CommonMsg.ShowError(ex);
            }
        }
        /// <summary>
        /// Завершение работы
        /// </summary>
        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log.Write("Завершение работы программы");
        }
    }
}
