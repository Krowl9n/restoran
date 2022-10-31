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
    public partial class AddFormSot : Form
    {
        public AddFormSot()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void AdBtnSot_Click (object sender, EventArgs e)
        {
            Form3 main = this.Owner as Form3;
            if (main != null)
            {
                DataRow nRow = main._999DataSet2.Tables[11].NewRow();
                int rc = main.dataGridView1.RowCount + 8;
                nRow[0] = rc;
                nRow[4] = fambox.Text;
                nRow[5] = textBox2.Text;
                nRow[6] = textBox3.Text;
                nRow[7] = textBox4.Text;
                nRow[8] = textBox5.Text;
                nRow[9] = textBox6.Text;
                nRow[1] = textBox7.Text;
                nRow[3] = textBox8.Text;
                nRow[2] = textBox9.Text;
                
             

                main._999DataSet2.Tables[11].Rows.Add(nRow);
                main.сотрудникиTableAdapter.Update(main._999DataSet2.Сотрудники);
                main._999DataSet2.Tables[11].AcceptChanges();
                main.dataGridView1.Refresh();
                fambox.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}