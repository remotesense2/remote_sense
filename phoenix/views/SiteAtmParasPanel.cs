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
    public partial class SiteAtmParasPanel : UserControl
    {
        public SiteAtmParasPanel()
        {
            InitializeComponent();
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPending.Text = dialog.FileName;
            }
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = dialog.FileName;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxsave.Text = dialog.FileName;
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
            byte[] data = System.Text.Encoding.Default.GetBytes(textBoxPending.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBox2.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            int index = comboBoxPosition.SelectedIndex + 1;
            data = System.Text.Encoding.Default.GetBytes(index.ToString() + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxsave.Text + "\r\n");
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
                        //具体的显示结果
                        this.textBoxResult.Clear();
                        StreamReader sr = new StreamReader(textBoxsave.Text, Encoding.Default);
                        String line;
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
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
            string idlsavinputpath = strPath + @"\SiteAtmParas_input.txt";
            string idlsavpath = strPath + @"\SiteAtmParas.sav";
            GenerateIdlPath(idlsavpath, idlsavinputpath, @"SiteAtmParas", @"SiteAtmParas_input");
            System.Diagnostics.Process.Start(idlsavpath, idlsavinputpath);
        }

        private void SiteAtmParasPanel_Load(object sender, EventArgs e)
        {
            comboBoxPosition.SelectedIndex = 0;
        }

    }
}
