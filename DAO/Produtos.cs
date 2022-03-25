using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Estoque.Models;
namespace Estoque.DAO
{
    internal class Produtos
    {
        private SQLiteConnection sqlconn;
        public Produtos(SQLiteConnection sqlconn)
        {
            this.sqlconn = sqlconn;
        }
        public void Add(Models.Produtos produto)
        {
            try
            {
                SQLiteCommand cmd;
                cmd = sqlconn.CreateCommand();
                cmd.CommandText =
                    @$"INSERT INTO PRODUTOS (nome, preco, img) 
                VALUES ('{produto.Nome}', '{produto.Preco}', '{produto.Img}');";
                cmd.ExecuteNonQuery();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Models.Produtos> Reader()
        {
            SQLiteCommand cmd;
            SQLiteDataReader dataReader;
            List<Models.Produtos> produtos = new List<Models.Produtos>();
            cmd = sqlconn.CreateCommand();
            cmd.CommandText = "SELECT id, nome, preco, img FROM produtos order by id";

            dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {
                Models.Produtos produto = new Models.Produtos();
                produto.Id = Convert.ToInt64(dataReader["id"].ToString());
                produto.Nome = dataReader["nome"].ToString();
                produto.Preco = Convert.ToDouble(dataReader["preco"].ToString());
                produto.Img = dataReader["img"].ToString();
                produtos.Add(produto);
            }
            return produtos;
        }
    }
}
