using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TI46.estoque._0._1
{


    public partial class formPagamento : Form
    {

        public decimal Subtotal { get; set; }

        public event EventHandler VendaFinalizada;

        public formPagamento()
        {
            InitializeComponent();
            CarregarPagamento();
            AbrirUC();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(formPagamento_KeyDown);
        }

        private void formPagamento_Load(object sender, EventArgs e)
        {
            this.Focus(); // Define o foco no formulário
        }

        public void InserirVenda(decimal totalVenda, string formaPagamento, decimal troco, string codigoPix, string statusPagamento, string observacoes)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=bd_Integrador;Integrated Security=True"; // Substitua pela sua string de conexão
            string query = @"
        INSERT INTO Vendas (DataVenda, TotalVenda, FormaPagamento, Troco, CodigoPix, StatusPagamento, Observacoes)
        VALUES (@DataVenda, @TotalVenda, @FormaPagamento, @Troco, @CodigoPix, @StatusPagamento, @Observacoes)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adiciona os parâmetros
                    command.Parameters.AddWithValue("@DataVenda", DateTime.Now);
                    command.Parameters.AddWithValue("@TotalVenda", totalVenda);
                    command.Parameters.AddWithValue("@FormaPagamento", formaPagamento);
                    command.Parameters.AddWithValue("@Troco", troco);
                    command.Parameters.AddWithValue("@CodigoPix", codigoPix ?? (object)DBNull.Value); // Trata NULL para CodigoPix
                    command.Parameters.AddWithValue("@StatusPagamento", statusPagamento);
                    command.Parameters.AddWithValue("@Observacoes", observacoes ?? (object)DBNull.Value); // Trata NULL para Observacoes

                    // Abre a conexão e executa a query
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void TrocarParaPagamentoDinheiro()
        {
            pnPagamento.Controls.Clear(); // Limpa o painel de pagamento

            // Cria uma instância do ucPagDinheiro e passa o subtotal
            ucPagDinheiro ucDinheiro = new ucPagDinheiro(this.Subtotal);
            ucDinheiro.Dock = DockStyle.Fill; // Preenche o painel

            // Adiciona o ucPagDinheiro ao painel
            pnPagamento.Controls.Add(ucDinheiro);
        }

        private void TrocarParaPagamentoCartao()
        {
            pnPagamento.Controls.Clear(); // Limpa o painel de pagamento

            // Cria uma instância do ucPagCartao e passa o subtotal
            ucPagCartao ucCartao = new ucPagCartao(this.Subtotal);
            ucCartao.Dock = DockStyle.Fill; // Preenche o painel

            // Adiciona o ucPagCartao ao painel
            pnPagamento.Controls.Add(ucCartao);
        }
        public void FinalizarVenda()
        {
            // Lógica para finalizar a venda...

            // Disparar o evento de venda finalizada
            VendaFinalizada?.Invoke(this, EventArgs.Empty);
        }

        private void AbrirUC()
        {
            // Crie uma instância do UserControl
            ucEscPagamento ucEscPagamento = new ucEscPagamento();

            // Certifique-se de que o UserControl seja do tamanho do painel
            ucEscPagamento.Dock = DockStyle.Fill;

            // Adicione o UserControl ao pnPagamento
            pnPagamento.Controls.Clear();  // Limpa o painel caso já tenha outros controles
            pnPagamento.Controls.Add(ucEscPagamento);  // Adiciona o ucPagDinheiro ao painel
        }
        private void CarregarPagamento()
        {
            pnPagamento.Controls.Clear();
            ucEscPagamento ucEscPagamento = new ucEscPagamento();
            ucEscPagamento.Dock = DockStyle.Fill;
            pnPagamento.Controls.Add(ucEscPagamento);
        }
        private bool vendaConcluida = false;
        private void formPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (vendaConcluida) return; // Se a venda já foi concluída, sai do método

            // Variáveis para armazenar as informações do pagamento
            decimal subtotal = 0;
            decimal troco = 0;
            string formaPagamento = "";
            string codigoPix = null;

            // Verifica se a tecla 1 foi pressionada (Trocar para Dinheiro)
            if (e.KeyCode == Keys.D1) // Tecla 1 ou 1 do teclado numérico
            {
                TrocarParaPagamentoDinheiro();
                e.Handled = true; // Indica que o evento foi tratado
            }

            // Verifica se a tecla 2 foi pressionada (Trocar para Cartão)
            if (e.KeyCode == Keys.D2) // Tecla 2 ou 2 do teclado numérico
            {
                TrocarParaPagamentoCartao();
                e.Handled = true; // Indica que o evento foi tratado
            }

            // Verifica se a tecla 3 foi pressionada (PIX)
            if (e.KeyCode == Keys.D3) // Tecla 3 ou 3 do teclado numérico
            {
                // Prepara os dados para pagamento via PIX
                subtotal = this.Subtotal;
                formaPagamento = "PIX";
                codigoPix = "1234-5678-9012-3456"; // Substitua pelo código PIX gerado

                // Exibe a mensagem de pagamento via PIX
                string mensagemVenda = $"Pagamento via PIX Concluído com Sucesso!\n\n" +
                                       $"Total da Venda: {subtotal:C2}\n" +
                                       $"Código PIX: {codigoPix}\n\n" +
                                       "Aguarde a confirmação do pagamento.";
                MessageBox.Show(mensagemVenda, "Pagamento Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Insere a venda no banco de dados
                InserirVenda(totalVenda: subtotal, formaPagamento: formaPagamento, troco: troco, codigoPix: codigoPix, statusPagamento: "Confirmado", observacoes: "Pagamento via PIX confirmado.");

                vendaConcluida = true; // Marca a venda como concluída
            }

            // Verifica se a tecla Enter foi pressionada (Dinheiro ou Cartão)
            if (e.KeyCode == Keys.Enter) // Tecla Enter para confirmar a venda
            {
                // Variáveis para definir o pagamento (Dinheiro ou Cartão)
                foreach (Control control in pnPagamento.Controls)
                {
                    if (control is ucPagDinheiro)
                    {
                        ucPagDinheiro ucDinheiro = (ucPagDinheiro)control;
                        subtotal = decimal.Parse(ucDinheiro.lblSubtotal.Text.Replace("R$", "").Trim());
                        troco = decimal.Parse(ucDinheiro.lblTroco.Text.Replace("R$", "").Trim());
                        formaPagamento = "Dinheiro";

                        // Exibe a mensagem de pagamento em dinheiro
                        string mensagemVenda = $"Venda Concluída com Sucesso!\n\n" +
                                               $"Total da Venda: {subtotal:C2}\n" +
                                               $"Troco: {troco:C2}";
                        MessageBox.Show(mensagemVenda, "Pagamento Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Insere a venda no banco de dados
                        InserirVenda(totalVenda: subtotal, formaPagamento: formaPagamento, troco: troco, codigoPix: null, statusPagamento: "Confirmado", observacoes: "Pagamento em dinheiro confirmado.");

                        vendaConcluida = true; // Marca a venda como concluída
                        break; // Sai do loop após encontrar o ucPagDinheiro
                    }

                    if (control is ucPagCartao)
                    {
                        ucPagCartao ucCartao = (ucPagCartao)control;
                        ucCartao.btnConfirmar.PerformClick(); // Simula o clique no botão
                        subtotal = ucCartao.Subtotal;
                        formaPagamento = "Cartão";

                        // Exibe a mensagem de pagamento com cartão
                        string mensagemVenda = $"Venda Concluída com Sucesso!\n\n" +
                                               $"Total da Venda: {subtotal:C2}";
                        MessageBox.Show(mensagemVenda, "Pagamento Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Insere a venda no banco de dados
                        InserirVenda(totalVenda: subtotal, formaPagamento: formaPagamento, troco: 0, codigoPix: null, statusPagamento: "Confirmado", observacoes: "Pagamento com cartão confirmado.");

                        vendaConcluida = true; // Marca a venda como concluída
                        break; // Sai do loop após encontrar o ucPagCartao
                    }
                }
            }

            // Se alguma forma de pagamento foi escolhida, chamamos a função para finalizar a venda
            if (!string.IsNullOrEmpty(formaPagamento))
            {
                // Dá baixa no estoque dos produtos vendidos
                FinalizarVenda(); // Chama a função para finalizar a venda

                // Fecha o formPagamento
                this.Close();
                e.Handled = true; // Indica que o evento foi tratado
            }
        }
    }
}