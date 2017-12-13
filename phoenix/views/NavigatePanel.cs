using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phoenix
{
    public partial class NavigatePanel : UserControl
    {
        private int rightPos = 0;

        public NavigatePanel()
        {
            InitializeComponent();
        }

        public delegate void NavigateEventHandler(ContainerControl container);
        public event NavigateEventHandler NavigateEvent;

        private void NavigatePanel_Load(object sender, EventArgs e)
        {
            rightPos = btnExit.Location.X;
        }

        private void SetButtonActive(NavigateButton button)
        {
            foreach (Control c in this.Controls)
            {
                if (button == c)
                {
                    c.ForeColor = System.Drawing.Color.Gray;
                    c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
                }
                else
                {
                    c.ForeColor = System.Drawing.Color.White;
                    c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
                }
            }

            if (NavigateEvent != null)
            {
                NavigateEvent(button.ContainerPanel);
            }
        }

        public NavigateTabGroup AddGroup()
        {
            NavigateTabGroup tab = new NavigateTabGroup();
            tab.Size = new System.Drawing.Size(0, 30);
            tab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Margin = new System.Windows.Forms.Padding(0);
            tab.NavigateTabEvent += new phoenix.NavigateTabGroup.NavigateTabEventHandler(this.TabNavigate_Click);
            panelContainer.Controls.Add(tab);
            return tab;
        }

        public void AddNoGroupPanel(string text, ContainerControl container)
        {
            NavigateButton btnNew = new NavigateButton(container);
            btnNew.AutoSize = true;
            btnNew.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            btnNew.Text = text;
            btnNew.ForeColor = System.Drawing.Color.White;
            btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNew.Click += new System.EventHandler(this.btnNavigate_Click);
            this.Controls.Add(btnNew);
            rightPos -= btnNew.Width;
            btnNew.AutoSize = false;
            panelContainer.Size = new System.Drawing.Size(rightPos, panelContainer.Size.Height);
            btnNew.Location = new System.Drawing.Point(rightPos, 0);
            btnNew.Size = new System.Drawing.Size(btnNew.Width, panelContainer.Size.Height);
        }

        private void TabNavigate_Click(NavigateTabGroup sender, ContainerControl container)
        {
           panelContainer.Controls.Remove(sender);
           foreach (Control c in panelContainer.Controls)
           {
               NavigateTabGroup tabGroup = (NavigateTabGroup)c;
               if (tabGroup != null)
               {
                   tabGroup.SetInactive();
               }
           }

           foreach (Control c in this.Controls)
           {
               c.ForeColor = System.Drawing.Color.White;
               c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
           }

           sender.Size = new System.Drawing.Size(0, 30);
           sender.Dock = System.Windows.Forms.DockStyle.Bottom;
           panelContainer.Controls.Add(sender);

           if (NavigateEvent != null)
           {
               NavigateEvent(container);
           }
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelContainer.Controls)
            {
                NavigateTabGroup tabGroup = (NavigateTabGroup)c;
                if (tabGroup != null)
                {
                    tabGroup.SetInactive();
                }
            }

            foreach (Control c in this.Controls)
            {
                if (c == sender)
                {
                    c.ForeColor = System.Drawing.Color.Gray;
                    c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
                }
                else
                {
                    c.ForeColor = System.Drawing.Color.White;
                    c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
                }
            }

            if (NavigateEvent != null)
            {
                NavigateButton btnSender = (NavigateButton)sender;
                NavigateEvent(btnSender.ContainerPanel);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
