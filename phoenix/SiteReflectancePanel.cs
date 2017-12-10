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
    public partial class SiteReflectancePanel : UserControl
    {
        public SiteReflectancePanel()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SiteReflectancePanel_Load(object sender, EventArgs e)
        {
            comboBoxPosition.SelectedIndex = 0;
        }

        private void openbtn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPending.Text = dialog.FileName;
            }
        }

        private void openbtn2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
        }

        private void savebtn1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = dialog.FileName;
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
            int index = comboBoxPosition.SelectedIndex + 1;
            data = System.Text.Encoding.Default.GetBytes(index.ToString() + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBox1.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBox2.Text + "\r\n");
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
                        //显示计算出来的结果，通过调用IDL的画图来显示


                        /*
                        this.textBoxResult.Clear();
                        //textBoxResult.AppendText("                       观测天顶角 / 观测方位角 / 太阳天顶角 / 太阳方位角");
                        StreamReader sr = new StreamReader(textBoxOutput.Text, Encoding.Default);
                        String line;
                        if ((line = sr.ReadLine()) != null)
                        {
                            //textBoxResult.AppendText("\r\n参考传感器      ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            //textBoxResult.AppendText("\r\n待定标传感器     ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            //textBoxResult.AppendText("\r\n四波段BRDF校正系数 ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        //textBoxResult.AppendText(File.ReadAllText(textBoxCorrectParams.Text));
                        textBoxResult.Select(0, 1);
                        textBoxResult.ScrollToCaret();*/
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                    }
                };

                //textBoxResult.Invoke(updateProcess);
            }
        }

        private void btnPlaceImage_Click(object sender, EventArgs e)
        {
            string strPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            strPath = Directory.GetParent(strPath).FullName;
            string idlsavinputpath = strPath + @"\SiteReflectance_input.txt";
            string idlsavpath = strPath + @"\SiteReflectance.sav";
            GenerateIdlPath(idlsavpath, idlsavinputpath, @"SiteReflectance", @"SiteReflectance_input");
            //idlsavpath = @"E:\remote1\remote_sense\phoenix\bin\Debug\PreProccess.sav";
            //idlsavinputpath = @"E:\remote1\remote_sense\phoenix\bin\Debug\PreProccess_input.txt";
            System.Diagnostics.Process.Start(idlsavpath, idlsavinputpath);
        }

    }
}
