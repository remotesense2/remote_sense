using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phoenix.views
{
    public partial class LoginPanel : UserControl
    {
        public Privilege Privileges = Privilege.ALL;
        public bool IsAdmin = false;

        public LoginPanel()
        {
            InitializeComponent();
            textBoxUserName.Text = "admin";
            textBoxPassword.Text = "qaz123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text.Trim();
            string userPwd = textBoxPassword.Text;

            bool valid = false;
            if (userName == "admin" && userPwd == "qaz123")
            {
                IsAdmin = true;
                Privileges = Privilege.ALL;
                valid = true;
            }
            else
            {
                // 需要数据库验证
                IsAdmin = false;
                Privileges = Privilege.BATCHCROSSCALIBRATION | Privilege.BRDFMODEL | Privilege.PREPROCESS | Privilege.SITEATMPARAS;
                valid = true;
            }

            if (valid)
            {
                this.ParentForm.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(@"账号密码错误，请重新输入");
            }
        }
    }
}
