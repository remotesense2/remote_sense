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
        public NavigatePanel()
        {
            InitializeComponent();
        }

        public delegate void NavigateEventHandler(ContainerControl container);
        public event NavigateEventHandler NavigateEvent;

        private void NavigatePanel_Load(object sender, EventArgs e)
        {
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
            tab.NavigateTabEvent += new phoenix.NavigateTabGroup.NavigateTabEventHandler(this.TabNavigate_Click);
            panelContainer.Controls.Add(tab);
            return tab;
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

           sender.Size = new System.Drawing.Size(0, 30);
           sender.Dock = System.Windows.Forms.DockStyle.Bottom;
           panelContainer.Controls.Add(sender);

           if (NavigateEvent != null)
           {
               NavigateEvent(container);
           }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
