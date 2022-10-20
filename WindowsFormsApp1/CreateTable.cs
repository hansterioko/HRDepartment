using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class CreateTable
    {
        public static void createT()
        {
            try
            {
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\3 курс\TestDBSQLite1.db; Version=3;")) // в строке указывается к какой базе подключаемся
                {
                    if (Form1.textBox1.Text != "")
                    {
                        // строка запроса, который надо будет выполнить
                        string commandText = "CREATE TABLE IF NOT EXISTS [" + Form1.textBox1.Text + "] ( [id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [lastname] VARCHAR(255), [firstname] VARCHAR(255), " +
                            "[middlename] VARCHAR(255),[birthday] DATETIME,[prize] REAL, [adress] VARCHAR(255), [city] VARCHAR(255), [state] VARCHAR(255), [zipcode] VARCHAR(255),[vacation] BOOLEAN, [image] BLOB)"; // создать таблицу, если её нет
                        SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                        Connect.Open(); // открыть соединение
                        Command.ExecuteNonQuery(); // выполнить запрос
                        Connect.Close(); // закрыть соединение
                        MessageBox.Show("Таблица " + Form1.textBox1.Text + " в базе данных создана");
                    }
                    else
                    {
                        MessageBox.Show("Введите название таблицы", "Создание таблицы", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка создания таблицы", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
