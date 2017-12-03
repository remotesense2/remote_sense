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
                    c.BackColor = System.Drawing.Color.AntiqueWhite;
                }
                else
                {
                    c.BackColor = System.Drawing.Color.LightBlue;
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
            btnNew.Size = new System.Drawing.Size(132, this.Height);
            btnNew.Text = text;
            btnNew.BackColor = System.Drawing.Color.LightBlue;
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
