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
            navigatePanelHead.AddPanel("PreProccess", new PreprocessPanel());
            navigatePanelHead.AddPanel("BRDFCorrection", new BRDFPanel());
            navigatePanelHead.AddPanel("SBAFCorrection", new SBAFCorrectionPanel());
            navigatePanelHead.AddPanel("CrossCalibration", new CrossCalibrationPanel());
            navigatePanelHead.AddPanel("SiteReflectance", new SiteReflectancePanel());
            navigatePanelHead.AddPanel("SiteAtmParas", new SiteAtmParasPanel());
            navigatePanelHead.AddPanel("BRDFModel", new BRDFModelPanel());
            navigatePanelHead.AddPanel("BatchCrossCalibration", new BatchCrossCalibrationPanel());
            navigatePanelHead.AddPanel("TIRCrossCalibration", new TIRCrossCalibrationPanel());
            navigatePanelHead.AddPanel("ImageUncertainty", new ImageUncertaintyPanel());
            navigatePanelHead.AddPanel("BRDFUncertainty", new BRDFUncertaintyPanel());
            navigatePanelHead.AddPanel("退出", null);
        }

        private void navigatePanelHead_NavigateEvent(ContainerControl container)
        {
            panelContext.Controls.Clear();
            if (container != null)
            {
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
