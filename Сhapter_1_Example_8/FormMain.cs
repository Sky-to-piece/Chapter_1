using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сhapter_1_Example_8
{
    public partial class FormMain : Form
    {
        public FormMain() {
            InitializeComponent();
            var tpSize = new TabPage();
            tpSize.UseVisualStyleBackColor = true;
            this.tabControl.Controls.Add(tpSize);
            tpSize.Controls.Add(this.radioButtonFirst);
            tpSize.Controls.Add(this.radioButtonSecond);
            this.radioButtonFirst.Location = new Point(20, 15);
            this.radioButtonSecond.Location = new Point(20, 58);
            this.Text = "Какая улыбка вам ближе";
            tabControl.TabPages[0].Text = "Текст";
            tabControl.TabPages[1].Text = "Цвет";
            tabControl.TabPages[2].Text = "Размер";


        }

        private void FormMain_Load(object sender, EventArgs e) {
            
        }
    }
}
