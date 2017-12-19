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

        public Point MouseLocation { get; set; }

        private const int ITEM_PADDING = 3;

        public MaterialComboBox()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);

            MouseLocation = new Point(-1, -1);
            MouseState = MouseState.OUT;
            MouseEnter += delegate
            {
                MouseState = MouseState.HOVER;
            };
            MouseLeave += delegate
            {
                MouseState = MouseState.OUT;
                MouseLocation = new Point(-1, -1);
                Invalidate();
            };
            MouseDown += delegate { MouseState = MouseState.DOWN; };
            MouseUp += delegate { MouseState = MouseState.HOVER; };
            MouseMove += delegate(object sender, MouseEventArgs args)
            {
                MouseLocation = args.Location;
            };
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Font = SkinManager.ROBOTO_MEDIUM_10;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.DropDownHeight = 2000;
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            string displayText = this.Items[e.Index].ToString();
            SizeF stringSize = e.Graphics.MeasureString(displayText, this.Font);
            e.ItemHeight = (int)stringSize.Height + ITEM_PADDING * 2 + ITEM_PADDING;
            e.ItemWidth = (int)stringSize.Width;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Bounds.Height == 0)
                return;

            var b = new Bitmap(e.Bounds.Width, e.Bounds.Height);
            var g = Graphics.FromImage(b);

            //always draw default background
            g.FillRectangle(new SolidBrush(SkinManager.GetApplicationBackgroundColor()), new Rectangle(new Point(e.Bounds.X, 0), e.Bounds.Size));

            if (e.State.HasFlag(DrawItemState.ComboBoxEdit))
            {
                g.DrawString(this.Text, SkinManager.ROBOTO_MEDIUM_10, SkinManager.GetPrimaryTextBrush(),
                    new Rectangle(e.Bounds.X + ITEM_PADDING, ITEM_PADDING, e.Bounds.Width - 2 * ITEM_PADDING, e.Bounds.Height),
                    getStringFormat());
            }

            if (e.State.HasFlag(DrawItemState.Selected))
            {
                //selected background
                g.FillRectangle(SkinManager.GetFlatButtonPressedBackgroundBrush(), new Rectangle(new Point(e.Bounds.X, 0), e.Bounds.Size));
            }
            else if (e.Bounds.Contains(MouseLocation) && MouseState == MouseState.HOVER)
            {
                //hover background
                g.FillRectangle(SkinManager.GetFlatButtonHoverBackgroundBrush(), new Rectangle(new Point(e.Bounds.X, 0), e.Bounds.Size));
            }

            if (e.Index >= 0)
            {
                String itemText = this.Items[e.Index].ToString();
                g.DrawString(itemText, SkinManager.ROBOTO_MEDIUM_10, SkinManager.GetPrimaryTextBrush(),
                     new Rectangle(e.Bounds.X + ITEM_PADDING, ITEM_PADDING, e.Bounds.Width - 2 * ITEM_PADDING, e.Bounds.Height - 2 * ITEM_PADDING),
                     getStringFormat());
            }

            e.Graphics.DrawImage((Image)b.Clone(), new Point(0, e.Bounds.Location.Y));
            e.DrawFocusRectangle();
            g.Dispose();
            b.Dispose();
        }

        private StringFormat getStringFormat()
        {
            return new StringFormat
            {
                FormatFlags = StringFormatFlags.LineLimit,
                Trimming = StringTrimming.EllipsisCharacter,
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };
        }
    }
}
