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

namespace StackMetinGeriAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<string> geriAl = new Stack<string>();
        Stack<string> ileriAl = new Stack<string>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!geriAl.Contains(textBox1.Text));
            {
                ileriAl.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ileriAl.Count > 0)
            {
                string ileriMetin = ileriAl.Pop();
                geriAl.Push(ileriMetin);
                textBox1.Text = ileriMetin;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (geriAl.Count > 1)
            {
                string hedef = geriAl.Pop();
                ileriAl.Push(hedef);
                textBox1.Text = geriAl.Peek();


            }
        }
    }
}
