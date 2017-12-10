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
            tabFirst.AddPanel("PreProccess", new PreprocessPanel(), true);
            tabFirst.AddPanel("BRDFCorrection", new BRDFPanel());
            tabFirst.AddPanel("SBAFCorrection", new SBAFCorrectionPanel());
            tabFirst.AddPanel("CrossCalibration", new CrossCalibrationPanel());
            tabFirst.AddPanel("SiteReflectance", new SiteReflectancePanel());
            tabFirst.AddPanel("SiteAtmParas", new SiteAtmParasPanel());
            tabFirst.AddPanel("BRDFModel", new BRDFModelPanel());
            NavigateTabGroup tabSecond = navigatePanelHead.AddGroup();
            tabSecond.AddPanel("BatchCrossCalibration", new BatchCrossCalibrationPanel());
            tabSecond.AddPanel("TIRCrossCalibration", new TIRCrossCalibrationPanel());
            tabSecond.AddPanel("ImageUncertainty", new ImageUncertaintyPanel());
            tabSecond.AddPanel("BRDFUncertainty", new BRDFUncertaintyPanel());
            tabSecond.AddPanel("SBAFUncertainty", new SBAFUncertaintyPanel());
            tabSecond.AddPanel("TotalUncertainty", new TotalUncertaintyPanel());
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
