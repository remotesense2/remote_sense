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
        private int baseHeight;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            baseHeight = this.navigatePanelHead.Height + 20;
            navigatePanelHead.AddPanel("交叉定标数据预处理", new PreprocessPanel());
            navigatePanelHead.AddPanel("定标场地BRDF模型", new BRDFModelPanel());
            navigatePanelHead.AddPanel("观测几何校正因子计算", new BRDFPanel());
            navigatePanelHead.AddPanel("场地光谱信息提取", new SiteReflectancePanel());
            navigatePanelHead.AddPanel("场地大气参数提取", new SiteAtmParasPanel());
            navigatePanelHead.AddPanel("光谱匹配校正因子计算", new SBAFCorrectionPanel());
            navigatePanelHead.AddPanel("交叉定标", new CrossCalibrationPanel());
            navigatePanelHead.AddPanel("可见近红外全过程交叉定标", new BatchCrossCalibrationPanel());
            navigatePanelHead.AddPanel("热红外全过程交叉定标", new TIRCrossCalibrationPanel());
            navigatePanelHead.AddPanel("图像噪声不确定性分析", new ImageUncertaintyPanel());
            navigatePanelHead.AddPanel("观测几何不确定性分析", new BRDFUncertaintyPanel());
            navigatePanelHead.AddPanel("光谱匹配不确定性分析", new SBAFUncertaintyPanel());
            navigatePanelHead.AddPanel("总的不确定性分析", new TotalUncertaintyPanel());
            navigatePanelHead.AddPanel("退出", null);
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
            else
            {
                this.Close();
            }
        }

        private void navigatePanelHead_Load(object sender, EventArgs e)
        {

        }
    }
}
