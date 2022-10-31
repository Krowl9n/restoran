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
    public partial class Form5 : Form
    {
        private object grdPurchaseQMaster;

        public Form5()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._999DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this._999DataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Категория_продукта". При необходимости она может быть перемещена или удалена.
            this.категория_продуктаTableAdapter.Fill(this._999DataSet.Категория_продукта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Поставка_продукта". При необходимости она может быть перемещена или удалена.
            this.поставка_продуктаTableAdapter.Fill(this._999DataSet.Поставка_продукта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Категория_продукта". При необходимости она может быть перемещена или удалена.
            this.категория_продуктаTableAdapter.Fill(this._999DataSet.Категория_продукта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this._999DataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._999DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Поставка_продукта". При необходимости она может быть перемещена или удалена.
            this.поставка_продуктаTableAdapter.Fill(this._999DataSet.Поставка_продукта);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
            SearchFormPostavka postavka = new SearchFormPostavka();
            postavka.Owner = this;
            postavka.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFormPostavka postavka = new AddFormPostavka();
            postavka.Owner = this;
            postavka.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            поставщикTableAdapter.Update(_999DataSet);
            поставка_продуктаTableAdapter.Update(_999DataSet);
            сотрудникиTableAdapter.Update(_999DataSet);
            категория_продуктаTableAdapter.Update(_999DataSet);
            
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddFormPostavka2 postavka = new AddFormPostavka2();
            postavka.Owner = this;
            postavka.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
            }
