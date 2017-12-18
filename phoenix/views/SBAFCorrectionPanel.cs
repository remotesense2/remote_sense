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

namespace phoenix
{
    public partial class SBAFCorrectionPanel : UserControl
    {
        private PrivilegeManager privilegeManager = null;
        public SBAFCorrectionPanel(PrivilegeManager privilege)
        {
            privilegeManager = privilege;
            InitializeComponent();
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

        private void btnOpenPendingAngle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPendingAngle.Text = dialog.FileName;
            }
        }

        private void btnOpenReferAngle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
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
            int index = comboBoxSiteName.SelectedIndex + 1;
            byte[] data = System.Text.Encoding.Default.GetBytes(index.ToString() + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxThickness.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxVapor.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            index = comboBoxAtmModel.SelectedIndex + 1;
            data = System.Text.Encoding.Default.GetBytes(index.ToString() + "\r\n");
            fs.Write(data, 0, data.Length);
            index = comboBoxAeroModel.SelectedIndex + 1;
            data = System.Text.Encoding.Default.GetBytes(index.ToString() + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxSpectra.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxPendingAngle.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxReferAngle.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxOutput.Text + "\r\n");
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
                        textBoxResult.AppendText("    波段1    波段2    波段3    波段4\r\n");
                        StreamReader sr = new StreamReader(textBoxOutput.Text, Encoding.Default);
                        String line;
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("待定标卫星模拟反射率    ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("参考卫星模拟反射率   ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("光谱匹配校正系数    ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        //textBoxResult.AppendText(File.ReadAllText(textBoxCorrectParams.Text));
                        textBoxResult.Select(0, 1);
                        textBoxResult.ScrollToCaret();
                        privilegeManager.AppendLog(this.Text, textBoxOutput.Text);
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
            string idlsavinputpath = strPath + @"\SBAFCorrection_input.txt";
            string idlsavpath = strPath + @"\SBAFCorrection.sav";
            GenerateIdlPath(idlsavpath, idlsavinputpath, @"SBAFCorrection", @"SBAFCorrection_input");
            //idlsavpath = @"E:\remote1\remote_sense\phoenix\bin\Debug\PreProccess.sav";
            //idlsavinputpath = @"E:\remote1\remote_sense\phoenix\bin\Debug\PreProccess_input.txt";
            System.Diagnostics.Process.Start(idlsavpath, idlsavinputpath);
        }



    }
}
