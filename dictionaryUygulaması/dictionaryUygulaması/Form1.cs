using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionaryUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
        int anahtar;
        string deger;
        private void button1_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (textBox1.Text!="")
            {
                anahtar = int.Parse(textBox1.Text);
                durum = ogrenciler.ContainsKey(anahtar);
            }
            else
            {
                deger = textBox2.Text;
                durum = ogrenciler.ContainsValue(deger);
            }
            if (durum==true)
            {
                MessageBox.Show("öğrenci kayıtlıdır");
            }
            else
            {
                MessageBox.Show("öğrenci kayıtlı değildir");
            }
        }
        private void listele()
        {
            listBox1.Items.Clear();
            foreach (var ogrenci  in ogrenciler)
            {
                listBox1.Items.Add(ogrenci.Key + "-" + ogrenci.Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox1.Text);
            deger = textBox2.Text;
            ogrenciler[anahtar] = deger;
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox1.Text);
            ogrenciler.Remove(anahtar);
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox1.Text);
            deger = textBox2.Text;
            ogrenciler.Add(anahtar, deger);
            listele();
        }
    }
}
