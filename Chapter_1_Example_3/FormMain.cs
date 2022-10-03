using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_1_Example_3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "Средство выбора даты";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "ddd,dd MMM, yyyy";
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            markDate.Text = String.Format("Сегодня: {0}", dateTimePicker1.Text);
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Focus();
            SendKeys.Send("{F4}");
        }
    }
}
