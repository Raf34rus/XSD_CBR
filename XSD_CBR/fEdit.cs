using System;
using System.Windows.Forms;
using ClassByXSD;
using System.IO;

namespace XSD_CBR
{
    public partial class fEdit : Form
    {
        private ED542 _ed;
        /// <summary>
        /// Конструктор
        /// </summary>
        public fEdit()
        {       
            InitializeComponent();                
        }
        /// <summary>
        /// Показать окно редактирования
        /// </summary>
        public static bool Show(ED542 ed)
        {
            var pv = new fEdit();
            pv.LoadED(ed);
            DialogResult f = pv.ShowDialog();
            if (f == DialogResult.OK)
            {                
                Exception exception = null;
                var fullPath = Path.Combine(CommonConst.AppPathFiles, CommonConst.GetUniqueFileName());
                ed.SaveToFile(fullPath, out exception);
                if (exception != null)
                {
                    throw new Exception(string.Format("Файл не сохранен: {0}", exception.Message));
                } else
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Обновить значение полей на форме 
        /// </summary>
        public void LoadED(ED542 ed)
        {
            _ed = ed;
            numericUpDownEDNo.Text = _ed.EDNo;
            if (_ed.EDDate == default(DateTime))
                dateTimePickerEDDate.Value = DateTime.Now;
            else
                dateTimePickerEDDate.Value = _ed.EDDate;
            numericUpDownEDAuthor.Text = _ed.EDAuthor;
            numericUpDownRepeatReceptInqCode.Text = _ed.RepeatReceptInqCode;
            textBoxEDTypeNo.Text = _ed.EDTypeNo;
            numericUpDownARMNo.Text = _ed.ARMNo;
            numericUpDownRefEDNo.Text = _ed.EDRefID1.EDNo;            
            if (_ed.EDRefID1.EDDate == default(DateTime))
                dateTimePickerRefEDDate.Value = DateTime.Now;
            else
                dateTimePickerRefEDDate.Value = _ed.EDRefID1.EDDate;
            numericUpDownRefEDAuthor.Text = _ed.EDRefID1.EDAuthor;
        }
        /// <summary>
        /// Сохранить изменения 
        /// </summary>
        public void SaveED()
        {
            _ed.EDNo = numericUpDownEDNo.Text;
            _ed.EDDate = dateTimePickerEDDate.Value;
            _ed.EDAuthor = numericUpDownEDAuthor.Text;
            _ed.RepeatReceptInqCode = numericUpDownRepeatReceptInqCode.Text;
            _ed.EDTypeNo = "0542";//textBoxEDTypeNo.Text;
            _ed.ARMNo = numericUpDownARMNo.Text;
            _ed.EDRefID1.EDNo = numericUpDownRefEDNo.Text;
            _ed.EDRefID1.EDDate = dateTimePickerRefEDDate.Value;
            _ed.EDRefID1.EDAuthor = numericUpDownRefEDAuthor.Text;
        }
        /// <summary>
        /// Событие нажатия на кнопку сохранить
        /// </summary>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveED();
        }
    }
}
