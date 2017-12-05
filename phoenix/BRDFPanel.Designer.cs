namespace phoenix
{
    partial class BRDFPanel
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
            this.textBoxReferGeometry = new System.Windows.Forms.TextBox();
            this.btnOpenRefer = new System.Windows.Forms.Button();
            this.textBoxTargetGeometry = new System.Windows.Forms.TextBox();
            this.btnOpenTarget = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCorrectParams = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.btnModel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxReferGeometry
            // 
            this.textBoxReferGeometry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReferGeometry.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxReferGeometry.Location = new System.Drawing.Point(183, 63);
            this.textBoxReferGeometry.Name = "textBoxReferGeometry";
            this.textBoxReferGeometry.ReadOnly = true;
            this.textBoxReferGeometry.Size = new System.Drawing.Size(429, 26);
            this.textBoxReferGeometry.TabIndex = 22;
            // 
            // btnOpenRefer
            // 
            this.btnOpenRefer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenRefer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenRefer.Location = new System.Drawing.Point(632, 63);
            this.btnOpenRefer.Name = "btnOpenRefer";
            this.btnOpenRefer.Size = new System.Drawing.Size(53, 29);
            this.btnOpenRefer.TabIndex = 21;
            this.btnOpenRefer.Text = "打开";
            this.btnOpenRefer.UseVisualStyleBackColor = true;
            this.btnOpenRefer.Click += new System.EventHandler(this.btnOpenRefer_Click);
            // 
            // textBoxTargetGeometry
            // 
            this.textBoxTargetGeometry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTargetGeometry.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTargetGeometry.Location = new System.Drawing.Point(183, 28);
            this.textBoxTargetGeometry.Name = "textBoxTargetGeometry";
            this.textBoxTargetGeometry.ReadOnly = true;
            this.textBoxTargetGeometry.Size = new System.Drawing.Size(429, 26);
            this.textBoxTargetGeometry.TabIndex = 20;
            // 
            // btnOpenTarget
            // 
            this.btnOpenTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTarget.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenTarget.Location = new System.Drawing.Point(632, 25);
            this.btnOpenTarget.Name = "btnOpenTarget";
            this.btnOpenTarget.Size = new System.Drawing.Size(53, 29);
            this.btnOpenTarget.TabIndex = 16;
            this.btnOpenTarget.Text = "打开";
            this.btnOpenTarget.UseVisualStyleBackColor = true;
            this.btnOpenTarget.Click += new System.EventHandler(this.btnOpenTarget_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "参考卫星影像观测几何";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "目标卫星影像观测几何";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(92, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 17;
            // 
            // textBoxCorrectParams
            // 
            this.textBoxCorrectParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCorrectParams.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCorrectParams.Location = new System.Drawing.Point(183, 140);
            this.textBoxCorrectParams.Name = "textBoxCorrectParams";
            this.textBoxCorrectParams.ReadOnly = true;
            this.textBoxCorrectParams.Size = new System.Drawing.Size(429, 26);
            this.textBoxCorrectParams.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(632, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 29);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxModel.Location = new System.Drawing.Point(183, 105);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new System.Drawing.Size(429, 26);
            this.textBoxModel.TabIndex = 27;
            // 
            // btnModel
            // 
            this.btnModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModel.Location = new System.Drawing.Point(632, 105);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(53, 29);
            this.btnModel.TabIndex = 23;
            this.btnModel.Text = "打开";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "观测几何校正因子";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "场地方向归一化模型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(92, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 51);
            this.label7.TabIndex = 30;
            this.label7.Text = "观测几何校正因子计算结果";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.White;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxResult.Location = new System.Drawing.Point(183, 181);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(429, 184);
            this.textBoxResult.TabIndex = 31;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHelp.Location = new System.Drawing.Point(337, 391);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(81, 42);
            this.btnHelp.TabIndex = 33;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompute.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompute.Location = new System.Drawing.Point(92, 391);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(90, 42);
            this.btnCompute.TabIndex = 32;
            this.btnCompute.Text = "计算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(574, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 42);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BRDFPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCorrectParams);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxReferGeometry);
            this.Controls.Add(this.btnOpenRefer);
            this.Controls.Add(this.textBoxTargetGeometry);
            this.Controls.Add(this.btnOpenTarget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "BRDFPanel";
            this.Size = new System.Drawing.Size(724, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReferGeometry;
        private System.Windows.Forms.Button btnOpenRefer;
        private System.Windows.Forms.TextBox textBoxTargetGeometry;
        private System.Windows.Forms.Button btnOpenTarget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCorrectParams;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnExit;
    }
}
