using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using phoenix.views;

namespace phoenix
{
    public partial class BRDFPanel : UserControl
    {
        private PrivilegeManager privilegeManager = null;
        public BRDFPanel(PrivilegeManager privilege)
        {
            privilegeManager = privilege;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnOpenTarget_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTargetGeometry.Text = dialog.FileName;
            }
        }

        private void btnOpenRefer_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxReferGeometry.Text = dialog.FileName;
            }
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxModel.Text = dialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxCorrectParams.Text = dialog.FileName;
            }
        }

        public void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void GenerateIdlPath(string idlsavpath, string idlsavinputpath, string functionname, string inputname)
        {
            string strPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            strPath = Directory.GetParent(strPath).FullName;
            idlsavpath = strPath + @"\" + functionname + @".sav";
            idlsavinputpath = strPath + @"\" + inputname + @".txt";
            string progresspath = strPath + @"\" + functionname + @"_progress.txt";
            IDLProgress = progresspath;
            DeleteFile(IDLProgress);
            FileStream fs = new FileStream(idlsavinputpath, FileMode.Create);
            byte[] data = System.Text.Encoding.Default.GetBytes(textBoxTargetGeometry.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxReferGeometry.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxModel.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxCorrectParams.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(progresspath + "\r\n");
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
            if (RUtimer != null)
            {
                RUtimer.Stop();
            }
            RUtimer = new System.Timers.Timer(1000);    // 参数单位为ms
            RUtimer.Elapsed += OnTimedUEvent;
            RUtimer.AutoReset = true;
            RUtimer.Enabled = true;
            RUtimer.Start();
        }


        public delegate void UpdateTextDelegate();

        void OnTimedUEvent(object sender, ElapsedEventArgs e)
        {
            if (File.Exists(IDLProgress))
            {
                RUtimer.Stop();
                UpdateTextDelegate updateProcess = delegate()
                {
                    try
                    {
                        this.textBoxResult.Clear();
                        textBoxResult.AppendText("                       观测天顶角 / 观测方位角 / 太阳天顶角 / 太阳方位角");
                        StreamReader sr = new StreamReader(textBoxCorrectParams.Text, Encoding.Default);
                        String line;
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("\r\n参考传感器      ");
                            textBoxResult.AppendText(line.ToString());
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("\r\n待定标传感器     ");
                            textBoxResult.AppendText(line.ToString());
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("\r\n四波段BRDF校正系数 ");
                            textBoxResult.AppendText(line.ToString());
                        }
                        //textBoxResult.AppendText(File.ReadAllText(textBoxCorrectParams.Text));
                        textBoxResult.Select(0, 1);
                        textBoxResult.ScrollToCaret();
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                    }
                };

                textBoxResult.Invoke(updateProcess);
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string strPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            strPath = Directory.GetParent(strPath).FullName;
            string idlsavinputpath = strPath + @"\BRDFCorrection_input.txt";
            string idlsavpath = strPath + @"\BRDFCorrection.sav";
            GenerateIdlPath(idlsavpath, idlsavinputpath, @"BRDFCorrection", @"BRDFCorrection_input");
            //idlsavpath = @"E:\remote1\remote_sense\phoenix\bin\Debug\PreProccess.sav";
            //idlsavinputpath = @"E:\remote1\remote_sense\phoenix\bin\Debug\PreProccess_input.txt";
            System.Diagnostics.Process.Start(idlsavpath, idlsavinputpath);
        }

        private void btnPlaceInfo_Click(object sender, EventArgs e)
        {
            GeometryPanel geometryPanel = new GeometryPanel();
            geometryPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            TemplateForm popupForm = new TemplateForm(@"交叉定标观测几何校正", geometryPanel.Size);
            popupForm.AddContent(geometryPanel);
            popupForm.Size = new System.Drawing.Size(728, 451);
            popupForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            popupForm.Show(this);
        }
    }
}
