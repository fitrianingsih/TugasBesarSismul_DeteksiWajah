/*=================================================
 *Kelompok 4
 *[10109316] Riza Hardian
 *[10109321] Mirah Anugraheny
 *[10109326] Andri Nugraha Ramdhon
 *[10109345] Fitrianingsih
 *IF-8
 *Sistem Multimedia
 * ================================================== */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;



namespace deteksiwajah
{
    public partial class DeteksiWajah : Form
    {
        //variabel global
        private Capture tangkap; //mengambil gambar dari kamera dan menyimpan ke dalam frame-frame gambar
        private HaarCascade haar; //deklarasi penggunaan kelas viola-jones untuk mendeteksi gambar 

        public DeteksiWajah() 
        {
            InitializeComponent(); //inialisasi komponen
        }

        private void ProsesMenangkapFrame(object sender, EventArgs arg)
        {
            //menyimpan frame gambar yang ditangkap kamera ke imageframe
            Image<Bgr, Byte> FrameGambar = tangkap.QueryFrame();
            //mendeteksi wajah dari framegambar
            if (FrameGambar != null) //mengkonfirmasi valid tidaknya framegambar
            {
                //konversi gambar ke gray-scale
                Image<Gray, byte> framegrayscale = FrameGambar.Convert<Gray, byte>();

                //mendeteksi wajah dari gray-scale image dan menyimpan ke dalam array
                var wajah = framegrayscale.DetectHaarCascade(haar, 1.1, 1,
                                        HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                        new Size(25, 25))[0];
                //menandai kotak biru pada wajah yang dideteksi dari gambar
                foreach (var wajah2 in wajah)
                {
                    FrameGambar.Draw(wajah2.rect, new Bgr(Color.Blue),3);
                }
            }
            //menyimpan gambar ke direktori C:\
            FrameGambar.Save(@"C:\HasilFoto.jpg")
            //menampilkan gambar pada EmguCV ImageBox
            KameraImageBox.Image = FrameGambar.Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR, true);
        }

        private void btnMulai_Click(object sender, EventArgs e)
        {
            if (tangkap == null)
            {
                try
                {
                    tangkap = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }


            if (tangkap != null)
            {
                if (btnKamera.Text=="Berhenti Kamera")
                {
                    btnKamera.Text = "Mulai Kamera";
                    Application.Idle -= ProsesMenangkapFrame;
                }
                else
                {
                    btnKamera.Text = "Berhenti Kamera";
                    Application.Idle += ProsesMenangkapFrame;
                }
            }
        }
        
        //diskonek kamera
        private void ReleaseData()
        {
            if (tangkap != null)
                tangkap.Dispose();
        }

        private void DeteksiWajah_Load(object sender, EventArgs e)
        {
            //mencari xml yang akan digunakan
            haar = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
        }
        
    }
}    
        

