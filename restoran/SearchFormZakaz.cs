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
    public partial class SearchFormZakaz : Form
    {
        public SearchFormZakaz()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void srzakaz_Click(object sender, EventArgs e)
        {
            {
                Form4 main = this.Owner as Form4;

                if (main == null)
                    return;
                var idColumntIndex = main.dataGridView1.Columns.OfType<DataGridViewColumn>().ToList().IndexOf(main.iDЗаказаDataGridViewTextBoxColumn1);
                if (idColumntIndex < 0)
                    return;
                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    var cell = main.dataGridView1.Rows[i].Cells[idColumntIndex];
                    cell.Selected = cell.Value != null && cell.Value.ToString().Equals(textBox1.Text);
                }
            }
        }
    }
}




                
            
        
    


        
