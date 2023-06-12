using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project_13
{
    public partial class Form1 : Form
    {
        Bitmap HinhGoc = new Bitmap(@"C:\Users\Admin\Documents\Tai Lieu UTE\XLA\Projects\Lena.jpg");
        
        public Form1()
        {
            InitializeComponent();
            
            pic_box_rgb.Image = HinhGoc;
           

        }

        private void label4_Click(object sender, EventArgs e)
        {


            Bitmap Seg_Img = new Bitmap(HinhGoc.Width, HinhGoc.Height);
            int x1 = Convert.ToInt16(text_box_x1.Text);
            int x2 = Convert.ToInt16(text_box_x2.Text);
            int y1 = Convert.ToInt16(text_box_y1.Text);
            int y2 = Convert.ToInt16(text_box_y2.Text);
            int nguong = Convert.ToInt16(textBox1.Text);

            double Rs =0, Gs = 0, Bs = 0;


            for (int a=x1;a<=x2;a++)
                for (int b=y1;b<=y2;b++)

                {
                   Color pixel = HinhGoc.GetPixel(a, b);
                    Rs += pixel.R;
                    Gs += pixel.G;
                    Bs += pixel.B;

                }
            double size = Math.Abs(x2-x1)*Math.Abs(y2-y1);  
            double aRs = Rs/size;
            double aGs = Gs/size;
            double aBs = Bs/size;

            
            for (int x =0; x <HinhGoc.Width; x++) 
                for (int y = 0; y<HinhGoc.Height; y++)
                {
                    Color pixel_2 = HinhGoc.GetPixel(x, y);
                    byte R_2 = pixel_2.R;
                    byte G_2 = pixel_2.G;
                    byte B_2 = pixel_2.B;

                    double D = Math.Sqrt((R_2 - aRs)*(R_2-aRs)+(G_2 - aGs)*(G_2-aGs)+(B_2 - aBs)*(B_2 - aBs));

                    if (D > nguong)
                    
                        Seg_Img.SetPixel(x,y,Color.FromArgb(R_2, G_2, B_2));
                    
                    else
                    
                        Seg_Img.SetPixel(x,y,Color.FromArgb(255,255,255));
                    
                }
            pic_box_seg.Image = Seg_Img;

        }

        
    }
}
