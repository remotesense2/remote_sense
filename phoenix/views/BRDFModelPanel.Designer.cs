namespace phoenix
{
    partial class BRDFModelPanel
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
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonsave2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonsave1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnPlaceImage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxRefer
            // 
            this.textBoxRefer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRefer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRefer.Location = new System.Drawing.Point(178, 55);
            this.textBoxRefer.Name = "textBoxRefer";
            this.textBoxRefer.ReadOnly = true;
            this.textBoxRefer.Size = new System.Drawing.Size(456, 23);
            this.textBoxRefer.TabIndex = 14;
            // 
            // btnOpenRefer
            // 
            this.btnOpenRefer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenRefer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenRefer.Depth = 0;
            this.btnOpenRefer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenRefer.Icon = null;
            this.btnOpenRefer.Location = new System.Drawing.Point(650, 51);
            this.btnOpenRefer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenRefer.Name = "btnOpenRefer";
            this.btnOpenRefer.Primary = true;
            this.btnOpenRefer.Size = new System.Drawing.Size(53, 25);
            this.btnOpenRefer.TabIndex = 13;
            this.btnOpenRefer.Text = "打开";
            this.btnOpenRefer.UseVisualStyleBackColor = true;
            this.btnOpenRefer.Click += new System.EventHandler(this.btnOpenRefer_Click);
            // 
            // textBoxPending
            // 
            this.textBoxPending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPending.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPending.Location = new System.Drawing.Point(178, 21);
            this.textBoxPending.Name = "textBoxPending";
            this.textBoxPending.ReadOnly = true;
            this.textBoxPending.Size = new System.Drawing.Size(456, 23);
            this.textBoxPending.TabIndex = 12;
            // 
            // btnOpenPending
            // 
            this.btnOpenPending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPending.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenPending.Depth = 0;
            this.btnOpenPending.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenPending.Icon = null;
            this.btnOpenPending.Location = new System.Drawing.Point(650, 17);
            this.btnOpenPending.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenPending.Name = "btnOpenPending";
            this.btnOpenPending.Primary = true;
            this.btnOpenPending.Size = new System.Drawing.Size(53, 25);
            this.btnOpenPending.TabIndex = 9;
            this.btnOpenPending.Text = "打开";
            this.btnOpenPending.UseVisualStyleBackColor = true;
            this.btnOpenPending.Click += new System.EventHandler(this.btnOpenPending_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(20, 56);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "时间序列云产品文件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "时间序列场地反射率";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(178, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(456, 23);
            this.textBox1.TabIndex = 20;
            // 
            // buttonsave2
            // 
            this.buttonsave2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsave2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsave2.Depth = 0;
            this.buttonsave2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonsave2.Icon = null;
            this.buttonsave2.Location = new System.Drawing.Point(650, 118);
            this.buttonsave2.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonsave2.Name = "buttonsave2";
            this.buttonsave2.Primary = true;
            this.buttonsave2.Size = new System.Drawing.Size(53, 25);
            this.buttonsave2.TabIndex = 19;
            this.buttonsave2.Text = "保存";
            this.buttonsave2.UseVisualStyleBackColor = true;
            this.buttonsave2.Click += new System.EventHandler(this.buttonsave2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(178, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(456, 23);
            this.textBox2.TabIndex = 18;
            // 
            // buttonsave1
            // 
            this.buttonsave1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsave1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsave1.Depth = 0;
            this.buttonsave1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonsave1.Icon = null;
            this.buttonsave1.Location = new System.Drawing.Point(650, 85);
            this.buttonsave1.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonsave1.Name = "buttonsave1";
            this.buttonsave1.Primary = true;
            this.buttonsave1.Size = new System.Drawing.Size(53, 25);
            this.buttonsave1.TabIndex = 15;
            this.buttonsave1.Text = "保存";
            this.buttonsave1.UseVisualStyleBackColor = true;
            this.buttonsave1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 121);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "场地方向归一化模型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "时间序列有效反射率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(100, 153);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "输出结果";
            // 
            // btnPlaceImage
            // 
            this.btnPlaceImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaceImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlaceImage.Depth = 0;
            this.btnPlaceImage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceImage.Icon = null;
            this.btnPlaceImage.Location = new System.Drawing.Point(585, 348);
            this.btnPlaceImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlaceImage.Name = "btnPlaceImage";
            this.btnPlaceImage.Primary = true;
            this.btnPlaceImage.Size = new System.Drawing.Size(118, 44);
            this.btnPlaceImage.TabIndex = 23;
            this.btnPlaceImage.Text = "有效反射率计算";
            this.btnPlaceImage.UseVisualStyleBackColor = true;
            this.btnPlaceImage.Click += new System.EventHandler(this.btnPlaceImage_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.White;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxResult.Location = new System.Drawing.Point(178, 153);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(525, 187);
            this.textBoxResult.TabIndex = 55;
            // 
            // BRDFModelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.btnPlaceImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonsave2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonsave1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRefer);
            this.Controls.Add(this.btnOpenRefer);
            this.Controls.Add(this.textBoxPending);
            this.Controls.Add(this.btnOpenPending);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "BRDFModelPanel";
            this.Size = new System.Drawing.Size(720, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRefer;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenRefer;
        private System.Windows.Forms.TextBox textBoxPending;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenPending;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonsave2;
        private System.Windows.Forms.TextBox textBox2;
        private MaterialSkin.Controls.MaterialRaisedButton buttonsave1;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialRaisedButton btnPlaceImage;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}
