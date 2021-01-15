using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WavesOverlay
{
    public partial class ImageForm : Form
    {
        private CheckBox whenClosed;

        public ImageForm(CheckBox whenClosed)
        {
            InitializeComponent();
            this.whenClosed = whenClosed;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox1.Checked;
        }

        public void updateImage(Image image)
        {
            this.pictureBox1.Image = image;
        }

        private void ImageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            whenClosed.Checked = false;
        }
    }
}
