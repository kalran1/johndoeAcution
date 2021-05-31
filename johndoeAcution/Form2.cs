using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace johndoeAcution
{
    public partial class Form2 : Form
    {
        protected string LoginId;
        protected string Password;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            LoginId = txtLogin.Text;
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            Password = txtPwd.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new johndoeDb();
            /*
            if (LoginId == "abcd" || Password == "1234")
            {
                var form = new Form1();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login failed.");
                Hide();
            }
            */
        }
    }
}
