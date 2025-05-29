using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İki_Boyutlu_Dizi_Uyg
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] dizi;
        int SatırSayısı;
        int SutunSayısı;
        private void btnDiziOluştur_Click(object sender, EventArgs e)
        {
            int rasgeleMin = int.Parse(txtRasgeleMin.Text);
            int rasgeleMax = int.Parse(txtRasgeleMax.Text);
            SatırSayısı = int.Parse(txtSatırSayısı.Text);
            SutunSayısı = int.Parse(txtSutunSayısı.Text);
            dizi = new int[SatırSayısı, SutunSayısı];
            Random rasgele = new Random();
            for (int x = 0; x < SatırSayısı; x++)
            {
                for (int y = 0; y < SutunSayısı ; y++)
                {
                    dizi[x,y] = rasgele.Next(rasgeleMin,rasgeleMax);
                }
            }
        }

        private void btnDiziGöster_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < SatırSayısı; x++)
            {
                for (int y = 0; y < SutunSayısı; y++)
                {
                    listDizi.Items.Add(x + "," + y + "=>" + dizi[x, y]);
                }
            }
        }
    }
}
