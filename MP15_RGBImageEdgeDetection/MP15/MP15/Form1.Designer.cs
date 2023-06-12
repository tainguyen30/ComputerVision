namespace MP15
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
            this.picBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.picBoxHinhDuongBien = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.lblHinhDuongBien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhDuongBien)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxHinhGoc.Location = new System.Drawing.Point(49, 78);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(484, 394);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhGoc.TabIndex = 0;
            this.picBoxHinhGoc.TabStop = false;
            // 
            // picBoxHinhDuongBien
            // 
            this.picBoxHinhDuongBien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxHinhDuongBien.Location = new System.Drawing.Point(565, 78);
            this.picBoxHinhDuongBien.Name = "picBoxHinhDuongBien";
            this.picBoxHinhDuongBien.Size = new System.Drawing.Size(484, 394);
            this.picBoxHinhDuongBien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhDuongBien.TabIndex = 1;
            this.picBoxHinhDuongBien.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hình màu RGB gốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(559, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ảnh nhận dạng biên dùng Sobel:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLevel.Location = new System.Drawing.Point(49, 490);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(79, 31);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Level";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar1.Location = new System.Drawing.Point(55, 550);
            this.hScrollBar1.Maximum = 260;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1189, 34);
            this.hScrollBar1.TabIndex = 5;
            // 
            // lblHinhDuongBien
            // 
            this.lblHinhDuongBien.BackColor = System.Drawing.Color.Red;
            this.lblHinhDuongBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhDuongBien.ForeColor = System.Drawing.Color.Yellow;
            this.lblHinhDuongBien.Location = new System.Drawing.Point(1069, 397);
            this.lblHinhDuongBien.Name = "lblHinhDuongBien";
            this.lblHinhDuongBien.Size = new System.Drawing.Size(175, 75);
            this.lblHinhDuongBien.TabIndex = 6;
            this.lblHinhDuongBien.Text = "NHẬN DẠNG";
            this.lblHinhDuongBien.UseVisualStyleBackColor = false;
            this.lblHinhDuongBien.Click += new System.EventHandler(this.lblHinhDuongBien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1267, 628);
            this.Controls.Add(this.lblHinhDuongBien);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxHinhDuongBien);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Name = "Form1";
            this.Text = "Edge Detection - Nhận dạng đường biên dùng phương pháp Sobel cho ảnh màu RGB";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhDuongBien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.PictureBox picBoxHinhDuongBien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button lblHinhDuongBien;
    }
}

