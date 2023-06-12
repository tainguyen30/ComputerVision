using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIN14
{
    public partial class Form1 : Form
    {
        //load hình .png từ file
        Bitmap HinhGoc = new Bitmap(@"E:\vs2022\lena.jpg");
        public Form1()
        {
            InitializeComponent();
            
            // Hiển thị hình RGB gốc
            picBox_HinhGoc.Image = HinhGoc;

        }
        /// <summary>
        /// Khai báo hàm tính toán mức xám theo phương pháp trung bình Average
        /// Công thức: (R + G + B)/3
        /// </summary>
        /// <param name="HinhGoc"></param>
        /// <param name="HinhGoc"></param>
        /// <returns></returns>
        
        public Bitmap ChuyenHinhRGBSangHinhXamAverage(Bitmap HinhGoc)
        {
            Bitmap HinhMucXam = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            // Chú ý: điểm tọa độ gốc (0,0) của hình là điểm góc trái trên cùng của hình
            // Chiều x từ gốc tính về phải, chiều y từ gốc tính xuống dưới

            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    // Lấy điểm ảnh
                    // Đọc giá trị Pixel tại điểm ảnh có vị trí (x, y)

                    Color pixel = HinhGoc.GetPixel(x, y);

                    // Mỗi giá trị chứa 4 giá trị thông tin màu R, G, B

                    Byte R = pixel.R;  // Giá trị kênh màu Red
                    Byte G = pixel.G;  // Giá trị kênh màu Green
                    Byte B = pixel.B;  // Giá trị kênh màu Blue
                   

                    // Tính giá trị mức xám cho điểm ảnh tại (x, y)

                    Byte gray = (byte)((R + G + B) / 3);


                    // Gán giá trị mức xám vừa tính vào hình mức xám
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));


                }
            return HinhMucXam;
        }

        public Bitmap NhanDangDuongBienAnhXamPPSobel(Bitmap HinhXam, int Nguong)
        {
            // int Nguong = Convert.ToInt(tblNguong.Text);

            int[,] Sx =
            {
                {-1, -2, -1},
                {0, 0, 0},
                {1, 2, 1}
            };
            int[,] Sy =
            {
                {-1, 0, 1},
                {-2, 0, 2},
                {-1, 0, 1}
            };
            Bitmap AnhDuongBien = new Bitmap(HinhXam.Width, HinhXam.Height);
            for (int x = 1; x < HinhXam.Width - 1; x++)
                for (int y = 1; y < HinhXam.Height - 1; y++)

                {
                    int gx = 0, gy = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = HinhXam.GetPixel(i, j);

                            int Gr = color.R;
                            gx += Gr * Sx[i - x + 1, j - y + 1];
                            gy += Gr * Sy[i - x + 1, j - y + 1];
                        }
                    }
                    int H = Math.Abs(gx) + Math.Abs(gy);
                    if (H < Nguong)
                        AnhDuongBien.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        AnhDuongBien.SetPixel(x, y, Color.FromArgb(255, 255, 255));

                }
            return AnhDuongBien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị ngưỡng từ giá trị thanh cuộn
            // do Value của thanh cuộn trả về là int, trong khi ngưỡng là kiểu byte
            // nên cần chuyển kiểu int sang kiểu byte

            byte Nguong = (byte)hScrollBar1HinhDuongBien.Value;

            // Cho hiển thị giá trị ngưỡng
            lblNguong.Text = Nguong.ToString();
            Bitmap HinhMucXam = ChuyenHinhRGBSangHinhXamAverage(HinhGoc);
            Bitmap HinhDuongBien = NhanDangDuongBienAnhXamPPSobel(HinhMucXam, Nguong);
            
            picBox_HinhDuongBien.Image = HinhDuongBien;
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Lấy giá trị ngưỡng từ giá trị thanh cuộn
            // do Value của thanh cuộn trả về là int, trong khi ngưỡng là kiểu byte
            // nên cần chuyển kiểu int sang kiểu byte

            byte Nguong = (byte)hScrollBar1HinhDuongBien.Value;

            // Cho hiển thị giá trị ngưỡng
            lblNguong.Text = Nguong.ToString();
            Bitmap HinhMucXam = ChuyenHinhRGBSangHinhXamAverage(HinhGoc);
            Bitmap HinhDuongBien = NhanDangDuongBienAnhXamPPSobel(HinhMucXam, Nguong);

            picBox_HinhDuongBien.Image = HinhDuongBien;
        }

        private void hScrollBar1HinhDuongBien_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picBox_HinhDuongBien_Click(object sender, EventArgs e)
        {

        }
    }
}
