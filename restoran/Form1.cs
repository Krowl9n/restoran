using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restoran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 sotrudniki = new Form3();
            sotrudniki.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 zakaz = new Form4();
            zakaz.Owner = this;
            zakaz.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 postavka = new Form5();
            postavka.Owner = this;
            postavka.Show();
        }
    }
}
