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
    public partial class AddFormZakaz : Form
    {
        public AddFormZakaz()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main._999DataSet.Tables[2].NewRow();
                int rc = main.dataGridView1.RowCount + 1;

                nRow[0] = rc;
                nRow[4] = textBox2.Text;
                nRow[5] = textBox6.Text;
                nRow[6] = textBox7.Text;



                main._999DataSet.Tables[2].Rows.Add(nRow);
                main.заказTableAdapter.Update(main._999DataSet.Заказ);
                main._999DataSet.Tables[2].AcceptChanges();
                main.dataGridView1.Refresh();

                textBox2.Text = "";
    
         
                textBox6.Text = "";
                textBox7.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
   
}