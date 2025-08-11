using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI46.estoque._0._1
{
    public partial class ucPagDinheiro : UserControl
    {

        public ucPagDinheiro(decimal subtotal)
        {
            InitializeComponent();
            lblSubtotal.Text = subtotal.ToString("C2"); // Formata como moeda
            lblTroco.Text = "R$ 0,00";

            textBox1.TextChanged += textBox1_TextChanged;
        }
        private void ucPagDinheiro_Load(object sender, EventArgs e)
        {
            lblSubtotal.Text = lblSubtotal.Text;  // Apenas para garantir a atualização na UI
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal valorInserido))
            {
                // Obtém o valor do subtotal (remove o "R$" e converte para decimal)
                decimal subtotal = decimal.Parse(lblSubtotal.Text.Replace("R$", "").Trim());

                // Calcula o troco
                decimal troco = valorInserido - subtotal;

                // Verifica se o valor inserido é suficiente
                if (troco >= 0)
                {
                    // Exibe o troco no lblTroco
                    lblTroco.Text = troco.ToString("C2"); // Formata como moeda (R$)
                }
                else
                {
                    // Se o valor inserido for menor que o subtotal, define o troco como zero
                    lblTroco.Text = "R$ 0,00";
                }
            }
            else
            {
                // Se o valor inserido não for válido, limpa o lblTroco
                lblTroco.Text = "R$ 0,00";
            }
        }
    }
}
