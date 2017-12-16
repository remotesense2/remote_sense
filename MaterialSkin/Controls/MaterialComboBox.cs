using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public partial class MaterialComboBox : ComboBox, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        public MaterialComboBox()
        {
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.FlatStyle = FlatStyle.Flat;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.ItemHeight = 50;
            // 
            // MaterialComboBox
            // 
            this.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MaterialComboBox_DrawItem);
            this.ResumeLayout(false);

        }

        private void MaterialComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
           
        }
    }
}
