namespace MP01_HienThiAnhRGB
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
            this.imgbox = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.redbox = new Emgu.CV.UI.ImageBox();
            this.bluebox = new Emgu.CV.UI.ImageBox();
            this.greenbox = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbox)).BeginInit();
            this.SuspendLayout();
            // 
            // imgbox
            // 
            this.imgbox.Location = new System.Drawing.Point(8, 0);
            this.imgbox.Name = "imgbox";
            this.imgbox.Size = new System.Drawing.Size(674, 417);
            this.imgbox.TabIndex = 2;
            this.imgbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anh goc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // redbox
            // 
            this.redbox.Location = new System.Drawing.Point(688, 0);
            this.redbox.Name = "redbox";
            this.redbox.Size = new System.Drawing.Size(632, 417);
            this.redbox.TabIndex = 2;
            this.redbox.TabStop = false;
            this.redbox.Click += new System.EventHandler(this.redbox_Click);
            // 
            // bluebox
            // 
            this.bluebox.Location = new System.Drawing.Point(688, 423);
            this.bluebox.Name = "bluebox";
            this.bluebox.Size = new System.Drawing.Size(632, 395);
            this.bluebox.TabIndex = 2;
            this.bluebox.TabStop = false;
            this.bluebox.Click += new System.EventHandler(this.greenbox_Click);
            // 
            // greenbox
            // 
            this.greenbox.Location = new System.Drawing.Point(8, 423);
            this.greenbox.Name = "greenbox";
            this.greenbox.Size = new System.Drawing.Size(674, 395);
            this.greenbox.TabIndex = 2;
            this.greenbox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "layer Red";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "layer Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "layer Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 816);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.greenbox);
            this.Controls.Add(this.bluebox);
            this.Controls.Add(this.redbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgbox);
            this.Name = "Form1";
            this.Text = "Hiển thị JPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgbox;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox redbox;
        private Emgu.CV.UI.ImageBox bluebox;
        private Emgu.CV.UI.ImageBox greenbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

