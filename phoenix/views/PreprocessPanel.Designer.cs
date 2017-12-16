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
            this.btnSaveReferForAngle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOpenPending = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxSaveRefer = new System.Windows.Forms.TextBox();
            this.textBoxSavePendingForAngle = new System.Windows.Forms.TextBox();
            this.btnSaveRefer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxSaveReferForAngle = new System.Windows.Forms.TextBox();
            this.textBoxSavePending = new System.Windows.Forms.TextBox();
            this.btnSavePending = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSavePendingForAngle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.btnHelp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPlaceInfo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label10 = new MaterialSkin.Controls.MaterialLabel();
            this.btnPlaceImage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label11 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.btnOpenRefer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxRefer = new System.Windows.Forms.TextBox();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPending = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelViewer = new System.Windows.Forms.Panel();
            this.imageViewer = new phoenix.ImageViewer();
            this.labelViewer = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveReferForAngle
            // 
            this.btnSaveReferForAngle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveReferForAngle.Depth = 0;
            this.btnSaveReferForAngle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveReferForAngle.Icon = null;
            this.btnSaveReferForAngle.Location = new System.Drawing.Point(429, 60);
            this.btnSaveReferForAngle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveReferForAngle.Name = "btnSaveReferForAngle";
            this.btnSaveReferForAngle.Primary = true;
            this.btnSaveReferForAngle.Size = new System.Drawing.Size(53, 23);
            this.btnSaveReferForAngle.TabIndex = 7;
            this.btnSaveReferForAngle.Text = "保存";
            this.btnSaveReferForAngle.UseVisualStyleBackColor = true;
            this.btnSaveReferForAngle.Click += new System.EventHandler(this.btnSaveReferForAngle_Click);
            // 
            // btnOpenPending
            // 
            this.btnOpenPending.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenPending.Depth = 0;
            this.btnOpenPending.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenPending.Icon = null;
            this.btnOpenPending.Location = new System.Drawing.Point(429, 29);
            this.btnOpenPending.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenPending.Name = "btnOpenPending";
            this.btnOpenPending.Primary = true;
            this.btnOpenPending.Size = new System.Drawing.Size(53, 23);
            this.btnOpenPending.TabIndex = 0;
            this.btnOpenPending.Text = "打开";
            this.btnOpenPending.UseVisualStyleBackColor = true;
            this.btnOpenPending.Click += new System.EventHandler(this.btnOpenPending_Click);
            // 
            // textBoxSaveRefer
            // 
            this.textBoxSaveRefer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSaveRefer.Location = new System.Drawing.Point(135, 62);
            this.textBoxSaveRefer.Name = "textBoxSaveRefer";
            this.textBoxSaveRefer.ReadOnly = true;
            this.textBoxSaveRefer.Size = new System.Drawing.Size(278, 23);
            this.textBoxSaveRefer.TabIndex = 8;
            // 
            // textBoxSavePendingForAngle
            // 
            this.textBoxSavePendingForAngle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSavePendingForAngle.Location = new System.Drawing.Point(135, 25);
            this.textBoxSavePendingForAngle.Name = "textBoxSavePendingForAngle";
            this.textBoxSavePendingForAngle.ReadOnly = true;
            this.textBoxSavePendingForAngle.Size = new System.Drawing.Size(278, 23);
            this.textBoxSavePendingForAngle.TabIndex = 6;
            // 
            // btnSaveRefer
            // 
            this.btnSaveRefer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveRefer.Depth = 0;
            this.btnSaveRefer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveRefer.Icon = null;
            this.btnSaveRefer.Location = new System.Drawing.Point(429, 60);
            this.btnSaveRefer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveRefer.Name = "btnSaveRefer";
            this.btnSaveRefer.Primary = true;
            this.btnSaveRefer.Size = new System.Drawing.Size(53, 23);
            this.btnSaveRefer.TabIndex = 7;
            this.btnSaveRefer.Text = "保存";
            this.btnSaveRefer.UseVisualStyleBackColor = true;
            this.btnSaveRefer.Click += new System.EventHandler(this.btnSaveRefer_Click);
            // 
            // textBoxSaveReferForAngle
            // 
            this.textBoxSaveReferForAngle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSaveReferForAngle.Location = new System.Drawing.Point(135, 60);
            this.textBoxSaveReferForAngle.Name = "textBoxSaveReferForAngle";
            this.textBoxSaveReferForAngle.ReadOnly = true;
            this.textBoxSaveReferForAngle.Size = new System.Drawing.Size(278, 23);
            this.textBoxSaveReferForAngle.TabIndex = 8;
            // 
            // textBoxSavePending
            // 
            this.textBoxSavePending.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSavePending.Location = new System.Drawing.Point(135, 28);
            this.textBoxSavePending.Name = "textBoxSavePending";
            this.textBoxSavePending.ReadOnly = true;
            this.textBoxSavePending.Size = new System.Drawing.Size(278, 23);
            this.textBoxSavePending.TabIndex = 6;
            // 
            // btnSavePending
            // 
            this.btnSavePending.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSavePending.Depth = 0;
            this.btnSavePending.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSavePending.Icon = null;
            this.btnSavePending.Location = new System.Drawing.Point(429, 28);
            this.btnSavePending.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSavePending.Name = "btnSavePending";
            this.btnSavePending.Primary = true;
            this.btnSavePending.Size = new System.Drawing.Size(53, 23);
            this.btnSavePending.TabIndex = 0;
            this.btnSavePending.Text = "保存";
            this.btnSavePending.UseVisualStyleBackColor = true;
            this.btnSavePending.Click += new System.EventHandler(this.btnSavePending_Click);
            // 
            // btnSavePendingForAngle
            // 
            this.btnSavePendingForAngle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSavePendingForAngle.Depth = 0;
            this.btnSavePendingForAngle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSavePendingForAngle.Icon = null;
            this.btnSavePendingForAngle.Location = new System.Drawing.Point(429, 25);
            this.btnSavePendingForAngle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSavePendingForAngle.Name = "btnSavePendingForAngle";
            this.btnSavePendingForAngle.Primary = true;
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
            this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.textBoxAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAngle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelp.Depth = 0;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHelp.Icon = null;
            this.btnHelp.Location = new System.Drawing.Point(819, 408);
            this.btnHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Primary = true;
            this.btnHelp.Size = new System.Drawing.Size(70, 42);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnPlaceInfo
            // 
            this.btnPlaceInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlaceInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlaceInfo.Depth = 0;
            this.btnPlaceInfo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceInfo.Icon = null;
            this.btnPlaceInfo.Location = new System.Drawing.Point(429, 408);
            this.btnPlaceInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlaceInfo.Name = "btnPlaceInfo";
            this.btnPlaceInfo.Primary = true;
            this.btnPlaceInfo.Size = new System.Drawing.Size(92, 42);
            this.btnPlaceInfo.TabIndex = 19;
            this.btnPlaceInfo.Text = "场地信息";
            this.btnPlaceInfo.UseVisualStyleBackColor = true;
            this.btnPlaceInfo.Click += new System.EventHandler(this.btnPlaceInfo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Depth = 0;
            this.label10.Font = new System.Drawing.Font("Roboto", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(9, 60);
            this.label10.MouseState = MaterialSkin.MouseState.HOVER;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "参考卫星图像";
            // 
            // btnPlaceImage
            // 
            this.btnPlaceImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlaceImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlaceImage.Depth = 0;
            this.btnPlaceImage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceImage.Icon = null;
            this.btnPlaceImage.Location = new System.Drawing.Point(70, 408);
            this.btnPlaceImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlaceImage.Name = "btnPlaceImage";
            this.btnPlaceImage.Primary = true;
            this.btnPlaceImage.Size = new System.Drawing.Size(101, 42);
            this.btnPlaceImage.TabIndex = 18;
            this.btnPlaceImage.Text = "场地图像";
            this.btnPlaceImage.UseVisualStyleBackColor = true;
            this.btnPlaceImage.Click += new System.EventHandler(this.btnPlaceImage_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Depth = 0;
            this.label11.Font = new System.Drawing.Font("Roboto", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(9, 28);
            this.label11.MouseState = MaterialSkin.MouseState.HOVER;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 18);
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
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(10, 164);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "输出";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.comboBoxPosition.Location = new System.Drawing.Point(135, 98);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(278, 25);
            this.comboBoxPosition.TabIndex = 9;
            // 
            // btnOpenRefer
            // 
            this.btnOpenRefer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenRefer.Depth = 0;
            this.btnOpenRefer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenRefer.Icon = null;
            this.btnOpenRefer.Location = new System.Drawing.Point(429, 64);
            this.btnOpenRefer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenRefer.Name = "btnOpenRefer";
            this.btnOpenRefer.Primary = true;
            this.btnOpenRefer.Size = new System.Drawing.Size(53, 23);
            this.btnOpenRefer.TabIndex = 7;
            this.btnOpenRefer.Text = "打开";
            this.btnOpenRefer.UseVisualStyleBackColor = true;
            this.btnOpenRefer.Click += new System.EventHandler(this.btnOpenRefer_Click);
            // 
            // textBoxRefer
            // 
            this.textBoxRefer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRefer.Location = new System.Drawing.Point(135, 64);
            this.textBoxRefer.Name = "textBoxRefer";
            this.textBoxRefer.ReadOnly = true;
            this.textBoxRefer.Size = new System.Drawing.Size(278, 23);
            this.textBoxRefer.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(9, 28);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "待定标卫星图像";
            // 
            // textBoxPending
            // 
            this.textBoxPending.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPending.Location = new System.Drawing.Point(135, 29);
            this.textBoxPending.Name = "textBoxPending";
            this.textBoxPending.ReadOnly = true;
            this.textBoxPending.Size = new System.Drawing.Size(278, 23);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "场地位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "参考卫星图像";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "待定标卫星图像";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "输入";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(9, 62);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.panelViewer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelViewer.Location = new System.Drawing.Point(584, 28);
            this.panelViewer.Name = "panelViewer";
            this.panelViewer.Size = new System.Drawing.Size(322, 246);
            this.panelViewer.TabIndex = 23;
            // 
            // imageViewer
            // 
            this.imageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imageViewer.Location = new System.Drawing.Point(0, 0);
            this.imageViewer.Margin = new System.Windows.Forms.Padding(6);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Size = new System.Drawing.Size(320, 244);
            this.imageViewer.TabIndex = 0;
            this.imageViewer.Load += new System.EventHandler(this.imageViewer_Load);
            this.imageViewer.DoubleClick += new System.EventHandler(this.imageViewer_DoubleClick);
            // 
            // labelViewer
            // 
            this.labelViewer.AutoSize = true;
            this.labelViewer.Depth = 0;
            this.labelViewer.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelViewer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelViewer.Location = new System.Drawing.Point(581, 8);
            this.labelViewer.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelViewer.Name = "labelViewer";
            this.labelViewer.Size = new System.Drawing.Size(56, 18);
            this.labelViewer.TabIndex = 24;
            this.labelViewer.Text = "快视图";
            // 
            // PreprocessPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
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

        private MaterialSkin.Controls.MaterialRaisedButton btnSaveReferForAngle;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenPending;
        private System.Windows.Forms.TextBox textBoxSaveRefer;
        private System.Windows.Forms.TextBox textBoxSavePendingForAngle;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveRefer;
        private System.Windows.Forms.TextBox textBoxSaveReferForAngle;
        private System.Windows.Forms.TextBox textBoxSavePending;
        private MaterialSkin.Controls.MaterialRaisedButton btnSavePending;
        private MaterialSkin.Controls.MaterialRaisedButton btnSavePendingForAngle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxAngle;
        private MaterialSkin.Controls.MaterialRaisedButton btnHelp;
        private MaterialSkin.Controls.MaterialRaisedButton btnPlaceInfo;
        private MaterialSkin.Controls.MaterialLabel label10;
        private MaterialSkin.Controls.MaterialRaisedButton btnPlaceImage;
        private MaterialSkin.Controls.MaterialLabel label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel label6;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenRefer;
        private System.Windows.Forms.TextBox textBoxRefer;
        private MaterialSkin.Controls.MaterialLabel label8;
        private System.Windows.Forms.TextBox textBoxPending;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelViewer;
        private MaterialSkin.Controls.MaterialLabel labelViewer;
        private ImageViewer imageViewer;
    }
}
