using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phoenix
{
    public partial class NavigateButton : System.Windows.Forms.Button
    {
        public ContainerControl ContainerPanel;

        public NavigateButton(ContainerControl container)
        {
            ContainerPanel = container;
        }
    }

    public partial class NavigateTabGroup : System.Windows.Forms.Panel
    {
        private int buttonLeftPos = 0;

        private System.Windows.Forms.Timer timerExec;
        private NavigateButton activeButton = null;

        public delegate void NavigateTabEventHandler(NavigateTabGroup sender, ContainerControl container);
        public event NavigateTabEventHandler NavigateTabEvent;

        public NavigateTabGroup()
        {
            timerExec = new System.Windows.Forms.Timer();
            timerExec.Tick += new EventHandler(this.timerExec_Tick);
            timerExec.Start();
        }

        public void AddPanel(string text, ContainerControl container, bool active = false)
        {
            NavigateButton btnNew = new NavigateButton(container);
            btnNew.Location = new System.Drawing.Point(buttonLeftPos, 0);
            btnNew.AutoSize = true;
            btnNew.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            btnNew.Text = text;
            btnNew.ForeColor = System.Drawing.Color.White;
            btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNew.Click += new System.EventHandler(this.btnNavigate_Click);
            this.Controls.Add(btnNew);
            int width = btnNew.Width;
            buttonLeftPos += width;
            btnNew.AutoSize = false;
            btnNew.Size = new System.Drawing.Size(width, this.Size.Height);

            if (active)
            {
                activeButton = btnNew;
            }
        }

        private void timerExec_Tick(object sender, EventArgs e)
        {
            if (activeButton != null)
            {
                SetButtonActive(activeButton);
            }
            timerExec.Stop();
        }

        public void SetInactive()
        {
            foreach (Control c in this.Controls)
            {
                c.ForeColor = System.Drawing.Color.White;
                c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            }
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            SetButtonActive((NavigateButton)sender);
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

            if (NavigateTabEvent != null)
            {
                NavigateTabEvent(this, button.ContainerPanel);
            }
        }
    }
}
