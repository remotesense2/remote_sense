namespace phoenix
{
    partial class CrossCalibrationPanel
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
            this.textBoxRefer = new System.Windows.Forms.TextBox();
            this.btnOpenRefer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxPending = new System.Windows.Forms.TextBox();
            this.btnOpenPending = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxBRDFCoeff = new System.Windows.Forms.TextBox();
            this.btnBRDFCoeff = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxSBAFCoeff = new System.Windows.Forms.TextBox();
            this.btnSBAFCoeff = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxCoefficient = new System.Windows.Forms.TextBox();
            this.btnCoefficient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnCompute = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnHelp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // textBoxRefer
            // 
            this.textBoxRefer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRefer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRefer.Location = new System.Drawing.Point(156, 46);
            this.textBoxRefer.Name = "textBoxRefer";
            this.textBoxRefer.ReadOnly = true;
            this.textBoxRefer.Size = new System.Drawing.Size(534, 23);
            this.textBoxRefer.TabIndex = 24;
            // 
            // btnOpenRefer
            // 
            this.btnOpenRefer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenRefer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenRefer.Depth = 0;
            this.btnOpenRefer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenRefer.Icon = null;
            this.btnOpenRefer.Location = new System.Drawing.Point(696, 45);
            this.btnOpenRefer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenRefer.Name = "btnOpenRefer";
            this.btnOpenRefer.Primary = true;
            this.btnOpenRefer.Size = new System.Drawing.Size(53, 26);
            this.btnOpenRefer.TabIndex = 22;
            this.btnOpenRefer.Text = "打开";
            this.btnOpenRefer.UseVisualStyleBackColor = true;
            this.btnOpenRefer.Click += new System.EventHandler(this.btnOpenRefer_Click);
            // 
            // textBoxPending
            // 
            this.textBoxPending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPending.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPending.Location = new System.Drawing.Point(156, 14);
            this.textBoxPending.Name = "textBoxPending";
            this.textBoxPending.ReadOnly = true;
            this.textBoxPending.Size = new System.Drawing.Size(534, 23);
            this.textBoxPending.TabIndex = 21;
            // 
            // btnOpenPending
            // 
            this.btnOpenPending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPending.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenPending.Depth = 0;
            this.btnOpenPending.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenPending.Icon = null;
            this.btnOpenPending.Location = new System.Drawing.Point(696, 13);
            this.btnOpenPending.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenPending.Name = "btnOpenPending";
            this.btnOpenPending.Primary = true;
            this.btnOpenPending.Size = new System.Drawing.Size(53, 26);
            this.btnOpenPending.TabIndex = 19;
            this.btnOpenPending.Text = "打开";
            this.btnOpenPending.UseVisualStyleBackColor = true;
            this.btnOpenPending.Click += new System.EventHandler(this.btnOpenPending_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(14, 17);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "待定标传感器图像";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "场地参考卫星图像";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "观测几何校正因子";
            // 
            // textBoxBRDFCoeff
            // 
            this.textBoxBRDFCoeff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBRDFCoeff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBRDFCoeff.Location = new System.Drawing.Point(156, 81);
            this.textBoxBRDFCoeff.Name = "textBoxBRDFCoeff";
            this.textBoxBRDFCoeff.ReadOnly = true;
            this.textBoxBRDFCoeff.Size = new System.Drawing.Size(534, 23);
            this.textBoxBRDFCoeff.TabIndex = 27;
            // 
            // btnBRDFCoeff
            // 
            this.btnBRDFCoeff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBRDFCoeff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBRDFCoeff.Depth = 0;
            this.btnBRDFCoeff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBRDFCoeff.Icon = null;
            this.btnBRDFCoeff.Location = new System.Drawing.Point(696, 79);
            this.btnBRDFCoeff.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBRDFCoeff.Name = "btnBRDFCoeff";
            this.btnBRDFCoeff.Primary = true;
            this.btnBRDFCoeff.Size = new System.Drawing.Size(53, 26);
            this.btnBRDFCoeff.TabIndex = 26;
            this.btnBRDFCoeff.Text = "打开";
            this.btnBRDFCoeff.UseVisualStyleBackColor = true;
            this.btnBRDFCoeff.Click += new System.EventHandler(this.btnBRDFCoeff_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(14, 116);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "光谱匹配校正因子";
            // 
            // textBoxSBAFCoeff
            // 
            this.textBoxSBAFCoeff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSBAFCoeff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSBAFCoeff.Location = new System.Drawing.Point(156, 113);
            this.textBoxSBAFCoeff.Name = "textBoxSBAFCoeff";
            this.textBoxSBAFCoeff.ReadOnly = true;
            this.textBoxSBAFCoeff.Size = new System.Drawing.Size(534, 23);
            this.textBoxSBAFCoeff.TabIndex = 30;
            // 
            // btnSBAFCoeff
            // 
            this.btnSBAFCoeff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSBAFCoeff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSBAFCoeff.Depth = 0;
            this.btnSBAFCoeff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSBAFCoeff.Icon = null;
            this.btnSBAFCoeff.Location = new System.Drawing.Point(696, 111);
            this.btnSBAFCoeff.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSBAFCoeff.Name = "btnSBAFCoeff";
            this.btnSBAFCoeff.Primary = true;
            this.btnSBAFCoeff.Size = new System.Drawing.Size(53, 26);
            this.btnSBAFCoeff.TabIndex = 29;
            this.btnSBAFCoeff.Text = "打开";
            this.btnSBAFCoeff.UseVisualStyleBackColor = true;
            this.btnSBAFCoeff.Click += new System.EventHandler(this.btnSBAFCoeff_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(46, 152);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "交叉定标系数";
            // 
            // textBoxCoefficient
            // 
            this.textBoxCoefficient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCoefficient.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCoefficient.Location = new System.Drawing.Point(156, 147);
            this.textBoxCoefficient.Name = "textBoxCoefficient";
            this.textBoxCoefficient.ReadOnly = true;
            this.textBoxCoefficient.Size = new System.Drawing.Size(534, 23);
            this.textBoxCoefficient.TabIndex = 33;
            // 
            // btnCoefficient
            // 
            this.btnCoefficient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCoefficient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCoefficient.Depth = 0;
            this.btnCoefficient.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCoefficient.Icon = null;
            this.btnCoefficient.Location = new System.Drawing.Point(696, 145);
            this.btnCoefficient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCoefficient.Name = "btnCoefficient";
            this.btnCoefficient.Primary = true;
            this.btnCoefficient.Size = new System.Drawing.Size(53, 26);
            this.btnCoefficient.TabIndex = 32;
            this.btnCoefficient.Text = "保存";
            this.btnCoefficient.UseVisualStyleBackColor = true;
            this.btnCoefficient.Click += new System.EventHandler(this.btnCoefficient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(46, 183);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "交叉定标结果";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.White;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxResult.Location = new System.Drawing.Point(156, 183);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(593, 151);
            this.textBoxResult.TabIndex = 36;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompute.Depth = 0;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompute.Icon = null;
            this.btnCompute.Location = new System.Drawing.Point(156, 340);
            this.btnCompute.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Primary = true;
            this.btnCompute.Size = new System.Drawing.Size(91, 32);
            this.btnCompute.TabIndex = 37;
            this.btnCompute.Text = "计算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelp.Depth = 0;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHelp.Icon = null;
            this.btnHelp.Location = new System.Drawing.Point(658, 340);
            this.btnHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Primary = true;
            this.btnHelp.Size = new System.Drawing.Size(91, 32);
            this.btnHelp.TabIndex = 38;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // CrossCalibrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCoefficient);
            this.Controls.Add(this.btnCoefficient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSBAFCoeff);
            this.Controls.Add(this.btnSBAFCoeff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBRDFCoeff);
            this.Controls.Add(this.btnBRDFCoeff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRefer);
            this.Controls.Add(this.btnOpenRefer);
            this.Controls.Add(this.textBoxPending);
            this.Controls.Add(this.btnOpenPending);
            this.Controls.Add(this.label5);
            this.Name = "CrossCalibrationPanel";
            this.Size = new System.Drawing.Size(782, 384);
            this.Load += new System.EventHandler(this.CrossCalibrationPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRefer;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenRefer;
        private System.Windows.Forms.TextBox textBoxPending;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenPending;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private System.Windows.Forms.TextBox textBoxBRDFCoeff;
        private MaterialSkin.Controls.MaterialRaisedButton btnBRDFCoeff;
        private MaterialSkin.Controls.MaterialLabel label3;
        private System.Windows.Forms.TextBox textBoxSBAFCoeff;
        private MaterialSkin.Controls.MaterialRaisedButton btnSBAFCoeff;
        private MaterialSkin.Controls.MaterialLabel label4;
        private System.Windows.Forms.TextBox textBoxCoefficient;
        private MaterialSkin.Controls.MaterialRaisedButton btnCoefficient;
        private MaterialSkin.Controls.MaterialLabel label6;
        private System.Windows.Forms.TextBox textBoxResult;
        private MaterialSkin.Controls.MaterialRaisedButton btnCompute;
        private MaterialSkin.Controls.MaterialRaisedButton btnHelp;
    }
}
