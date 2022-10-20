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
                string commandText = "CREATE TABLE IF NOT EXISTS ["+tNameTable.Text+"] ( [id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [lastname] VARCHAR(255), [firstname] VARCHAR(255), " +
                    "[middlename] VARCHAR(255), [adress] VARCHAR(255), [city] VARCHAR(255), [state] VARCHAR(255), [zipcode] VARCHAR(255))"; // создать таблицу, если её нет
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open(); // открыть соединение
                Command.ExecuteNonQuery(); // выполнить запрос
                Connect.Close(); // закрыть соединение
                MessageBox.Show("Таблица "+tNameTable.Text+" в базе данных создана");
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

        }
    }
}
