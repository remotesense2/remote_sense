using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;

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

            TemplateForm addForm = new TemplateForm(@"添加账户", addPanel.Size);
            addForm.AddContent(addPanel);
            addForm.MaximizeBox = false;
            addForm.MinimizeBox = false;
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
                    ListViewItem item = listBoxUsers.Items.Add(privilege.UserName);
                    item.Tag = privilege;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ListViewItem selected_item = null;
            foreach (ListViewItem item in this.listBoxUsers.SelectedItems)
            {
                selected_item = item;
                break;
            }

            UserPrivilege privilege = selected_item.Tag as UserPrivilege;

            if (privilegeManager.DeleteUser(privilege.UserName))
            {
                listBoxUsers.Items.Remove(selected_item);
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            startMonitor = false;
            btnRemove.Enabled = (listBoxUsers.SelectedItems.Count > 0);
            if (listBoxUsers.SelectedItems.Count > 0)
            {
                ListViewItem selected_item = null;
                foreach (ListViewItem item in this.listBoxUsers.SelectedItems)
                {
                    selected_item = item;
                    break;
                }

                UserPrivilege privilege = selected_item.Tag as UserPrivilege;
                currentUserPrivilege = privilege;
                foreach (MaterialCheckBox checkedItem in groupBoxPrivileges.Controls)
                {
                    PrivilegeData data = checkedItem.Tag as PrivilegeData;
                    checkedItem.Checked = ((privilege.Privileges & data.PrivilegeName) == data.PrivilegeName);
                }
            }
            startMonitor = true;
        }

        private void SettingPanel_Load(object sender, EventArgs e)
        {
            // 初始化权限界面
            int topPos = 30;
            int margin = 5;
            foreach (PrivilegeData data in privilegeManager.Privileges)
            {
                MaterialCheckBox checkedItem = new MaterialCheckBox();
                checkedItem.AutoSize = true;
                checkedItem.Text = data.PrivilegeText;
                checkedItem.Tag = data;
                checkedItem.Location = new System.Drawing.Point(margin * 2, topPos);
                groupBoxPrivileges.Controls.Add(checkedItem);

                topPos += checkedItem.Size.Height + margin;
            }

            // 加载用户列表
            ArrayList users = privilegeManager.GetAllUsers();
            foreach (UserPrivilege privilege in users)
            {
                ListViewItem item = listBoxUsers.Items.Add(privilege.UserName);
                item.Tag = privilege;
            }
        }

        private void checkedListBoxPrivilege_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (startMonitor && (currentUserPrivilege != null))
            {
                Privilege privilege = Privilege.NON;
                foreach (MaterialCheckBox checkedItem in groupBoxPrivileges.Controls)
                {
                    if (checkedItem.Checked)
                    {
                        PrivilegeData data = checkedItem.Tag as PrivilegeData;
                        privilege |= data.PrivilegeName;
                    }
                }

                currentUserPrivilege.Privileges = privilege;
                privilegeManager.UpdateUser(currentUserPrivilege);
            }
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }
    }
}
