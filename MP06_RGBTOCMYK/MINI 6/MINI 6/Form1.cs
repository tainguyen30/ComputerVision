using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // tao biến chua đường dẫn cua hinh
            string filehinh = @"C:\Users\Admin\Documents\Visual Studio 2017\Projects\Lena.jpg";

            // tao biến chua hinh bitmap duoc load tu file hinh
            Bitmap hinhgoc = new Bitmap(filehinh);

            // hien thi hinh goc trong picbox
            pictureBox1.Image = hinhgoc;


            List<Bitmap> CMYK = cdCMYK(hinhgoc);
            pictureBox2.Image = CMYK[0];
            pictureBox3.Image = CMYK[1];
            pictureBox4.Image = CMYK[2];
            pictureBox5.Image = CMYK[3];



        }
        // Tạo hàm chuyển đổi CMYK
        public List<Bitmap> cdCMYK(Bitmap hinhgoc)
        {
            List<Bitmap> CMYK = new List<Bitmap>();

            Bitmap C = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap M = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Y = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap K = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    Color pixel = hinhgoc.GetPixel(x, y);

                    byte R = pixel.R; 
                    byte G = pixel.G;

                    byte B = pixel.B;



                    C.SetPixel(x, y, Color.FromArgb(0, G, B));
                    M.SetPixel(x, y, Color.FromArgb(R, 0, B));
                    Y.SetPixel(x, y, Color.FromArgb(R, G, 0));

              
                    byte k = Math.Min(R, Math.Min(G, B));
                    K.SetPixel(x, y, Color.FromArgb(k, k, k));

                }


            CMYK.Add(C);
            CMYK.Add(M);
            CMYK.Add(Y);
            CMYK.Add(K);
            return CMYK;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
