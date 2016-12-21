using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        List<int> Sayilar = new List<int>(6);
        int rastgeleSayi;
        int sayac = 0;
        int tur = 1;

        private void BtnOyna_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tur >= 15)
            {
                timer1.Interval = 500;
            }
            if ( tur % 10 == 0)
                {
                timer1.Stop();
            }
            else
            {
                Sayilar.Clear();

                while (sayac < 6)
                {
                    rastgeleSayi = rnd.Next(1, 50);
                    if (!Sayilar.Contains(rastgeleSayi))
                    {
                        Sayilar.Add(rastgeleSayi);
                        sayac++;
                    }
                }

                Sayilar.Sort();

                label1.Text = Sayilar[0].Sayilar[0].ToString();
                label2.Text = Sayilar[1].Sayilar[1].ToString();
                label3.Text = Sayilar[2].Sayilar[2].ToString();
                label4.Text = Sayilar[3].Sayilar[3].ToString();
                label5.Text = Sayilar[4].Sayilar[4].ToString();
                label6.Text = Sayilar[5].Sayilar[5].ToString();

                sayac = 0;
                tur++;
            }
        }
    }
}
