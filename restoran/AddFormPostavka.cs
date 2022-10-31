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
    public partial class AddFormPostavka : Form
    {
        public AddFormPostavka()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 main = this.Owner as Form5;
            if (main != null)
            {
                DataRow nRow = main._999DataSet.Tables[7].NewRow();
                int rc = main.dataGridView2.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = textBox5.Text;
                nRow[6] = textBox6.Text;




                main._999DataSet.Tables[7].Rows.Add(nRow);
                main.поставщикTableAdapter.Update(main._999DataSet.Поставщик);
                main._999DataSet.Tables[7].AcceptChanges();
                main.dataGridView2.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

            }
        }
    }
}