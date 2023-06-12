using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI_3
{
    public partial class Form1 : Form
    {
        Bitmap HinhGoc;
        public Form1()
        {
            InitializeComponent();
            // Load hinh .jpg tu file
            HinhGoc = new Bitmap(@"C:\Users\Admin\Documents\Visual Studio 2017\Projects\Lena.jpg");
            //Cho hien thi len picbox
            pictureBox1.Image = HinhGoc;

            pictureBox2.Image = PPLightness(HinhGoc);

            pictureBox3.Image = PPAverage(HinhGoc);

            pictureBox4.Image = PPLuminance(HinhGoc);
            // tách hình nhị phân và cho hiển thị
            // giả sử ngưỡng cho là 100
            pictureBox5.Image = PPhinhnhiphan(HinhGoc, 100);
         
        }
        // CO 3 PP TINH MUC XAM CHO ANH MAU rgb . liGHTNESS, AVERAGE,LUMINANCE

            /// <summary>
            /// KHAI BÁO HÀM TÍNH TOÁN MỨC XÁM THEO  PP LIGHTNESS
            /// </summary>
            /// <param name="HinhGoc"></param>
            /// <returns></returns>
        public Bitmap PPLightness(Bitmap HinhGoc)
        {
            Bitmap HinhMucXam = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            //DIEM GOC TOA DO(0,0) CUA HINH LA DIEM GOC TRAI TREN CUNG CUA HINH, CHIEU X SE TINH TU X VE PHAI
            // CHIEU Y TINH TU GOC XUONG DUOI


            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    //Lay diem anh
                    Color pixel = HinhGoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //Tinh gia tri muc xam cho diem anh tai (x,y)
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    byte gray = (byte)((max + min) / 2);   // KHAI BÁO ÉP 
      //  GRAY ĐƯỢC KHAI BÁO LÀ KIỂU BYTE , KẾT QUẢ PHÉP TÍNH LÀ KIỂU SỐ THỰC. CẦN PHẢI ÉP KQ PHÉP TÍNH VỀ KIỂU BYTE   



                   //gan gia tri muc xam vua tinh vao hhinh muc xam
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            return HinhMucXam;

        }

        /// <summary>
        /// KHAI BÁO HÀM TÍNH TOÁN MỨC XÁM THEO  PP average
        /// </summary>
        /// <param name="HinhGoc"></param>
        /// <returns></returns>
        public Bitmap PPAverage(Bitmap HinhGoc)
        {
            Bitmap HinhMucXam = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    //Lay diem anh
                    Color pixel = HinhGoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //Tinh gia tri muc xam cho diem anh tai (x,y)
                    
                    byte gray = (byte)((R+G+B) / 3);
                    //gan gia tri muc xam vua tinh vao hhinh muc xam
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            return HinhMucXam;

        }
        /// <summary>
        /// KHAI BÁO HÀM TÍNH TOÁN MỨC XÁM THEO  PP Luminance
        /// </summary>
        /// <param name="HinhGoc"></param>
        /// <returns></returns>

        public Bitmap PPLuminance(Bitmap HinhGoc)
        {
            Bitmap HinhMucXam = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    //Lay diem anh
                    Color pixel = HinhGoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //Tinh gia tri muc xam cho diem anh tai (x,y)

                    byte gray = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);
                    //gan gia tri muc xam vua tinh vao hhinh muc xam
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(gray, gray, gray));

                }
            return HinhMucXam;
        }
//Chuyển ảnh màu RGB sang  ảnh nhị phân đen trắng, tức là ảnh trong đó chỉ có các pixel có gtri là 0(đen) hoặc 255(trắng)
       
            //SAU KHI ẢNH ĐƯỢC CHUYỂN SANG MỨC XÁM. TA THIẾT LẬP 1 NGƯỠNG ĐỂ PHÂN CÁC ĐIỂM ẢNH THÀNH 2 LOẠI
            // MÀU ĐEN NẾU ĐIỂM ẢNH MỨC XÁM CÓ GIÁ TRỊ NHỎ HƠN NGƯỠNG VÀ NGƯỢC LẠI
        public Bitmap PPhinhnhiphan(Bitmap HinhGoc, byte nguong)
        {
            Bitmap HinhNhiPhan = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            for (int x = 0; x < HinhGoc.Width; x++)
                for (int y = 0; y < HinhGoc.Height; y++)
                {
                    //Lay diem anh
                    Color pixel = HinhGoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    //Tinh gia tri muc xam cho diem anh tai (x,y)

                    byte NP = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);
                    //Phân loại điểm ảnh sang nhị phân dựa vào giá trị ngưỡng

                    if (NP < nguong)
                        NP = 0;
                    else
                        NP = 255;


                    //gan gia tri nhi phan  vua tinh vao hinh nhi phan
                    HinhNhiPhan.SetPixel(x, y, Color.FromArgb(NP, NP, NP));

                }
            return HinhNhiPhan;
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HINHGOC_Click(object sender, EventArgs e)
        {

        }
        //ĐỂ DỄ DÀNG THAY ĐỔI GIÁ TRỊ NGƯỠNG TA CÓ THỂ DÙNG THAN CUỘN. min=0 max =255
        //sd sự kiện thay đổi giá trị thanh cuộn để điều chỉnh giá trị ngưỡng 
        private void vScrollBarHinhNhiPhan_ValueChanged(object sender, EventArgs e)
        {
            //lấy giá trị ngưỡng từ giá trị của thanh cuộn
            byte nguong = (byte)vScrollBarHinhNhiPhan.Value;

            // do value của thanh cuộn trả về là int  trong khi ngưỡng là kiểu byte , ép kiểu int về kiểu byte


            // tính hình nhị phân và cho hiển thị

            pictureBox5.Image = PPhinhnhiphan(HinhGoc, nguong);
            // cho hiển thị giá trị ngưỡng
            lblNguong.Text = nguong.ToString();
        }
    }
}
