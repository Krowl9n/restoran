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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                DataRow nRow = main._999DataSet.Tables[9].NewRow();
                int rc = main.dataGridView2.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = txt.Text;
             





                main._999DataSet.Tables[9].Rows.Add(nRow);
                main.продуктыTableAdapter1.Update(main._999DataSet.Продукты);
                main._999DataSet.Tables[9].AcceptChanges();
                main.dataGridView2.Refresh();
                txt.Text = "";
                

            }


        }
        }
    }

