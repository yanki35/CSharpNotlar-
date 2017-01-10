using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GunlukKur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xmlDoc = new XmlDocument();

            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            DateTime tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

            //label1.Text = "Dolar Kuru: " + tarih.ToString("dd/MM/yyyy") + " - " + USD + " ₺";

            dataGridView1.Rows.Add("Dolar", tarih.ToString("dd/MM/yy"), USD);

            string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            dataGridView1.Rows.Add("Euro", tarih.ToString("dd/MM/yy"), EUR);

            string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;

            dataGridView1.Rows.Add("Pound", tarih.ToString("dd/MM/yy"), GBP);
        }
    }
}
