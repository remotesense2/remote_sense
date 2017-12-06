﻿namespace phoenix
{
    partial class SBAFCorrectionPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxThickness = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenSpectra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVapor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSpectra = new System.Windows.Forms.TextBox();
            this.textBoxPendingAngle = new System.Windows.Forms.TextBox();
            this.btnOpenPendingAngle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxReferAngle = new System.Windows.Forms.TextBox();
            this.btnOpenReferAngle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.comboBoxSiteName = new System.Windows.Forms.ComboBox();
            this.comboBoxAeroModel = new System.Windows.Forms.ComboBox();
            this.comboBoxAtmModel = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxAtmModel);
            this.groupBox1.Controls.Add(this.comboBoxAeroModel);
            this.groupBox1.Controls.Add(this.comboBoxSiteName);
            this.groupBox1.Controls.Add(this.textBoxReferAngle);
            this.groupBox1.Controls.Add(this.btnOpenReferAngle);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxPendingAngle);
            this.groupBox1.Controls.Add(this.btnOpenPendingAngle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxSpectra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnOpenSpectra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxVapor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxThickness);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 236);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入参数";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxThickness
            // 
            this.textBoxThickness.Location = new System.Drawing.Point(80, 64);
            this.textBoxThickness.Name = "textBoxThickness";
            this.textBoxThickness.Size = new System.Drawing.Size(239, 23);
            this.textBoxThickness.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "场地光谱";
            // 
            // btnOpenSpectra
            // 
            this.btnOpenSpectra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSpectra.Location = new System.Drawing.Point(587, 125);
            this.btnOpenSpectra.Name = "btnOpenSpectra";
            this.btnOpenSpectra.Size = new System.Drawing.Size(53, 29);
            this.btnOpenSpectra.TabIndex = 0;
            this.btnOpenSpectra.Text = "打开";
            this.btnOpenSpectra.UseVisualStyleBackColor = true;
            this.btnOpenSpectra.Click += new System.EventHandler(this.btnOpenSpectra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "光学厚度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "选择场地";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxResult);
            this.groupBox2.Controls.Add(this.textBoxOutput);
            this.groupBox2.Controls.Add(this.btnSaveOutput);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(19, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 185);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(83, 28);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(482, 23);
            this.textBoxOutput.TabIndex = 6;
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveOutput.Location = new System.Drawing.Point(587, 22);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(53, 29);
            this.btnSaveOutput.TabIndex = 0;
            this.btnSaveOutput.Text = "保存";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "计算结果";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "输出结果";
            // 
            // textBoxVapor
            // 
            this.textBoxVapor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVapor.Location = new System.Drawing.Point(403, 64);
            this.textBoxVapor.Name = "textBoxVapor";
            this.textBoxVapor.Size = new System.Drawing.Size(237, 23);
            this.textBoxVapor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "水汽含量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "气溶胶类型";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "大气类型";
            // 
            // textBoxSpectra
            // 
            this.textBoxSpectra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSpectra.Location = new System.Drawing.Point(80, 128);
            this.textBoxSpectra.Name = "textBoxSpectra";
            this.textBoxSpectra.Size = new System.Drawing.Size(485, 23);
            this.textBoxSpectra.TabIndex = 15;
            // 
            // textBoxPendingAngle
            // 
            this.textBoxPendingAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPendingAngle.Location = new System.Drawing.Point(80, 165);
            this.textBoxPendingAngle.Name = "textBoxPendingAngle";
            this.textBoxPendingAngle.Size = new System.Drawing.Size(485, 23);
            this.textBoxPendingAngle.TabIndex = 18;
            // 
            // btnOpenPendingAngle
            // 
            this.btnOpenPendingAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPendingAngle.Location = new System.Drawing.Point(587, 163);
            this.btnOpenPendingAngle.Name = "btnOpenPendingAngle";
            this.btnOpenPendingAngle.Size = new System.Drawing.Size(53, 29);
            this.btnOpenPendingAngle.TabIndex = 16;
            this.btnOpenPendingAngle.Text = "打开";
            this.btnOpenPendingAngle.UseVisualStyleBackColor = true;
            this.btnOpenPendingAngle.Click += new System.EventHandler(this.btnOpenPendingAngle_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(9, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 36);
            this.label10.TabIndex = 17;
            this.label10.Text = "待定标卫星角度信息";
            // 
            // textBoxReferAngle
            // 
            this.textBoxReferAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReferAngle.Location = new System.Drawing.Point(80, 202);
            this.textBoxReferAngle.Name = "textBoxReferAngle";
            this.textBoxReferAngle.Size = new System.Drawing.Size(485, 23);
            this.textBoxReferAngle.TabIndex = 21;
            // 
            // btnOpenReferAngle
            // 
            this.btnOpenReferAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenReferAngle.Location = new System.Drawing.Point(587, 200);
            this.btnOpenReferAngle.Name = "btnOpenReferAngle";
            this.btnOpenReferAngle.Size = new System.Drawing.Size(53, 29);
            this.btnOpenReferAngle.TabIndex = 19;
            this.btnOpenReferAngle.Text = "打开";
            this.btnOpenReferAngle.UseVisualStyleBackColor = true;
            this.btnOpenReferAngle.Click += new System.EventHandler(this.btnOpenReferAngle_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(9, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 36);
            this.label11.TabIndex = 20;
            this.label11.Text = "参考卫星角度信息";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.White;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Location = new System.Drawing.Point(83, 62);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(557, 102);
            this.textBoxResult.TabIndex = 7;
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompute.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompute.Location = new System.Drawing.Point(585, 446);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(91, 42);
            this.btnCompute.TabIndex = 19;
            this.btnCompute.Text = "计算";
            this.btnCompute.UseVisualStyleBackColor = true;
            // 
            // comboBoxSiteName
            // 
            this.comboBoxSiteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSiteName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSiteName.FormattingEnabled = true;
            this.comboBoxSiteName.Items.AddRange(new object[] {
            "敦煌",
            "酒泉",
            "格尔木",
            "二连浩特",
            "民勤",
            "民丰",
            "若羌",
            "和田",
            "其他"});
            this.comboBoxSiteName.Location = new System.Drawing.Point(80, 26);
            this.comboBoxSiteName.Name = "comboBoxSiteName";
            this.comboBoxSiteName.Size = new System.Drawing.Size(560, 25);
            this.comboBoxSiteName.TabIndex = 22;
            // 
            // comboBoxAeroModel
            // 
            this.comboBoxAeroModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAeroModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAeroModel.FormattingEnabled = true;
            this.comboBoxAeroModel.Items.AddRange(new object[] {
            "乡村型气溶胶",
            "沙漠型气溶胶",
            "城市型气溶胶",
            "海洋型气溶胶"});
            this.comboBoxAeroModel.Location = new System.Drawing.Point(403, 94);
            this.comboBoxAeroModel.Name = "comboBoxAeroModel";
            this.comboBoxAeroModel.Size = new System.Drawing.Size(237, 25);
            this.comboBoxAeroModel.TabIndex = 23;
            // 
            // comboBoxAtmModel
            // 
            this.comboBoxAtmModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAtmModel.FormattingEnabled = true;
            this.comboBoxAtmModel.Items.AddRange(new object[] {
            "热带大气",
            "中纬度夏季",
            "中纬度冬季",
            "极地夏季",
            "极地冬季",
            "美国1962标准大气"});
            this.comboBoxAtmModel.Location = new System.Drawing.Point(80, 94);
            this.comboBoxAtmModel.Name = "comboBoxAtmModel";
            this.comboBoxAtmModel.Size = new System.Drawing.Size(239, 25);
            this.comboBoxAtmModel.TabIndex = 24;
            // 
            // SBAFCorrectionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SBAFCorrectionPanel";
            this.Size = new System.Drawing.Size(698, 494);
            this.Load += new System.EventHandler(this.SBAFCorrectionPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSpectra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenSpectra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxVapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxThickness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxReferAngle;
        private System.Windows.Forms.Button btnOpenReferAngle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPendingAngle;
        private System.Windows.Forms.Button btnOpenPendingAngle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ComboBox comboBoxSiteName;
        private System.Windows.Forms.ComboBox comboBoxAtmModel;
        private System.Windows.Forms.ComboBox comboBoxAeroModel;
    }
}