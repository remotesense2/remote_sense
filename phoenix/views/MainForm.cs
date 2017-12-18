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
        private Control logViewerPanel = null;

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

            //------------------------------
            privilegeManager.AppendLog(@"交叉定标数据预处理", @"C:\\myfiles\\myresult.txt");
            privilegeManager.AppendLog(@"定标场地BRDF模型", @"C:\\myfiles\\myresult.txt");
            privilegeManager.AppendLog(@"观测几何校正因子计算", @"C:\\myfiles\\myresult.txt");
            privilegeManager.AppendLog(@"场地光谱信息提取", @"C:\\myfiles\\myresult.txt");
            privilegeManager.AppendLog(@"场地大气参数提取", @"C:\\myfiles\\myresult.txt");
            privilegeManager.AppendLog(@"光谱匹配校正因子计算", @"C:\\myfiles\\myresult.txt");
            privilegeManager.AppendLog(@"交叉定标", @"C:\\myfiles\\myresult.txt");
            privilegeManager.AppendLog(@"可见近红外全过程交叉定标", @"C:\\myfiles\\myresult.txt");
            privilegeManager.AppendLog(@"热红外全过程交叉定标", @"C:\\myfiles\\myresult.txt");
            privilegeManager.AppendLog(@"图像噪声不确定性分析", @"C:\\myfiles\\myresult.txt");
            privilegeManager.AppendLog(@"观测几何不确定性分析", @"C:\\myfiles\\myresult.txt");
            //-----------------------------

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
                // 添加日志显示panel
                logViewerPanel = new OperateLogViewer(privilegeManager);
                ToolStripMenuItem menuItem = new ToolStripMenuItem();
                menuItem.Text = @"操作日志";
                menuItem.Click += new EventHandler(contextMenuStrip_ShowLog);
                contextMenuStripModules.Items.Add(menuItem);

                // 添加设置界面
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
            if (data != null)
            {
                SwitchPanel(data);
            }
        }

        private void contextMenuStrip_ShowLog(object sender, EventArgs e)
        {
            this.Text = @"定标系统  -  操作日志";
            this.Refresh();

            panelContext.Controls.Clear();
            this.Size = new System.Drawing.Size(this.Size.Width, baseHeight + logViewerPanel.Size.Height);
            logViewerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            logViewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContext.Controls.Add(logViewerPanel);
        }
    }
}
