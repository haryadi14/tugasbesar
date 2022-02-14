using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasbesar
{
    public partial class PelangganButton : PictureBox
    {
        public PelangganButton()
        {
            InitializeComponent();
        }
        private Image NormalImage;
        private Image HoverImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }

        public Image ImageHover
        {
            get { return HoverImage; }
            set { HoverImage = value; }
        }

        private void CustomerButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void CustomerButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }

        private void PelangganButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;

        }

        private void PelangganButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;

        }
    }
}
