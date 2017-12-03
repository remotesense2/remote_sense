namespace phoenix
{
    partial class UncertaintyAnalysisPanel
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnPlaceInfo = new System.Windows.Forms.Button();
            this.btnPlaceImage = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxPending = new System.Windows.Forms.TextBox();
            this.btnOpenPending = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(247, 96);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(309, 21);
            this.textBox7.TabIndex = 98;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 96;
            this.button1.Text = "打开";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 97;
            this.label9.Text = "场地参考卫星图像";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHelp.Location = new System.Drawing.Point(528, 454);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(81, 42);
            this.btnHelp.TabIndex = 85;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnPlaceInfo
            // 
            this.btnPlaceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaceInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceInfo.Location = new System.Drawing.Point(330, 454);
            this.btnPlaceInfo.Name = "btnPlaceInfo";
            this.btnPlaceInfo.Size = new System.Drawing.Size(98, 42);
            this.btnPlaceInfo.TabIndex = 84;
            this.btnPlaceInfo.Text = "保存";
            this.btnPlaceInfo.UseVisualStyleBackColor = true;
            // 
            // btnPlaceImage
            // 
            this.btnPlaceImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlaceImage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceImage.Location = new System.Drawing.Point(154, 454);
            this.btnPlaceImage.Name = "btnPlaceImage";
            this.btnPlaceImage.Size = new System.Drawing.Size(95, 42);
            this.btnPlaceImage.TabIndex = 83;
            this.btnPlaceImage.Text = "计算";
            this.btnPlaceImage.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 139);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(309, 163);
            this.textBox3.TabIndex = 82;
            // 
            // textBoxPending
            // 
            this.textBoxPending.Location = new System.Drawing.Point(247, 53);
            this.textBoxPending.Name = "textBoxPending";
            this.textBoxPending.Size = new System.Drawing.Size(309, 21);
            this.textBoxPending.TabIndex = 79;
            // 
            // btnOpenPending
            // 
            this.btnOpenPending.Location = new System.Drawing.Point(572, 53);
            this.btnOpenPending.Name = "btnOpenPending";
            this.btnOpenPending.Size = new System.Drawing.Size(53, 23);
            this.btnOpenPending.TabIndex = 76;
            this.btnOpenPending.Text = "打开";
            this.btnOpenPending.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 78;
            this.label4.Text = "图像噪声不确定度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 77;
            this.label3.Text = "待定标传感器图像";
            // 
            // UncertaintyAnalysisPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPlaceInfo);
            this.Controls.Add(this.btnPlaceImage);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxPending);
            this.Controls.Add(this.btnOpenPending);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "UncertaintyAnalysisPanel";
            this.Size = new System.Drawing.Size(743, 548);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnPlaceInfo;
        private System.Windows.Forms.Button btnPlaceImage;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxPending;
        private System.Windows.Forms.Button btnOpenPending;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
