namespace deteksiwajah
{
    partial class DeteksiWajah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeteksiWajah));
            this.KameraImageBox = new Emgu.CV.UI.ImageBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnKamera = new System.Windows.Forms.Button();
            this.btnGambar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbGambar = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFotoKamera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KameraImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGambar)).BeginInit();
            this.SuspendLayout();
            // 
            // KameraImageBox
            // 
            this.KameraImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KameraImageBox.Location = new System.Drawing.Point(11, 11);
            this.KameraImageBox.Margin = new System.Windows.Forms.Padding(2);
            this.KameraImageBox.Name = "KameraImageBox";
            this.KameraImageBox.Size = new System.Drawing.Size(476, 354);
            this.KameraImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KameraImageBox.TabIndex = 2;
            this.KameraImageBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnKamera
            // 
            this.btnKamera.Location = new System.Drawing.Point(495, 30);
            this.btnKamera.Name = "btnKamera";
            this.btnKamera.Size = new System.Drawing.Size(160, 36);
            this.btnKamera.TabIndex = 7;
            this.btnKamera.Text = "Dari Live Kamera";
            this.btnKamera.UseVisualStyleBackColor = true;
            this.btnKamera.Click += new System.EventHandler(this.btnKamera_Click);
            // 
            // btnGambar
            // 
            this.btnGambar.Location = new System.Drawing.Point(495, 72);
            this.btnGambar.Name = "btnGambar";
            this.btnGambar.Size = new System.Drawing.Size(160, 36);
            this.btnGambar.TabIndex = 9;
            this.btnGambar.Text = "Dari File Gambar";
            this.btnGambar.UseVisualStyleBackColor = true;
            this.btnGambar.Click += new System.EventHandler(this.btnGambar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mode pengambilan data :";
            // 
            // pbGambar
            // 
            this.pbGambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGambar.Location = new System.Drawing.Point(495, 170);
            this.pbGambar.Name = "pbGambar";
            this.pbGambar.Size = new System.Drawing.Size(158, 195);
            this.pbGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGambar.TabIndex = 11;
            this.pbGambar.TabStop = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(495, 378);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(77, 48);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(578, 377);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(77, 49);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFotoKamera
            // 
            this.btnFotoKamera.Location = new System.Drawing.Point(495, 114);
            this.btnFotoKamera.Name = "btnFotoKamera";
            this.btnFotoKamera.Size = new System.Drawing.Size(160, 36);
            this.btnFotoKamera.TabIndex = 14;
            this.btnFotoKamera.Text = "Dari Foto Kamera";
            this.btnFotoKamera.UseVisualStyleBackColor = true;
            this.btnFotoKamera.Click += new System.EventHandler(this.btnFotoKamera_Click);
            // 
            // DeteksiWajah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 438);
            this.Controls.Add(this.btnFotoKamera);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.pbGambar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGambar);
            this.Controls.Add(this.btnKamera);
            this.Controls.Add(this.KameraImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeteksiWajah";
            this.Text = "Aplikasi Pendeteksi Wajah";
            this.Load += new System.EventHandler(this.DeteksiWajah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KameraImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGambar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox KameraImageBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnKamera;
        private System.Windows.Forms.Button btnGambar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGambar;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFotoKamera;
    }
}

