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
    public partial class ucCliente : UserControl
    {
        public ucCliente()
        {
            InitializeComponent();
            CarregarClientes();
            dgvClientes.DefaultCellStyle.SelectionBackColor = dgvClientes.DefaultCellStyle.BackColor;
            dgvClientes.DefaultCellStyle.SelectionForeColor = dgvClientes.DefaultCellStyle.ForeColor;
            txtBusca.TextChanged += txtBusca_TextChanged;
        }
        //private string connectionString = @"Server=TIT0628248W11-1\SQLEXPRESS; Database=bd_Integrador; Integrated Security=True;";

        private void CarregarClientes()
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=bd_Integrador;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT idClientes, nome, cpf, DataDeCadastro FROM clientes"; // Consulta SQL

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvClientes.DataSource = dt; // Define o DataTable como fonte do DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.ToUpper();
            string cpf = txtCPF.Text.Trim();
            DateTime dataCadastro = dtpDataCadastro.Value; // Pega a data do DateTimePicker

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=bd_Integrador;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "INSERT INTO clientes (nome, cpf, DataDeCadastro) VALUES (@nome, @cpf, @dataCadastro)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Clear();
                            txtCPF.Clear();
                            dtpDataCadastro.Value = DateTime.Now; // Reseta a data
                            CarregarClientes(); // Atualiza a lista no DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string busca = txtBusca.Text.Trim();

            if (!string.IsNullOrWhiteSpace(busca))
            {
                string query = "SELECT nome, cpf, DataDeCadastro FROM clientes WHERE Nome LIKE @busca";

                //using (SqlConnection con = new SqlConnection("Server=TIT0628248W11-1\\SQLEXPRESS; Database=bd_Integrador; Integrated Security=True"))
                using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=bd_Integrador;Integrated Security=True"))

                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");

                    try
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvClientes.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um nome para buscar.");
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void BuscarClientes()
        {
            string busca = txtBusca.Text.Trim();

            string query = "SELECT nome, cpf, DataDeCadastro FROM clientes WHERE Nome LIKE @busca";

            //using (SqlConnection con = new SqlConnection("Server=TIT0628248W11-1\\SQLEXPRESS; Database=bd_Integrador; Integrated Security=True"))
            using (SqlConnection con = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=bd_Integrador;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClientes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                }
            }
        }
    }
    
}
