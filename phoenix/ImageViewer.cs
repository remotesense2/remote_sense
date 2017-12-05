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
    public partial class ImageViewer : UserControl
    {
        private Bitmap bmpViewer;
        private int zoomStep = 20;
        private Point pointStart;
        private bool isDragged = false;
        public int PercentShow = 100;

        public ImageViewer()
        {
            InitializeComponent();
        }

        public void SetBitmap(Bitmap bmp)
        {
            bmpViewer = bmp;
            pictureBoxView.Image = bmpViewer;

            int x_percent = 100 * this.Width / bmpViewer.Width;
            int y_percent = 100 * this.Height / bmpViewer.Height;
            SetPercent(Math.Min(x_percent, y_percent));
        }

        public void SetPercent(int percent)
        {
            PercentShow = percent;

            this.pictureBoxView.Width = (int)(bmpViewer.Width * PercentShow / 100);
            this.pictureBoxView.Height = (int)(bmpViewer.Height * PercentShow / 100);
            this.pictureBoxView.Location = new System.Drawing.Point((this.Size.Width - this.pictureBoxView.Size.Width) / 2,
                                                                    (this.Size.Height - this.pictureBoxView.Size.Height) / 2);
            this.pictureBoxView.Focus();
        }

        private void pictureBoxView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointStart = Cursor.Position;
                isDragged = true;
            }
            this.pictureBoxView.Focus();
        }

        private void pictureBoxView_MouseWheel(object sender, MouseEventArgs e)
        {
            if (bmpViewer == null)
                return;

            int original_width = this.pictureBoxView.Width;
            int original_height = this.pictureBoxView.Height;
            float percent = (float)bmpViewer.Height / bmpViewer.Width;
            if (e.Delta > 0)
            {
                if (PercentShow >= 200)
                    return;

                PercentShow += 10;

                this.pictureBoxView.Width = bmpViewer.Width * PercentShow / 100;
                this.pictureBoxView.Height = bmpViewer.Height * PercentShow / 100;
            }
            if (e.Delta < 0)
            {
                if (PercentShow <= 20)
                    return;

                PercentShow -= 10;
            }

            this.pictureBoxView.Width = bmpViewer.Width * PercentShow / 100;
            this.pictureBoxView.Height = bmpViewer.Height * PercentShow / 100;

            int new_x = (int)((double)e.Location.X * (original_width - this.pictureBoxView.Width) / original_width);
            int new_y = (int)((double)e.Location.Y * (original_height - this.pictureBoxView.Height) / original_height);
            this.pictureBoxView.Location = new Point(this.pictureBoxView.Location.X + new_x, this.pictureBoxView.Location.Y + new_y);
        }

        private void pictureBoxView_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                int x = this.pictureBoxView.Location.X + Cursor.Position.X - pointStart.X;
                int y = this.pictureBoxView.Location.Y + Cursor.Position.Y - pointStart.Y;
                this.pictureBoxView.Location = new Point(x, y);
                pointStart = Cursor.Position;
            }
        }

        private void pictureBoxView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragged = false;
            }
        }

        private void pictureBoxView_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }

        private void pictureBoxView_Click(object sender, EventArgs e)
        {

        }
    }
}
