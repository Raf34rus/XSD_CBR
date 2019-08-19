using System.Windows.Forms;

namespace XSD_CBR
{
    /// <summary>
    /// Форма с результатами валидации XML 
    /// </summary>
    public partial class fResult : Form
    {
        private ValidatorXML _validator;
        /// <summary>
        /// Конструктор
        /// </summary>
        public fResult()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Показать форму
        /// </summary>
        public static void Show(ValidatorXML validator)
        {
            var t = new fResult();
            t.LoadResult(validator);
            t.ShowDialog();
        }
        /// <summary>
        /// Обновитить контролы на форме
        /// </summary>
        private void LoadResult(ValidatorXML validator)
        {
            _validator = validator;
            memoEditError.Text = string.Format("{0}\r\n{1}", validator.WarningMessage, validator.ErrorMessage);
        }
    }
}
