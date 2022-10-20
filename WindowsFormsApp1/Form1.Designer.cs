namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCreate = new System.Windows.Forms.Button();
            this.bTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tNameTable = new System.Windows.Forms.TextBox();
            this.gAddData = new System.Windows.Forms.GroupBox();
            this.bOutputAll = new System.Windows.Forms.Button();
            this.bSelectChange = new System.Windows.Forms.Button();
            this.bChange = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.tIndex = new System.Windows.Forms.TextBox();
            this.tState = new System.Windows.Forms.TextBox();
            this.tCity = new System.Windows.Forms.TextBox();
            this.tStreet = new System.Windows.Forms.TextBox();
            this.tMiddlename = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.tSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bSelectName = new System.Windows.Forms.Button();
            this.tSelectName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bSelectCity = new System.Windows.Forms.Button();
            this.tSelectCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gAddData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(5, 18);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(151, 53);
            this.bCreate.TabIndex = 0;
            this.bCreate.Text = "Создание БД";
            this.bCreate.UseVisualStyleBackColor = true;
            // 
            // bTable
            // 
            this.bTable.Location = new System.Drawing.Point(5, 77);
            this.bTable.Name = "bTable";
            this.bTable.Size = new System.Drawing.Size(151, 53);
            this.bTable.TabIndex = 1;
            this.bTable.Text = "Создание таблицы:";
            this.bTable.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dataGridView1.Location = new System.Drawing.Point(10, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(569, 275);
            this.dataGridView1.TabIndex = 4;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Width = 125;
            // 
            // tNameTable
            // 
            this.tNameTable.Location = new System.Drawing.Point(162, 112);
            this.tNameTable.Name = "tNameTable";
            this.tNameTable.Size = new System.Drawing.Size(100, 20);
            this.tNameTable.TabIndex = 2;
            // 
            // gAddData
            // 
            this.gAddData.Controls.Add(this.bOutputAll);
            this.gAddData.Controls.Add(this.bSelectChange);
            this.gAddData.Controls.Add(this.bChange);
            this.gAddData.Controls.Add(this.bDelete);
            this.gAddData.Controls.Add(this.bAdd);
            this.gAddData.Controls.Add(this.tIndex);
            this.gAddData.Controls.Add(this.tState);
            this.gAddData.Controls.Add(this.tCity);
            this.gAddData.Controls.Add(this.tStreet);
            this.gAddData.Controls.Add(this.tMiddlename);
            this.gAddData.Controls.Add(this.tName);
            this.gAddData.Controls.Add(this.tSurname);
            this.gAddData.Controls.Add(this.label7);
            this.gAddData.Controls.Add(this.label6);
            this.gAddData.Controls.Add(this.label5);
            this.gAddData.Controls.Add(this.label4);
            this.gAddData.Controls.Add(this.label3);
            this.gAddData.Controls.Add(this.label2);
            this.gAddData.Controls.Add(this.label1);
            this.gAddData.Location = new System.Drawing.Point(584, 11);
            this.gAddData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gAddData.Name = "gAddData";
            this.gAddData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gAddData.Size = new System.Drawing.Size(207, 323);
            this.gAddData.TabIndex = 5;
            this.gAddData.TabStop = false;
            this.gAddData.Text = "Добавление данных";
            // 
            // bOutputAll
            // 
            this.bOutputAll.Location = new System.Drawing.Point(4, 279);
            this.bOutputAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bOutputAll.Name = "bOutputAll";
            this.bOutputAll.Size = new System.Drawing.Size(202, 41);
            this.bOutputAll.TabIndex = 9;
            this.bOutputAll.Text = "Вывод всех";
            this.bOutputAll.UseVisualStyleBackColor = true;
            this.bOutputAll.Click += new System.EventHandler(this.bOutputAll_Click);
            // 
            // bSelectChange
            // 
            this.bSelectChange.Location = new System.Drawing.Point(121, 231);
            this.bSelectChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSelectChange.Name = "bSelectChange";
            this.bSelectChange.Size = new System.Drawing.Size(86, 43);
            this.bSelectChange.TabIndex = 17;
            this.bSelectChange.Text = "Выбрать для изменения";
            this.bSelectChange.UseVisualStyleBackColor = true;
            this.bSelectChange.Click += new System.EventHandler(this.bSelectChange_Click);
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(4, 231);
            this.bChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(86, 43);
            this.bChange.TabIndex = 16;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(121, 183);
            this.bDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(86, 43);
            this.bDelete.TabIndex = 15;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(4, 183);
            this.bAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(86, 43);
            this.bAdd.TabIndex = 14;
            this.bAdd.Text = "Добавить ";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tIndex
            // 
            this.tIndex.Location = new System.Drawing.Point(58, 160);
            this.tIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tIndex.Name = "tIndex";
            this.tIndex.Size = new System.Drawing.Size(135, 20);
            this.tIndex.TabIndex = 13;
            // 
            // tState
            // 
            this.tState.Location = new System.Drawing.Point(58, 137);
            this.tState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tState.Name = "tState";
            this.tState.Size = new System.Drawing.Size(135, 20);
            this.tState.TabIndex = 12;
            // 
            // tCity
            // 
            this.tCity.Location = new System.Drawing.Point(58, 115);
            this.tCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tCity.Name = "tCity";
            this.tCity.Size = new System.Drawing.Size(135, 20);
            this.tCity.TabIndex = 11;
            // 
            // tStreet
            // 
            this.tStreet.Location = new System.Drawing.Point(58, 92);
            this.tStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tStreet.Name = "tStreet";
            this.tStreet.Size = new System.Drawing.Size(135, 20);
            this.tStreet.TabIndex = 10;
            // 
            // tMiddlename
            // 
            this.tMiddlename.Location = new System.Drawing.Point(58, 69);
            this.tMiddlename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tMiddlename.Name = "tMiddlename";
            this.tMiddlename.Size = new System.Drawing.Size(135, 20);
            this.tMiddlename.TabIndex = 9;
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(58, 46);
            this.tName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(135, 20);
            this.tName.TabIndex = 8;
            // 
            // tSurname
            // 
            this.tSurname.Location = new System.Drawing.Point(58, 24);
            this.tSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tSurname.Name = "tSurname";
            this.tSurname.Size = new System.Drawing.Size(135, 20);
            this.tSurname.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Индекс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Область";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Улица";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.bCreate);
            this.groupBox2.Controls.Add(this.bTable);
            this.groupBox2.Controls.Add(this.tNameTable);
            this.groupBox2.Location = new System.Drawing.Point(10, 291);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(268, 150);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание Базы Данных";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Название таблицы";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bSelectName);
            this.groupBox3.Controls.Add(this.tSelectName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(283, 291);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(150, 130);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор по имени";
            // 
            // bSelectName
            // 
            this.bSelectName.Location = new System.Drawing.Point(34, 86);
            this.bSelectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSelectName.Name = "bSelectName";
            this.bSelectName.Size = new System.Drawing.Size(86, 35);
            this.bSelectName.TabIndex = 2;
            this.bSelectName.Text = "Выбрать";
            this.bSelectName.UseVisualStyleBackColor = true;
            this.bSelectName.Click += new System.EventHandler(this.bSelectName_Click);
            // 
            // tSelectName
            // 
            this.tSelectName.Location = new System.Drawing.Point(34, 44);
            this.tSelectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tSelectName.Name = "tSelectName";
            this.tSelectName.Size = new System.Drawing.Size(113, 20);
            this.tSelectName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Имя";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bSelectCity);
            this.groupBox4.Controls.Add(this.tSelectCity);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(437, 291);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(150, 130);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выбор по городу";
            // 
            // bSelectCity
            // 
            this.bSelectCity.Location = new System.Drawing.Point(34, 86);
            this.bSelectCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSelectCity.Name = "bSelectCity";
            this.bSelectCity.Size = new System.Drawing.Size(86, 35);
            this.bSelectCity.TabIndex = 2;
            this.bSelectCity.Text = "Выбрать";
            this.bSelectCity.UseVisualStyleBackColor = true;
            this.bSelectCity.Click += new System.EventHandler(this.bSelectCity_Click);
            // 
            // tSelectCity
            // 
            this.tSelectCity.Location = new System.Drawing.Point(34, 44);
            this.tSelectCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tSelectCity.Name = "tSelectCity";
            this.tSelectCity.Size = new System.Drawing.Size(113, 20);
            this.tSelectCity.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Город";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gAddData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "HRDepartment";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gAddData.ResumeLayout(false);
            this.gAddData.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tNameTable;
        private System.Windows.Forms.GroupBox gAddData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tIndex;
        private System.Windows.Forms.TextBox tState;
        private System.Windows.Forms.TextBox tCity;
        private System.Windows.Forms.TextBox tStreet;
        private System.Windows.Forms.TextBox tMiddlename;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Button bSelectChange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bSelectName;
        private System.Windows.Forms.TextBox tSelectName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bSelectCity;
        private System.Windows.Forms.TextBox tSelectCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bOutputAll;
    }
}

