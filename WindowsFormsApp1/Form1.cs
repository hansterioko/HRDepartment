using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;



namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private sqliteclass mydb = null;
        private string sPath = string.Empty;
        private string sSql = string.Empty;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();



        private void LoadTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=TestDBSQLite1.db; Version=3;"))
            {
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * from clients", connection);
                cmd.CommandType = CommandType.Text;
                SQLiteDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }

        }

        private void ReloadData()
        {
            while (dataGridView1.Rows.Count != 0)
            {

                dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);
            }


        }

        private void ClearBoxes()
        {
            tSurname.Clear();
            tName.Clear();
            tMiddlename.Clear();
            tStreet.Clear();
            tCity.Clear();
            tState.Clear();
            tIndex.Clear();
        }



        private void bCreate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"TestDBSQLite1.db")) // если базы данных нету, то создать БД
            {
                SQLiteConnection.CreateFile(@"TestDBSQLite1.db"); // создать базу данных, по указанному пути содаётся пустой файл базы данных
                MessageBox.Show("База данных создана");

            }
        }

        private void bTable_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=TestDBSQLite1.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                // строка запроса, который надо будет выполнить
                string commandText = "CREATE TABLE IF NOT EXISTS [" + tNameTable.Text + "] ( [id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [lastname] VARCHAR(255), [firstname] VARCHAR(255), " +
                    "[middlename] VARCHAR(255), [adress] VARCHAR(255), [city] VARCHAR(255), [state] VARCHAR(255), [zipcode] VARCHAR(255))"; // создать таблицу, если её нет
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open(); // открыть соединение
                Command.ExecuteNonQuery(); // выполнить запрос
                Connect.Close(); // закрыть соединение
                MessageBox.Show("Таблица " + tNameTable.Text + " в базе данных создана");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bChange.Enabled = false;
            LoadTable();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["lastname"].Width = 70;
            dataGridView1.Columns["firstname"].Width = 80;
            dataGridView1.Columns["middlename"].Width = 60;
            dataGridView1.Columns["adress"].Width = 50;
            dataGridView1.Columns["city"].Width = 80;
            dataGridView1.Columns["state"].Width = 80;
            dataGridView1.Columns["zipcode"].Width = 80;


            dataGridView1.Columns["lastname"].ReadOnly = true;
            dataGridView1.Columns["firstname"].ReadOnly = true;
            dataGridView1.Columns["middlename"].ReadOnly = true;
            dataGridView1.Columns["adress"].ReadOnly = true;
            dataGridView1.Columns["city"].ReadOnly = true;
            dataGridView1.Columns["state"].ReadOnly = true;
            dataGridView1.Columns["zipcode"].ReadOnly = true;
        }

        private void bSelectName_Click(object sender, EventArgs e)
        {

            using (var connection = new SQLiteConnection("Data Source = TestDBSQLite1.db"))
            {
                if (tSelectName.Text != "")
                {
                    dataGridView1.DataSource = null;

                    dt = new DataTable();
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("select * from clients where firstname='" + tSelectName.Text + "'", connection);

                    tSelectName.Clear();


                    SQLiteDataReader dr = command.ExecuteReader();

                    dt.Load(dr);

                    dataGridView1.DataSource = dt;
                }
                else
                    MessageBox.Show("Не введены данные!!!", "Ввод данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tSurname.Text != "" && tName.Text != "" && tMiddlename.Text != "" && tStreet.Text != "" && tCity.Text != "" && tState.Text != "" && tIndex.Text != "")
            {
                try
                {
                    using (var connection = new SQLiteConnection("Data Source = TestDBSQLite1.db"))
                    {
                        connection.Open();

                        SQLiteCommand Command = new SQLiteCommand("INSERT INTO clients (lastname, firstname, middlename, adress, city, state, zipcode) VALUES ('" + tSurname.Text + "', '" + tName.Text + "', '" + tMiddlename.Text + "', '" + tStreet.Text + "', '" + tCity.Text + "', '" + tState.Text + "', '" + tIndex.Text + "')", connection);

                        if (Command.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Запись не была добавлена!", "Добавление данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Запись успешно добавлена!", "Добавление данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ClearBoxes();
                        LoadTable();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Добавление данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("Не заполнены все поля!", "Добавление данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void bSelectCity_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source = TestDBSQLite1.db"))
            {
                if (tSelectCity.Text != "")
                {
                    dataGridView1.DataSource = null;

                    dt = new DataTable();
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("select * from clients where city='" + tSelectCity.Text + "'", connection);
                    tSelectCity.Clear();


                    SQLiteDataReader dr = command.ExecuteReader();

                    dt.Load(dr);

                    dataGridView1.DataSource = dt;
                }
                else
                    MessageBox.Show("Не введены данные!!!", "Ввод данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void bOutputAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            dt = new DataTable();

            using (var connection = new SQLiteConnection("Data Source = TestDBSQLite1.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select * from clients", connection);



                SQLiteDataReader dr = command.ExecuteReader();

                dt.Load(dr);

                dataGridView1.DataSource = dt;
            }
        }

        int id = -1;

        private int CheckCountSelect()
        {
            int number = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Select"].Value))
                {
                    number++;

                }

            }
            return number;
        }
        private void bSelectChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckCountSelect() > 1)
                {
                    MessageBox.Show("Выберите только 1 значение", "Изменение данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (var connection = new SQLiteConnection("Data Source =TestDBSQLite1.db"))
                    {

                        connection.Open();
                        if (dataGridView1.Rows[0].Cells[2].Value == null)
                        {
                            MessageBox.Show("Изменение невозможно,т.к в таблице нет строк для изменения!", "Изменение строк", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        int num = -1;
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Select"].Value))
                            {
                                id = Convert.ToInt32(dataGridView1.Rows[i].Cells["id"].Value);
                                num = i;
                            }
                        }

                        tSurname.Text = dataGridView1.Rows[num].Cells["lastname"].Value.ToString();
                        tName.Text = dataGridView1.Rows[num].Cells["firstname"].Value.ToString();
                        tMiddlename.Text = dataGridView1.Rows[num].Cells["middlename"].Value.ToString();
                        tStreet.Text = dataGridView1.Rows[num].Cells["adress"].Value.ToString();
                        tCity.Text = dataGridView1.Rows[num].Cells["city"].Value.ToString();
                        tState.Text = dataGridView1.Rows[num].Cells["state"].Value.ToString();
                        tIndex.Text = dataGridView1.Rows[num].Cells["zipcode"].Value.ToString();

                        bChange.Enabled = true;
                        bSelectChange.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            if (tSurname.Text != "" && tName.Text != "" && tMiddlename.Text != "" && tCity.Text != "" && tStreet.Text != "" && tState.Text != "" && tIndex.Text != "")
            {
                try
                {
                    using (var connection = new SQLiteConnection("Data Source = TestDBSQLite1.db"))
                    {
                        connection.Open();

                        SQLiteCommand Command = new SQLiteCommand("UPDATE clients SET lastname = '" + tSurname.Text + "', firstname = '" + tName.Text + "',middlename = '" + tMiddlename.Text + "',adress = '" + tStreet.Text + "',city = '" + tCity.Text + "',state = '" + tState.Text + "',zipcode = '" + tIndex.Text + "' WHERE id='" + id + "'", connection);

                        if (Command.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Запись не была изменена!", "Изменение данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Запись успешно изменена!", "Изменение данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ClearBoxes();
                        LoadTable();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Изменение данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckCountSelect() > 1)
                {
                    MessageBox.Show("Выберите только 1 значение", "Удаление данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (var connection = new SQLiteConnection("Data Source = C:/3 курс/TestDBSQLite1.db"))
                    {
                        connection.Open();
                        if (dataGridView1.Rows[0].Cells[2].Value == null)
                        {
                            MessageBox.Show("Удаление невозможно,т.к в таблице нет строк для удаления!", "Удаление строк", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            for (int i = 0; i < dataGridView1.RowCount; i++)
                            {
                                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Select"].Value))
                                {

                                    int id = Convert.ToInt32(dataGridView1.Rows[i].Cells["id"].Value);
                                    SQLiteCommand cmd = new SQLiteCommand("delete FROM clients WHERE id = '" + id + "'", connection);
                                    cmd.ExecuteNonQuery();
                                    dataGridView1.Rows.RemoveAt(i);
                                }

                            }

                        }



                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
