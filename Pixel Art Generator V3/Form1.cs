using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

// allocate MessageBox namespace to errBox for my sanity
using errBox = System.Windows.Forms.MessageBox;

namespace Pixel_Art_Generator_V3
{
    public partial class Form1 : Form
    {
        Panel pGrid = new Panel();
        Pixel[,] pixels;
        int nX, nY;
        bool generated = false;

        bool clickPressed = false;
        bool clickRight = false;

        public Form1()
        {
            InitializeComponent();
            
            this.MouseDown += Clicked;
            this.MouseUp += UnClicked;
        }

        private void bGen_Click(object sender, EventArgs e)
        {
            bool valid = false;

            try
            {
                nX = int.Parse(xInput.Text);
                nY = int.Parse(yInput.Text);
                valid = true;
            }
            catch (FormatException ex)
            {
                errBox.Show(ex.Message);
            }

            if (valid)
            {
                generate();
            }
        }

        private void generate()
        {
            pGrid.Dispose();
            pGrid = new Panel();
            pixels = new Pixel[nX, nY];

            for (int j = 0; j < nY; j++)
            {
                for (int i = 0; i < nX; i++)
                {
                    pixels[i, j] = new Pixel(i, j);
                    pixels[i, j].MouseDown += Clicked;
                    pixels[i, j].MouseUp += UnClicked;

                    pGrid.Controls.Add(pixels[i, j]);
                }
            }

            pGrid.Size = new Size(pixels[0,0].getWidth() * nX, pixels[0,0].getWidth() * nY);
            pGrid.Location = new Point(12, 41);
            this.Controls.Add(pGrid);
            generated = true;
        }

        private void Tick(object sender, EventArgs e)
        {
            if (clickPressed)
            {
                if (generated)
                {
                    int relativeX = Cursor.Position.X - this.Left - pGrid.Left;
                    int relativeY = Cursor.Position.Y - this.Top - pGrid.Top - 30;
                    Point relativePos = new Point(relativeX, relativeY);
                    for (int j = 0; j < nY; j++)
                    {
                        for (int i = 0; i < nX; i++)
                        {
                            //testing.Text = relativePos.ToString();
                            if(pixels[i,j].Top < relativeY
                                && pixels[i, j].Right > relativeX
                                && pixels[i, j].Bottom > relativeY
                                && pixels[i, j].Left < relativeX)
                            {
                                if(colInput.Text.Length == 0 || clickRight)
                                    pixels[i, j].BackColor = pixels[i, j].BackColor = Color.Transparent;
                                else
                                    pixels[i,j].BackColor = pixels[i,j].BackColor = ColorTranslator.FromHtml("0x" + colInput.Text);
                            }
                        }
                    }
                }
            }
        }

        void Clicked(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            clickPressed = true;
            if (me.Button.Equals(MouseButtons.Right))
                clickRight = true;
        }

        void UnClicked(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            clickPressed = false;
            if (me.Button.Equals(MouseButtons.Right))
                clickRight = false;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (generated)
            {
                string name = nameInput.Text;
                if (name.Length > 0)
                {
                    Bitmap image = new Bitmap(nX, nY);
                    for (int j = 0; j < nY; j++)
                    {
                        for (int i = 0; i < nX; i++)
                        {
                            image.SetPixel(i, j, pixels[i, j].BackColor);
                        }
                    }
                    image.Save(name + ".png", ImageFormat.Png);
                    image.Dispose();
                }
            }
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;

            if(name.Length > 0)
            {
                try
                {
                    Bitmap image = new Bitmap(name + ".png");
                    nY = image.Height;
                    nX = image.Width;
                    generate();

                    for (int j = 0; j < nY; j++)
                    {
                        for (int i = 0; i < nX; i++)
                        {
                            pixels[i, j].BackColor = image.GetPixel(i, j);
                        }
                    }
                    image.Dispose(); // prevents currently in use error
                } catch (ArgumentException ex) {
                    errBox.Show(ex.Message);
                } catch (FileNotFoundException ex)
                {
                    errBox.Show(ex.Message);
                }
            }
        }
    }
}



/* Todo list
 * Save scaling
 * Advanced save and load
 * animation tab (multiple drawings to compare)
 */
