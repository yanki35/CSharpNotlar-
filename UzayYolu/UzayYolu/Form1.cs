using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzayYolu
{
    public partial class Form1 : Form
    {
        public Form1()

           
        {
            InitializeComponent();
            Rocket.Visible = false;
        }
        int yukseklik, genislik;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    PictureBox.Left -= 10;
                    break;

                case Keys.Right:
                    PictureBox.Left += 10;
                    break;

                case Keys.Up:
                    PictureBox.Top -= 10;
                    break;

                case Keys.Down:
                    PictureBox.Top += 10;
                    break;

                

                case Keys.Space:
                    int x = PictureBox.Location.X + PictureBox.Width / 2;
                    int y = PictureBox.Location.Y + PictureBox.Height / 2;
                    Rocket.Location = new Point(x, y);
                    Rocket.Visible = true;
                    timer1.Start();
                    break;

                default:
                    break;

                    int SpaceX = PictureBox.Location.X;
                    int SpaceY = PictureBox.Location.Y;

                    if (SpaceX > genislik - PictureBox.Width || SpaceX <=0)
                    {
                        MessageBox.Show("Lanet olsun! Oyun bitti.");
                    }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int genislik, yukseklik;
            genislik = Form1.ActiveForm.Width;
            yukseklik = Form1.ActiveForm.Height;

            if (Rocket.Location.X < genislik - Rocket.Width * 2)
                Rocket.Left += 10;
        }
    }
}


