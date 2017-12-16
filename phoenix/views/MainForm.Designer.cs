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
            this.contextMenuStripModules = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.panelTool = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelContext
            // 
            this.panelContext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContext.Location = new System.Drawing.Point(0, 64);
            this.panelContext.Margin = new System.Windows.Forms.Padding(6);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(1051, 534);
            this.panelContext.TabIndex = 1;
            // 
            // contextMenuStripModules
            // 
            this.contextMenuStripModules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contextMenuStripModules.Depth = 0;
            this.contextMenuStripModules.MouseState = MaterialSkin.MouseState.HOVER;
            this.contextMenuStripModules.Name = "contextMenuStripModules";
            this.contextMenuStripModules.Size = new System.Drawing.Size(61, 4);
            // 
            // panelTool
            // 
            this.panelTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panelTool.ForeColor = System.Drawing.Color.Cornsilk;
            this.panelTool.Location = new System.Drawing.Point(885, 24);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(166, 38);
            this.panelTool.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 600);
            this.Controls.Add(this.panelTool);
            this.Controls.Add(this.panelContext);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1052, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定标系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContext;
        private MaterialSkin.Controls.MaterialContextMenuStrip contextMenuStripModules;
        private System.Windows.Forms.Panel panelTool;
    }
}