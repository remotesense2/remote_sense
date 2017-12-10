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
    public partial class SBAFUncertaintyPanel : UserControl
    {
        public SBAFUncertaintyPanel()
        {
            InitializeComponent();
        }

        private void btnOpenSpectra_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSpectra.Text = dialog.FileName;
            }
        }

        private void btnOpenNewSpectra_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxNewSpectra.Text = dialog.FileName;
            }
        }

        private void btnOpenTargetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTargetImage.Text = dialog.FileName;
            }
        }

        private void btnOpenReferImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxReferImage.Text = dialog.FileName;
            }
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxOutput.Text = dialog.FileName;
            }
        }

        private void SBAFUncertaintyPanel_Load(object sender, EventArgs e)
        {
            comboBoxSiteName.SelectedIndex = 0;
            comboBoxAtmModel.SelectedIndex = 0;
            comboBoxAeroModel.SelectedIndex = 0;
            comboBoxNewAtmModel.SelectedIndex = 0;
            comboBoxNewAeroModel.SelectedIndex = 0;
        }
    }
}
