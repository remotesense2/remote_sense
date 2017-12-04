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
        private int buttonLeftPos = 0;
        private bool hasActive = false;

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
                    c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                }
                else
                {
                    c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(185)))), ((int)(((byte)(205)))));
                }
            }

            if (NavigateEvent != null)
            {
                NavigateEvent(button.ContainerPanel);
            }
        }

        public void AddPanel(string text, ContainerControl container)
        {
            NavigateButton btnNew = new NavigateButton(container);
            btnNew.Location = new System.Drawing.Point(buttonLeftPos, 0);
            btnNew.Size = new System.Drawing.Size(100, this.Height);
            btnNew.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            btnNew.Text = text;
            btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(185)))), ((int)(((byte)(205)))));
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNew.Click += new System.EventHandler(this.btnNavigate_Click);
            this.Controls.Add(btnNew);
            buttonLeftPos += btnNew.Width;

            if (!hasActive)
            {
                hasActive = true;
                SetButtonActive(btnNew);
            }
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            SetButtonActive((NavigateButton)sender);
        }
    }
}
