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
    public partial class AddFormPostavka2 : Form
    {
        public AddFormPostavka2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 main = this.Owner as Form5;
            if (main != null)
            {
                DataRow nRow = main._999DataSet.Tables[6].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                
                
                
                nRow[4] = textBox4.Text;
                nRow[5] = textBox5.Text;





                main._999DataSet.Tables[6].Rows.Add(nRow);
                main.поставка_продуктаTableAdapter.Update(main._999DataSet.Поставка_продукта);
                main._999DataSet.Tables[6].AcceptChanges();
                main.dataGridView1.Refresh();
                
                textBox4.Text = "";
                textBox5.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}