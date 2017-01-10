using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsanKaynaklari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = false;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SatisTemsilcisi st = (SatisTemsilcisi)
                listBox1.SelectedItem;

            numericUpDown2.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown3.Enabled = true;

            numericUpDown1.Value = st.sskNo;
            numericUpDown2.Value = Convert.ToDecimal(st.maas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SatisTemsilcisi st = new SatisTemsilcisi();
            st.elemanTuru = comboBox1.SelectedItem.ToString();
            st.maas = Convert.ToInt32(numericUpDown2.Value);
            st.sskNo = Convert.ToInt32(numericUpDown1.Value);
            listBox1.Items.Add(st);
        }
    }
}
