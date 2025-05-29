using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziMetotları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[]  sayiler = {20000, 25000,19000,52000,65000,18000,51000,100000,80000,70000} 

        private void button1_Click(object sender, EventArgs e)
        {
            int uzunluk = sayiler.Length;
            MessageBox.Show("Dizinin Uzunlugu  :"  + uzunluk.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int boyut = sayiler.Rank;
            MessageBox.Show("Dizinin Boyutu  :" + boyut.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int max = sayiler.Max();
            MessageBox.Show("Dizinin En Büyük Elemanı :" + max.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int min  = sayiler.Min();
            MessageBox.Show("Dizinin En Küçük Elemanı :" + min.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int toplam = sayiler.Sum();
            MessageBox.Show("Dizinin Toplam Degeri  :" + toplam.ToString ());

        }

        private void button6_Click(object sender, EventArgs e)
        {

            double ortalama = sayiler.Average();
            MessageBox.Show("Dizinin Elemanlarının Ortalaması  :" + ortalama.ToString());

        }

        private void button8_Click(object sender, EventArgs e)
        {

            int ilk = sayiler.First();
            MessageBox.Show("Dizinin İlk Emenaı  :" + ilk.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int son = sayiler.Last();
            MessageBox.Show("Dizinin Son Elemanı  :" + son.ToString());
        }
    }
}
