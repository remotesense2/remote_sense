namespace phoenix
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

        private static System.Timers.Timer RUtimer;
        private string IDLProgress;


        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAtmModel = new System.Windows.Forms.ComboBox();
            this.comboBoxAeroModel = new System.Windows.Forms.ComboBox();
            this.comboBoxSiteName = new System.Windows.Forms.ComboBox();
            this.textBoxReferAngle = new System.Windows.Forms.TextBox();
            this.btnOpenReferAngle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label11 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPendingAngle = new System.Windows.Forms.TextBox();
            this.btnOpenPendingAngle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label10 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxSpectra = new System.Windows.Forms.TextBox();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpenSpectra = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label9 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxVapor = new System.Windows.Forms.TextBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxThickness = new System.Windows.Forms.TextBox();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.btnSaveOutput = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCompute = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 220);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入参数";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxAtmModel
            // 
            this.comboBoxAtmModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAtmModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxAtmModel.FormattingEnabled = true;
            this.comboBoxAtmModel.Items.AddRange(new object[] {
            "热带大气",
            "中纬度夏季",
            "中纬度冬季",
            "极地夏季",
            "极地冬季",
            "美国1962标准大气"});
            this.comboBoxAtmModel.Location = new System.Drawing.Point(129, 82);
            this.comboBoxAtmModel.Name = "comboBoxAtmModel";
            this.comboBoxAtmModel.Size = new System.Drawing.Size(355, 26);
            this.comboBoxAtmModel.TabIndex = 24;
            // 
            // comboBoxAeroModel
            // 
            this.comboBoxAeroModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAeroModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAeroModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxAeroModel.FormattingEnabled = true;
            this.comboBoxAeroModel.Items.AddRange(new object[] {
            "乡村型气溶胶",
            "沙漠型气溶胶",
            "城市型气溶胶",
            "海洋型气溶胶"});
            this.comboBoxAeroModel.Location = new System.Drawing.Point(583, 86);
            this.comboBoxAeroModel.Name = "comboBoxAeroModel";
            this.comboBoxAeroModel.Size = new System.Drawing.Size(379, 26);
            this.comboBoxAeroModel.TabIndex = 23;
            // 
            // comboBoxSiteName
            // 
            this.comboBoxSiteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSiteName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
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
            this.comboBoxSiteName.Location = new System.Drawing.Point(129, 22);
            this.comboBoxSiteName.Name = "comboBoxSiteName";
            this.comboBoxSiteName.Size = new System.Drawing.Size(833, 26);
            this.comboBoxSiteName.TabIndex = 22;
            // 
            // textBoxReferAngle
            // 
            this.textBoxReferAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReferAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxReferAngle.Location = new System.Drawing.Point(129, 188);
            this.textBoxReferAngle.Name = "textBoxReferAngle";
            this.textBoxReferAngle.ReadOnly = true;
            this.textBoxReferAngle.Size = new System.Drawing.Size(770, 24);
            this.textBoxReferAngle.TabIndex = 21;
            // 
            // btnOpenReferAngle
            // 
            this.btnOpenReferAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenReferAngle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenReferAngle.Depth = 0;
            this.btnOpenReferAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnOpenReferAngle.Icon = null;
            this.btnOpenReferAngle.Location = new System.Drawing.Point(909, 186);
            this.btnOpenReferAngle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenReferAngle.Name = "btnOpenReferAngle";
            this.btnOpenReferAngle.Primary = true;
            this.btnOpenReferAngle.Size = new System.Drawing.Size(53, 25);
            this.btnOpenReferAngle.TabIndex = 19;
            this.btnOpenReferAngle.Text = "打开";
            this.btnOpenReferAngle.UseVisualStyleBackColor = true;
            this.btnOpenReferAngle.Click += new System.EventHandler(this.btnOpenReferAngle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Depth = 0;
            this.label11.Font = new System.Drawing.Font("Roboto", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(21, 188);
            this.label11.MouseState = MaterialSkin.MouseState.HOVER;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "参考图像信息";
            // 
            // textBoxPendingAngle
            // 
            this.textBoxPendingAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPendingAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxPendingAngle.Location = new System.Drawing.Point(129, 153);
            this.textBoxPendingAngle.Name = "textBoxPendingAngle";
            this.textBoxPendingAngle.ReadOnly = true;
            this.textBoxPendingAngle.Size = new System.Drawing.Size(770, 24);
            this.textBoxPendingAngle.TabIndex = 18;
            // 
            // btnOpenPendingAngle
            // 
            this.btnOpenPendingAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPendingAngle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenPendingAngle.Depth = 0;
            this.btnOpenPendingAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnOpenPendingAngle.Icon = null;
            this.btnOpenPendingAngle.Location = new System.Drawing.Point(909, 151);
            this.btnOpenPendingAngle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenPendingAngle.Name = "btnOpenPendingAngle";
            this.btnOpenPendingAngle.Primary = true;
            this.btnOpenPendingAngle.Size = new System.Drawing.Size(53, 25);
            this.btnOpenPendingAngle.TabIndex = 16;
            this.btnOpenPendingAngle.Text = "打开";
            this.btnOpenPendingAngle.UseVisualStyleBackColor = true;
            this.btnOpenPendingAngle.Click += new System.EventHandler(this.btnOpenPendingAngle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Depth = 0;
            this.label10.Font = new System.Drawing.Font("Roboto", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(5, 152);
            this.label10.MouseState = MaterialSkin.MouseState.HOVER;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "待定标图像信息";
            // 
            // textBoxSpectra
            // 
            this.textBoxSpectra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSpectra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSpectra.Location = new System.Drawing.Point(129, 119);
            this.textBoxSpectra.Name = "textBoxSpectra";
            this.textBoxSpectra.ReadOnly = true;
            this.textBoxSpectra.Size = new System.Drawing.Size(770, 24);
            this.textBoxSpectra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(490, 87);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "气溶胶类型";
            // 
            // btnOpenSpectra
            // 
            this.btnOpenSpectra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSpectra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenSpectra.Depth = 0;
            this.btnOpenSpectra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnOpenSpectra.Icon = null;
            this.btnOpenSpectra.Location = new System.Drawing.Point(909, 116);
            this.btnOpenSpectra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenSpectra.Name = "btnOpenSpectra";
            this.btnOpenSpectra.Primary = true;
            this.btnOpenSpectra.Size = new System.Drawing.Size(53, 25);
            this.btnOpenSpectra.TabIndex = 0;
            this.btnOpenSpectra.Text = "打开";
            this.btnOpenSpectra.UseVisualStyleBackColor = true;
            this.btnOpenSpectra.Click += new System.EventHandler(this.btnOpenSpectra_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Depth = 0;
            this.label9.Font = new System.Drawing.Font("Roboto", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(53, 86);
            this.label9.MouseState = MaterialSkin.MouseState.HOVER;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "大气类型";
            // 
            // textBoxVapor
            // 
            this.textBoxVapor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxVapor.Location = new System.Drawing.Point(583, 55);
            this.textBoxVapor.Name = "textBoxVapor";
            this.textBoxVapor.Size = new System.Drawing.Size(379, 24);
            this.textBoxVapor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(505, 59);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "水汽含量";
            // 
            // textBoxThickness
            // 
            this.textBoxThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxThickness.Location = new System.Drawing.Point(129, 55);
            this.textBoxThickness.Name = "textBoxThickness";
            this.textBoxThickness.Size = new System.Drawing.Size(355, 24);
            this.textBoxThickness.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(53, 119);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "场地光谱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(69, 55);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "能见度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(53, 25);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "选择场地";
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.Location = new System.Drawing.Point(19, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 215);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.White;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxResult.Location = new System.Drawing.Point(129, 56);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(833, 153);
            this.textBoxResult.TabIndex = 7;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxOutput.Location = new System.Drawing.Point(129, 23);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(770, 24);
            this.textBoxOutput.TabIndex = 6;
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveOutput.Depth = 0;
            this.btnSaveOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSaveOutput.Icon = null;
            this.btnSaveOutput.Location = new System.Drawing.Point(909, 20);
            this.btnSaveOutput.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Primary = true;
            this.btnSaveOutput.Size = new System.Drawing.Size(53, 25);
            this.btnSaveOutput.TabIndex = 0;
            this.btnSaveOutput.Text = "保存";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(53, 56);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "计算结果";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(53, 27);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "输出结果";
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompute.Depth = 0;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCompute.Icon = null;
            this.btnCompute.Location = new System.Drawing.Point(925, 460);
            this.btnCompute.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Primary = true;
            this.btnCompute.Size = new System.Drawing.Size(74, 30);
            this.btnCompute.TabIndex = 19;
            this.btnCompute.Text = "计算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
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
            this.Size = new System.Drawing.Size(1020, 499);
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
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenSpectra;
        private MaterialSkin.Controls.MaterialLabel label9;
        private System.Windows.Forms.TextBox textBoxVapor;
        private MaterialSkin.Controls.MaterialLabel label1;
        private System.Windows.Forms.TextBox textBoxThickness;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOutput;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveOutput;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialLabel label8;
        private System.Windows.Forms.TextBox textBoxReferAngle;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenReferAngle;
        private MaterialSkin.Controls.MaterialLabel label11;
        private System.Windows.Forms.TextBox textBoxPendingAngle;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenPendingAngle;
        private MaterialSkin.Controls.MaterialLabel label10;
        private System.Windows.Forms.TextBox textBoxResult;
        private MaterialSkin.Controls.MaterialRaisedButton btnCompute;
        private System.Windows.Forms.ComboBox comboBoxSiteName;
        private System.Windows.Forms.ComboBox comboBoxAtmModel;
        private System.Windows.Forms.ComboBox comboBoxAeroModel;
    }
}
