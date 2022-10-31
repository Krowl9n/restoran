namespace restoran
{
    partial class Form2
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDУчётаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокГодностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Поставка = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.поставкаПродуктаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._999DataSet = new restoran._999DataSet();
            this.ID_Сотрудники = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Продукта = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.продуктыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.учётПродуктовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учёт_продуктовTableAdapter1 = new restoran._999DataSetTableAdapters.Учёт_продуктовTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDПродуктаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыTableAdapter1 = new restoran._999DataSetTableAdapters.ПродуктыTableAdapter();
            this.поставка_продуктаTableAdapter1 = new restoran._999DataSetTableAdapters.Поставка_продуктаTableAdapter();
            this.сотрудникиTableAdapter1 = new restoran._999DataSetTableAdapters.СотрудникиTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкаПродуктаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._999DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётПродуктовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDУчётаDataGridViewTextBoxColumn,
            this.срокГодностиDataGridViewTextBoxColumn,
            this.ID_Поставка,
            this.ID_Сотрудники,
            this.ID_Продукта});
            this.dataGridView1.DataSource = this.учётПродуктовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 243);
            this.dataGridView1.TabIndex = 0;
           
            // 
            // iDУчётаDataGridViewTextBoxColumn
            // 
            this.iDУчётаDataGridViewTextBoxColumn.DataPropertyName = "ID_Учёта";
            this.iDУчётаDataGridViewTextBoxColumn.HeaderText = "ID_Учёта";
            this.iDУчётаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDУчётаDataGridViewTextBoxColumn.Name = "iDУчётаDataGridViewTextBoxColumn";
            this.iDУчётаDataGridViewTextBoxColumn.Width = 125;
            // 
            // срокГодностиDataGridViewTextBoxColumn
            // 
            this.срокГодностиDataGridViewTextBoxColumn.DataPropertyName = "Срок годности";
            this.срокГодностиDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            this.срокГодностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.срокГодностиDataGridViewTextBoxColumn.Name = "срокГодностиDataGridViewTextBoxColumn";
            this.срокГодностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // ID_Поставка
            // 
            this.ID_Поставка.DataPropertyName = "Поставка";
            this.ID_Поставка.DataSource = this.поставкаПродуктаBindingSource;
            this.ID_Поставка.DisplayMember = "Количесвто";
            this.ID_Поставка.HeaderText = "Поставка";
            this.ID_Поставка.MinimumWidth = 6;
            this.ID_Поставка.Name = "ID_Поставка";
            this.ID_Поставка.ValueMember = "ID_Поставка";
            this.ID_Поставка.Width = 125;
            // 
            // поставкаПродуктаBindingSource
            // 
            this.поставкаПродуктаBindingSource.DataMember = "Поставка продукта";
            this.поставкаПродуктаBindingSource.DataSource = this._999DataSet;
            // 
            // _999DataSet
            // 
            this._999DataSet.DataSetName = "_999DataSet";
            this._999DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_Сотрудники
            // 
            this.ID_Сотрудники.DataPropertyName = "ID_Сотрудники";
            this.ID_Сотрудники.DataSource = this.сотрудникиBindingSource;
            this.ID_Сотрудники.DisplayMember = "Фамилия сотрудника";
            this.ID_Сотрудники.HeaderText = "Сотрудник";
            this.ID_Сотрудники.MinimumWidth = 6;
            this.ID_Сотрудники.Name = "ID_Сотрудники";
            this.ID_Сотрудники.ValueMember = "ID_Сотрудники";
            this.ID_Сотрудники.Width = 125;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._999DataSet;
            // 
            // ID_Продукта
            // 
            this.ID_Продукта.DataPropertyName = "Продукт";
            this.ID_Продукта.DataSource = this.продуктыBindingSource1;
            this.ID_Продукта.DisplayMember = "Название продукта";
            this.ID_Продукта.HeaderText = "ID_Продукта";
            this.ID_Продукта.MinimumWidth = 6;
            this.ID_Продукта.Name = "ID_Продукта";
            this.ID_Продукта.ValueMember = "ID_Продукта";
            this.ID_Продукта.Width = 125;
            // 
            // продуктыBindingSource1
            // 
            this.продуктыBindingSource1.DataMember = "Продукты";
            this.продуктыBindingSource1.DataSource = this._999DataSet;
            // 
            // учётПродуктовBindingSource
            // 
            this.учётПродуктовBindingSource.DataMember = "Учёт продуктов";
            this.учётПродуктовBindingSource.DataSource = this._999DataSet;
            // 
            // учёт_продуктовTableAdapter1
            // 
            this.учёт_продуктовTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПродуктаDataGridViewTextBoxColumn1,
            this.названиеПродуктаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.продуктыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 338);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(386, 354);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDПродуктаDataGridViewTextBoxColumn1
            // 
            this.iDПродуктаDataGridViewTextBoxColumn1.DataPropertyName = "ID_Продукта";
            this.iDПродуктаDataGridViewTextBoxColumn1.HeaderText = "ID_Продукта";
            this.iDПродуктаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDПродуктаDataGridViewTextBoxColumn1.Name = "iDПродуктаDataGridViewTextBoxColumn1";
            this.iDПродуктаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // названиеПродуктаDataGridViewTextBoxColumn
            // 
            this.названиеПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.HeaderText = "Название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеПродуктаDataGridViewTextBoxColumn.Name = "названиеПродуктаDataGridViewTextBoxColumn";
            this.названиеПродуктаDataGridViewTextBoxColumn.Width = 125;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this._999DataSet;
            // 
            // продуктыTableAdapter1
            // 
            this.продуктыTableAdapter1.ClearBeforeFill = true;
            // 
            // поставка_продуктаTableAdapter1
            // 
            this.поставка_продуктаTableAdapter1.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(404, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 86);
            this.button6.TabIndex = 2;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(404, 430);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 75);
            this.button7.TabIndex = 3;
            this.button7.Text = "Поиск";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(833, 636);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 75);
            this.button8.TabIndex = 4;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(982, 636);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(128, 75);
            this.button9.TabIndex = 5;
            this.button9.Text = "Закрыть";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(531, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Учёт продуктов";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1271, 723);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкаПродуктаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._999DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётПродуктовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label1;
        public _999DataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        public _999DataSetTableAdapters.Учёт_продуктовTableAdapter учёт_продуктовTableAdapter;
        public _999DataSetTableAdapters.Поставка_продуктаTableAdapter поставка_продуктаTableAdapter;
        public _999DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.DataGridView dataGridView1;
        public _999DataSet _999DataSet;
        public System.Windows.Forms.BindingSource учётПродуктовBindingSource;
        public _999DataSetTableAdapters.Учёт_продуктовTableAdapter учёт_продуктовTableAdapter1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource продуктыBindingSource;
        public _999DataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter1;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDПродуктаDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn названиеПродуктаDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource поставкаПродуктаBindingSource;
        public _999DataSetTableAdapters.Поставка_продуктаTableAdapter поставка_продуктаTableAdapter1;
        public System.Windows.Forms.BindingSource сотрудникиBindingSource;
        public _999DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDУчётаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn срокГодностиDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewComboBoxColumn ID_Поставка;
        public System.Windows.Forms.DataGridViewComboBoxColumn ID_Сотрудники;
        public System.Windows.Forms.DataGridViewComboBoxColumn ID_Продукта;
        public System.Windows.Forms.BindingSource продуктыBindingSource1;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.IContainer components;
    }
}