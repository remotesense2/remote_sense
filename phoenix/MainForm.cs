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
            navigatePanelHead.AddPanel("交叉定标数据预处理", new PreprocessPanel());
            navigatePanelHead.AddPanel("交叉定标观测几何校正", new GeometryPanel());
            navigatePanelHead.AddPanel("交叉定标光谱匹配校正", new SpectrumPanel());
            navigatePanelHead.AddPanel("交叉定标处理", new ProcessPanel());
            navigatePanelHead.AddPanel("交叉定标批处理", new BatchProcessPanel());
            navigatePanelHead.AddPanel("热红外传感器交叉定标", new InfraredPanel());
            navigatePanelHead.AddPanel("交叉定标不确定性分析", new UncertaintyAnalysisPanel());
            navigatePanelHead.AddPanel("系统管理", new SystemManagerPanel());
            navigatePanelHead.AddPanel("退出", null);
        }

        private void navigatePanelHead_NavigateEvent(ContainerControl container)
        {
            panelContext.Controls.Clear();
            if (container != null)
            {
                container.Dock = System.Windows.Forms.DockStyle.Fill;
                panelContext.Controls.Add(container);
            }
            else
            {
                this.Close();
            }
        }
    }
}
