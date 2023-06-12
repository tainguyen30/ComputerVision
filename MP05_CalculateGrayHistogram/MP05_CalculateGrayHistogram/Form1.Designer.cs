namespace MP05_CalculateGrayHistogram
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
            this.components = new System.ComponentModel.Container();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.zgHistogram = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(12, 35);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(446, 309);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox1.TabIndex = 0;
            this.picbox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gray Image";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Original Image";
            // 
            // picbox2
            // 
            this.picbox2.Location = new System.Drawing.Point(12, 415);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(446, 345);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox2.TabIndex = 3;
            this.picbox2.TabStop = false;
            // 
            // zgHistogram
            // 
            this.zgHistogram.Location = new System.Drawing.Point(465, 65);
            this.zgHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zgHistogram.Name = "zgHistogram";
            this.zgHistogram.ScrollGrace = 0D;
            this.zgHistogram.ScrollMaxX = 0D;
            this.zgHistogram.ScrollMaxY = 0D;
            this.zgHistogram.ScrollMaxY2 = 0D;
            this.zgHistogram.ScrollMinX = 0D;
            this.zgHistogram.ScrollMinY = 0D;
            this.zgHistogram.ScrollMinY2 = 0D;
            this.zgHistogram.Size = new System.Drawing.Size(870, 653);
            this.zgHistogram.TabIndex = 4;
            this.zgHistogram.UseExtendedPrintDialog = true;
            this.zgHistogram.Load += new System.EventHandler(this.zgHistogram_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 790);
            this.Controls.Add(this.zgHistogram);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbox1);
            this.Name = "Form1";
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picbox2;
        private ZedGraph.ZedGraphControl zgHistogram;
    }
}

