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
            this.panelContext.Location = new System.Drawing.Point(0, 76);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(899, 450);
            this.panelContext.TabIndex = 1;
            // 
            // navigatePanelHead
            // 
            this.navigatePanelHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.navigatePanelHead.Location = new System.Drawing.Point(0, 0);
            this.navigatePanelHead.Name = "navigatePanelHead";
            this.navigatePanelHead.Size = new System.Drawing.Size(899, 76);
            this.navigatePanelHead.TabIndex = 0;
            this.navigatePanelHead.NavigateEvent += new phoenix.NavigatePanel.NavigateEventHandler(this.navigatePanelHead_NavigateEvent);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 524);
            this.Controls.Add(this.panelContext);
            this.Controls.Add(this.navigatePanelHead);
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