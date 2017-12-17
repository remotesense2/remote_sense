using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using phoenix.views;

namespace phoenix
{
    public partial class MainForm : MaterialForm
    {
        private int baseHeight;
        private PrivilegeManager privilegeManager = new PrivilegeManager();
        private readonly MaterialSkinManager materialSkinManager;
        private MaterialRaisedButton btnSwitch;
        private Control settingPanel = null;

        public MainForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel(privilegeManager);
            loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            TemplateForm loginForm = new TemplateForm(@"登录", loginPanel.Size);
            loginForm.AddContent(loginPanel);
            loginForm.MaximizeBox = false;
            loginForm.MinimizeBox = false;
            loginForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            DialogResult result = loginForm.ShowDialog();
            if (result != DialogResult.OK)
            {
                this.Close();
                return;
            }

            baseHeight = 64;

            PrivilegeData first_data = null;
            Privilege privileges = loginPanel.Privileges;
            foreach (PrivilegeData data in privilegeManager.Privileges)
            {
                if ((privileges & data.PrivilegeName) == data.PrivilegeName)
                {
                    if (first_data == null)
                        first_data = data;

                    ToolStripMenuItem menuItem = new ToolStripMenuItem();
                    menuItem.Text = data.PrivilegeText;
                    menuItem.Click += new EventHandler(contextMenuStrip_Hitted);
                    menuItem.Tag = data;
                    contextMenuStripModules.Items.Add(menuItem);
                }
            }

            SwitchPanel(first_data);

            btnSwitch = new MaterialRaisedButton();
            btnSwitch.Text = @"切换";
            btnSwitch.Dock = DockStyle.Right;
            btnSwitch.Click += this.btnSwitchModuel_Click;
            
            panelTool.Controls.Add(btnSwitch);


            if (loginPanel.IsAdmin)
            {
                settingPanel = new SettingPanel(privilegeManager);
                MaterialRaisedButton btnSetting = new MaterialRaisedButton();
                btnSetting.Text = @"设置";
                btnSetting.Dock = DockStyle.Right;
                btnSetting.Click += this.btnSetting_Click;
                panelTool.Controls.Add(btnSetting);
            }
        }

        void btnSetting_Click(object sender, EventArgs e)
        {
            this.Text = @"定标系统  -  系统管理";
            this.Refresh();

            panelContext.Controls.Clear();
            this.Size = new System.Drawing.Size(this.Size.Width, baseHeight + settingPanel.Size.Height);
            settingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            settingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContext.Controls.Add(settingPanel);
        }

        private void btnSwitchModuel_Click(object sender, EventArgs e)
        {
            contextMenuStripModules.Show(btnSwitch, new System.Drawing.Point(0, btnSwitch.Height));
        }

        private void SwitchPanel(PrivilegeData data)
        {
            this.Text = @"定标系统  -  " + data.PrivilegeText;
            this.Refresh();

            Control ctrl = data.Container;
            if ((ctrl != null) && !panelContext.Controls.Contains(ctrl))
            {
                panelContext.Controls.Clear();
                this.Size = new System.Drawing.Size(this.Size.Width, baseHeight + ctrl.Size.Height);
                ctrl.BackColor = System.Drawing.SystemColors.ControlLightLight;
                ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
                panelContext.Controls.Add(ctrl);
            }
        }

        private void contextMenuStrip_Hitted(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;

            PrivilegeData data = menu.Tag as PrivilegeData;
            SwitchPanel(data);
        }
    }
}
