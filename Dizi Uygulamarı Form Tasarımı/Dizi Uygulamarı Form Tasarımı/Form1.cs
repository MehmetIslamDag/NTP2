using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizi_Uygulamarı_Form_Tasarımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (index<isimler.Length)
            {
                isimler[index] = txtAdSoyad.Text;
                notlar[index] = int.Parse(txtDersNotu.Text);
                //int.Parse Fonksiyonu girilen değeri"int" veri türüne dönüştürür
                index++;
                txtAdSoyad.Text = "";
                txtDersNotu.Text = "";
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i]!=null)
                {
                    lbListe.Items.Add(isimler[i] + ">" + notlar[i]);
                }
            }
        }

        private void btnEnYüksek_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i]>enyuksek)
                {
                    enyuksek = notlar[i];
                }
            }
            txtEnYüksek.Text = enyuksek.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnDüşük_Click(object sender, EventArgs e)
        {
            int enDusuk = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] < enDusuk)
                {
                    enDusuk = notlar[i];
                }
            }
            txtEnDüşük.Text = enDusuk.ToString();
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int  i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            txtOrtalama.Text = ortalama.ToString();
        }
    }
}
