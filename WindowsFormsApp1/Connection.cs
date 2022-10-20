using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Connection
    {
        private sqliteclass mydb = null;
        private string sPath = string.Empty;
        private string sSql = string.Empty;
        public DataTable dt = new DataTable();
        DataSet ds = new DataSet();



        public void LoadTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=TestDBSQLite1.db; Version=3;"))
            {
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * from workers", connection);
                cmd.CommandType = CommandType.Text;
                SQLiteDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
        }
        }
    }
