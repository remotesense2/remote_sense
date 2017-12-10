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
            this.panelContext.Location = new System.Drawing.Point(0, 152);
            this.panelContext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(1710, 924);
            this.panelContext.TabIndex = 1;
            // 
            // navigatePanelHead
            // 
            this.navigatePanelHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.navigatePanelHead.Location = new System.Drawing.Point(0, 0);
            this.navigatePanelHead.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.navigatePanelHead.Name = "navigatePanelHead";
            this.navigatePanelHead.Size = new System.Drawing.Size(1710, 152);
            this.navigatePanelHead.TabIndex = 0;
            this.navigatePanelHead.NavigateEvent += new phoenix.NavigatePanel.NavigateEventHandler(this.navigatePanelHead_NavigateEvent);
            this.navigatePanelHead.Load += new System.EventHandler(this.navigatePanelHead_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 1072);
            this.Controls.Add(this.panelContext);
            this.Controls.Add(this.navigatePanelHead);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1716, 1077);
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