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
            this.btnCompute = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotalUncertainty = new System.Windows.Forms.TextBox();
            this.btnSaveTotalUncertainty = new System.Windows.Forms.Button();
            this.textBoxSBAFUncertainty = new System.Windows.Forms.TextBox();
            this.btnOpenSBAFUncertainty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBRDFUncertainty = new System.Windows.Forms.TextBox();
            this.btnOpenBRDFUncertainty = new System.Windows.Forms.Button();
            this.textBoxImageUncertainty = new System.Windows.Forms.TextBox();
            this.btnOpenImageUncertainty = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 

            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompute.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompute.Location = new System.Drawing.Point(293, 720);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(6);
            this.btnCompute.Name = "btnCompute";
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
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxResult.Location = new System.Drawing.Point(293, 338);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(541, 185);
            this.textBoxResult.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(27, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 28);
            this.label7.TabIndex = 50;
            this.label7.Text = "不确定度计算结果";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotalUncertainty
            // 
            this.textBoxTotalUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalUncertainty.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTotalUncertainty.Location = new System.Drawing.Point(293, 256);
            this.textBoxTotalUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTotalUncertainty.Name = "textBoxTotalUncertainty";
            this.textBoxTotalUncertainty.ReadOnly = true;
            this.textBoxTotalUncertainty.Size = new System.Drawing.Size(946, 39);
            this.textBoxTotalUncertainty.TabIndex = 49;
            // 
            // btnSaveTotalUncertainty
            // 
            this.btnSaveTotalUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTotalUncertainty.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveTotalUncertainty.Location = new System.Drawing.Point(1269, 252);
            this.btnSaveTotalUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveTotalUncertainty.Name = "btnSaveTotalUncertainty";
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
            this.textBoxSBAFUncertainty.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSBAFUncertainty.Location = new System.Drawing.Point(293, 178);
            this.textBoxSBAFUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSBAFUncertainty.Name = "textBoxSBAFUncertainty";
            this.textBoxSBAFUncertainty.ReadOnly = true;
            this.textBoxSBAFUncertainty.Size = new System.Drawing.Size(946, 39);
            this.textBoxSBAFUncertainty.TabIndex = 47;
            // 
            // btnOpenSBAFUncertainty
            // 
            this.btnOpenSBAFUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSBAFUncertainty.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenSBAFUncertainty.Location = new System.Drawing.Point(1269, 174);
            this.btnOpenSBAFUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenSBAFUncertainty.Name = "btnOpenSBAFUncertainty";
            this.btnOpenSBAFUncertainty.Size = new System.Drawing.Size(53, 25);
            this.btnOpenSBAFUncertainty.TabIndex = 43;
            this.btnOpenSBAFUncertainty.Text = "打开";
            this.btnOpenSBAFUncertainty.UseVisualStyleBackColor = true;
            this.btnOpenSBAFUncertainty.Click += new System.EventHandler(this.btnOpenSBAFUncertainty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 46;
            this.label1.Text = "总的额不确定性";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(27, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 31);
            this.label5.TabIndex = 45;
            this.label5.Text = "光谱匹配不确定性";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(179, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 44;
            // 
            // textBoxBRDFUncertainty
            // 
            this.textBoxBRDFUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBRDFUncertainty.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBRDFUncertainty.Location = new System.Drawing.Point(293, 102);
            this.textBoxBRDFUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxBRDFUncertainty.Name = "textBoxBRDFUncertainty";
            this.textBoxBRDFUncertainty.ReadOnly = true;
            this.textBoxBRDFUncertainty.Size = new System.Drawing.Size(946, 39);
            this.textBoxBRDFUncertainty.TabIndex = 42;
            // 
            // btnOpenBRDFUncertainty
            // 
            this.btnOpenBRDFUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBRDFUncertainty.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenBRDFUncertainty.Location = new System.Drawing.Point(1269, 96);
            this.btnOpenBRDFUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenBRDFUncertainty.Name = "btnOpenBRDFUncertainty";
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
            this.textBoxImageUncertainty.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxImageUncertainty.Location = new System.Drawing.Point(293, 32);
            this.textBoxImageUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxImageUncertainty.Name = "textBoxImageUncertainty";
            this.textBoxImageUncertainty.ReadOnly = true;
            this.textBoxImageUncertainty.Size = new System.Drawing.Size(946, 39);
            this.textBoxImageUncertainty.TabIndex = 40;
            // 
            // btnOpenImageUncertainty
            // 
            this.btnOpenImageUncertainty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenImageUncertainty.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenImageUncertainty.Location = new System.Drawing.Point(1269, 26);
            this.btnOpenImageUncertainty.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenImageUncertainty.Name = "btnOpenImageUncertainty";
            this.btnOpenImageUncertainty.Size = new System.Drawing.Size(53, 25);
            this.btnOpenImageUncertainty.TabIndex = 36;
            this.btnOpenImageUncertainty.Text = "打开";
            this.btnOpenImageUncertainty.UseVisualStyleBackColor = true;
            this.btnOpenImageUncertainty.Click += new System.EventHandler(this.btnOpenImageUncertainty_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(27, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 31);

            this.label4.TabIndex = 39;
            this.label4.Text = "观测几何不确定性";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 38;
            this.label3.Text = "图像噪声不确定性";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(179, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TotalUncertaintyPanel";
            this.Size = new System.Drawing.Size(702, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotalUncertainty;
        private System.Windows.Forms.Button btnSaveTotalUncertainty;
        private System.Windows.Forms.TextBox textBoxSBAFUncertainty;
        private System.Windows.Forms.Button btnOpenSBAFUncertainty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBRDFUncertainty;
        private System.Windows.Forms.Button btnOpenBRDFUncertainty;
        private System.Windows.Forms.TextBox textBoxImageUncertainty;
        private System.Windows.Forms.Button btnOpenImageUncertainty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
