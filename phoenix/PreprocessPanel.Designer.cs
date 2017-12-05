namespace phoenix
{
    partial class PreprocessPanel
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

        private static System.Timers.Timer RUtimer;
        private string IDLProgress;

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveReferForAngle = new System.Windows.Forms.Button();
            this.btnOpenPending = new System.Windows.Forms.Button();
            this.textBoxSaveRefer = new System.Windows.Forms.TextBox();
            this.textBoxSavePendingForAngle = new System.Windows.Forms.TextBox();
            this.btnSaveRefer = new System.Windows.Forms.Button();
            this.textBoxSaveReferForAngle = new System.Windows.Forms.TextBox();
            this.textBoxSavePending = new System.Windows.Forms.TextBox();
            this.btnSavePending = new System.Windows.Forms.Button();
            this.btnSavePendingForAngle = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnPlaceInfo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPlaceImage = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.btnOpenRefer = new System.Windows.Forms.Button();
            this.textBoxRefer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPending = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelViewer = new System.Windows.Forms.Panel();
            this.imageViewer = new phoenix.ImageViewer();
            this.labelViewer = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveReferForAngle
            // 
            this.btnSaveReferForAngle.Location = new System.Drawing.Point(429, 60);
            this.btnSaveReferForAngle.Name = "btnSaveReferForAngle";
            this.btnSaveReferForAngle.Size = new System.Drawing.Size(53, 23);
            this.btnSaveReferForAngle.TabIndex = 7;
            this.btnSaveReferForAngle.Text = "保存";
            this.btnSaveReferForAngle.UseVisualStyleBackColor = true;
            this.btnSaveReferForAngle.Click += new System.EventHandler(this.btnSaveReferForAngle_Click);
            // 
            // btnOpenPending
            // 
            this.btnOpenPending.Location = new System.Drawing.Point(429, 29);
            this.btnOpenPending.Name = "btnOpenPending";
            this.btnOpenPending.Size = new System.Drawing.Size(53, 23);
            this.btnOpenPending.TabIndex = 0;
            this.btnOpenPending.Text = "打开";
            this.btnOpenPending.UseVisualStyleBackColor = true;
            this.btnOpenPending.Click += new System.EventHandler(this.btnOpenPending_Click);
            // 
            // textBoxSaveRefer
            // 
            this.textBoxSaveRefer.Location = new System.Drawing.Point(104, 62);
            this.textBoxSaveRefer.Name = "textBoxSaveRefer";
            this.textBoxSaveRefer.ReadOnly = true;
            this.textBoxSaveRefer.Size = new System.Drawing.Size(309, 23);
            this.textBoxSaveRefer.TabIndex = 8;
            // 
            // textBoxSavePendingForAngle
            // 
            this.textBoxSavePendingForAngle.Location = new System.Drawing.Point(105, 25);
            this.textBoxSavePendingForAngle.Name = "textBoxSavePendingForAngle";
            this.textBoxSavePendingForAngle.ReadOnly = true;
            this.textBoxSavePendingForAngle.Size = new System.Drawing.Size(308, 23);
            this.textBoxSavePendingForAngle.TabIndex = 6;
            // 
            // btnSaveRefer
            // 
            this.btnSaveRefer.Location = new System.Drawing.Point(429, 60);
            this.btnSaveRefer.Name = "btnSaveRefer";
            this.btnSaveRefer.Size = new System.Drawing.Size(53, 23);
            this.btnSaveRefer.TabIndex = 7;
            this.btnSaveRefer.Text = "保存";
            this.btnSaveRefer.UseVisualStyleBackColor = true;
            this.btnSaveRefer.Click += new System.EventHandler(this.btnSaveRefer_Click);
            // 
            // textBoxSaveReferForAngle
            // 
            this.textBoxSaveReferForAngle.Location = new System.Drawing.Point(105, 60);
            this.textBoxSaveReferForAngle.Name = "textBoxSaveReferForAngle";
            this.textBoxSaveReferForAngle.ReadOnly = true;
            this.textBoxSaveReferForAngle.Size = new System.Drawing.Size(308, 23);
            this.textBoxSaveReferForAngle.TabIndex = 8;
            // 
            // textBoxSavePending
            // 
            this.textBoxSavePending.Location = new System.Drawing.Point(104, 28);
            this.textBoxSavePending.Name = "textBoxSavePending";
            this.textBoxSavePending.ReadOnly = true;
            this.textBoxSavePending.Size = new System.Drawing.Size(309, 23);
            this.textBoxSavePending.TabIndex = 6;
            // 
            // btnSavePending
            // 
            this.btnSavePending.Location = new System.Drawing.Point(429, 28);
            this.btnSavePending.Name = "btnSavePending";
            this.btnSavePending.Size = new System.Drawing.Size(53, 23);
            this.btnSavePending.TabIndex = 0;
            this.btnSavePending.Text = "保存";
            this.btnSavePending.UseVisualStyleBackColor = true;
            this.btnSavePending.Click += new System.EventHandler(this.btnSavePending_Click);
            // 
            // btnSavePendingForAngle
            // 
            this.btnSavePendingForAngle.Location = new System.Drawing.Point(429, 25);
            this.btnSavePendingForAngle.Name = "btnSavePendingForAngle";
            this.btnSavePendingForAngle.Size = new System.Drawing.Size(53, 23);
            this.btnSavePendingForAngle.TabIndex = 0;
            this.btnSavePendingForAngle.Text = "保存";
            this.btnSavePendingForAngle.UseVisualStyleBackColor = true;
            this.btnSavePendingForAngle.Click += new System.EventHandler(this.btnSavePendingForAngle_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.textBoxAngle);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(580, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 122);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "角度信息";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.BackColor = System.Drawing.Color.White;
            this.textBoxAngle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAngle.Location = new System.Drawing.Point(3, 19);
            this.textBoxAngle.Multiline = true;
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.ReadOnly = true;
            this.textBoxAngle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAngle.Size = new System.Drawing.Size(320, 100);
            this.textBoxAngle.TabIndex = 1;
            this.textBoxAngle.TextChanged += new System.EventHandler(this.textBoxAngle_TextChanged);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHelp.Location = new System.Drawing.Point(819, 408);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(70, 42);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnPlaceInfo
            // 
            this.btnPlaceInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlaceInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceInfo.Location = new System.Drawing.Point(429, 408);
            this.btnPlaceInfo.Name = "btnPlaceInfo";
            this.btnPlaceInfo.Size = new System.Drawing.Size(92, 42);
            this.btnPlaceInfo.TabIndex = 19;
            this.btnPlaceInfo.Text = "场地信息";
            this.btnPlaceInfo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "参考卫星图像";
            // 
            // btnPlaceImage
            // 
            this.btnPlaceImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlaceImage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceImage.Location = new System.Drawing.Point(70, 408);
            this.btnPlaceImage.Name = "btnPlaceImage";
            this.btnPlaceImage.Size = new System.Drawing.Size(101, 42);
            this.btnPlaceImage.TabIndex = 18;
            this.btnPlaceImage.Text = "场地图像";
            this.btnPlaceImage.UseVisualStyleBackColor = true;
            this.btnPlaceImage.Click += new System.EventHandler(this.btnPlaceImage_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "待定标卫星图像";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSaveReferForAngle);
            this.groupBox3.Controls.Add(this.btnSaveReferForAngle);
            this.groupBox3.Controls.Add(this.textBoxSavePendingForAngle);
            this.groupBox3.Controls.Add(this.btnSavePendingForAngle);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(70, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 95);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "角度信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.label6.Location = new System.Drawing.Point(10, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "输出";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "敦煌",
            "酒泉",
            "格尔木",
            "二连浩特",
            "民勤",
            "民丰",
            "若羌",
            "和田"});
            this.comboBoxPosition.Location = new System.Drawing.Point(105, 98);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(308, 25);
            this.comboBoxPosition.TabIndex = 9;
            this.comboBoxPosition.Text = "敦煌";
            // 
            // btnOpenRefer
            // 
            this.btnOpenRefer.Location = new System.Drawing.Point(429, 64);
            this.btnOpenRefer.Name = "btnOpenRefer";
            this.btnOpenRefer.Size = new System.Drawing.Size(53, 23);
            this.btnOpenRefer.TabIndex = 7;
            this.btnOpenRefer.Text = "打开";
            this.btnOpenRefer.UseVisualStyleBackColor = true;
            this.btnOpenRefer.Click += new System.EventHandler(this.btnOpenRefer_Click);
            // 
            // textBoxRefer
            // 
            this.textBoxRefer.Location = new System.Drawing.Point(104, 64);
            this.textBoxRefer.Name = "textBoxRefer";
            this.textBoxRefer.ReadOnly = true;
            this.textBoxRefer.Size = new System.Drawing.Size(309, 23);
            this.textBoxRefer.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "待定标卫星图像";
            // 
            // textBoxPending
            // 
            this.textBoxPending.Location = new System.Drawing.Point(104, 29);
            this.textBoxPending.Name = "textBoxPending";
            this.textBoxPending.ReadOnly = true;
            this.textBoxPending.Size = new System.Drawing.Size(309, 23);
            this.textBoxPending.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPosition);
            this.groupBox1.Controls.Add(this.textBoxRefer);
            this.groupBox1.Controls.Add(this.btnOpenRefer);
            this.groupBox1.Controls.Add(this.textBoxPending);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnOpenPending);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(70, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 129);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原始影像";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "场地位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "参考卫星图像";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "待定标卫星图像";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "输入";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "参考卫星图像";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSaveRefer);
            this.groupBox2.Controls.Add(this.btnSaveRefer);
            this.groupBox2.Controls.Add(this.textBoxSavePending);
            this.groupBox2.Controls.Add(this.btnSavePending);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(70, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 94);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "场地影像";
            // 
            // panelViewer
            // 
            this.panelViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelViewer.Controls.Add(this.imageViewer);
            this.panelViewer.Location = new System.Drawing.Point(584, 28);
            this.panelViewer.Name = "panelViewer";
            this.panelViewer.Size = new System.Drawing.Size(322, 246);
            this.panelViewer.TabIndex = 23;
            // 
            // imageViewer
            // 
            this.imageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer.Location = new System.Drawing.Point(0, 0);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Size = new System.Drawing.Size(320, 244);
            this.imageViewer.TabIndex = 0;
            this.imageViewer.Load += new System.EventHandler(this.imageViewer_Load);
            this.imageViewer.DoubleClick += new System.EventHandler(this.imageViewer_DoubleClick);
            // 
            // labelViewer
            // 
            this.labelViewer.AutoSize = true;
            this.labelViewer.Location = new System.Drawing.Point(582, 13);
            this.labelViewer.Name = "labelViewer";
            this.labelViewer.Size = new System.Drawing.Size(41, 12);
            this.labelViewer.TabIndex = 24;
            this.labelViewer.Text = "快视图";
            // 
            // PreprocessPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.labelViewer);
            this.Controls.Add(this.panelViewer);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPlaceInfo);
            this.Controls.Add(this.btnPlaceImage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PreprocessPanel";
            this.Size = new System.Drawing.Size(921, 468);
            this.Load += new System.EventHandler(this.PreprocessPanel_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelViewer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveReferForAngle;
        private System.Windows.Forms.Button btnOpenPending;
        private System.Windows.Forms.TextBox textBoxSaveRefer;
        private System.Windows.Forms.TextBox textBoxSavePendingForAngle;
        private System.Windows.Forms.Button btnSaveRefer;
        private System.Windows.Forms.TextBox textBoxSaveReferForAngle;
        private System.Windows.Forms.TextBox textBoxSavePending;
        private System.Windows.Forms.Button btnSavePending;
        private System.Windows.Forms.Button btnSavePendingForAngle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnPlaceInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPlaceImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Button btnOpenRefer;
        private System.Windows.Forms.TextBox textBoxRefer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPending;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelViewer;
        private System.Windows.Forms.Label labelViewer;
        private ImageViewer imageViewer;
    }
}
