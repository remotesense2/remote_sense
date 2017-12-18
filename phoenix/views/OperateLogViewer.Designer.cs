namespace phoenix.views
{
    partial class OperateLogViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewLog = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFunc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOutfile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewLog
            // 
            this.listViewLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderUser,
            this.columnHeaderFunc,
            this.columnHeaderOutfile});
            this.listViewLog.Depth = 0;
            this.listViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLog.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.listViewLog.FullRowSelect = true;
            this.listViewLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewLog.Location = new System.Drawing.Point(0, 0);
            this.listViewLog.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewLog.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.OwnerDraw = true;
            this.listViewLog.Size = new System.Drawing.Size(1170, 539);
            this.listViewLog.TabIndex = 0;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "操作时间";
            this.columnHeaderDate.Width = 224;
            // 
            // columnHeaderUser
            // 
            this.columnHeaderUser.Text = "操作者";
            this.columnHeaderUser.Width = 116;
            // 
            // columnHeaderFunc
            // 
            this.columnHeaderFunc.Text = "算法";
            this.columnHeaderFunc.Width = 85;
            // 
            // columnHeaderOutfile
            // 
            this.columnHeaderOutfile.Text = "保存路径";
            this.columnHeaderOutfile.Width = 142;
            // 
            // OperateLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.listViewLog);
            this.Name = "OperateLogViewer";
            this.Size = new System.Drawing.Size(1170, 539);
            this.Load += new System.EventHandler(this.OperateLogViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewLog;
        private System.Windows.Forms.ColumnHeader columnHeaderUser;
        private System.Windows.Forms.ColumnHeader columnHeaderFunc;
        private System.Windows.Forms.ColumnHeader columnHeaderOutfile;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
    }
}
