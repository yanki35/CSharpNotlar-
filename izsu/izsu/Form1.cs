using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izsu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abone _abone = new Abone();
            _abone.AboneNo = textBox1.Text;
            _abone.AdSoyad = textBox2.Text;
            _abone.OncekiSayac = int.Parse(textBox3.Text);
            _abone.SonSayac = int.Parse(textBox4.Text);

            string aboneTuru = radioButton1.Checked == true ? "Ev" : "Kurum";
            aboneTuru = radioButton2.Checked == true ? "Kurum" : "Ev";
            _abone.AboneTuru = aboneTuru;

            listBox1.Items.Add(_abone);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)listBox1.SelectedItem;
            double odeme = _abone.OdemeHesapla(_abone.OncekiSayac, _abone.SonSayac, _abone.AboneTuru);

            DialogResult result = MessageBox.Show("Ödeme Tutarı: " + odeme + "\nÖdeme Yapmak İstiyor Musunuz?", "Ödeme Ekranı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                listBox2.Items.Add(_abone);
                listBox1.Items.Remove(_abone);
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)listBox2.SelectedItem;
            Form2 frm = new Form2(_abone);
            frm.Show();
        }
    }
}
