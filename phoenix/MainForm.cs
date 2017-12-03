using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phoenix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            navigatePanelHead.AddPanel("预处理", new PreprocessPanel());
            navigatePanelHead.AddPanel("观测几何校正", null);
            navigatePanelHead.AddPanel("光谱匹配校正", null);
            navigatePanelHead.AddPanel("光谱信息提取", null);
            navigatePanelHead.AddPanel("卫星过境大气参数提取", null);
            navigatePanelHead.AddPanel("交叉定标处理", null);
            navigatePanelHead.AddPanel("交叉定标批处理", null);
            navigatePanelHead.AddPanel("热红外传感器交叉定标", null);
            navigatePanelHead.AddPanel("交叉定标不确定性分析", null);
        }

        private void navigatePanelHead_NavigateEvent(ContainerControl container)
        {
            panelContext.Controls.Clear();
            if (container != null)
            {
                container.Dock = System.Windows.Forms.DockStyle.Fill;
                panelContext.Controls.Add(container);
            }
        }
    }
}
