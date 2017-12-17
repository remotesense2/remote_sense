using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace phoenix
{
    public partial class PreprocessPanel : UserControl
    {
        private Bitmap bmpViewer;

        public PreprocessPanel()
        {
            InitializeComponent();
        }

        private void btnOpenPending_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.xml)|*.xml";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPending.Text = dialog.FileName;
                string imgPath = Path.ChangeExtension(dialog.FileName, "jpg");
                bmpViewer = new Bitmap(imgPath);
                if (bmpViewer == null)
                {
                    MessageBox.Show("读取文件失败");
                }
                else
                {
                    this.imageViewer.SetBitmap(bmpViewer);
                }
            }
        }

        private void btnOpenRefer_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxRefer.Text = dialog.FileName;
            }
        }

        private void btnSavePending_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.tif)|*.tif";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSavePending.Text = dialog.FileName;
            }
        }

        private void btnSaveRefer_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.tif)|*.tif";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSaveRefer.Text = dialog.FileName;
            }
        }

        private void btnSavePendingForAngle_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSavePendingForAngle.Text = dialog.FileName;
            }
        }

        private void btnSaveReferForAngle_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSaveReferForAngle.Text = dialog.FileName;
            }
        }


        private void GenerateIdlPath(string idlsavpath, string idlsavinputpath, string functionname, string inputname)
        {
            string strPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            strPath = Directory.GetParent(strPath).FullName;
            idlsavpath = strPath + @"\" + functionname + @".sav";
            idlsavinputpath = strPath + @"\" + inputname + @".txt";
            string progresspath = strPath + @"\" + @"progress.txt";
            IDLProgress = progresspath;
            DeleteFile(progresspath);
            FileStream fs = new FileStream(idlsavinputpath, FileMode.Create);
            byte[] data = System.Text.Encoding.Default.GetBytes(textBoxPending.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxRefer.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            int index = comboBoxPosition.SelectedIndex + 1;
            data = System.Text.Encoding.Default.GetBytes(index.ToString() + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxSavePending.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxSaveRefer.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxSavePendingForAngle.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxSaveReferForAngle.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(progresspath + "\r\n");
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
            if (RUtimer != null)
            {
                RUtimer.Stop();
            }

            // 创建一个1000ms定时的定时器
            RUtimer = new System.Timers.Timer(1000);    // 参数单位为ms
            // 定时时间到，处理函数为OnTimedUEvent(...)
            RUtimer.Elapsed += OnTimedUEvent;
            // 为true时，定时时间到会重新计时；为false则只定时一次
            RUtimer.AutoReset = true;
            // 使能定时器
            RUtimer.Enabled = true;
            // 开始计时
            RUtimer.Start();
        }

        public delegate void UpdateTextDelegate(); 

        void OnTimedUEvent(object sender, ElapsedEventArgs e)
        {
            if (File.Exists(IDLProgress))
            {
                RUtimer.Stop();
                //触发界面做出响应
                //btnPlaceImage.Enabled = true;
                //读取角度txt在角度信息进行显示  在此调用显示角度信息

                UpdateTextDelegate updateProcess = delegate()
                {
                    try
                    {
                        this.textBoxAngle.Clear();
                        textBoxAngle.AppendText(File.ReadAllText(textBoxSavePendingForAngle.Text));
                        textBoxAngle.AppendText(Environment.NewLine);
                        textBoxAngle.AppendText(File.ReadAllText(textBoxSaveReferForAngle.Text));
                        textBoxAngle.Select(0, 1);
                        textBoxAngle.ScrollToCaret();
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                    }

                };
                textBoxAngle.Invoke(updateProcess);
            }
        }

        public void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void btnPlaceImage_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process exep = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.FileName = "";
            //startInfo.Arguments = cmdStr;
            //startInfo.CreateNoWindow = true;
            //startInfo.UseShellExecute = false;
            //exep.Start(startInfo);
            //exep.WaitForExit();

            //string strPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            //strPath = Directory.GetParent(strPath).FullName;
            //MessageBox.Show(strPath);

            string strPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            strPath = Directory.GetParent(strPath).FullName;
            string idlsavinputpath = strPath + @"\PreProccess_input.txt";
            string idlsavpath = strPath + @"\preproccess.sav";
            GenerateIdlPath(idlsavpath, idlsavinputpath, @"preproccess", @"PreProccess_input");
            //idlsavpath = @"E:\remote1\remote_sense\phoenix\bin\Debug\PreProccess.sav";
            //idlsavinputpath = @"E:\remote1\remote_sense\phoenix\bin\Debug\PreProccess_input.txt";
            System.Diagnostics.Process.Start(idlsavpath, idlsavinputpath);

        }

        private void PreprocessPanel_Load(object sender, EventArgs e)
        {
            comboBoxPosition.SelectedIndex = 0;
        }

        private void imageViewer_Load(object sender, EventArgs e)
        {
           
        }

        private void imageViewer_DoubleClick(object sender, EventArgs e)
        {
            if (bmpViewer != null)
            {
                ImageViewForm viewer = new ImageViewForm(labelViewer.Text, bmpViewer, this.imageViewer.PercentShow);
                viewer.Show(this);
            } 
        }

        private void textBoxAngle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlaceInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
