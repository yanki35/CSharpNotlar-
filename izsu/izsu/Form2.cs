﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2(Abone aboneForm2)
        {
            InitializeComponent();
            textBox1.Text = aboneForm2.AboneNo;
            textBox2.Text = aboneForm2.AdSoyad;
            textBox3.Text = aboneForm2.OdemeHesapla(aboneForm2.OncekiSayac, aboneForm2.SonSayac, aboneForm2.AboneTuru).ToString();
        }
    }
}
