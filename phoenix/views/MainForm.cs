using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using phoenix.views;

namespace phoenix
{
    public partial class MainForm : Form
    {
        private int baseHeight;
        private PrivilegeManager privilegeManager = new PrivilegeManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            Form loginForm = new Form();
            loginForm.Text = @"登录";
            loginForm.Controls.Add(loginPanel);
            loginForm.Size = new System.Drawing.Size(332, 203);
            loginForm.MaximizeBox = false;
            loginForm.MinimizeBox = false;
            loginForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            loginForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            DialogResult result = loginForm.ShowDialog();
            if (result != DialogResult.OK)
            {
                this.Close();
                return;
            }

            baseHeight = this.navigatePanelHead.Height + 20;

            int added = 0;
            bool firstPinned = true;
            NavigateTabGroup tabGroup = null;
            Privilege privileges = loginPanel.Privileges;
            foreach (PrivilegeData data in privilegeManager.Privileges)
            {
                if ((privileges & data.PrivilegeName) == data.PrivilegeName)
                {
                    if (added++ % 7 == 0)
                    {
                        tabGroup = navigatePanelHead.AddGroup();
                    }
                    tabGroup.AddPanel(data.PrivilegeText, data.Container, firstPinned);
                    firstPinned = false;
                }
            }

            if (loginPanel.IsAdmin)
            {
                navigatePanelHead.AddNoGroupPanel(@"系统管理", new SettingPanel(privilegeManager));
            }
        }

        private void navigatePanelHead_NavigateEvent(ContainerControl container)
        {
            panelContext.Controls.Clear();
            if (container != null)
            {
                this.Size = new System.Drawing.Size(this.Size.Width, baseHeight + container.Size.Height);
                container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
                container.Dock = System.Windows.Forms.DockStyle.Fill;
                panelContext.Controls.Add(container);
            }
        }

        private void navigatePanelHead_Load(object sender, EventArgs e)
        {

        }
    }
}
