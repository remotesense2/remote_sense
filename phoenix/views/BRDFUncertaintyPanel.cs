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
    public partial class BRDFUncertaintyPanel : UserControl
    {
        private PrivilegeManager privilegeManager = null;
        public BRDFUncertaintyPanel(PrivilegeManager privilege)
        {
            privilegeManager = privilege;
            InitializeComponent();
        }

        private void btnOpenTargetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTargetFile.Text = dialog.FileName;
            }
        }

        private void btnOpenReferFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxReferFile.Text = dialog.FileName;
            }
        }

        private void btnOpenBRDFOrigin_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxBRDFOrigin.Text = dialog.FileName;
            }
        }

        private void btnBRDFNew_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxBRDFNew.Text = dialog.FileName;
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
            byte[] data = System.Text.Encoding.Default.GetBytes(textBoxTargetFile.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxReferFile.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxBRDFOrigin.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxBRDFNew.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBox1.Text + "\r\n");
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
                        StreamReader sr = new StreamReader(textBox1.Text, Encoding.Default);
                        String line;
                        textBoxResult.AppendText("        波段1          波段2           波段3           波段4\r\n");
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("旧模型BRDF校正系数    ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("新模型BRDF校正系数    ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("观测几何校正不确定度    ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        textBoxResult.Select(0, 1);
                        textBoxResult.ScrollToCaret();
                        privilegeManager.AppendLog(this.Text, textBox1.Text);
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
            string idlsavinputpath = strPath + @"\BRDFUncertainty_input.txt";
            string idlsavpath = strPath + @"\BRDFUncertainty.sav";
            GenerateIdlPath(idlsavpath, idlsavinputpath, @"BRDFUncertainty", @"BRDFUncertainty_input");
            System.Diagnostics.Process.Start(idlsavpath, idlsavinputpath);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
        }

    }
}
