using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavKafeSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            int counter = 1;
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    Button btn = new Button();
                    btn.Click += button_click();
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Text = counter + " ";
                    btn.Left = (btn.Width * j);
                    btn.Top = (btn.Height * i);
                    groupBox2.Controls.Add(btn);
                    counter++;
                }
            }
        }

        private EventHandler button_click()
        {
            throw new NotImplementedException();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            comboBox1.Items.Add(" ");
            comboBox1.Items.Add("Kuru Fasulye");
            comboBox1.Items.Add("Tavuklu Pilav");
            comboBox1.Items.Add("Simit Tost");
            comboBox1.Items.Add("Lazanya");
            comboBox1.Items.Add(" ");
            comboBox1.Items.Add("Su");
            comboBox1.Items.Add("Kola");
            comboBox1.Items.Add("Limonata");
            comboBox1.Items.Add("Çay");
            comboBox1.Items.Add("Kahve");
            Siparis s = new Siparis();
            s.yiyecek = Convert.ToString(comboBox1.SelectedItem);
            s.içecek = Convert.ToString(comboBox1.SelectedItem);
            s.yemekadet = Convert.ToString(numericUpDown1.Value);
            s.içecekadet = Convert.ToString(numericUpDown2.Value);
            Button secilenmasa = sender as Button;


        }
    }
}
