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
    public partial class Login : Form
    {
        protected string LoginId;
        protected string Password;
        public Login()
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
            using (var db = new johndoeDb()) // 유징블록을 지나가면 바로 제거하기위함   
            {
                var emp = db.회원정보.SingleOrDefault(p => p.userId == txtLogin.Text &&
                                                        p.password == txtPwd.Text);


                if (emp != null)
                {
                    var form = new Form1();
                    form.Show();
                    this.Hide(); // 로그인창 감춤 
                }
                else
                {
                    MessageBox.Show(" 아이디나 비밀번호가 잘못되었습니다.", "로그인 실패");
                }
            }
        }
    }
}
