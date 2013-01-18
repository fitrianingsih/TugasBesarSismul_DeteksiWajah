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
            ((System.ComponentModel.ISupportInitialize)(this.KameraImageBox)).BeginInit();
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
            this.btnKamera.Location = new System.Drawing.Point(188, 385);
            this.btnKamera.Name = "btnKamera";
            this.btnKamera.Size = new System.Drawing.Size(112, 36);
            this.btnKamera.TabIndex = 7;
            this.btnKamera.Text = "Mulai";
            this.btnKamera.UseVisualStyleBackColor = true;
            this.btnKamera.Click += new System.EventHandler(this.btnMulai_Click);
            // 
            // DeteksiWajah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 433);
            this.Controls.Add(this.btnKamera);
            this.Controls.Add(this.KameraImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeteksiWajah";
            this.Text = "Aplikasi Pendeteksi Wajah";
            ((System.ComponentModel.ISupportInitialize)(this.KameraImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox KameraImageBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnKamera;
    }
}

