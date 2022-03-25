using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace Estoque.Database
{
    internal class SqliteDB
    {
        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn = 
                   new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            try
            {
                sqlite_conn.Open();
            } catch(Exception ex)
            {
                MessageBox.Show("Não foi possivel conectar ao DB");
            }
            return sqlite_conn;
        }
        public static void CreateTable(SQLiteConnection sql_conn)
        {
            string createProdutos = @"
                create table IF NOT EXISTS produtos (
	                id INTEGER primary key AUTOINCREMENT,
  	                nome varchar(255) not null,
  	                preco double(8,2) not null,
  	                img varchar(255) null
                );";
            SQLiteCommand cmd = sql_conn.CreateCommand();
            cmd.CommandText = createProdutos;
            cmd.ExecuteNonQuery();
        }
    }
}
