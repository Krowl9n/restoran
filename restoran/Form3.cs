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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet2.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter1.Fill(this._999DataSet2.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet2.Оклад". При необходимости она может быть перемещена или удалена.
            this.окладTableAdapter1.Fill(this._999DataSet2.Оклад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet2.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this._999DataSet2.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this._999DataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet.Оклад". При необходимости она может быть перемещена или удалена.
            this.окладTableAdapter.Fill(this._999DataSet.Оклад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_999DataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._999DataSet1.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchFormSot sfst = new SearchFormSot();
            sfst.Owner = this;
            sfst.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFormSot sotrudniki = new AddFormSot();
            sotrudniki.Owner = this;
            sotrudniki.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            сотрудникиTableAdapter.Update(_999DataSet2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
