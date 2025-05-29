using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Maaş_personel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] personeller;
        int[] maaslar;

        private void button2_Click(object sender, EventArgs e)
        {
            int dusuk = maaslar[0];
            for (int i = 0; i < maaslar.Length; i++)
            {
                dusuk = maaslar[i];
            }
            label1.Text = "En Düşük Maaş  :" + dusuk;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            personeller = new string[] { "nisa", "Kerim", "Taha", "Deniz", "Miray", "Hazal", "Arda", "Damla", "Emirhan", "Rüzgar" };
            maaslar = new int[] { 20000, 25000, 19000, 52000, 65000, 18000, 51000, 1000000, 80000, 70000 };
            for (int i = 0; i < personeller.Length; i++)
            {
                listBox1.Items.Add(personeller[i] + "/t" + maaslar[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            bool bulundu = false;
            for (int i = 0; i < personeller.Length; i++)
            {
                if (aranan==personeller[i])
                {
                    bulundu = true;
                    listBox1.SelectedIndex = i;
                    break;
                }
            }
            if (bulundu)
            {
                MessageBox.Show("Personel Bulundu");
            }
            else
            {
                MessageBox.Show("Personel Bulunamadı");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Toplam Personel Sayısı ;" + personeller.Length;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int yuksek = maaslar[0];
            int yuyksekIndex = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (yuksek < maaslar[i])

                {
                    yuksek = maaslar[i];
                    yuyksekIndex = i;
                }
            }
            label1.Text = "En Yuksek Maaş Alan  :" + personeller[yuyksekIndex];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i]<20000)
                {
                    listBox1.Items.Add(personeller[i] + ">>" + maaslar[i]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < maaslar.Length; i++)

            {
                if (maaslar[i] >= 50000 && maaslar[i] <= 100000)
                {
                    sayac++;

                }
            }
            label1.Text = "50000-100000 Arasında Olanların Sayısı  :" + sayac;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < maaslar.Length; i++)
            {
                toplam += maaslar[i];
            }
            label1.Text = "Toplam Ödenen Maaş Tutarı  :" + toplam;
        }
    }
}
