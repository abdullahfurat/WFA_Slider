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
            pcbImage.Image = imageList.Images[rnd.Next(0, 6)];
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
            pcbImage.Image = imageList.Images[]
            timer1.Stop();
        }
    }
    }
