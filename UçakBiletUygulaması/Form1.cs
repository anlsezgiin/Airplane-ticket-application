using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UçakBiletUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ankara" + "İstanbul");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden: " + comboBox1.Text + "-" + comboBox2.Text);
            listBox1.Items.Add("Tarih: " + comboBox3.Text);
            listBox1.Items.Add("Saat: " + maskedTextBox1.Text);
            listBox1.Items.Add("Yolcu Adı-Soyadı: " + textBox1.Text);
            listBox1.Items.Add("Yolcu TC: " + maskedTextBox2.Text);
            listBox1.Items.Add("Yolcu Telefon Numarası: " + maskedTextBox3.Text);
            MessageBox.Show("Kaydınız alınmıştır");
        }
    }
}
