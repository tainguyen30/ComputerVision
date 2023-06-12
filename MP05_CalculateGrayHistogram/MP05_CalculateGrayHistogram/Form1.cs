using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace MP05_CalculateGrayHistogram
{
    public partial class Form1 : Form
    {
        Bitmap original;
        public Form1()
        {
            InitializeComponent();
            original = new Bitmap(@"D:\Code\Adruino\Pycharm\Project\Image Processing\Lena.jpg");
            picbox1.Image = original;
            Bitmap HinhMucXam = PPLightness(original);
            picbox2.Image = HinhMucXam;
            // GỌI CÁC HÀM ĐÃ VIẾT ĐỂ VẼ BĐỒ HISTOGRAM

            // tính histogram 
            double[] histogram = TinhHistogram(HinhMucXam);
            //chuyển đổi kiểu dữ liệu
            PointPairList points = ChuyenDoiHistogram(histogram);

            // vẽ và hthi bđồ
            zgHistogram.GraphPane = BieuDo(points);
            zgHistogram.Refresh();
        }

    public Bitmap PPLightness(Bitmap original)
    {
        Bitmap HinhMucXam = new Bitmap(original.Width, original.Height);

        //DIEM GOC TOA DO(0,0) CUA HINH LA DIEM GOC TRAI TREN CUNG CUA HINH, CHIEU X SE TINH TU X VE PHAI
        // CHIEU Y TINH TU GOC XUONG DUOI


        for (int x = 0; x < original.Width; x++)
            for (int y = 0; y < original.Height; y++)
            {
                //Lay diem anh
                Color pixel = original.GetPixel(x, y);
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

        // tính histogram của ảnh xám
        public double[] TinhHistogram(Bitmap HinhMucXam)
        {
            double[] histogram = new double[256];
            // MỖI PIXEL MỨC XÁM CÓ GIÁ TRỊ 0-255
            // KHAI BÁO MẢNG 256 PHẦN TỬ, CHỨA SỐ ĐẾM CÁC PIXEL CÓ CÙNG MỨC XÁM TRONG ẢNH
            // dùng double vì tổng số đếm có thể >>, phụ thuộc kích thước ảnh



            for (int x = 0; x < HinhMucXam.Width; x++)
                for (int y = 0; y < HinhMucXam.Height; y++)
                {
                    Color color = HinhMucXam.GetPixel(x, y);
                    byte gray = color.R;
                    // trong hình mức xám, gtri kênh R cũng giống kênh G, B

                    // gtri gray tính ra là phần tử thứ gray trong mảng  histogram. 
                    //tăng số đếm của phần tử thứ gray lên 1
                    histogram[gray]++;
                }
            return histogram;

        }

        //================
        // DÙNG THƯ VIỆN ZG ĐỂ VẼ BIỂU ĐỒ HISTOGRAM

        //PointPairList là kieu du lieu của ZG để vẽ bđồ
        PointPairList ChuyenDoiHistogram(double[] histogram)
        {
            PointPairList points = new PointPairList();
            for (int i = 0; i < histogram.Length; i++)
            {
                points.Add(i, histogram[i]);

                //i tương ứng trục ngang (0-255
                //histogram[i] -> trục đứng (là số pixel mức xám)

            }
            return points;
        }

        // thiết lập biểu đồ trong zedgraph
        public GraphPane BieuDo(PointPairList histogram)
        {
            GraphPane gp = new GraphPane(); // GraphPane là đối tượng biểu đồ trng ZedGr..
            gp.Title.Text = @" BIỂU ĐỒ HISTOGRAM";     // tên
            gp.Rect = new Rectangle(0, 0, 700, 500);   //kHUNG CHỨA BđỒ


            //THIẾT LẬP TRỤC NGANG
            gp.XAxis.Title.Text = @"GIÁ TRỊ MỨC XÁM CÁC ĐIỂM ẢNH";
            gp.XAxis.Scale.Min = 0;                // nhỏ nhất là 0

            gp.XAxis.Scale.Max = 255;              // lớn nhất là 255

            gp.XAxis.Scale.MajorStep = 5;  // mỗi bước chính = 5
            gp.XAxis.Scale.MinorStep = 1;  // mỗi bước trong 1 bước chính =1


            // tương tự trục đứng

            gp.YAxis.Title.Text = @"SỐ ĐIỂM ẢNH CÓ CÙNG MỨC XÁM";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 1000;  // SỐ NÀY PHẢI > KÍCH THƯỚC ẢNH (w x h)



            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 1;


            // dùng biểu đồ dạng bar bdiễn histogram
            gp.AddBar("HISTOGRAM", histogram, Color.OrangeRed);



            return gp;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zgHistogram_Load(object sender, EventArgs e)
        {

        }
    }
}
