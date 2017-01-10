using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba a = new Araba();
            a.yakitDepoKapasite = Convert.ToInt32(numericUpDown1.Value);
            //a.ortalamaTuketim100km = Convert.ToDouble(numericUpDown2.Value);
            a.yakitFiyat = Convert.ToDouble(numericUpDown3.Value);

            MessageBox.Show(a.yakitDepoKapasite + "\n" + a.ortalamaTuketim100km + "\n" + a.yakitFiyat + "\n" + a.toplamYol);
        }
    }
}
