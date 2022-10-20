using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class CreateDB
    {
        public static void create()
        {
            try
            {
                if (!File.Exists(@"C:\3 курс\TestDBSQLite1.db")) // если базы данных нету, то создать БД
                {
                    SQLiteConnection.CreateFile(@"C:\3 курс\TestDBSQLite1.db"); // создать базу данных, по указанному пути содаётся пустой файл базы данных
                    MessageBox.Show("База данных создана", "Создание базы данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Такая база данных уже существует", "Создание базы данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка создания бд", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
