﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phoenix
{
    public partial class GeometryPanel : UserControl
    {
        public GeometryPanel()
        {
            InitializeComponent();
        }

        private void btnOpenRefer_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxRefer.Text = dialog.FileName;
            }
        }

        private void GeometryPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenCloud_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxCloud.Text = dialog.FileName;
            }
        }

        private void btnOpenNormalization_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxNormalization.Text = dialog.FileName;
            }
        }

        private void btnPlaceInfo_Click(object sender, EventArgs e)
        {
            BRDFPanel brdfPanel = new BRDFPanel();
            brdfPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            Form popupForm = new Form();
            popupForm.Text = @"定标场地方向归一化模型构建";
            popupForm.Controls.Add(brdfPanel);
            popupForm.Size = new System.Drawing.Size(724, 447);
            popupForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            popupForm.Show(this);
        }
    }
}
