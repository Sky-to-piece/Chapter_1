using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_1_Example_2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            this.Text = "Приветствие";
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Саламчики!");
        }

        private void markFIO_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Событие MouseHover!");
        }
    }
}
