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
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }
        public void btnAcessar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; Integrated Security = true; Database = bd_Integrador;"))

            {
                try
                {
                    conexao.Open();

                    string query = "SELECT nome FROM usuarios WHERE nome = @nome AND Senha = @Senha AND fiscal = 'sim'";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtUser.Text.Trim());
                        cmd.Parameters.AddWithValue("@Senha", txtSenha.Text.Trim());

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string nomeUsuario = reader["nome"].ToString(); // Pegando o nome do banco
                            reader.Close();

                            MessageBox.Show("Login bem-sucedido!");

                            // Abre o FormInicial passando o nome do usuário
                            inicial formInicial = new inicial(nomeUsuario);
                            this.Hide();

                            // Passa o nome de usuário para o FormInicial e inicializa o ucCaixa
                            formInicial.IniciarCaixa(); // Chama o método que adiciona o ucCaixa ao FormInicial
                            formInicial.ShowDialog();
                            this.Close(); // Fecha o FormLogin depois que o FormInicial for fechado
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
            }

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                using (SqlConnection conexao = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; Integrated Security = true; Database = bd_Integrador;"))
                {
                    try
                    {
                        conexao.Open();

                        string query = "SELECT nome FROM usuarios WHERE nome = @nome AND Senha = @Senha AND fiscal = 'sim'";

                        using (SqlCommand cmd = new SqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("@nome", txtUser.Text.Trim());
                            cmd.Parameters.AddWithValue("@Senha", txtSenha.Text.Trim());

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                string nomeUsuario = reader["nome"].ToString(); // Pegando o nome do banco
                                reader.Close();


                                // Abre o FormInicial passando o nome do usuário
                                inicial formInicial = new inicial(nomeUsuario);
                                this.Hide();
                                formInicial.ShowDialog();
                                this.Close(); // Fecha o FormLogin depois que o FormInicial for fechado
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha incorretos!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                    }
                }
            }
        }
    }
}

