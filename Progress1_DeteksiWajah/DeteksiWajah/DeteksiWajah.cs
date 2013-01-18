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



namespace deteksiwajah
{
    public partial class DeteksiWajah : Form
    {
        //variabel global
        private Capture tangkap; //mengambil gambar dari kamera dan menyimpan ke dalam frame-frame gambar
        private bool progresTangkapGambar;

        public DeteksiWajah() 
        {
            InitializeComponent(); //inialisasi komponen
        }

        private void ProsesMenangkapFrame(object sender, EventArgs arg)
        {
            //menyimpan frame gambar yang ditangkap kamera ke imageframe
            Image<Bgr, Byte> FrameGambar = tangkap.QueryFrame();
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
                if (progresTangkapGambar)
                {
                    btnKamera.Text = "Mulai";
                    Application.Idle -= ProsesMenangkapFrame;
                }
                else
                {
                    btnKamera.Text = "Berhenti";
                    Application.Idle += ProsesMenangkapFrame;
                }

                progresTangkapGambar = !progresTangkapGambar;
            }
        }
        
        //diskonek kamera
        private void ReleaseData()
        {
            if (tangkap != null)
                tangkap.Dispose();
        }
        
    }
}    
        

