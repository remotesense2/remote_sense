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
            NavigateTabGroup tabFirst = navigatePanelHead.AddGroup();
            tabFirst.AddPanel("交叉定标数据预处理", new PreprocessPanel(), true);
            tabFirst.AddPanel("定标场地BRDF模型", new BRDFModelPanel());
            tabFirst.AddPanel("观测几何校正因子计算", new BRDFPanel());
            tabFirst.AddPanel("场地光谱信息提取", new SiteReflectancePanel());
            tabFirst.AddPanel("场地大气参数提取", new SiteAtmParasPanel());
            tabFirst.AddPanel("光谱匹配校正因子计算", new SBAFCorrectionPanel());
            tabFirst.AddPanel("交叉定标", new CrossCalibrationPanel());
            NavigateTabGroup tabSecond = navigatePanelHead.AddGroup();
            tabSecond.AddPanel("可见近红外全过程交叉定标", new BatchCrossCalibrationPanel());
            tabSecond.AddPanel("热红外全过程交叉定标", new TIRCrossCalibrationPanel());
            tabSecond.AddPanel("图像噪声不确定性分析", new ImageUncertaintyPanel());
            tabSecond.AddPanel("观测几何不确定性分析", new BRDFUncertaintyPanel());
            tabSecond.AddPanel("光谱匹配不确定性分析", new SBAFUncertaintyPanel());
            tabSecond.AddPanel("总的不确定性分析", new TotalUncertaintyPanel());
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
