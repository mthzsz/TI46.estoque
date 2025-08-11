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
    public partial class formRmvEstoque : Form
    {
        public formRmvEstoque()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Recupera os valores dos campos de texto
            string codigoProduto = txtCodProd.Text; // Código do produto digitado
            int quantidadeVendida;

            // Verifica se a quantidade é um número válido
            if (!int.TryParse(escQuantidade.Text, out quantidadeVendida))
            {
                MessageBox.Show("Quantidade inválida. Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chama a função para dar baixa no estoque
            DarBaixaNoEstoque(codigoProduto, quantidadeVendida);
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
                    try
                    {
                        // Adiciona os parâmetros
                        command.Parameters.AddWithValue("@quantidadeVendida", quantidadeVendida);
                        command.Parameters.AddWithValue("@codigoProduto", codigoProduto);

                        // Abre a conexão e executa a query
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verifica se a atualização foi bem-sucedida
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Baixa no estoque realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado ou quantidade insuficiente no estoque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao dar baixa no estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }



}
