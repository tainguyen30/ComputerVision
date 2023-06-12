using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap HinhGoc = new Bitmap(@"C:\Users\Admin\Documents\Visual Studio 2017\Projects\Lena.jpg");

            pic_box_rgb.Image = HinhGoc;

            Bitmap SmoothedImage_3x3 = ColorImageSmoothing3x3(HinhGoc);
            Bitmap SmoothedImage_5x5 = ColorImageSmoothing5x5(HinhGoc);
            Bitmap SmoothedImage_7x7 = ColorImageSmoothing7x7(HinhGoc);
            Bitmap SmoothedImage_9x9 = ColorImageSmoothing9x9(HinhGoc);

            pic_box_3x3.Image = SmoothedImage_3x3;
            pic_box_5x5.Image = SmoothedImage_5x5;
            pic_box_7x7.Image = SmoothedImage_7x7;
            pic_box_9x9.Image = SmoothedImage_9x9;

        }
        public Bitmap ColorImageSmoothing3x3 (Bitmap HinhGoc)
        {
            Bitmap SmoothedImage_3x3 = new Bitmap (HinhGoc.Width, HinhGoc.Height);

            for (int x = 1; x< HinhGoc.Width - 1; x++)
                for ( int y = 1; y < HinhGoc.Height -1; y++)
                {   
                    // Cac bien nay dung de chua cac gia tri cong don cua cac diem anh nam trong mat na.
                    // Do vay phai khai bao kieu int de co the chua duoc gia tri cong don cac pixel

                    int Rs = 0, Gs = 0, Bs = 0;
                    //Tien hanh quet cac diem trong mat na
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y-1; j <= y+1; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;   
                            byte B = color.B;
                            //Cong don tat ca diem anh
                            Rs += R;
                            Gs += G;
                            Bs += B;

                        }
                    byte K = 3 * 3;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    SmoothedImage_3x3.SetPixel(x,y,Color.FromArgb(Rs, Gs, Bs));

                }

            return HinhGoc;
        }
        public Bitmap ColorImageSmoothing5x5(Bitmap HinhGoc)
        {
            Bitmap SmoothedImage_5x5 = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 2; x < HinhGoc.Width - 2; x++)
                for (int y = 2; y < HinhGoc.Height - 2; y++)
                {
                    // Cac bien nay dung de chua cac gia tri cong don cua cac diem anh nam trong mat na.
                    // Do vay phai khai bao kieu int de co the chua duoc gia tri cong don cac pixel

                    int Rs = 0, Gs = 0, Bs = 0;

                    for (int i = x - 2; i <= x + 2; i++)
                        for (int j = y - 2; j <= y + 2; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Cong don tat ca diem anh
                            Rs += R;
                            Gs += G;
                            Bs += B;

                        }
                    byte K = 5 * 5;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    SmoothedImage_5x5.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));

                }

            return HinhGoc;
        }
        public Bitmap ColorImageSmoothing7x7(Bitmap HinhGoc)
        {
            Bitmap SmoothedImage_7x7 = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 3; x < HinhGoc.Width - 3; x++)
                for (int y = 3; y < HinhGoc.Height - 3; y++)
                {
                    // Cac bien nay dung de chua cac gia tri cong don cua cac diem anh nam trong mat na.
                    // Do vay phai khai bao kieu int de co the chua duoc gia tri cong don cac pixel

                    int Rs = 0, Gs = 0, Bs = 0;

                    for (int i = x - 3; i <= x + 3; i++)
                        for (int j = y - 3; j <= y + 3; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Cong don tat ca diem anh
                            Rs += R;
                            Gs += G;
                            Bs += B;

                        }
                    byte K = 7*7;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    SmoothedImage_7x7.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));

                }

            return HinhGoc;
        }
        public Bitmap ColorImageSmoothing9x9(Bitmap HinhGoc)
        {
            Bitmap SmoothedImage_9x9 = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 4; x < HinhGoc.Width - 4; x++)
                for (int y = 4; y < HinhGoc.Height - 4; y++)
                {
                    // Cac bien nay dung de chua cac gia tri cong don cua cac diem anh nam trong mat na.
                    // Do vay phai khai bao kieu int de co the chua duoc gia tri cong don cac pixel

                    int Rs = 0, Gs = 0, Bs = 0;

                    for (int i = x - 4; i <= x + 4; i++)
                        for (int j = y - 4; j <= y + 4; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;
                            //Cong don tat ca diem anh
                            Rs += R;
                            Gs += G;
                            Bs += B;

                        }
                    byte K = 9 * 9;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    SmoothedImage_9x9.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));

                }

            return HinhGoc;
        }

    }
}
