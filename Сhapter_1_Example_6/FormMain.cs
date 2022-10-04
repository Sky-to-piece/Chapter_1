using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сhapter_1_Example_6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        void FormMain_Load(object sender, EventArgs e) {
            this.Text = "Флажок CheckBox";
            chbFontStyle.Text = "Полужирный";
            chbFontStyle.Focus();
            markFontStyleExamp.Text = "Выберите стиль шрифта";
            markFontStyleExamp.TextAlign = ContentAlignment.MiddleCenter;
            markFontStyleExamp.Font = new Font("Courier New", 14.0F);
        }

        void chbFontStyle_CheckedChanged(object sender, EventArgs e) {
            if (chbFontStyle.Checked == true) {
                markFontStyleExamp.Font = new Font("Courier New", 14.0F, FontStyle.Bold);
            }

            if(chbFontStyle.Checked == false) {
                markFontStyleExamp.Font = new Font("Courier New", 14.0F, FontStyle.Regular);
            }
        }
    }
}
