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
        string dirImages = "M:\\Pictures\\";
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
                nX = int.Parse(inputX.Text);
                nY = int.Parse(inputY.Text);
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
                                if(inputCol.Text.Length == 0 || clickRight)
                                    pixels[i, j].BackColor = pixels[i, j].BackColor = Color.Transparent;
                                else
                                    pixels[i,j].BackColor = pixels[i,j].BackColor = ColorTranslator.FromHtml("0x" + inputCol.Text);
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
                string name = inputName.Text;
                int scale = 1;

                try
                {
                    scale = int.Parse(inputScale.Text);
                    if (scale * nX > 23101)
                        scale = 23101/nX;
                    else if (scale * nY > 23101)
                        scale = 23101/nY;
                    else if (scale <= 0)
                        scale = 1;
                }catch(FormatException ex)
                {
                    errBox.Show(ex.Message);
                }

                if (name.Length > 0)
                {
                    Bitmap image = new Bitmap(nX*scale, nY*scale);
                    for (int j = 0; j < nY; j++)
                    {
                        for (int i = 0; i < nX; i++)
                        {
                            for (int v = 0; v < scale; v++)
                            {
                                for (int u = 0; u < scale; u++)
                                {
                                    image.SetPixel((i*scale) + u, (j*scale) + v, pixels[i, j].BackColor);
                                }
                            }
                        }
                    }

                    if(!Directory.Exists(dirImages))
                        Directory.CreateDirectory(dirImages);
                    image.Save(dirImages + name + "-" + scale.ToString() + "-.png", ImageFormat.Png);
                    image.Dispose();
                }
            }
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            string name = inputName.Text;

            if(name.Length > 0)
            {
                try
                {
                    string[] files = Directory.GetFiles(dirImages);
                    string fileName = "";

                    foreach (string f in files)
                    {
                        if (f.Contains(name))
                            fileName = f;
                    }

                    Bitmap image = new Bitmap(fileName);

                    string[] nameSplit = fileName.Split('-');

                    errBox.Show(nameSplit[1]);

                    int scale = int.Parse(nameSplit[1]);
                    nY = image.Height / scale;
                    nX = image.Width / scale;
                    generate();

                    for (int j = 0; j < nY; j++)
                    {
                        for (int i = 0; i < nX; i++)
                        {
                            pixels[i, j].BackColor = image.GetPixel(i * scale, j * scale);
                        }
                    }
                    image.Dispose(); // prevents currently in use error
                } catch (ArgumentException ex) {
                    //errBox.Show(ex.Message);
                } catch (FileNotFoundException ex)
                {
                    //errBox.Show(ex.Message);
                }
            }
        }
    }
}



/* Todo list
 * Advanced save and load
 * animation tab (multiple drawings to compare)
 */
