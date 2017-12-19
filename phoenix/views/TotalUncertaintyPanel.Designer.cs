namespace phoenix
{
    partial class TotalUncertaintyPanel
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
            this.btnCompute = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxTotalUncertainty = new System.Windows.Forms.TextBox();
            this.btnSaveTotalUncertainty = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxSBAFUncertainty = new System.Windows.Forms.TextBox();
            this.btnOpenSBAFUncertainty = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxBRDFUncertainty = new System.Windows.Forms.TextBox();
            this.btnOpenBRDFUncertainty = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxImageUncertainty = new System.Windows.Forms.TextBox();
            this.btnOpenImageUncertainty = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompute.Depth = 0;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompute.Icon = null;
            this.btnCompute.Location = new System.Drawing.Point(594, 294);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(6);
            this.btnCompute.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Primary = true;
            this.btnCompute.Size = new System.Drawing.Size(84, 30);
            this.btnCompute.TabIndex = 52;
            this.btnCompute.Text = "计算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.White;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxResult.Location = new System.Drawing.Point(159, 165);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(519, 117);
            this.textBoxResult.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(20, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 28);
            this.label7.TabIndex = 50;
            this.label7.Text = "不确定度计算结果";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotalUncertainty
            // 
            this.textBoxTotalUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalUncertainty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTotalUncertainty.Location = new System.Drawing.Point(159, 125);
            this.textBoxTotalUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTotalUncertainty.Name = "textBoxTotalUncertainty";
            this.textBoxTotalUncertainty.ReadOnly = true;
            this.textBoxTotalUncertainty.Size = new System.Drawing.Size(454, 23);
            this.textBoxTotalUncertainty.TabIndex = 49;
            // 
            // btnSaveTotalUncertainty
            // 
            this.btnSaveTotalUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTotalUncertainty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveTotalUncertainty.Depth = 0;
            this.btnSaveTotalUncertainty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveTotalUncertainty.Icon = null;
            this.btnSaveTotalUncertainty.Location = new System.Drawing.Point(625, 125);
            this.btnSaveTotalUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveTotalUncertainty.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveTotalUncertainty.Name = "btnSaveTotalUncertainty";
            this.btnSaveTotalUncertainty.Primary = true;
            this.btnSaveTotalUncertainty.Size = new System.Drawing.Size(53, 25);
            this.btnSaveTotalUncertainty.TabIndex = 48;
            this.btnSaveTotalUncertainty.Text = "保存";
            this.btnSaveTotalUncertainty.UseVisualStyleBackColor = true;
            this.btnSaveTotalUncertainty.Click += new System.EventHandler(this.btnSaveTotalUncertainty_Click);
            // 
            // textBoxSBAFUncertainty
            // 
            this.textBoxSBAFUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSBAFUncertainty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSBAFUncertainty.Location = new System.Drawing.Point(160, 90);
            this.textBoxSBAFUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSBAFUncertainty.Name = "textBoxSBAFUncertainty";
            this.textBoxSBAFUncertainty.ReadOnly = true;
            this.textBoxSBAFUncertainty.Size = new System.Drawing.Size(453, 23);
            this.textBoxSBAFUncertainty.TabIndex = 47;
            // 
            // btnOpenSBAFUncertainty
            // 
            this.btnOpenSBAFUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSBAFUncertainty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenSBAFUncertainty.Depth = 0;
            this.btnOpenSBAFUncertainty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenSBAFUncertainty.Icon = null;
            this.btnOpenSBAFUncertainty.Location = new System.Drawing.Point(625, 88);
            this.btnOpenSBAFUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenSBAFUncertainty.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenSBAFUncertainty.Name = "btnOpenSBAFUncertainty";
            this.btnOpenSBAFUncertainty.Primary = true;
            this.btnOpenSBAFUncertainty.Size = new System.Drawing.Size(53, 25);
            this.btnOpenSBAFUncertainty.TabIndex = 43;
            this.btnOpenSBAFUncertainty.Text = "打开";
            this.btnOpenSBAFUncertainty.UseVisualStyleBackColor = true;
            this.btnOpenSBAFUncertainty.Click += new System.EventHandler(this.btnOpenSBAFUncertainty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(36, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "总的额不确定性";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(20, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "光谱匹配不确定性";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(179, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 44;
            // 
            // textBoxBRDFUncertainty
            // 
            this.textBoxBRDFUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBRDFUncertainty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBRDFUncertainty.Location = new System.Drawing.Point(160, 55);
            this.textBoxBRDFUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxBRDFUncertainty.Name = "textBoxBRDFUncertainty";
            this.textBoxBRDFUncertainty.ReadOnly = true;
            this.textBoxBRDFUncertainty.Size = new System.Drawing.Size(453, 23);
            this.textBoxBRDFUncertainty.TabIndex = 42;
            // 
            // btnOpenBRDFUncertainty
            // 
            this.btnOpenBRDFUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBRDFUncertainty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenBRDFUncertainty.Depth = 0;
            this.btnOpenBRDFUncertainty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenBRDFUncertainty.Icon = null;
            this.btnOpenBRDFUncertainty.Location = new System.Drawing.Point(625, 55);
            this.btnOpenBRDFUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenBRDFUncertainty.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenBRDFUncertainty.Name = "btnOpenBRDFUncertainty";
            this.btnOpenBRDFUncertainty.Primary = true;
            this.btnOpenBRDFUncertainty.Size = new System.Drawing.Size(53, 25);
            this.btnOpenBRDFUncertainty.TabIndex = 41;
            this.btnOpenBRDFUncertainty.Text = "打开";
            this.btnOpenBRDFUncertainty.UseVisualStyleBackColor = true;
            this.btnOpenBRDFUncertainty.Click += new System.EventHandler(this.btnOpenBRDFUncertainty_Click);
            // 
            // textBoxImageUncertainty
            // 
            this.textBoxImageUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageUncertainty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxImageUncertainty.Location = new System.Drawing.Point(160, 16);
            this.textBoxImageUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxImageUncertainty.Name = "textBoxImageUncertainty";
            this.textBoxImageUncertainty.ReadOnly = true;
            this.textBoxImageUncertainty.Size = new System.Drawing.Size(453, 23);
            this.textBoxImageUncertainty.TabIndex = 40;
            // 
            // btnOpenImageUncertainty
            // 
            this.btnOpenImageUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenImageUncertainty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenImageUncertainty.Depth = 0;
            this.btnOpenImageUncertainty.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenImageUncertainty.Icon = null;
            this.btnOpenImageUncertainty.Location = new System.Drawing.Point(625, 16);
            this.btnOpenImageUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenImageUncertainty.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenImageUncertainty.Name = "btnOpenImageUncertainty";
            this.btnOpenImageUncertainty.Primary = true;
            this.btnOpenImageUncertainty.Size = new System.Drawing.Size(53, 25);
            this.btnOpenImageUncertainty.TabIndex = 36;
            this.btnOpenImageUncertainty.Text = "打开";
            this.btnOpenImageUncertainty.UseVisualStyleBackColor = true;
            this.btnOpenImageUncertainty.Click += new System.EventHandler(this.btnOpenImageUncertainty_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(20, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "观测几何不确定性";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "图像噪声不确定性";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(172, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 37;
            // 
            // TotalUncertaintyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTotalUncertainty);
            this.Controls.Add(this.btnSaveTotalUncertainty);
            this.Controls.Add(this.textBoxSBAFUncertainty);
            this.Controls.Add(this.btnOpenSBAFUncertainty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBRDFUncertainty);
            this.Controls.Add(this.btnOpenBRDFUncertainty);
            this.Controls.Add(this.textBoxImageUncertainty);
            this.Controls.Add(this.btnOpenImageUncertainty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TotalUncertaintyPanel";
            this.Size = new System.Drawing.Size(702, 335);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnCompute;
        private System.Windows.Forms.TextBox textBoxResult;
        private MaterialSkin.Controls.MaterialLabel label7;
        private System.Windows.Forms.TextBox textBoxTotalUncertainty;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveTotalUncertainty;
        private System.Windows.Forms.TextBox textBoxSBAFUncertainty;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenSBAFUncertainty;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label6;
        private System.Windows.Forms.TextBox textBoxBRDFUncertainty;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenBRDFUncertainty;
        private System.Windows.Forms.TextBox textBoxImageUncertainty;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenImageUncertainty;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label2;
    }
}
