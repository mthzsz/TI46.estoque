using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI46.estoque._0._1
{
    public partial class AdcProdNovo : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=bd_Integrador;Integrated Security=True;";

        public AdcProdNovo()
        {
            InitializeComponent();
            CarregarCategorias(); // Chama a função ao abrir o formulário
        }

        public void CarregarCategorias()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT idCategorias, Nome FROM categorias";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    escCategoria.DataSource = dt;
                    escCategoria.DisplayMember = "nome";
                    escCategoria.ValueMember = "idCategorias";
                    escCategoria.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Pegando os valores dos campos
            string descricao = txtDesc.Text.Trim().ToUpper();
            string marca = txtMarca.Text.Trim().ToUpper();
            string precoTexto = txtPreco.Text.Trim();
            string quantidadeTexto = escQuantidade.Text.Trim();
            string codigodebarras = txtCodProd.Text.Trim(); // Adicionando o campo código de barras
            object categoriaSelecionada = escCategoria.SelectedValue;

            // Validações
            if ( 
                string.IsNullOrWhiteSpace(descricao) ||
                string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrWhiteSpace(precoTexto) ||
                string.IsNullOrWhiteSpace(quantidadeTexto) ||
                string.IsNullOrWhiteSpace(codigodebarras) ||
                categoriaSelecionada == null)
            {
                MessageBox.Show("Preencha todos os campos antes de adicionar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(precoTexto, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantidadeTexto, out int quantidade) || quantidade < 0)
            {
                MessageBox.Show("Quantidade inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCategoria = Convert.ToInt32(categoriaSelecionada);

            // Inserção no banco
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO estoque (descricao, marca, quantidade, preco, codigodebarras, idCategoria) " +
                                   "VALUES (@descricao, @marca, @quantidade, @preco, @codigodebarras, @idCategoria)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("marca", marca);
                        cmd.Parameters.AddWithValue("@preco", preco);
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@codigodebarras", codigodebarras); // Adicionando código de barras
                        cmd.Parameters.AddWithValue("@idCategoria", idCategoria);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void LimparCampos()
        {
            txtCodProd.Clear();
            txtDesc.Clear();
            txtPreco.Clear();
            escCategoria.SelectedIndex = -1;
        }
    }
}
