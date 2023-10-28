using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppV1
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        public double virtual_time = 1;
        public int second_time = 0;

        Form1 anaform = new Form1();

        private void SplashScreen_Load(object sender, EventArgs e)
        {
             timer1.Start();
             timer2.Start();
             this.Opacity = 1;
            this.pictureBox1.Image = Properties.Resources.SplashScreenGif;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            virtual_time -= 0.01;
            label1.Text = virtual_time.ToString();
           this.Opacity = virtual_time;
            if(virtual_time == 0)
            {
                MessageBox.Show("0");
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 900;

            second_time = second_time + 1;
            label2.Text = second_time.ToString();
            if (second_time == 8)
            {
                anaform.Show();
                this.Hide();

            }
            
        }
    }
}
