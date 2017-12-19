namespace phoenix
{
    partial class SiteReflectancePanel
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
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnPlaceImage = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxPosition = new MaterialSkin.Controls.MaterialComboBox();
            this.textBoxPending = new System.Windows.Forms.TextBox();
            this.openbtn1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openbtn2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.savebtn1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(73, 59);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "场地位置";
            // 
            // btnPlaceImage
            // 
            this.btnPlaceImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaceImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlaceImage.Depth = 0;
            this.btnPlaceImage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceImage.Icon = null;
            this.btnPlaceImage.Location = new System.Drawing.Point(682, 399);
            this.btnPlaceImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlaceImage.Name = "btnPlaceImage";
            this.btnPlaceImage.Primary = true;
            this.btnPlaceImage.Size = new System.Drawing.Size(76, 35);
            this.btnPlaceImage.TabIndex = 25;
            this.btnPlaceImage.Text = "计算处理";
            this.btnPlaceImage.UseVisualStyleBackColor = true;
            this.btnPlaceImage.Click += new System.EventHandler(this.btnPlaceImage_Click);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.comboBoxPosition.Location = new System.Drawing.Point(151, 52);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(548, 25);
            this.comboBoxPosition.TabIndex = 29;
            // 
            // textBoxPending
            // 
            this.textBoxPending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPending.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPending.Location = new System.Drawing.Point(151, 23);
            this.textBoxPending.Name = "textBoxPending";
            this.textBoxPending.ReadOnly = true;
            this.textBoxPending.Size = new System.Drawing.Size(548, 23);
            this.textBoxPending.TabIndex = 32;
            // 
            // openbtn1
            // 
            this.openbtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openbtn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openbtn1.Depth = 0;
            this.openbtn1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openbtn1.Icon = null;
            this.openbtn1.Location = new System.Drawing.Point(715, 23);
            this.openbtn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.openbtn1.Name = "openbtn1";
            this.openbtn1.Primary = true;
            this.openbtn1.Size = new System.Drawing.Size(53, 26);
            this.openbtn1.TabIndex = 30;
            this.openbtn1.Text = "打开";
            this.openbtn1.UseVisualStyleBackColor = true;
            this.openbtn1.Click += new System.EventHandler(this.openbtn1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(57, 23);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "反射率影像";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(151, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(548, 23);
            this.textBox1.TabIndex = 35;
            // 
            // openbtn2
            // 
            this.openbtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openbtn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openbtn2.Depth = 0;
            this.openbtn2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openbtn2.Icon = null;
            this.openbtn2.Location = new System.Drawing.Point(715, 89);
            this.openbtn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.openbtn2.Name = "openbtn2";
            this.openbtn2.Primary = true;
            this.openbtn2.Size = new System.Drawing.Size(53, 26);
            this.openbtn2.TabIndex = 34;
            this.openbtn2.Text = "打开";
            this.openbtn2.UseVisualStyleBackColor = true;
            this.openbtn2.Click += new System.EventHandler(this.openbtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(57, 93);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "场地反射率";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(151, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(548, 23);
            this.textBox2.TabIndex = 38;
            // 
            // savebtn1
            // 
            this.savebtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savebtn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savebtn1.Depth = 0;
            this.savebtn1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.savebtn1.Icon = null;
            this.savebtn1.Location = new System.Drawing.Point(715, 121);
            this.savebtn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.savebtn1.Name = "savebtn1";
            this.savebtn1.Primary = true;
            this.savebtn1.Size = new System.Drawing.Size(53, 26);
            this.savebtn1.TabIndex = 37;
            this.savebtn1.Text = "保存";
            this.savebtn1.UseVisualStyleBackColor = true;
            this.savebtn1.Click += new System.EventHandler(this.savebtn1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "光谱滤波后反射率";
            // 
            // SiteReflectancePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.savebtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openbtn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPending);
            this.Controls.Add(this.openbtn1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.btnPlaceImage);
            this.Controls.Add(this.label4);
            this.Name = "SiteReflectancePanel";
            this.Size = new System.Drawing.Size(782, 460);
            this.Load += new System.EventHandler(this.SiteReflectancePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialRaisedButton btnPlaceImage;
        private MaterialSkin.Controls.MaterialComboBox comboBoxPosition;
        private System.Windows.Forms.TextBox textBoxPending;
        private MaterialSkin.Controls.MaterialRaisedButton openbtn1;
        private MaterialSkin.Controls.MaterialLabel label5;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialRaisedButton openbtn2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private System.Windows.Forms.TextBox textBox2;
        private MaterialSkin.Controls.MaterialRaisedButton savebtn1;
        private MaterialSkin.Controls.MaterialLabel label2;
    }
}
