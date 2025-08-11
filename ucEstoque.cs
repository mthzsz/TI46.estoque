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
    public partial class ucEstoque : UserControl
    {
        public ucEstoque()
        {
            InitializeComponent();
            dgEstoque.ScrollBars = ScrollBars.Both;
            dgEstoque.Height = 400;
            dgEstoque.DefaultCellStyle.SelectionBackColor = dgEstoque.DefaultCellStyle.BackColor;
            dgEstoque.DefaultCellStyle.SelectionForeColor = dgEstoque.DefaultCellStyle.ForeColor;
            CarregarEstoque();
        }

        private void CarregarEstoque()
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=bd_Integrador;Integrated Security=True"))

                {
                    conn.Open();
                    string query = "SELECT idEstoques, descricao, marca, quantidade, preco, codigodebarras, idCategoria FROM estoque"; // Consulta SQL

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgEstoque.DataSource = dt; // Define o DataTable como fonte do DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdcProd_Click(object sender, EventArgs e)
        {
            AdcProdNovo AdicionarProd = new AdcProdNovo();
            AdicionarProd.ShowDialog();
            CarregarEstoque();
        }

        private void btnRmvProd_Click(object sender, EventArgs e)
        {
            formRmvEstoque formRmvEstoque = new formRmvEstoque();
            formRmvEstoque.ShowDialog();
            CarregarEstoque();
        }
    }
}
