namespace Estoque.Painel
{
    partial class Produtos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.btnAddProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProdutos
            // 
            this.dataGridProdutos.AllowUserToAddRows = false;
            this.dataGridProdutos.AllowUserToDeleteRows = false;
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Location = new System.Drawing.Point(12, 52);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.ReadOnly = true;
            this.dataGridProdutos.RowTemplate.Height = 25;
            this.dataGridProdutos.Size = new System.Drawing.Size(565, 267);
            this.dataGridProdutos.TabIndex = 0;
            this.dataGridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProdutos_CellContentClick);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Location = new System.Drawing.Point(12, 23);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduto.TabIndex = 1;
            this.btnAddProduto.Text = "Adicionar Produto";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 331);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.dataGridProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridProdutos;
        private Button btnAddProduto;
    }
}