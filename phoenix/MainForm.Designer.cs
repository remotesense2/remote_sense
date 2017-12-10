namespace phoenix
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContext = new System.Windows.Forms.Panel();
            this.navigatePanelHead = new phoenix.NavigatePanel();
            this.SuspendLayout();
            // 
            // panelContext
            // 
            this.panelContext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContext.Location = new System.Drawing.Point(0, 60);
            this.panelContext.Margin = new System.Windows.Forms.Padding(6);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(920, 504);
            this.panelContext.TabIndex = 1;
            // 
            // navigatePanelHead
            // 
            this.navigatePanelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.navigatePanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatePanelHead.Location = new System.Drawing.Point(0, 0);
            this.navigatePanelHead.Margin = new System.Windows.Forms.Padding(16, 19, 16, 19);
            this.navigatePanelHead.Name = "navigatePanelHead";
            this.navigatePanelHead.Size = new System.Drawing.Size(920, 60);
            this.navigatePanelHead.TabIndex = 0;
            this.navigatePanelHead.NavigateEvent += new phoenix.NavigatePanel.NavigateEventHandler(this.navigatePanelHead_NavigateEvent);
            this.navigatePanelHead.Load += new System.EventHandler(this.navigatePanelHead_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 562);
            this.Controls.Add(this.panelContext);
            this.Controls.Add(this.navigatePanelHead);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "**定标系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private NavigatePanel navigatePanelHead;
        private System.Windows.Forms.Panel panelContext;

    }
}