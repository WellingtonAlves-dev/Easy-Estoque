using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;
namespace Estoque
{
    public partial class AdicionarProduto : Form
    {

        Action carregarProdutos;
        public AdicionarProduto(Action carregarProdutos)
        {
            InitializeComponent();
            this.carregarProdutos = carregarProdutos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlconn = Database.SqliteDB.CreateConnection();
            Models.Produtos produto = new Models.Produtos();
            produto.Nome = nomeProduto.Text;
            produto.Preco = double.Parse(precoProduto.Text, NumberStyles.Currency);
            produto.Img = "";
            DAO.Produtos produtoDB = new DAO.Produtos(sqlconn);
            produtoDB.Add(produto);
            carregarProdutos();
            this.Close();
        }
    }
}
