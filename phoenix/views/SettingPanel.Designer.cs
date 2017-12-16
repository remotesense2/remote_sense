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
            this.listBoxUsers = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.groupBoxPrivileges = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listBoxUsers.Depth = 0;
            this.listBoxUsers.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.listBoxUsers.FullRowSelect = true;
            this.listBoxUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 13);
            this.listBoxUsers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listBoxUsers.MouseState = MaterialSkin.MouseState.OUT;
            this.listBoxUsers.MultiSelect = false;
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.OwnerDraw = true;
            this.listBoxUsers.Scrollable = false;
            this.listBoxUsers.Size = new System.Drawing.Size(223, 454);
            this.listBoxUsers.TabIndex = 4;
            this.listBoxUsers.UseCompatibleStateImageBehavior = false;
            this.listBoxUsers.View = System.Windows.Forms.View.Details;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "所有账户列表";
            this.columnHeader1.Width = 221;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Depth = 0;
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(160, 478);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = true;
            this.btnRemove.Size = new System.Drawing.Size(75, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(12, 478);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(249, 11);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 500);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // groupBoxPrivileges
            // 
            this.groupBoxPrivileges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPrivileges.Font = new System.Drawing.Font("Roboto", 11F);
            this.groupBoxPrivileges.Location = new System.Drawing.Point(272, 3);
            this.groupBoxPrivileges.Name = "groupBoxPrivileges";
            this.groupBoxPrivileges.Size = new System.Drawing.Size(317, 505);
            this.groupBoxPrivileges.TabIndex = 7;
            this.groupBoxPrivileges.TabStop = false;
            this.groupBoxPrivileges.Text = "可访问功能模块";
            // 
            // SettingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBoxPrivileges);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxUsers);
            this.Name = "SettingPanel";
            this.Size = new System.Drawing.Size(611, 526);
            this.Load += new System.EventHandler(this.SettingPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnRemove;
        private MaterialSkin.Controls.MaterialListView listBoxUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.GroupBox groupBoxPrivileges;
    }
}
