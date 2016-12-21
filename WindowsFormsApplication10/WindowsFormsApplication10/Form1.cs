using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(textBox1.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime DTarihi = dateTimePicker1.Value;
            DateTime Simdi = DateTime.Now;

            int yas = Simdi.Year - DTarihi.Year;

            TxtYas.Text = yas.ToString();

            TxtYas.Text = ((Simdi - DTarihi).TotalDays).ToString();
        }
    }
}
