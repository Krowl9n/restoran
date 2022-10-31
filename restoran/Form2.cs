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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Учёт_продуктов". При необходимости она может быть перемещена или удалена.
            this.учёт_продуктовTableAdapter1.Fill(this._999DataSet.Учёт_продуктов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this._999DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter1.Fill(this._999DataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Поставка_продукта". При необходимости она может быть перемещена или удалена.
            this.поставка_продуктаTableAdapter1.Fill(this._999DataSet.Поставка_продукта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet2.Сотрудники". При необходимости она может быть перемещена или удалена.








        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AddForm product = new AddForm();
            product.Owner = this;
            product.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }







        private void button5_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                DataRow nRow = main._999DataSet.Tables[13].NewRow();
                int rc = main.dataGridView1.RowCount + 10;
                nRow[0] = rc;
                nRow[3] = textBox1.Text;

                main._999DataSet.Tables[13].Rows.Add(nRow);
                main.учёт_продуктовTableAdapter.Update(main._999DataSet.Учёт_продуктов);
                main._999DataSet.Tables[13].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this._999DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Поставка_продукта". При необходимости она может быть перемещена или удалена.
            this.поставка_продуктаTableAdapter1.Fill(this._999DataSet.Поставка_продукта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter1.Fill(this._999DataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Учёт_продуктов". При необходимости она может быть перемещена или удалена.
            this.учёт_продуктовTableAdapter1.Fill(this._999DataSet.Учёт_продуктов);

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            продуктыTableAdapter1.Update(_999DataSet);
            учёт_продуктовTableAdapter1.Update(_999DataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
    }

