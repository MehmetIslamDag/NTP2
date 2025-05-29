using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList_Uyg
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList Sehirler = new ArrayList();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sehirler.Add(txtSehirler.Text);
            Listele();
        }
        private void Listele ()
        {
            ListeSehirler.Items.Clear();
            foreach (string sehir in Sehirler)
            {
                ListeSehirler.Items.Add(sehir);
            }
        }

        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            int indexNo = ListeSehirler.SelectedIndex;
            Sehirler.Insert(indexNo, txtSehirler.Text);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int indexNo = ListeSehirler.SelectedIndex;
            Sehirler[indexNo] = txtSehirler.Text;
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int indexNo = ListeSehirler.SelectedIndex;
            Sehirler.RemoveAt(indexNo);
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (Sehirler.Contains(txtSehirler.Text)) 
            {
                labelDurum.Text = "Aranan Değer Bulundu";
                ListeSehirler.SelectedIndex = Sehirler.IndexOf(txtSehirler.Text);
            }
            else
            {
                labelDurum.Text = "Aranan Değer Bulunamadı ";
            }
        }
    }
}
