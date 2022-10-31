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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._999DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Рецепт_напитка". При необходимости она может быть перемещена или удалена.
            this.рецепт_напиткаTableAdapter.Fill(this._999DataSet.Рецепт_напитка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._999DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Рецепт_напитка". При необходимости она может быть перемещена или удалена.
            this.рецепт_напиткаTableAdapter.Fill(this._999DataSet.Рецепт_напитка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Блюдо". При необходимости она может быть перемещена или удалена.
            this.блюдоTableAdapter.Fill(this._999DataSet.Блюдо);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this._999DataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet1.Рецепт_напитка". При необходимости она может быть перемещена или удалена.





        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchFormZakaz zakazs = new SearchFormZakaz();
            zakazs.Owner = this;
            zakazs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFormZakaz zakaz = new AddFormZakaz();
            zakaz.Owner = this;
            zakaz.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказTableAdapter.Update(_999DataSet);
            рецепт_напиткаTableAdapter.Update(_999DataSet);
            сотрудникиTableAdapter.Update(_999DataSet);
            блюдоTableAdapter.Update(_999DataSet);

        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //This event is used to avoid the error of DataGridviewCombobox Cell 
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}