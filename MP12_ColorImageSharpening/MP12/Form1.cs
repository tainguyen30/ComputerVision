using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load hình .jpg từ file hình gốc cô gái Lena từ thư mục
            Bitmap HinhGoc = new Bitmap(@"C:\Users\Admin\Documents\Visual Studio 2017\Projects\Lena.jpg");

            //Hiển thị hình gốc lên picBox
            picBoxHinhGoc.Image = HinhGoc;

            //Tạo biến chứa hình sắc nét tính từ hàm làm sắc nét
            Bitmap SharpeImage = ColorImageSharpening3x3(HinhGoc);

            //Cho hiển thị kết quả làm sắc ảnh
            picBoxSharpe.Image = SharpeImage;
        }
        public Bitmap ColorImageSharpening3x3(Bitmap HinhGoc)
        {
            int[,] matrix = { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
            //Tạo sẵn 1 hình bitmap để chứa ảnh được làm nét
            Bitmap SharpeImage = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            //Quét ảnh từ x = 1 đến x = width-1 và y = 1 đến y = height-1
            for (int x = 1; x < HinhGoc.Width - 1; x++)
                for (int y = 1; y < HinhGoc.Height - 1; y++)
                {
                    int Rs = 0, Gs = 0, Bs = 0;
                    int SharpR = 0, SharpG = 0, SharpB = 0;

                    //Quét các điểm ảnh trong mặt nạ
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            int R = color.R;
                            int G = color.G;
                            int B = color.B;

                            //Nhân tích chập tất cả điểm ảnh cho mỗi kênh R-G-B tương ứng
                            Rs += R * matrix[i - x + 1, j - y + 1];
                            Gs += G * matrix[i - x + 1, j - y + 1];
                            Bs += B * matrix[i - x + 1, j - y + 1];
                        }
                    //Tính điểm ảnh sắc nét mỗi kênh theo công thức 3.6-7 cho từng kênh màu R-G-B
                    Color color1 = HinhGoc.GetPixel(x, y);
                    int R1 = color1.R;
                    int G1 = color1.G;
                    int B1 = color1.B;

                    SharpR = R1 + Rs;
                    SharpG = G1 + Gs;
                    SharpB = B1 + Bs;

                    if (SharpR < 0)
                        SharpR = 0;
                    else if (SharpR > 255)
                        SharpR = 255;

                    if (SharpG < 0)
                        SharpG = 0;
                    else if (SharpG > 255)
                        SharpG = 255;

                    if (SharpB < 0)
                        SharpB = 0;
                    else if (SharpB > 255)
                        SharpB = 255;
                    //Set điểm ảnh đã làm sắc nét vào ảnh Bitmap
                    SharpeImage.SetPixel(x, y, Color.FromArgb(SharpR, SharpG, SharpB));
                }
            //Trả ảnh làm nét về hàm
            return SharpeImage;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
