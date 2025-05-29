using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_maaş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[10];
        int[] Maaşlar = new int[10];
        int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = txtAdSoyad.Text;
                Maaşlar[index] = int.Parse(txtMaaş.Text);
                index++;
                txtAdSoyad.Text = "";
                txtMaaş.Text = "";
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                {
                    lbListe.Items.Add(isimler[i] + ">" + Maaşlar[i]);
                }
            }


        }

        private void btnEnYuksek_Click(object sender, EventArgs e)
        {
            int enyuksek = Maaşlar[0];
            for (int i = 0; i < Maaşlar.Length; i++)
            {
                if (Maaşlar[i]> enyuksek)
                {
                    enyuksek = Maaşlar[i];
                }
                txtEnYuksek.Text = enyuksek.ToString();
            }
        }

        private void btnEnDusuk_Click(object sender, EventArgs e)
        {
            int endusuk = Maaşlar[0];
            for (int i = 0; i < Maaşlar.Length; i++)
            {
                if (Maaşlar[i] < endusuk)
                {
                    endusuk = Maaşlar[i];
                }
                txtEnDusuk.Text = endusuk.ToString();
            }
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double Toplam = 0;
            for (int i = 0; i < Maaşlar.Length; i++)
            {
                toplam += Maaşlar[i];
            }
            Toplam = toplam + Maaşlar.Length;
            txtToplam.Text = toplam.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
        }
    }
}
