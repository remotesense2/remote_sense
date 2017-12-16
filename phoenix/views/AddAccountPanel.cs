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
    public partial class AddAccountPanel : UserControl
    {
        public string UserName;
        public string UserPwd;
        private PrivilegeManager privilegeManager = null;

        public AddAccountPanel(PrivilegeManager mgr)
        {
            privilegeManager = mgr;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserName = textBoxUserName.Text.Trim();
            UserPwd = textBoxPassword.Text;
            if (UserName.Length == 0)
            {
                MessageBox.Show(@"用户名不能为空");
                return;
            }

            if (textBoxPassword.Text.Length == 0 || textBoxPwdAgain.Text.Length == 0)
            {
                MessageBox.Show(@"密码不能为空");
                return;
            }

            if (textBoxPassword.Text != textBoxPwdAgain.Text)
            {
                MessageBox.Show(@"密码不一致");
                return;
            }

            if (privilegeManager.IsUserExisted(UserName))
            {
                MessageBox.Show(@"该账户已经存在");
                return;
            }

            UserName = textBoxUserName.Text;
            UserPwd = textBoxPassword.Text;
            this.ParentForm.DialogResult = DialogResult.OK;
        }
    }
}
