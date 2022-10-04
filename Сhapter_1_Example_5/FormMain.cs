using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сhapter_1_Example_5 {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        void FormMain_Load(object sender, EventArgs e) {
            this.Text = "Введите пароль";
            tbPass.Text = null;
            tbPass.TabIndex = 0;
            tbPass.PasswordChar = '*';
            tbPass.Font = new Font("Courier New", 10.0F);
            markShowPass.Text = String.Empty;
            markShowPass.Font = new Font("Courier New", 10.0F);
        }

        void btnEnter_Click(object sender, EventArgs e) {
            markShowPass.Text = tbPass.Text;
        }

        
    }
}
