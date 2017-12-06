using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phoenix
{
    public partial class SBAFCorrectionPanel : UserControl
    {
        public SBAFCorrectionPanel()
        {
            InitializeComponent();
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.tif)|*.tif";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxOutput.Text = dialog.FileName;
            }
        }

        private void btnOpenSpectra_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSpectra.Text = dialog.FileName;
            }
        }

        private void btnOpenPendingAngle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPendingAngle.Text = dialog.FileName;
            }
        }

        private void btnOpenReferAngle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxReferAngle.Text = dialog.FileName;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SBAFCorrectionPanel_Load(object sender, EventArgs e)
        {
            this.comboBoxSiteName.SelectedIndex = 0;
            this.comboBoxAtmModel.SelectedIndex = 0;
            this.comboBoxAeroModel.SelectedIndex = 0;
        }
    }
}
