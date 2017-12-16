namespace phoenix
{
    partial class SBAFUncertaintyPanel
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxTargetImage = new System.Windows.Forms.TextBox();
            this.label10 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxReferImage = new System.Windows.Forms.TextBox();
            this.btnOpenTargetImage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOpenReferImage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label11 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveOutput = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label15 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label17 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAtmModel = new System.Windows.Forms.ComboBox();
            this.comboBoxAeroModel = new System.Windows.Forms.ComboBox();
            this.comboBoxSiteName = new System.Windows.Forms.ComboBox();
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
            this.comboBoxNewAtmModel = new System.Windows.Forms.ComboBox();
            this.comboBoxNewAeroModel = new System.Windows.Forms.ComboBox();
            this.textBoxNewSpectra = new System.Windows.Forms.TextBox();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpenNewSpectra = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxNewVapor = new System.Windows.Forms.TextBox();
            this.label12 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxNewThickness = new System.Windows.Forms.TextBox();
            this.label13 = new MaterialSkin.Controls.MaterialLabel();
            this.label14 = new MaterialSkin.Controls.MaterialLabel();
            this.label16 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCompute = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBoxTargetImage);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxReferImage);
            this.groupBox3.Controls.Add(this.btnOpenTargetImage);
            this.groupBox3.Controls.Add(this.btnOpenReferImage);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(5, 252);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(831, 88);
            this.groupBox3.TabIndex = 143;
            this.groupBox3.TabStop = false;
            // 
            // textBoxTargetImage
            // 
            this.textBoxTargetImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTargetImage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTargetImage.Location = new System.Drawing.Point(80, 19);
            this.textBoxTargetImage.Name = "textBoxTargetImage";
            this.textBoxTargetImage.ReadOnly = true;
            this.textBoxTargetImage.Size = new System.Drawing.Size(658, 23);
            this.textBoxTargetImage.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Depth = 0;
            this.label10.Font = new System.Drawing.Font("Roboto", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(9, 10);
            this.label10.MouseState = MaterialSkin.MouseState.HOVER;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 36);
            this.label10.TabIndex = 23;
            this.label10.Text = "目标卫星图像信息";
            // 
            // textBoxReferImage
            // 
            this.textBoxReferImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReferImage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxReferImage.Location = new System.Drawing.Point(80, 56);
            this.textBoxReferImage.Name = "textBoxReferImage";
            this.textBoxReferImage.ReadOnly = true;
            this.textBoxReferImage.Size = new System.Drawing.Size(658, 23);
            this.textBoxReferImage.TabIndex = 27;
            // 
            // btnOpenTargetImage
            // 
            this.btnOpenTargetImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTargetImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenTargetImage.Depth = 0;
            this.btnOpenTargetImage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenTargetImage.Icon = null;
            this.btnOpenTargetImage.Location = new System.Drawing.Point(758, 19);
            this.btnOpenTargetImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenTargetImage.Name = "btnOpenTargetImage";
            this.btnOpenTargetImage.Primary = true;
            this.btnOpenTargetImage.Size = new System.Drawing.Size(53, 24);
            this.btnOpenTargetImage.TabIndex = 22;
            this.btnOpenTargetImage.Text = "打开";
            this.btnOpenTargetImage.UseVisualStyleBackColor = true;
            // 
            // btnOpenReferImage
            // 
            this.btnOpenReferImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenReferImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenReferImage.Depth = 0;
            this.btnOpenReferImage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenReferImage.Icon = null;
            this.btnOpenReferImage.Location = new System.Drawing.Point(758, 56);
            this.btnOpenReferImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenReferImage.Name = "btnOpenReferImage";
            this.btnOpenReferImage.Primary = true;
            this.btnOpenReferImage.Size = new System.Drawing.Size(53, 24);
            this.btnOpenReferImage.TabIndex = 25;
            this.btnOpenReferImage.Text = "打开";
            this.btnOpenReferImage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Depth = 0;
            this.label11.Font = new System.Drawing.Font("Roboto", 11F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(9, 46);
            this.label11.MouseState = MaterialSkin.MouseState.HOVER;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 36);
            this.label11.TabIndex = 26;
            this.label11.Text = "参考卫星图像信息";
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveOutput.Depth = 0;
            this.btnSaveOutput.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveOutput.Icon = null;
            this.btnSaveOutput.Location = new System.Drawing.Point(764, 350);
            this.btnSaveOutput.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Primary = true;
            this.btnSaveOutput.Size = new System.Drawing.Size(53, 24);
            this.btnSaveOutput.TabIndex = 142;
            this.btnSaveOutput.Text = "保存";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxOutput.Location = new System.Drawing.Point(85, 352);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(659, 23);
            this.textBoxOutput.TabIndex = 141;
            // 
            // label15
            // 
            this.label15.Depth = 0;
            this.label15.Font = new System.Drawing.Font("Roboto", 11F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(4, 380);
            this.label15.MouseState = MaterialSkin.MouseState.HOVER;
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 39);
            this.label15.TabIndex = 140;
            this.label15.Text = "光谱匹配不确定性";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxResult.Location = new System.Drawing.Point(83, 386);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(756, 177);
            this.textBoxResult.TabIndex = 139;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Depth = 0;
            this.label17.Font = new System.Drawing.Font("Roboto", 11F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(4, 353);
            this.label17.MouseState = MaterialSkin.MouseState.HOVER;
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 18);
            this.label17.TabIndex = 138;
            this.label17.Text = "输出结果";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxAtmModel);
            this.groupBox1.Controls.Add(this.comboBoxAeroModel);
            this.groupBox1.Controls.Add(this.comboBoxSiteName);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 136);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原始参数";
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
            this.comboBoxAtmModel.Location = new System.Drawing.Point(80, 80);
            this.comboBoxAtmModel.Name = "comboBoxAtmModel";
            this.comboBoxAtmModel.Size = new System.Drawing.Size(268, 25);
            this.comboBoxAtmModel.TabIndex = 24;
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
            this.comboBoxAeroModel.Location = new System.Drawing.Point(451, 80);
            this.comboBoxAeroModel.Name = "comboBoxAeroModel";
            this.comboBoxAeroModel.Size = new System.Drawing.Size(360, 25);
            this.comboBoxAeroModel.TabIndex = 23;
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
            this.comboBoxSiteName.Location = new System.Drawing.Point(80, 20);
            this.comboBoxSiteName.Name = "comboBoxSiteName";
            this.comboBoxSiteName.Size = new System.Drawing.Size(731, 25);
            this.comboBoxSiteName.TabIndex = 22;
            // 
            // textBoxSpectra
            // 
            this.textBoxSpectra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSpectra.Location = new System.Drawing.Point(80, 110);
            this.textBoxSpectra.Name = "textBoxSpectra";
            this.textBoxSpectra.ReadOnly = true;
            this.textBoxSpectra.Size = new System.Drawing.Size(658, 23);
            this.textBoxSpectra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(357, 84);
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
            this.btnOpenSpectra.Icon = null;
            this.btnOpenSpectra.Location = new System.Drawing.Point(758, 109);
            this.btnOpenSpectra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenSpectra.Name = "btnOpenSpectra";
            this.btnOpenSpectra.Primary = true;
            this.btnOpenSpectra.Size = new System.Drawing.Size(53, 24);
            this.btnOpenSpectra.TabIndex = 0;
            this.btnOpenSpectra.Text = "打开";
            this.btnOpenSpectra.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Depth = 0;
            this.label9.Font = new System.Drawing.Font("Roboto", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(9, 78);
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
            this.textBoxVapor.Location = new System.Drawing.Point(447, 50);
            this.textBoxVapor.Name = "textBoxVapor";
            this.textBoxVapor.Size = new System.Drawing.Size(365, 23);
            this.textBoxVapor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(369, 54);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "水汽含量";
            // 
            // textBoxThickness
            // 
            this.textBoxThickness.Location = new System.Drawing.Point(80, 50);
            this.textBoxThickness.Name = "textBoxThickness";
            this.textBoxThickness.Size = new System.Drawing.Size(268, 23);
            this.textBoxThickness.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(9, 110);
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
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "光学厚度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 22);
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
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBoxNewAtmModel);
            this.groupBox2.Controls.Add(this.comboBoxNewAeroModel);
            this.groupBox2.Controls.Add(this.textBoxNewSpectra);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnOpenNewSpectra);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxNewVapor);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxNewThickness);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(5, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 112);
            this.groupBox2.TabIndex = 137;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新的参数";
            // 
            // comboBoxNewAtmModel
            // 
            this.comboBoxNewAtmModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewAtmModel.FormattingEnabled = true;
            this.comboBoxNewAtmModel.Items.AddRange(new object[] {
            "热带大气",
            "中纬度夏季",
            "中纬度冬季",
            "极地夏季",
            "极地冬季",
            "美国1962标准大气"});
            this.comboBoxNewAtmModel.Location = new System.Drawing.Point(80, 52);
            this.comboBoxNewAtmModel.Name = "comboBoxNewAtmModel";
            this.comboBoxNewAtmModel.Size = new System.Drawing.Size(268, 25);
            this.comboBoxNewAtmModel.TabIndex = 24;
            // 
            // comboBoxNewAeroModel
            // 
            this.comboBoxNewAeroModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNewAeroModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewAeroModel.FormattingEnabled = true;
            this.comboBoxNewAeroModel.Items.AddRange(new object[] {
            "乡村型气溶胶",
            "沙漠型气溶胶",
            "城市型气溶胶",
            "海洋型气溶胶"});
            this.comboBoxNewAeroModel.Location = new System.Drawing.Point(451, 52);
            this.comboBoxNewAeroModel.Name = "comboBoxNewAeroModel";
            this.comboBoxNewAeroModel.Size = new System.Drawing.Size(360, 25);
            this.comboBoxNewAeroModel.TabIndex = 23;
            // 
            // textBoxNewSpectra
            // 
            this.textBoxNewSpectra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewSpectra.Location = new System.Drawing.Point(80, 86);
            this.textBoxNewSpectra.Name = "textBoxNewSpectra";
            this.textBoxNewSpectra.ReadOnly = true;
            this.textBoxNewSpectra.Size = new System.Drawing.Size(658, 23);
            this.textBoxNewSpectra.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(357, 54);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "气溶胶类型";
            // 
            // btnOpenNewSpectra
            // 
            this.btnOpenNewSpectra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenNewSpectra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenNewSpectra.Depth = 0;
            this.btnOpenNewSpectra.Icon = null;
            this.btnOpenNewSpectra.Location = new System.Drawing.Point(758, 84);
            this.btnOpenNewSpectra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenNewSpectra.Name = "btnOpenNewSpectra";
            this.btnOpenNewSpectra.Primary = true;
            this.btnOpenNewSpectra.Size = new System.Drawing.Size(53, 24);
            this.btnOpenNewSpectra.TabIndex = 0;
            this.btnOpenNewSpectra.Text = "打开";
            this.btnOpenNewSpectra.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(9, 51);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "大气类型";
            // 
            // textBoxNewVapor
            // 
            this.textBoxNewVapor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewVapor.Location = new System.Drawing.Point(451, 22);
            this.textBoxNewVapor.Name = "textBoxNewVapor";
            this.textBoxNewVapor.Size = new System.Drawing.Size(360, 23);
            this.textBoxNewVapor.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Depth = 0;
            this.label12.Font = new System.Drawing.Font("Roboto", 11F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(369, 26);
            this.label12.MouseState = MaterialSkin.MouseState.HOVER;
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "水汽含量";
            // 
            // textBoxNewThickness
            // 
            this.textBoxNewThickness.Location = new System.Drawing.Point(80, 22);
            this.textBoxNewThickness.Name = "textBoxNewThickness";
            this.textBoxNewThickness.Size = new System.Drawing.Size(268, 23);
            this.textBoxNewThickness.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Depth = 0;
            this.label13.Font = new System.Drawing.Font("Roboto", 11F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(9, 86);
            this.label13.MouseState = MaterialSkin.MouseState.HOVER;
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "场地光谱";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Depth = 0;
            this.label14.Font = new System.Drawing.Font("Roboto", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(9, 22);
            this.label14.MouseState = MaterialSkin.MouseState.HOVER;
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "光学厚度";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Depth = 0;
            this.label16.Font = new System.Drawing.Font("Roboto", 11F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(21, 17);
            this.label16.MouseState = MaterialSkin.MouseState.HOVER;
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 18);
            this.label16.TabIndex = 2;
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompute.Depth = 0;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompute.Icon = null;
            this.btnCompute.Location = new System.Drawing.Point(734, 572);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(6);
            this.btnCompute.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Primary = true;
            this.btnCompute.Size = new System.Drawing.Size(105, 34);
            this.btnCompute.TabIndex = 144;
            this.btnCompute.Text = "计算";
            this.btnCompute.UseVisualStyleBackColor = true;
            // 
            // SBAFUncertaintyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCompute);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SBAFUncertaintyPanel";
            this.Size = new System.Drawing.Size(849, 612);
            this.Load += new System.EventHandler(this.SBAFUncertaintyPanel_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxTargetImage;
        private MaterialSkin.Controls.MaterialLabel label10;
        private System.Windows.Forms.TextBox textBoxReferImage;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenTargetImage;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenReferImage;
        private MaterialSkin.Controls.MaterialLabel label11;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private MaterialSkin.Controls.MaterialLabel label15;
        private System.Windows.Forms.TextBox textBoxResult;
        private MaterialSkin.Controls.MaterialLabel label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxAtmModel;
        private System.Windows.Forms.ComboBox comboBoxAeroModel;
        private System.Windows.Forms.ComboBox comboBoxSiteName;
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
        private System.Windows.Forms.ComboBox comboBoxNewAtmModel;
        private System.Windows.Forms.ComboBox comboBoxNewAeroModel;
        private System.Windows.Forms.TextBox textBoxNewSpectra;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenNewSpectra;
        private MaterialSkin.Controls.MaterialLabel label8;
        private System.Windows.Forms.TextBox textBoxNewVapor;
        private MaterialSkin.Controls.MaterialLabel label12;
        private System.Windows.Forms.TextBox textBoxNewThickness;
        private MaterialSkin.Controls.MaterialLabel label13;
        private MaterialSkin.Controls.MaterialLabel label14;
        private MaterialSkin.Controls.MaterialLabel label16;
        private MaterialSkin.Controls.MaterialRaisedButton btnCompute;

    }
}
