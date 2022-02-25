using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pixel_Art_Generator_V3
{
    internal class Pixel : Panel
    {
        private int width = 20;

        public Pixel(int i, int j)
        {
            this.Size = new Size(width,width);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Location = new Point(i * width, j * width);
            this.BackColor = Color.Transparent;
        }

        public int getWidth()
        {
            return this.width;
        }
    }
}
