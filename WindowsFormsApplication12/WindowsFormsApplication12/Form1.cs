using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ogrenci ogr1 = new ogrenci();
        ogrenci ogr2 = new ogrenci();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ogr1.AdSoyadi = "Yanki Karayılan";
            ogr1.OgrNo = 1;

            ogr2.AdSoyadi = "Atakan Şahan";
            ogr2.OgrNo = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ogr1.AdSoyadi + " " + ogr1.OgrNo);
            MessageBox.Show(ogr2.AdSoyadi + " " + ogr2.OgrNo);
        }
    }
}
