using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сhapter_1_Example_4 {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        void FormMain_Load(object sender, EventArgs e) {
            this.Text = "Извлечение квадратного корня";
            markMain.Text = "";
            tb_for_num.Clear();
            tb_for_num.TabIndex = 0;

        }

        void btnFind_Click(object sender, EventArgs e) {
            Single X;
            bool whatif = Single.TryParse(
                tb_for_num.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo,
                out X
                );

            if (whatif == false) {
                markMain.Text = "Введите пожалуйста число";
                markMain.ForeColor = Color.Red;
                return;
            }
            var Y = Convert.ToSingle(Math.Sqrt(X));
            markMain.ForeColor = Color.Black;
            markMain.Text = String.Format(" Корень из {0} равен {1:F5}", X, Y);
        }

    }
}
