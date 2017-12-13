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
    public partial class SettingPanel : UserControl
    {
        private PrivilegeManager privilegeManager = null;

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
                listBoxUsers.Items.Add(addPanel.UserName);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBoxUsers.Items.Remove(listBoxUsers.SelectedItem);
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = (listBoxUsers.SelectedItems.Count > 0);
            if (listBoxUsers.SelectedItems.Count > 0)
            {

            }
        }

        private void SettingPanel_Load(object sender, EventArgs e)
        {
            foreach (PrivilegeData data in privilegeManager.Privileges)
            {
                checkedListBoxPrivilege.Items.Add(data.PrivilegeText);
            }
        }
    }
}
