namespace MIN14
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
            this.picBox_HinhGoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox_HinhDuongBien = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hScrollBar1HinhDuongBien = new System.Windows.Forms.HScrollBar();
            this.lblNguong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhDuongBien)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_HinhGoc
            // 
            this.picBox_HinhGoc.Location = new System.Drawing.Point(25, 66);
            this.picBox_HinhGoc.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_HinhGoc.Name = "picBox_HinhGoc";
            this.picBox_HinhGoc.Size = new System.Drawing.Size(363, 366);
            this.picBox_HinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HinhGoc.TabIndex = 0;
            this.picBox_HinhGoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình gốc RGB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhận diện đường biên dùng phương pháp Sobel:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // picBox_HinhDuongBien
            // 
            this.picBox_HinhDuongBien.AccessibleName = "picBox_HinhDuongBien";
            this.picBox_HinhDuongBien.Location = new System.Drawing.Point(451, 66);
            this.picBox_HinhDuongBien.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_HinhDuongBien.Name = "picBox_HinhDuongBien";
            this.picBox_HinhDuongBien.Size = new System.Drawing.Size(363, 366);
            this.picBox_HinhDuongBien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HinhDuongBien.TabIndex = 2;
            this.picBox_HinhDuongBien.TabStop = false;
            this.picBox_HinhDuongBien.Click += new System.EventHandler(this.picBox_HinhDuongBien_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nhận Dạng Biên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // hScrollBar1HinhDuongBien
            // 
            this.hScrollBar1HinhDuongBien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hScrollBar1HinhDuongBien.LargeChange = 1;
            this.hScrollBar1HinhDuongBien.Location = new System.Drawing.Point(25, 527);
            this.hScrollBar1HinhDuongBien.Maximum = 255;
            this.hScrollBar1HinhDuongBien.Name = "hScrollBar1HinhDuongBien";
            this.hScrollBar1HinhDuongBien.Size = new System.Drawing.Size(990, 36);
            this.hScrollBar1HinhDuongBien.TabIndex = 6;
            this.hScrollBar1HinhDuongBien.Value = 255;
            this.hScrollBar1HinhDuongBien.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1HinhDuongBien_Scroll);
            // 
            // lblNguong
            // 
            this.lblNguong.AutoSize = true;
            this.lblNguong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguong.Location = new System.Drawing.Point(44, 482);
            this.lblNguong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNguong.Name = "lblNguong";
            this.lblNguong.Size = new System.Drawing.Size(65, 20);
            this.lblNguong.TabIndex = 7;
            this.lblNguong.Text = "Ngưỡng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 601);
            this.Controls.Add(this.lblNguong);
            this.Controls.Add(this.hScrollBar1HinhDuongBien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_HinhDuongBien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_HinhGoc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Nhận dạng đường biên ảnh dùng phương pháp Sobel ";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhDuongBien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_HinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_HinhDuongBien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar hScrollBar1HinhDuongBien;
        private System.Windows.Forms.Label lblNguong;
    }
}

