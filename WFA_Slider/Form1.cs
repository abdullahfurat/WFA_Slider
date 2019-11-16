using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_Slider
{
    public partial class Form1 : MetroForm

    {
        Random rnd = new Random();
        int indeks = 0;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                btnStartStop.TileImage = WFA_Slider.Properties.Resources.icon_stop;
            }
            else
            {

                btnStartStop.TileImage = WFA_Slider.Properties.Resources.icon_start;
                timer1.Start();



            }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            indeks = rnd.Next(0, 6);
            pcbImage.Image = imageList.Images[indeks];
        }

        private void trackBar_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval=trackBar.Value ;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pcbImage.Image = imageList.Images[0];
            timer1.Stop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (indeks != 0)
            {
                pcbImage.Image = imageList.Images[indeks - 1];
                timer1.Stop();
            }
            else
            { pcbImage.Image = imageList.Images[6];
                timer1.Stop();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pcbImage.Image = imageList.Images[6];
            timer1.Stop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (indeks != 6)
            {
                pcbImage.Image = imageList.Images[indeks + 1];
                timer1.Stop();
            }
            else
            {
                pcbImage.Image = imageList.Images[0];
                timer1.Stop();
            }
        }
    }
    }
