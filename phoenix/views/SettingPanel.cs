using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phoenix.views
{
    public partial class SettingPanel : UserControl
    {
        private PrivilegeManager privilegeManager = null;
        private bool startMonitor = false;
        private UserPrivilege currentUserPrivilege = null;

        public SettingPanel(PrivilegeManager mgr)
        {
            privilegeManager = mgr;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAccountPanel addPanel = new AddAccountPanel();
            addPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            Form addForm = new Form();
            addForm.Text = @"添加账户";
            addForm.Controls.Add(addPanel);
            addForm.Size = new System.Drawing.Size(332, 213);
            addForm.MaximizeBox = false;
            addForm.MinimizeBox = false;
            addForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            addForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            DialogResult result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                UserPrivilege privilege = new UserPrivilege();
                privilege.UserName = addPanel.UserName;
                privilege.UserPwd = addPanel.UserPwd;
                privilege.Privileges = Privilege.ALL;
                if (privilegeManager.AddUser(privilege))
                {
                    listBoxUsers.Items.Add(privilege);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            UserPrivilege privilege = (UserPrivilege)listBoxUsers.SelectedItem;
            if (privilegeManager.DeleteUser(privilege.UserName))
            {
                listBoxUsers.Items.Remove(privilege);
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            startMonitor = false;
            btnRemove.Enabled = (listBoxUsers.SelectedItems.Count > 0);
            if (listBoxUsers.SelectedItems.Count > 0)
            {
                UserPrivilege privilege = (UserPrivilege)listBoxUsers.SelectedItem;
                currentUserPrivilege = privilege;
                foreach (PrivilegeData data in privilegeManager.Privileges)
                {
                    bool shouldChecked = ((privilege.Privileges & data.PrivilegeName) == data.PrivilegeName);
                    int index = checkedListBoxPrivilege.Items.IndexOf(data);
                    checkedListBoxPrivilege.SetItemChecked(index, shouldChecked);
                }
            }
            startMonitor = true;
        }

        private void SettingPanel_Load(object sender, EventArgs e)
        {
            // 初始化权限界面
            foreach (PrivilegeData data in privilegeManager.Privileges)
            {
                checkedListBoxPrivilege.Items.Add(data);
            }

            // 加载用户列表
            ArrayList users = privilegeManager.GetAllUsers();
            foreach (UserPrivilege privilege in users)
            {
                listBoxUsers.Items.Add(privilege);
            }
        }

        private void checkedListBoxPrivilege_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (startMonitor && (currentUserPrivilege != null))
            {
                Privilege privilege = Privilege.NON;
                foreach (PrivilegeData data in privilegeManager.Privileges)
                {
                    int index = checkedListBoxPrivilege.Items.IndexOf(data);
                    bool isChecked = (index == e.Index) ? (e.NewValue == CheckState.Checked)
                                                        : checkedListBoxPrivilege.GetItemChecked(index);
                    if (isChecked)
                    {
                        privilege |= data.PrivilegeName;
                    }
                }
                currentUserPrivilege.Privileges = privilege;
                privilegeManager.UpdateUser(currentUserPrivilege);
            }
        }
    }
}
