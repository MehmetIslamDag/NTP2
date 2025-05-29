using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOzellikleri
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void FormB_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("FormB Kapandı");
        }

        private void FormB_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("FormB Kapanıyor");
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            MessageBox.Show("FormB Yükleniyor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FormB Clik Olayı Çalışıyor");
        }
    }
}
