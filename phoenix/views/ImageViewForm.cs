using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phoenix
{
    public partial class ImageViewForm : Form
    {
        private Bitmap bmpViewer;
        private int percentShow;

        public ImageViewForm(string caption, Bitmap bmp, int percent)
        {
            bmpViewer = bmp;
            percentShow = percent;
            InitializeComponent();
            this.Text = caption;
        }

        private void ImageViewForm_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(500, 500 * bmpViewer.Height / bmpViewer.Width);
            imageViewer.SetBitmap(bmpViewer);
            imageViewer.SetPercent(percentShow);
        }
    }
}
