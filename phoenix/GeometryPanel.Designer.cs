namespace phoenix
{
    partial class GeometryPanel
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
            this.textBoxCloud = new System.Windows.Forms.TextBox();
            this.btnOpenCloud = new System.Windows.Forms.Button();
            this.textBoxRefer = new System.Windows.Forms.TextBox();
            this.btnOpenRefer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNormalization = new System.Windows.Forms.TextBox();
            this.btnOpenNormalization = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnPlaceInfo = new System.Windows.Forms.Button();
            this.btnPlaceImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCloud
            // 
            this.textBoxCloud.Location = new System.Drawing.Point(163, 73);
            this.textBoxCloud.Name = "textBoxCloud";
            this.textBoxCloud.Size = new System.Drawing.Size(309, 21);
            this.textBoxCloud.TabIndex = 15;
            // 
            // btnOpenCloud
            // 
            this.btnOpenCloud.Location = new System.Drawing.Point(488, 73);
            this.btnOpenCloud.Name = "btnOpenCloud";
            this.btnOpenCloud.Size = new System.Drawing.Size(53, 23);
            this.btnOpenCloud.TabIndex = 14;
            this.btnOpenCloud.Text = "打开";
            this.btnOpenCloud.UseVisualStyleBackColor = true;
            // 
            // textBoxRefer
            // 
            this.textBoxRefer.Location = new System.Drawing.Point(163, 38);
            this.textBoxRefer.Name = "textBoxRefer";
            this.textBoxRefer.Size = new System.Drawing.Size(309, 21);
            this.textBoxRefer.TabIndex = 13;
            // 
            // btnOpenRefer
            // 
            this.btnOpenRefer.Location = new System.Drawing.Point(488, 38);
            this.btnOpenRefer.Name = "btnOpenRefer";
            this.btnOpenRefer.Size = new System.Drawing.Size(53, 23);
            this.btnOpenRefer.TabIndex = 9;
            this.btnOpenRefer.Text = "打开";
            this.btnOpenRefer.UseVisualStyleBackColor = true;
            this.btnOpenRefer.Click += new System.EventHandler(this.btnOpenRefer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "时间序列云产品影像";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "时间序列参考卫星影像";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "场地方向归一化模型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "场地时间序列反射率";
            // 
            // textBoxNormalization
            // 
            this.textBoxNormalization.Location = new System.Drawing.Point(163, 116);
            this.textBoxNormalization.Name = "textBoxNormalization";
            this.textBoxNormalization.Size = new System.Drawing.Size(309, 21);
            this.textBoxNormalization.TabIndex = 19;
            // 
            // btnOpenNormalization
            // 
            this.btnOpenNormalization.Location = new System.Drawing.Point(488, 116);
            this.btnOpenNormalization.Name = "btnOpenNormalization";
            this.btnOpenNormalization.Size = new System.Drawing.Size(53, 23);
            this.btnOpenNormalization.TabIndex = 18;
            this.btnOpenNormalization.Text = "打开";
            this.btnOpenNormalization.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 227);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "蓝波段";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(20, 264);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 16);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "绿波段";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(22, 307);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 16);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "红波段";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(20, 353);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(84, 16);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "近红外波段";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHelp.Location = new System.Drawing.Point(505, 401);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(81, 42);
            this.btnHelp.TabIndex = 26;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnPlaceInfo
            // 
            this.btnPlaceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaceInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceInfo.Location = new System.Drawing.Point(246, 401);
            this.btnPlaceInfo.Name = "btnPlaceInfo";
            this.btnPlaceInfo.Size = new System.Drawing.Size(123, 42);
            this.btnPlaceInfo.TabIndex = 25;
            this.btnPlaceInfo.Text = "场地模型计算";
            this.btnPlaceInfo.UseVisualStyleBackColor = true;
            // 
            // btnPlaceImage
            // 
            this.btnPlaceImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlaceImage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlaceImage.Location = new System.Drawing.Point(32, 401);
            this.btnPlaceImage.Name = "btnPlaceImage";
            this.btnPlaceImage.Size = new System.Drawing.Size(132, 42);
            this.btnPlaceImage.TabIndex = 24;
            this.btnPlaceImage.Text = "有效反射率提取";
            this.btnPlaceImage.UseVisualStyleBackColor = true;
            // 
            // GeometryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPlaceInfo);
            this.Controls.Add(this.btnPlaceImage);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxNormalization);
            this.Controls.Add(this.btnOpenNormalization);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCloud);
            this.Controls.Add(this.btnOpenCloud);
            this.Controls.Add(this.textBoxRefer);
            this.Controls.Add(this.btnOpenRefer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "GeometryPanel";
            this.Size = new System.Drawing.Size(628, 462);
            this.Load += new System.EventHandler(this.GeometryPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCloud;
        private System.Windows.Forms.Button btnOpenCloud;
        private System.Windows.Forms.TextBox textBoxRefer;
        private System.Windows.Forms.Button btnOpenRefer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNormalization;
        private System.Windows.Forms.Button btnOpenNormalization;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnPlaceInfo;
        private System.Windows.Forms.Button btnPlaceImage;
    }
}
