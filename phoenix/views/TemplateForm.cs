using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace phoenix.views
{
    public partial class TemplateForm : MaterialForm
    {
        public TemplateForm(string text, System.Drawing.Size contentSize)
        {
            InitializeComponent();
            this.Text = text;
            this.Size = new System.Drawing.Size(contentSize.Width + 2, contentSize.Height + 64);
            MaterialSkinManager.Instance.AddFormToManage(this);
        }


        public void AddContent(Control ctrl)
        {
            panelContent.Controls.Add(ctrl);
        }
    }
}
