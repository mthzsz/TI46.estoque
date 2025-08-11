using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI46.estoque._0._1
{
    public partial class ucCaixa : UserControl

    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=bd_Integrador;Integrated Security=True;";

        public ucCaixa()
        {
            InitializeComponent();
            txtCodigoProduto.Focus();
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            CalcularSubtotal();
            AtualizarSubtotal();
            dgvProdutos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.ColumnHeadersVisible = true;
            dgvProdutos.ClearSelection();
            dgvProdutos.DefaultCellStyle.SelectionBackColor = dgvProdutos.DefaultCellStyle.BackColor;
            dgvProdutos.DefaultCellStyle.SelectionForeColor = dgvProdutos.DefaultCellStyle.ForeColor;
            dgvProdutos.CurrentCell = null;
            dgvProdutos.Columns[0].Width = (int)(dgvProdutos.Width * 0.50); // 33% da largura total
            dgvProdutos.Columns[1].Width = (int)(dgvProdutos.Width * 0.25); // 33% da largura total
            dgvProdutos.Columns[2].Width = (int)(dgvProdutos.Width * 0.25); // 33% da largura total

        }

        public decimal Subtotal
        {
            get
            {
                decimal valor;
                if (decimal.TryParse(lblSubtotal.Text.Replace("R$", "").Trim(), out valor))
                {
                    return valor;
                }
                return 0; // Se não conseguir converter, retorna 0
            }
        }

        public DataGridView DgvProdutos
        {
            get { return dgvProdutos; }
        }


        private decimal CalcularSubtotal()
        {
            decimal subtotal = 0;

            // Percorre todas as linhas do DataGridView
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                // Obtém a quantidade e o preço da linha atual
                if (row.Cells["dgvQuantidade"].Value != null && row.Cells["dgvPreco"].Value != null)
                {
                    int quantidade = Convert.ToInt32(row.Cells["dgvQuantidade"].Value);
                    decimal preco = Convert.ToDecimal(row.Cells["dgvPreco"].Value.ToString().Replace("R$", "").Trim());

                    // Adiciona ao subtotal
                    subtotal += quantidade * preco;
                }
            }

            return subtotal;
        }


        public void DarBaixaNoEstoque(string codigoProduto, int quantidadeVendida)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=bd_Integrador;Integrated Security=True"; // Usando LocalDB

            string query = @"
        UPDATE estoque
        SET quantidade = quantidade - @quantidadeVendida
        WHERE codigodebarras = @codigoProduto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adiciona os parâmetros
                    command.Parameters.AddWithValue("@quantidadeVendida", quantidadeVendida);
                    command.Parameters.AddWithValue("@codigoProduto", codigoProduto);

                    // Abre a conexão e executa a query
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    // Verifica se a atualização foi bem-sucedida
                }
            }
        }

        private void AtualizarSubtotal()
        {
            decimal subtotal = CalcularSubtotal();
            lblSubtotal.Text = subtotal.ToString("C2"); // Formata como moeda (R$)
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(lblSubtotal.Text.Replace("R$", "").Trim());
            PassarSubtotal(subtotal); // Passa o subtotal para o método

        }

        private void PassarSubtotal(decimal subtotal)
        {
            formPagamento formPag = new formPagamento();
            formPag.Subtotal = subtotal; // Passa o subtotal para o formPagamento

            // Assinar o evento de venda finalizada
            formPag.VendaFinalizada += FormPag_VendaFinalizada;

            // Mostrar o formPagamento
            formPag.ShowDialog();
        }
        private void FormPag_VendaFinalizada(object sender, EventArgs e)
        {
            // Limpar o dgvProdutos e o subtotal
            FinalizarVenda();
            LimparVenda();

        }

        private Produto BuscarProdutoPorCodigo(string codigoProduto)
            {
            Produto produto = null;
            codigoProduto = codigoProduto.Trim();  // Remover espaços extras no código

            string query = "SELECT descricao, preco, quantidade, codigodebarras FROM estoque WHERE codigodebarras = @codigo";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@codigo", codigoProduto);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        
                        string descricao = reader["descricao"].ToString();
                        decimal preco = reader["preco"] != DBNull.Value ? Convert.ToDecimal(reader["preco"]) : 0m;
                        int quantidade = reader["quantidade"] != DBNull.Value ? Convert.ToInt32(reader["quantidade"]) : 0;
                        string codigoDeBarras = reader["codigodebarras"].ToString();
                        produto = new Produto(descricao, preco, quantidade, codigoDeBarras);

                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado com o código: " + codigoProduto);  // Código não encontrado no banco
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar produto: " + ex.Message);  // Mensagem de erro ao tentar buscar o produto
                }
            }

            return produto;
        }

        private void FinalizarVenda()
        {
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                // Obtém o código de barras da coluna oculta
                string codigoProduto = row.Cells["dgvCodigoDeBarras"].Value.ToString();
                int quantidadeVendida = Convert.ToInt32(row.Cells["dgvQuantidade"].Value);

                // Dá baixa no estoque
                DarBaixaNoEstoque(codigoProduto, quantidadeVendida);
            }

            // Limpa o dgvProdutos e o subtotal
            LimparVenda();
        }


        public class Produto
        {
            public string Descricao { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }
            public string CodigoDeBarras { get; set; } // Adicionando código de barras

            public Produto(string descricao, decimal preco, int quantidade, string codigoDeBarras)
            {
                Descricao = descricao;
                Preco = preco;
                Quantidade = quantidade;
                CodigoDeBarras = codigoDeBarras;
            }
        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            PreencherDataGrid();
        }

        private void txtCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Enter)){
                PreencherDataGrid();
            }
            if (e.KeyCode == Keys.F5)
            {
                
            }
        }
        private void PreencherDataGrid()
        {
            string codigoProduto = txtCodigoProduto.Text.Trim();

            if (!string.IsNullOrWhiteSpace(codigoProduto))
            {
                Produto produto = BuscarProdutoPorCodigo(codigoProduto);

                if (produto != null)
                {
                    int quantidadeSelecionada = Convert.ToInt32(txtQuantidade.Value);

                    // Adiciona o produto ao dgvProdutos
                    dgvProdutos.Rows.Add(
                        produto.Descricao, // Descrição
                        quantidadeSelecionada, // Quantidade
                        produto.Preco.ToString("C2"), // Preço
                        produto.CodigoDeBarras // Código de Barras (oculto)
                    );

                    AtualizarSubtotal(); // Atualiza o subtotal
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um código de produto válido.");
            }

            txtCodigoProduto.Clear();
            txtCodigoProduto.Focus();
        }

        public void LimparVenda()
        {
            // Limpar o DataGridView
            dgvProdutos.Rows.Clear();  // Limpa as linhas do DataGridView

            // Zerando o valor do subtotal
            lblSubtotal.Text = "R$ 0,00";  // Ou o valor que você utiliza para zerar o subtotal
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Clear();
            lblSubtotal.Text = string.Empty;
        }
    }
    
}