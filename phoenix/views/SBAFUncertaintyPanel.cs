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
    public partial class SBAFUncertaintyPanel : UserControl
    {
        private PrivilegeManager privilegeManager = null;
        public SBAFUncertaintyPanel(PrivilegeManager privilege)
        {
            privilegeManager = privilege;
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
            data = System.Text.Encoding.Default.GetBytes(textBoxNewThickness.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxNewVapor.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            index = comboBoxNewAtmModel.SelectedIndex + 1;
            data = System.Text.Encoding.Default.GetBytes(index.ToString() + "\r\n");
            fs.Write(data, 0, data.Length);
            index = comboBoxNewAeroModel.SelectedIndex + 1;
            data = System.Text.Encoding.Default.GetBytes(index.ToString() + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxNewSpectra.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxTargetImage.Text + "\r\n");
            fs.Write(data, 0, data.Length);
            data = System.Text.Encoding.Default.GetBytes(textBoxReferImage.Text + "\r\n");
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
                        StreamReader sr = new StreamReader(textBoxOutput.Text, Encoding.Default);
                        String line;
                        textBoxResult.AppendText("        波段1          波段2           波段3           波段4\r\n");
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("原始光谱匹配校正系数  ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("新的光谱匹配校正系数  ");
                            textBoxResult.AppendText(line.ToString());
                            textBoxResult.AppendText("\r\n");
                        }
                        if ((line = sr.ReadLine()) != null)
                        {
                            textBoxResult.AppendText("光谱匹配不确定度%  ");
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
            string idlsavinputpath = strPath + @"\SBAFUncertainty_input.txt";
            string idlsavpath = strPath + @"\SBAFUncertainty.sav";
            GenerateIdlPath(idlsavpath, idlsavinputpath, @"SBAFUncertainty", @"SBAFUncertainty_input");
            System.Diagnostics.Process.Start(idlsavpath, idlsavinputpath);
        }

        private void btnOpenSpectra_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxNewSpectra.Text = dialog.FileName;
            }
        }

        private void btnOpenTargetImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTargetImage.Text = dialog.FileName;
            }
        }

        private void btnOpenReferImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxReferImage.Text = dialog.FileName;
            }
        }

        private void btnSaveOutput_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxOutput.Text = dialog.FileName;
            }
        }

        private void btnOpenNewSpectra_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxNewSpectra.Text = dialog.FileName;
            }
        }

    }
}
