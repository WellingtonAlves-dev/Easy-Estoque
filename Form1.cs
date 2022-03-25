namespace Estoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarHome();
        }
        public void LoadForm(Form formulario)
        {
            int quantidadeFormsNoPainel = page.Controls.Count;
            if(quantidadeFormsNoPainel > 0)
            {
                page.Controls.RemoveAt(0);
            }
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.TopMost = true;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Size = new System.Drawing.Size(589, 331);
            formulario.TopLevel = false;
            formulario.AutoScroll = true;
            page.Controls.Add(formulario);
            formulario.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Deseja realmente fechar essa janela?", "Confirmar Fechamento", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            CarregarHome();
        }
        void CarregarHome()
        {
            Painel.Home home = new Painel.Home();
            LoadForm(home);
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Painel.Produtos produtos = new Painel.Produtos();
            LoadForm(produtos);
        }
    }
}