namespace mini_project_13
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_box_rgb = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_box_seg = new System.Windows.Forms.PictureBox();
            this.text_box_x1 = new System.Windows.Forms.TextBox();
            this.text_box_y1 = new System.Windows.Forms.TextBox();
            this.text_box_x2 = new System.Windows.Forms.TextBox();
            this.text_box_y2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblnguong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_rgb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_seg)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_box_rgb
            // 
            this.pic_box_rgb.Location = new System.Drawing.Point(21, 49);
            this.pic_box_rgb.Name = "pic_box_rgb";
            this.pic_box_rgb.Size = new System.Drawing.Size(426, 387);
            this.pic_box_rgb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_box_rgb.TabIndex = 0;
            this.pic_box_rgb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hinh mau RGB goc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hinh sau khi Segmentation";
            // 
            // pic_box_seg
            // 
            this.pic_box_seg.Location = new System.Drawing.Point(589, 49);
            this.pic_box_seg.Name = "pic_box_seg";
            this.pic_box_seg.Size = new System.Drawing.Size(426, 387);
            this.pic_box_seg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_box_seg.TabIndex = 3;
            this.pic_box_seg.TabStop = false;
            // 
            // text_box_x1
            // 
            this.text_box_x1.Location = new System.Drawing.Point(83, 472);
            this.text_box_x1.Name = "text_box_x1";
            this.text_box_x1.Size = new System.Drawing.Size(100, 22);
            this.text_box_x1.TabIndex = 5;
            this.text_box_x1.Text = "80";
            // 
            // text_box_y1
            // 
            this.text_box_y1.Location = new System.Drawing.Point(83, 526);
            this.text_box_y1.Name = "text_box_y1";
            this.text_box_y1.Size = new System.Drawing.Size(100, 22);
            this.text_box_y1.TabIndex = 6;
            this.text_box_y1.Text = "400";
            // 
            // text_box_x2
            // 
            this.text_box_x2.Location = new System.Drawing.Point(289, 472);
            this.text_box_x2.Name = "text_box_x2";
            this.text_box_x2.Size = new System.Drawing.Size(100, 22);
            this.text_box_x2.TabIndex = 7;
            this.text_box_x2.Text = "150";
            // 
            // text_box_y2
            // 
            this.text_box_y2.Location = new System.Drawing.Point(289, 526);
            this.text_box_y2.Name = "text_box_y2";
            this.text_box_y2.Size = new System.Drawing.Size(100, 22);
            this.text_box_y2.TabIndex = 8;
            this.text_box_y2.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chon vung de tinh vecto trung binh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "X1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "X2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Y2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ngưỡng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 92);
            this.button1.TabIndex = 16;
            this.button1.Text = "Segmentation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblnguong
            // 
            this.lblnguong.AutoSize = true;
            this.lblnguong.Location = new System.Drawing.Point(647, 475);
            this.lblnguong.Name = "lblnguong";
            this.lblnguong.Size = new System.Drawing.Size(0, 17);
            this.lblnguong.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 495);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "45";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 684);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblnguong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_box_y2);
            this.Controls.Add(this.text_box_x2);
            this.Controls.Add(this.text_box_y1);
            this.Controls.Add(this.text_box_x1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_box_seg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_box_rgb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_rgb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_seg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_box_rgb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_box_seg;
        private System.Windows.Forms.TextBox text_box_x1;
        private System.Windows.Forms.TextBox text_box_y1;
        private System.Windows.Forms.TextBox text_box_x2;
        private System.Windows.Forms.TextBox text_box_y2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblnguong;
        private System.Windows.Forms.TextBox textBox1;
    }
}

