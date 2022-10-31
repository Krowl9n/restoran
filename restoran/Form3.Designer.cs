namespace restoran
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._999DataSet2 = new restoran._999DataSet2();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._999DataSet1 = new restoran._999DataSet2();
            this.сотрудникиTableAdapter = new restoran._999DataSet2TableAdapters.СотрудникиTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.окладBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.окладBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._999DataSet = new restoran._999DataSet2();
            this.окладTableAdapter = new restoran._999DataSet2TableAdapters.ОкладTableAdapter();
            this.должностьBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностьTableAdapter = new restoran._999DataSet2TableAdapters.ДолжностьTableAdapter();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter1 = new restoran._999DataSet2TableAdapters.СотрудникиTableAdapter();
            this.окладTableAdapter1 = new restoran._999DataSet2TableAdapters.ОкладTableAdapter();
            this.должностьTableAdapter1 = new restoran._999DataSet2TableAdapters.ДолжностьTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.наименованиеДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDДолжностьDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.зарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDДолжностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОкладDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.фамилияСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСотрудникиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСпециализацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПолDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОкладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._999DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._999DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.окладBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.окладBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._999DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияСотрудникаDataGridViewTextBoxColumn,
            this.имяСотрудникаDataGridViewTextBoxColumn,
            this.отчествоСотрудникаDataGridViewTextBoxColumn,
            this.телефонСотрудникаDataGridViewTextBoxColumn,
            this.паспортDataGridViewTextBoxColumn,
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn,
            this.iDСотрудникиDataGridViewTextBoxColumn,
            this.iDСпециализацииDataGridViewTextBoxColumn,
            this.iDПолDataGridViewTextBoxColumn,
            this.iDОкладDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1452, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this._999DataSet2;
            // 
            // _999DataSet2
            // 
            this._999DataSet2.DataSetName = "_999DataSet2";
            this._999DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._999DataSet1;
            // 
            // _999DataSet1
            // 
            this._999DataSet1.DataSetName = "_999DataSet1";
            this._999DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(483, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудники";
            // 
            // окладBindingSource1
            // 
            this.окладBindingSource1.DataMember = "Оклад";
            this.окладBindingSource1.DataSource = this._999DataSet2;
            // 
            // окладBindingSource
            // 
            this.окладBindingSource.DataMember = "Оклад";
            this.окладBindingSource.DataSource = this._999DataSet;
            // 
            // _999DataSet
            // 
            this._999DataSet.DataSetName = "_999DataSet";
            this._999DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // окладTableAdapter
            // 
            this.окладTableAdapter.ClearBeforeFill = true;
            // 
            // должностьBindingSource1
            // 
            this.должностьBindingSource1.DataMember = "Должность";
            this.должностьBindingSource1.DataSource = this._999DataSet2;
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this._999DataSet;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this._999DataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // окладTableAdapter1
            // 
            this.окладTableAdapter1.ClearBeforeFill = true;
            // 
            // должностьTableAdapter1
            // 
            this.должностьTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(977, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 91);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1085, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 91);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1204, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 91);
            this.button3.TabIndex = 6;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1344, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 91);
            this.button4.TabIndex = 7;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // наименованиеДолжностиDataGridViewTextBoxColumn
            // 
            this.наименованиеДолжностиDataGridViewTextBoxColumn.DataPropertyName = "Наименование должности";
            this.наименованиеДолжностиDataGridViewTextBoxColumn.HeaderText = "Наименование должности";
            this.наименованиеДолжностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеДолжностиDataGridViewTextBoxColumn.Name = "наименованиеДолжностиDataGridViewTextBoxColumn";
            this.наименованиеДолжностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDДолжностьDataGridViewTextBoxColumn1
            // 
            this.iDДолжностьDataGridViewTextBoxColumn1.DataPropertyName = "ID_Должность";
            this.iDДолжностьDataGridViewTextBoxColumn1.HeaderText = "ID_Должность";
            this.iDДолжностьDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDДолжностьDataGridViewTextBoxColumn1.Name = "iDДолжностьDataGridViewTextBoxColumn1";
            this.iDДолжностьDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDДолжностьDataGridViewTextBoxColumn1,
            this.наименованиеДолжностиDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.должностьBindingSource1;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView3.Location = new System.Drawing.Point(12, 629);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(790, 195);
            this.dataGridView3.TabIndex = 3;
            // 
            // зарплатаDataGridViewTextBoxColumn
            // 
            this.зарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.зарплатаDataGridViewTextBoxColumn.Name = "зарплатаDataGridViewTextBoxColumn";
            this.зарплатаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDДолжностьDataGridViewTextBoxColumn
            // 
            this.iDДолжностьDataGridViewTextBoxColumn.DataPropertyName = "ID_Должность";
            this.iDДолжностьDataGridViewTextBoxColumn.HeaderText = "ID_Должность";
            this.iDДолжностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDДолжностьDataGridViewTextBoxColumn.Name = "iDДолжностьDataGridViewTextBoxColumn";
            this.iDДолжностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDОкладDataGridViewTextBoxColumn1
            // 
            this.iDОкладDataGridViewTextBoxColumn1.DataPropertyName = "ID_Оклад";
            this.iDОкладDataGridViewTextBoxColumn1.HeaderText = "ID_Оклад";
            this.iDОкладDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDОкладDataGridViewTextBoxColumn1.Name = "iDОкладDataGridViewTextBoxColumn1";
            this.iDОкладDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDОкладDataGridViewTextBoxColumn1,
            this.iDДолжностьDataGridViewTextBoxColumn,
            this.зарплатаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.окладBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 428);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(790, 195);
            this.dataGridView2.TabIndex = 2;
            // 
            // фамилияСотрудникаDataGridViewTextBoxColumn
            // 
            this.фамилияСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия сотрудника";
            this.фамилияСотрудникаDataGridViewTextBoxColumn.HeaderText = "Фамилия сотрудника";
            this.фамилияСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияСотрудникаDataGridViewTextBoxColumn.Name = "фамилияСотрудникаDataGridViewTextBoxColumn";
            this.фамилияСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяСотрудникаDataGridViewTextBoxColumn
            // 
            this.имяСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Имя сотрудника";
            this.имяСотрудникаDataGridViewTextBoxColumn.HeaderText = "Имя сотрудника";
            this.имяСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяСотрудникаDataGridViewTextBoxColumn.Name = "имяСотрудникаDataGridViewTextBoxColumn";
            this.имяСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоСотрудникаDataGridViewTextBoxColumn
            // 
            this.отчествоСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Отчество сотрудника";
            this.отчествоСотрудникаDataGridViewTextBoxColumn.HeaderText = "Отчество сотрудника";
            this.отчествоСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоСотрудникаDataGridViewTextBoxColumn.Name = "отчествоСотрудникаDataGridViewTextBoxColumn";
            this.отчествоСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонСотрудникаDataGridViewTextBoxColumn
            // 
            this.телефонСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Телефон сотрудника";
            this.телефонСотрудникаDataGridViewTextBoxColumn.HeaderText = "Телефон сотрудника";
            this.телефонСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонСотрудникаDataGridViewTextBoxColumn.Name = "телефонСотрудникаDataGridViewTextBoxColumn";
            this.телефонСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // паспортDataGridViewTextBoxColumn
            // 
            this.паспортDataGridViewTextBoxColumn.DataPropertyName = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.паспортDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.паспортDataGridViewTextBoxColumn.Name = "паспортDataGridViewTextBoxColumn";
            this.паспортDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРожденияСотрудникаDataGridViewTextBoxColumn
            // 
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения сотрудника";
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn.HeaderText = "Дата рождения сотрудника";
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn.Name = "датаРожденияСотрудникаDataGridViewTextBoxColumn";
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDСотрудникиDataGridViewTextBoxColumn
            // 
            this.iDСотрудникиDataGridViewTextBoxColumn.DataPropertyName = "ID_Сотрудники";
            this.iDСотрудникиDataGridViewTextBoxColumn.HeaderText = "ID_Сотрудники";
            this.iDСотрудникиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDСотрудникиDataGridViewTextBoxColumn.Name = "iDСотрудникиDataGridViewTextBoxColumn";
            this.iDСотрудникиDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDСпециализацииDataGridViewTextBoxColumn
            // 
            this.iDСпециализацииDataGridViewTextBoxColumn.DataPropertyName = "ID_Специализации";
            this.iDСпециализацииDataGridViewTextBoxColumn.HeaderText = "ID_Специализации";
            this.iDСпециализацииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDСпециализацииDataGridViewTextBoxColumn.Name = "iDСпециализацииDataGridViewTextBoxColumn";
            this.iDСпециализацииDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDПолDataGridViewTextBoxColumn
            // 
            this.iDПолDataGridViewTextBoxColumn.DataPropertyName = "ID_Пол";
            this.iDПолDataGridViewTextBoxColumn.HeaderText = "ID_Пол";
            this.iDПолDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПолDataGridViewTextBoxColumn.Name = "iDПолDataGridViewTextBoxColumn";
            this.iDПолDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDОкладDataGridViewTextBoxColumn
            // 
            this.iDОкладDataGridViewTextBoxColumn.DataPropertyName = "ID_Оклад";
            this.iDОкладDataGridViewTextBoxColumn.HeaderText = "ID_Оклад";
            this.iDОкладDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDОкладDataGridViewTextBoxColumn.Name = "iDОкладDataGridViewTextBoxColumn";
            this.iDОкладDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 923);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1221, 714);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._999DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._999DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.окладBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.окладBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._999DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private _999DataSet2 _999DataSet1;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        public _999DataSet2TableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.Label label1;
        public _999DataSet2 _999DataSet;
        public System.Windows.Forms.BindingSource окладBindingSource;
        private _999DataSet2TableAdapters.ОкладTableAdapter окладTableAdapter;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private _999DataSet2TableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        public _999DataSet2 _999DataSet2;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        private _999DataSet2TableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        private System.Windows.Forms.BindingSource окладBindingSource1;
        private _999DataSet2TableAdapters.ОкладTableAdapter окладTableAdapter1;
        private System.Windows.Forms.BindingSource должностьBindingSource1;
        private _999DataSet2TableAdapters.ДолжностьTableAdapter должностьTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDДолжностьDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDДолжностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОкладDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСпециализацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПолDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОкладDataGridViewTextBoxColumn;
    }
}