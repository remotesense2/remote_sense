namespace phoenix
{
    partial class SiteAtmParasPanel
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
            this.textBoxsave = new System.Windows.Forms.TextBox();
            this.btnsave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOpen2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxPending = new System.Windows.Forms.TextBox();
            this.btnOpen1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCompute = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(78, 120);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "大气参数";
            // 
            // textBoxsave
            // 
            this.textBoxsave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxsave.Location = new System.Drawing.Point(157, 120);
            this.textBoxsave.Name = "textBoxsave";
            this.textBoxsave.ReadOnly = true;
            this.textBoxsave.Size = new System.Drawing.Size(541, 23);
            this.textBoxsave.TabIndex = 48;
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsave.Depth = 0;
            this.btnsave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsave.Icon = null;
            this.btnsave.Location = new System.Drawing.Point(704, 118);
            this.btnsave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsave.Name = "btnsave";
            this.btnsave.Primary = true;
            this.btnsave.Size = new System.Drawing.Size(53, 26);
            this.btnsave.TabIndex = 47;
            this.btnsave.Text = "保存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "MOD05气溶胶产品";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(157, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(541, 23);
            this.textBox2.TabIndex = 39;
            // 
            // btnOpen2
            // 
            this.btnOpen2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpen2.Depth = 0;
            this.btnOpen2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen2.Icon = null;
            this.btnOpen2.Location = new System.Drawing.Point(704, 50);
            this.btnOpen2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Primary = true;
            this.btnOpen2.Size = new System.Drawing.Size(53, 26);
            this.btnOpen2.TabIndex = 38;
            this.btnOpen2.Text = "打开";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // textBoxPending
            // 
            this.textBoxPending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPending.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPending.Location = new System.Drawing.Point(157, 17);
            this.textBoxPending.Name = "textBoxPending";
            this.textBoxPending.ReadOnly = true;
            this.textBoxPending.Size = new System.Drawing.Size(541, 23);
            this.textBoxPending.TabIndex = 37;
            // 
            // btnOpen1
            // 
            this.btnOpen1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpen1.Depth = 0;
            this.btnOpen1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen1.Icon = null;
            this.btnOpen1.Location = new System.Drawing.Point(704, 13);
            this.btnOpen1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Primary = true;
            this.btnOpen1.Size = new System.Drawing.Size(53, 26);
            this.btnOpen1.TabIndex = 35;
            this.btnOpen1.Text = "打开";
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(14, 20);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "MOD04气溶胶产品";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.comboBoxPosition.Location = new System.Drawing.Point(157, 87);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(541, 25);
            this.comboBoxPosition.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(78, 88);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "场地名称";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.White;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxResult.Location = new System.Drawing.Point(157, 150);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(600, 197);
            this.textBoxResult.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(78, 150);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 52;
            this.label7.Text = "计算结果";
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompute.Depth = 0;
            this.btnCompute.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompute.Icon = null;
            this.btnCompute.Location = new System.Drawing.Point(666, 353);
            this.btnCompute.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Primary = true;
            this.btnCompute.Size = new System.Drawing.Size(91, 34);
            this.btnCompute.TabIndex = 54;
            this.btnCompute.Text = "计算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // SiteAtmParasPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxsave);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.textBoxPending);
            this.Controls.Add(this.btnOpen1);
            this.Controls.Add(this.label5);
            this.Name = "SiteAtmParasPanel";
            this.Size = new System.Drawing.Size(782, 396);
            this.Load += new System.EventHandler(this.SiteAtmParasPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label4;
        private System.Windows.Forms.TextBox textBoxsave;
        private MaterialSkin.Controls.MaterialRaisedButton btnsave;
        private MaterialSkin.Controls.MaterialLabel label1;
        private System.Windows.Forms.TextBox textBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpen2;
        private System.Windows.Forms.TextBox textBoxPending;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpen1;
        private MaterialSkin.Controls.MaterialLabel label5;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private MaterialSkin.Controls.MaterialLabel label2;
        private System.Windows.Forms.TextBox textBoxResult;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialRaisedButton btnCompute;
    }
}
