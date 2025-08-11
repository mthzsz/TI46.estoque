using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI46.estoque._0._1
{
    public partial class ucPagCartao : UserControl
    {
        public decimal Subtotal { get; set; }

        public ucPagCartao(decimal subtotal)
        {
            InitializeComponent();
            Subtotal = subtotal;
            lblSubtotal.Text = Subtotal.ToString("C"); // Exibe o subtotal no label (se houver)
            PreencherParcelamento();
        }

        public ucPagCartao()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void PreencherParcelamento()
        {
            cbParcelamento.Items.Clear(); // Limpa os itens antes de adicionar novos
            int maxParcelas = 12; // Número máximo de parcelas permitidas
            for (int i = 1; i <= maxParcelas; i++)
            {
                cbParcelamento.Items.Add(i + "x"); // Adiciona "1x", "2x", etc.
            }
            cbParcelamento.SelectedIndex = 0; // Define "1x" como padrão
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = false; // Impede múltiplos cliques
            progressBarPagamento.Visible = true; // Mostra a barra de progresso
            progressBarPagamento.Style = ProgressBarStyle.Marquee; // Inicia animação

            await Task.Delay(2000); // Simula o tempo de processamento

            progressBarPagamento.Visible = false; // Esconde a barra

            // Detalhes da venda
            decimal totalVenda = this.Subtotal;  // Subtotal calculado
            string parcelamento = cbParcelamento.SelectedItem.ToString(); // Forma de parcelamento
            int parcelas = int.Parse(parcelamento.Substring(0, 1)); // Quantidade de parcelas (1x, 2x, etc.)
            string formaPagamento = "Cartão";  // Exemplo de pagamento, pode ser alterado conforme o seu código

            // Exibe a mensagem com detalhes
            string mensagemVenda = $"Venda Concluída com Sucesso!\n\n" +
                                   $"Total da Venda: {totalVenda:C2}\n" +
                                   $"Forma de Pagamento: {formaPagamento}\n" +
                                   $"Parcelamento: {parcelas}x";

            MessageBox.Show(mensagemVenda, "Pagamento Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Subir na hierarquia de controles para encontrar o formulário pai (formPagamento)
            Control parentControl = this.Parent; // Começa com o pai direto (pnPagamento)
            while (parentControl != null && !(parentControl is Form))
            {
                parentControl = parentControl.Parent; // Sobe na hierarquia
            }

            if (parentControl is formPagamento formPagamento)
            {
                // Disparar o evento de venda finalizada
                formPagamento.FinalizarVenda();

                // Fecha o formPagamento
                if (formPagamento.Modal)
                {
                    formPagamento.DialogResult = DialogResult.OK; // Define o resultado do diálogo
                }
                formPagamento.Close(); // Fecha o formulário
            }
            else
            {
                MessageBox.Show("Erro: Não foi possível encontrar o formulário pai.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

