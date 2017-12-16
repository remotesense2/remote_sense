namespace phoenix.views
{
    partial class SettingPanel
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
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.账户 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBoxPrivilege = new System.Windows.Forms.GroupBox();
            this.checkedListBoxPrivilege = new System.Windows.Forms.CheckedListBox();
            this.账户.SuspendLayout();
            this.groupBoxPrivilege.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxUsers.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 17;
            this.listBoxUsers.Location = new System.Drawing.Point(6, 16);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(223, 446);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // 账户
            // 
            this.账户.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.账户.Controls.Add(this.btnRemove);
            this.账户.Controls.Add(this.btnAdd);
            this.账户.Controls.Add(this.listBoxUsers);
            this.账户.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.账户.Location = new System.Drawing.Point(19, 3);
            this.账户.Name = "账户";
            this.账户.Size = new System.Drawing.Size(235, 520);
            this.账户.TabIndex = 1;
            this.账户.TabStop = false;
            this.账户.Text = "账户";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.Location = new System.Drawing.Point(154, 475);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(6, 475);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBoxPrivilege
            // 
            this.groupBoxPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPrivilege.Controls.Add(this.checkedListBoxPrivilege);
            this.groupBoxPrivilege.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxPrivilege.Location = new System.Drawing.Point(260, 3);
            this.groupBoxPrivilege.Name = "groupBoxPrivilege";
            this.groupBoxPrivilege.Size = new System.Drawing.Size(353, 520);
            this.groupBoxPrivilege.TabIndex = 2;
            this.groupBoxPrivilege.TabStop = false;
            this.groupBoxPrivilege.Text = "权限";
            // 
            // checkedListBoxPrivilege
            // 
            this.checkedListBoxPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxPrivilege.CheckOnClick = true;
            this.checkedListBoxPrivilege.FormattingEnabled = true;
            this.checkedListBoxPrivilege.Location = new System.Drawing.Point(21, 15);
            this.checkedListBoxPrivilege.Name = "checkedListBoxPrivilege";
            this.checkedListBoxPrivilege.Size = new System.Drawing.Size(316, 490);
            this.checkedListBoxPrivilege.TabIndex = 0;
            this.checkedListBoxPrivilege.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPrivilege_ItemCheck);
            // 
            // SettingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBoxPrivilege);
            this.Controls.Add(this.账户);
            this.Name = "SettingPanel";
            this.Size = new System.Drawing.Size(631, 526);
            this.Load += new System.EventHandler(this.SettingPanel_Load);
            this.账户.ResumeLayout(false);
            this.groupBoxPrivilege.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.GroupBox 账户;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemove;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.GroupBox groupBoxPrivilege;
        private System.Windows.Forms.CheckedListBox checkedListBoxPrivilege;
    }
}
