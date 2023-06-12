using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace MP01_HienThiAnhRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Image Path
            string filehinh = @"D:\UTEX\HK2 2022-2023\Thị Giác Máy\Mini Project\1\Lena.jpg";

            // Load Lena picture
            Image<Rgb, byte> original_image = new Image<Rgb, byte>(filehinh);
            Image<Rgb, byte> blue_image = new Image<Rgb, byte>(original_image.Size);
            Image<Rgb, byte> green_image = new Image<Rgb, byte>(original_image.Size);
            Image<Rgb, byte> red_image = new Image<Rgb, byte>(original_image.Size);

            // Each image is a 2D matrix, using 2 loop to determine image pixel from height and width
            for (int i = 0; i < original_image.Height; i++)
                for (int j = 0; j < original_image.Width; j++)
                {

                    // Get pixel value from position (i,j)
                    Rgb pixel = original_image[i, j];

                    // Get Rgb value
                    double b = pixel.Blue;
                    double g = pixel.Green;
                    double r = pixel.Red;

                    // Rgb color channels
                    red_image[i, j] = new Rgb(r, 0, 0);
                    green_image[i, j] = new Rgb(0, g, 0);
                    blue_image[i, j] = new Rgb(0, 0, b);
                }

            // Show image in imagebox
            imgbox.Image = original_image;
            redbox.Image = red_image;
            greenbox.Image = green_image;
            bluebox.Image = blue_image;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void redbox_Click(object sender, EventArgs e)
        {

        }

        private void greenbox_Click(object sender, EventArgs e)
        {

        }
    }
}
