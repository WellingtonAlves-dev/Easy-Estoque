using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estoque.DAO;
using Estoque.Models;
using System.Data.SQLite;
namespace Estoque.Painel
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            carregarProdutos();
        }

        public void carregarProdutos()
        {
            SQLiteConnection sqlconn = Database.SqliteDB.CreateConnection();
            DAO.Produtos produtos = new DAO.Produtos(sqlconn);
            List<Models.Produtos> listaProdutos = produtos.Reader();
            dataGridProdutos.DataSource = listaProdutos;
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            AdicionarProduto addProduto = new AdicionarProduto(carregarProdutos);
            addProduto.Show();
        }

        private void dataGridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
