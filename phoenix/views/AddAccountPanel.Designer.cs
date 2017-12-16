namespace phoenix.views
{
    partial class AddAccountPanel
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
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPwdAgain = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Depth = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(212, 137);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(92, 38);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.Depth = 0;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(37, 137);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(92, 38);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPassword.Hint = "";
            this.textBoxPassword.Location = new System.Drawing.Point(99, 57);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(205, 23);
            this.textBoxPassword.TabIndex = 35;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.UseSystemPasswordChar = false;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Depth = 0;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUserName.Hint = "";
            this.textBoxUserName.Location = new System.Drawing.Point(99, 19);
            this.textBoxUserName.MaxLength = 32767;
            this.textBoxUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.PasswordChar = '\0';
            this.textBoxUserName.SelectedText = "";
            this.textBoxUserName.SelectionLength = 0;
            this.textBoxUserName.SelectionStart = 0;
            this.textBoxUserName.Size = new System.Drawing.Size(205, 23);
            this.textBoxUserName.TabIndex = 34;
            this.textBoxUserName.TabStop = false;
            this.textBoxUserName.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "用户名";
            // 
            // textBoxPwdAgain
            // 
            this.textBoxPwdAgain.Depth = 0;
            this.textBoxPwdAgain.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPwdAgain.Hint = "";
            this.textBoxPwdAgain.Location = new System.Drawing.Point(99, 97);
            this.textBoxPwdAgain.MaxLength = 32767;
            this.textBoxPwdAgain.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPwdAgain.Name = "textBoxPwdAgain";
            this.textBoxPwdAgain.PasswordChar = '*';
            this.textBoxPwdAgain.SelectedText = "";
            this.textBoxPwdAgain.SelectionLength = 0;
            this.textBoxPwdAgain.SelectionStart = 0;
            this.textBoxPwdAgain.Size = new System.Drawing.Size(205, 23);
            this.textBoxPwdAgain.TabIndex = 39;
            this.textBoxPwdAgain.TabStop = false;
            this.textBoxPwdAgain.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "重复密码";
            // 
            // AddAccountPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.textBoxPwdAgain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAccountPanel";
            this.Size = new System.Drawing.Size(319, 193);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxUserName;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPwdAgain;
        private MaterialSkin.Controls.MaterialLabel label3;
    }
}
