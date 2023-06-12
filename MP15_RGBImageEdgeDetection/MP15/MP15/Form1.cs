using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP15
{
    public partial class Form1 : Form
    {
        //Load hình từ file
        Bitmap HinhGoc = new Bitmap(@"E:\vs2022\lena.jpg");
        public Form1()
        {
            InitializeComponent();
            //Hiển thị hình gốc lên picBox
            picBoxHinhGoc.Image = HinhGoc;
        }
        public Bitmap NhanDangDuongBienAnhRGBppSobel(Bitmap HinhGoc, int Level)
        {
            int[,] Sx =
            {
                { -1, -2, -1}, { 0, 0, 0}, { 1, 2, 1}
            };
            int[,] Sy =
            {
                { -1, 0, -1}, {-2,  0, 2}, { -1, 0, 1}
            };
            Bitmap AnhDuongBien = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            for (int x = 1; x < HinhGoc.Width - 1; x++)
                for (int y = 1; y < HinhGoc.Height - 1; y++)
                {
                    int gxx = 0, gyy = 0, gxy = 0, gxR = 0, gxG = 0, gxB = 0, gyR = 0, gyG = 0, gyB = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            int Gr = color.R;
                            int Gg = color.G;
                            int Gb = color.B;
                            gxR += Gr * Sx[i - x + 1, j - y + 1];
                            gyR += Gr * Sy[i - x + 1, j - y + 1];
                            gxG += Gg * Sx[i - x + 1, j - y + 1];
                            gyG += Gg * Sy[i - x + 1, j - y + 1];
                            gxB += Gb * Sx[i - x + 1, j - y + 1];
                            gyB += Gb * Sy[i - x + 1, j - y + 1];
                        }
                    //Tính các giá trị gxx,gyy,gxy
                    //gxx = Math.Abs(gxR)^2 + Math.Abs(gxG)^2 + Math.Abs(gxB)^2
                    gxx = Math.Abs(gxR) ^ 2 + Math.Abs(gxG) ^ 2 + Math.Abs(gxB) ^ 2;
                    gyy = Math.Abs(gyR) ^ 2 + Math.Abs(gyG) ^ 2 + Math.Abs(gyB) ^ 2;
                    gxy = ((gxR * gyR) + (gxG * gyG) + (gxB * gyB));
                    //Tính góc theta. Dùng Atan2 để tính Theta để tránh trường hợp mẫu số (gxx - gyy) = 0
                    double theta = 0.5 * Math.Atan2((2 * gxy), (gxx - gyy));
                    //Tính F0
                    double F0 = Math.Sqrt(0.5 * ((gxx + gyy) + (gxx - gyy) * Math.Cos(2 * theta) + 2 * gxy * Math.Sin(2 * theta)));
                    //So sánh F0 với ngưỡng để xác định điểm đang xét là biên (Edge) hay nền (Backgroud)
                    if (F0 <= Level)
                        AnhDuongBien.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        AnhDuongBien.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return AnhDuongBien;
        }
        private void label1_click(object sender, EventArgs e)
        {

        }

        private void lblHinhDuongBien_Click(object sender, EventArgs e)
        {
            //Lấy giá trị ngưỡng từ giá trị của thanh cuộn do value của thanh cuộn trả về là int, trong khi ngưỡng là kiểu byte
            //Do đó ta cần đổi kiểu int về kiểu byte
            byte Level = (byte)hScrollBar1.Value;
            //Cho hiển thị giá trị ngưỡng
            lblLevel.Text = Level.ToString();
            Bitmap HinhDuongBien = NhanDangDuongBienAnhRGBppSobel(HinhGoc, Level);
            picBoxHinhDuongBien.Image = HinhDuongBien;
        }
    }
}
