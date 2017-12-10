namespace phoenix
{
    partial class BRDFUncertaintyPanel
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBRDFNew = new System.Windows.Forms.TextBox();
            this.btnBRDFNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBRDFOrigin = new System.Windows.Forms.TextBox();
            this.btnOpenBRDFOrigin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReferFile = new System.Windows.Forms.TextBox();
            this.btnOpenReferFile = new System.Windows.Forms.Button();
            this.textBoxTargetFile = new System.Windows.Forms.TextBox();
            this.btnOpenTargetFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompute.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompute.Location = new System.Drawing.Point(675, 403);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(91, 42);
            this.btnCompute.TabIndex = 56;
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
            this.textBoxResult.Location = new System.Drawing.Point(124, 194);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(642, 191);
            this.textBoxResult.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(15, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "观测几何不确定度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "新的场地模型系数";
            // 
            // textBoxBRDFNew
            // 
            this.textBoxBRDFNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBRDFNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBRDFNew.Location = new System.Drawing.Point(122, 149);
            this.textBoxBRDFNew.Name = "textBoxBRDFNew";
            this.textBoxBRDFNew.ReadOnly = true;
            this.textBoxBRDFNew.Size = new System.Drawing.Size(571, 23);
            this.textBoxBRDFNew.TabIndex = 49;
            // 
            // btnBRDFNew
            // 
            this.btnBRDFNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBRDFNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBRDFNew.Location = new System.Drawing.Point(713, 145);
            this.btnBRDFNew.Name = "btnBRDFNew";
            this.btnBRDFNew.Size = new System.Drawing.Size(53, 26);
            this.btnBRDFNew.TabIndex = 48;
            this.btnBRDFNew.Text = "打开";
            this.btnBRDFNew.UseVisualStyleBackColor = true;
            this.btnBRDFNew.Click += new System.EventHandler(this.btnBRDFNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "原始场地模型系数";
            // 
            // textBoxBRDFOrigin
            // 
            this.textBoxBRDFOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBRDFOrigin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBRDFOrigin.Location = new System.Drawing.Point(122, 107);
            this.textBoxBRDFOrigin.Name = "textBoxBRDFOrigin";
            this.textBoxBRDFOrigin.ReadOnly = true;
            this.textBoxBRDFOrigin.Size = new System.Drawing.Size(571, 23);
            this.textBoxBRDFOrigin.TabIndex = 46;
            // 
            // btnOpenBRDFOrigin
            // 
            this.btnOpenBRDFOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBRDFOrigin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenBRDFOrigin.Location = new System.Drawing.Point(713, 100);
            this.btnOpenBRDFOrigin.Name = "btnOpenBRDFOrigin";
            this.btnOpenBRDFOrigin.Size = new System.Drawing.Size(53, 26);
            this.btnOpenBRDFOrigin.TabIndex = 45;
            this.btnOpenBRDFOrigin.Text = "打开";
            this.btnOpenBRDFOrigin.UseVisualStyleBackColor = true;
            this.btnOpenBRDFOrigin.Click += new System.EventHandler(this.btnOpenBRDFOrigin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "参考卫星角度信息";
            // 
            // textBoxReferFile
            // 
            this.textBoxReferFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReferFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxReferFile.Location = new System.Drawing.Point(122, 62);
            this.textBoxReferFile.Name = "textBoxReferFile";
            this.textBoxReferFile.ReadOnly = true;
            this.textBoxReferFile.Size = new System.Drawing.Size(571, 23);
            this.textBoxReferFile.TabIndex = 43;
            // 
            // btnOpenReferFile
            // 
            this.btnOpenReferFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenReferFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenReferFile.Location = new System.Drawing.Point(713, 58);
            this.btnOpenReferFile.Name = "btnOpenReferFile";
            this.btnOpenReferFile.Size = new System.Drawing.Size(53, 26);
            this.btnOpenReferFile.TabIndex = 42;
            this.btnOpenReferFile.Text = "打开";
            this.btnOpenReferFile.UseVisualStyleBackColor = true;
            this.btnOpenReferFile.Click += new System.EventHandler(this.btnOpenReferFile_Click);
            // 
            // textBoxTargetFile
            // 
            this.textBoxTargetFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTargetFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTargetFile.Location = new System.Drawing.Point(122, 19);
            this.textBoxTargetFile.Name = "textBoxTargetFile";
            this.textBoxTargetFile.ReadOnly = true;
            this.textBoxTargetFile.Size = new System.Drawing.Size(571, 23);
            this.textBoxTargetFile.TabIndex = 41;
            // 
            // btnOpenTargetFile
            // 
            this.btnOpenTargetFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTargetFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenTargetFile.Location = new System.Drawing.Point(713, 15);
            this.btnOpenTargetFile.Name = "btnOpenTargetFile";
            this.btnOpenTargetFile.Size = new System.Drawing.Size(53, 26);
            this.btnOpenTargetFile.TabIndex = 39;
            this.btnOpenTargetFile.Text = "打开";
            this.btnOpenTargetFile.UseVisualStyleBackColor = true;
            this.btnOpenTargetFile.Click += new System.EventHandler(this.btnOpenTargetFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "目标卫星角度信息";
            // 
            // BRDFUncertaintyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBRDFNew);
            this.Controls.Add(this.btnBRDFNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBRDFOrigin);
            this.Controls.Add(this.btnOpenBRDFOrigin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReferFile);
            this.Controls.Add(this.btnOpenReferFile);
            this.Controls.Add(this.textBoxTargetFile);
            this.Controls.Add(this.btnOpenTargetFile);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BRDFUncertaintyPanel";
            this.Size = new System.Drawing.Size(779, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBRDFNew;
        private System.Windows.Forms.Button btnBRDFNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBRDFOrigin;
        private System.Windows.Forms.Button btnOpenBRDFOrigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReferFile;
        private System.Windows.Forms.Button btnOpenReferFile;
        private System.Windows.Forms.TextBox textBoxTargetFile;
        private System.Windows.Forms.Button btnOpenTargetFile;
        private System.Windows.Forms.Label label5;
    }
}
