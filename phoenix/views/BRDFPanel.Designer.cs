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
            this.btnOpenRefer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxTargetGeometry = new System.Windows.Forms.TextBox();
            this.btnOpenTarget = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxCorrectParams = new System.Windows.Forms.TextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.btnModel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnCompute = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // textBoxReferGeometry
            // 
            this.textBoxReferGeometry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReferGeometry.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxReferGeometry.Location = new System.Drawing.Point(183, 63);
            this.textBoxReferGeometry.Name = "textBoxReferGeometry";
            this.textBoxReferGeometry.ReadOnly = true;
            this.textBoxReferGeometry.Size = new System.Drawing.Size(429, 23);
            this.textBoxReferGeometry.TabIndex = 22;
            // 
            // btnOpenRefer
            // 
            this.btnOpenRefer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenRefer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenRefer.Depth = 0;
            this.btnOpenRefer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenRefer.Icon = null;
            this.btnOpenRefer.Location = new System.Drawing.Point(632, 60);
            this.btnOpenRefer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenRefer.Name = "btnOpenRefer";
            this.btnOpenRefer.Primary = true;
            this.btnOpenRefer.Size = new System.Drawing.Size(53, 25);
            this.btnOpenRefer.TabIndex = 21;
            this.btnOpenRefer.Text = "打开";
            this.btnOpenRefer.UseVisualStyleBackColor = true;
            this.btnOpenRefer.Click += new System.EventHandler(this.btnOpenRefer_Click);
            // 
            // textBoxTargetGeometry
            // 
            this.textBoxTargetGeometry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTargetGeometry.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTargetGeometry.Location = new System.Drawing.Point(183, 28);
            this.textBoxTargetGeometry.Name = "textBoxTargetGeometry";
            this.textBoxTargetGeometry.ReadOnly = true;
            this.textBoxTargetGeometry.Size = new System.Drawing.Size(429, 23);
            this.textBoxTargetGeometry.TabIndex = 20;
            // 
            // btnOpenTarget
            // 
            this.btnOpenTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTarget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenTarget.Depth = 0;
            this.btnOpenTarget.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenTarget.Icon = null;
            this.btnOpenTarget.Location = new System.Drawing.Point(632, 25);
            this.btnOpenTarget.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenTarget.Name = "btnOpenTarget";
            this.btnOpenTarget.Primary = true;
            this.btnOpenTarget.Size = new System.Drawing.Size(53, 25);
            this.btnOpenTarget.TabIndex = 16;
            this.btnOpenTarget.Text = "打开";
            this.btnOpenTarget.UseVisualStyleBackColor = true;
            this.btnOpenTarget.Click += new System.EventHandler(this.btnOpenTarget_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "参考卫星影像观测几何";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "目标卫星影像观测几何";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(92, 28);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 17;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCorrectParams
            // 
            this.textBoxCorrectParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCorrectParams.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCorrectParams.Location = new System.Drawing.Point(183, 140);
            this.textBoxCorrectParams.Name = "textBoxCorrectParams";
            this.textBoxCorrectParams.ReadOnly = true;
            this.textBoxCorrectParams.Size = new System.Drawing.Size(429, 23);
            this.textBoxCorrectParams.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(632, 136);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(53, 25);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxModel.Location = new System.Drawing.Point(183, 101);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new System.Drawing.Size(429, 23);
            this.textBoxModel.TabIndex = 27;
            // 
            // btnModel
            // 
            this.btnModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModel.Depth = 0;
            this.btnModel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModel.Icon = null;
            this.btnModel.Location = new System.Drawing.Point(632, 98);
            this.btnModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModel.Name = "btnModel";
            this.btnModel.Primary = true;
            this.btnModel.Size = new System.Drawing.Size(53, 25);
            this.btnModel.TabIndex = 23;
            this.btnModel.Text = "打开";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(41, 145);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "观测几何校正因子";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(25, 103);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "场地方向归一化模型";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(92, 105);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 24;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(65, 174);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 43);
            this.label7.TabIndex = 30;
            this.label7.Text = "观测几何校正因子计算结果";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.White;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxResult.Location = new System.Drawing.Point(183, 174);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(502, 134);
            this.textBoxResult.TabIndex = 31;
            // 
            // btnCompute
            // 
            this.btnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompute.Depth = 0;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompute.Icon = null;
            this.btnCompute.Location = new System.Drawing.Point(592, 321);
            this.btnCompute.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Primary = true;
            this.btnCompute.Size = new System.Drawing.Size(93, 32);
            this.btnCompute.TabIndex = 32;
            this.btnCompute.Text = "计算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // BRDFPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
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
            this.Size = new System.Drawing.Size(724, 361);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReferGeometry;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenRefer;
        private System.Windows.Forms.TextBox textBoxTargetGeometry;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenTarget;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label2;
        private System.Windows.Forms.TextBox textBoxCorrectParams;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private System.Windows.Forms.TextBox textBoxModel;
        private MaterialSkin.Controls.MaterialRaisedButton btnModel;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialLabel label7;
        private System.Windows.Forms.TextBox textBoxResult;
        private MaterialSkin.Controls.MaterialRaisedButton btnCompute;
    }
}
