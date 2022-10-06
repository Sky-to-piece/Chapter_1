using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сhapter_1_Example_7
{
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        void FormMain_Load(object sender, EventArgs e) {
            this.Text = "Флажок CheckBox";
            chbBold.Text = "Полужирный"; chbBold.Focus();
            chbOblique.Text = "Наклонный";
            markFontStyle.Text = "Выберите стиль шрифта";
            markFontStyle.TextAlign = ContentAlignment.MiddleCenter;
            markFontStyle.Font = new Font("Courier New", 14.0F);
        }

        void chbBold_CheckedChanged(object sender, EventArgs e) {
            markFontStyle.Font = new Font("Courier New",14.0F, markFontStyle.Font.Style ^ FontStyle.Bold);
        }

        void chbOblique_CheckedChanged(object sender, EventArgs e) {
            markFontStyle.Font = new Font("Courier New", 14.0F, markFontStyle.Font.Style ^ FontStyle.Italic);
        }
    }
}
