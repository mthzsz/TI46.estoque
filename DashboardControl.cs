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
using System.Windows.Forms.DataVisualization.Charting;

namespace TI46.estoque._0._1
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            AtualizarEstoque();
            AtualizarVendas();
            dgvVendas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVendas.RowHeadersVisible = false;
            dgvVendas.ColumnHeadersVisible = true;
            dgvVendas.ColumnHeadersVisible = false;
            dgvVendas.ClearSelection();
            dgvVendas.DefaultCellStyle.SelectionBackColor = dgvVendas.DefaultCellStyle.BackColor;
            dgvVendas.DefaultCellStyle.SelectionForeColor = dgvVendas.DefaultCellStyle.ForeColor;
            dgvVendas.CurrentCell = null;
            // Configura o User Control
            this.Size = new System.Drawing.Size(1280, 633);


        }

        public void AtualizarEstoque()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=bd_Integrador;Integrated Security=True"))
                {
                    connection.Open();

                    string query = @"
            SELECT c.nome AS Categoria, SUM(e.quantidade) AS TotalPorCategoria
            FROM estoque e
            JOIN Categorias c ON e.idCategoria = c.idCategorias
            GROUP BY c.nome";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader()) // Usa 'using' para fechar automaticamente
                    {
                        // Inicializa todas as labels com "0"
                        lblEstoque.Text = "0";
                        lblEletronicos.Text = "0";
                        lblRoupas.Text = "0";
                        lblAlimentos.Text = "0";
                        lblMoveis.Text = "0";
                        lblLivros.Text = "0";
                        lblBrinquedos.Text = "0";
                        lblEsportes.Text = "0";
                        lblBeleza.Text = "0";
                        lblAutomoveis.Text = "0";
                        lblFerramentas.Text = "0";

                        int totalProdutos = 0;

                        while (reader.Read())
                        {
                            string categoria = reader["Categoria"].ToString();
                            int total = Convert.ToInt32(reader["TotalPorCategoria"]);
                            totalProdutos += total;

                            // Define os valores nas labels correspondentes
                            switch (categoria)
                            {
                                case "Eletrônicos":
                                    lblEletronicos.Text = total.ToString();
                                    break;
                                case "Roupas":
                                    lblRoupas.Text = total.ToString();
                                    break;
                                case "Alimentos":
                                    lblAlimentos.Text = total.ToString();
                                    break;
                                case "Móveis":
                                    lblMoveis.Text = total.ToString();
                                    break;
                                case "Livros":
                                    lblLivros.Text = total.ToString();
                                    break;
                                case "Brinquedos":
                                    lblBrinquedos.Text = total.ToString();
                                    break;
                                case "Esportes":
                                    lblEsportes.Text = total.ToString();
                                    break;
                                case "Beleza":
                                    lblBeleza.Text = total.ToString();
                                    break;
                                case "Automóveis":
                                    lblAutomoveis.Text = total.ToString();
                                    break;
                                case "Ferramentas":
                                    lblFerramentas.Text = total.ToString();
                                    break;
                            }
                        }

                        // Atualiza o total geral
                        lblEstoque.Text = totalProdutos.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
        }

        public void AtualizarVendas()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=bd_Integrador;Integrated Security=True"))

                {
                    connection.Open();

                    // Consulta para pegar o total de vendas
                    string queryTotalVendas = "SELECT COALESCE(SUM(TotalVenda), 0) FROM vendas";

                    using (SqlCommand commandTotal = new SqlCommand(queryTotalVendas, connection))
                    {
                        object result = commandTotal.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            decimal totalVendas = Convert.ToDecimal(result);
                            lblVendasTotal.Text = $"R$ {totalVendas:F2}"; // Formata corretamente
                        }
                        else
                        {
                            lblVendasTotal.Text = "R$ 0,00"; // Garante que nunca fica vazio
                        }
                    }

                    // Consulta para pegar as últimas vendas com a data
                    string queryUltimasVendas = @"
                SELECT TotalVenda, FormaPagamento, StatusPagamento, DataVenda
                FROM vendas 
                ORDER BY DataVenda DESC";  // Ordena pela data para pegar as mais recentes

                    using (SqlDataAdapter adapter = new SqlDataAdapter(queryUltimasVendas, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvVendas.DataSource = dt;

                        // Adiciona a formatação para a coluna de DataVenda
                        dgvVendas.Columns["DataVenda"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Formata a data
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar vendas: " + ex.Message);
            }
        }
    }
}



