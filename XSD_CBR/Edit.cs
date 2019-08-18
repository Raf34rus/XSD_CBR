using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classByXSD;

namespace XSD_CBR
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var ed = new ED542();

            ed.EDNo = "1";
            ed.EDDate = DateTime.Now;
            ed.EDAuthor = "1";
            ed.RepeatReceptInqCode = "1";
            ed.EDTypeNo = "";
            ed.ARMNo = "1";
            //ed.EDRefID1 = "1"; 
            ed.EDRefID1.EDNo = "1";
            ed.EDRefID1.EDDate = DateTime.Now;
            ed.EDRefID1.EDAuthor = "";



        }
}
}
