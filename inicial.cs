using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI46.estoque._0._1
{


    public partial class inicial : Form
    {
        private ucCaixa caixa;
        public inicial()
        {
            InitializeComponent();
            label3.MouseEnter += new EventHandler(label3_MouseEnter);
            label3.MouseLeave += new EventHandler(label3_MouseLeave);

        }
        public inicial(string usuario)
        {
            InitializeComponent();
            txtUserInicial.Text = usuario;
            this.Load += inicial_Load;
        }

        

         private void inicial_Load(object sender, EventArgs e)
        {
            // Carrega o dashboard no pnConteudo assim que o formulário for carregado
            CarregarDashboard();
        }

        private void CarregarDashboard()
        {
            // Limpa o painel de conteúdo
            pnConteudo.Controls.Clear();

            // Cria e configura o DashboardControl
            DashboardControl dashboard = new DashboardControl();
            dashboard.Dock = DockStyle.Fill; // Faz o dashboard preencher todo o painel

            // Adiciona o dashboard ao painel de conteúdo
            pnConteudo.Controls.Add(dashboard);
        }
    
        private void table_ProdBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_ProdBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdProjetoV1DataSet);
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            formPagamento formpagamento = new formPagamento();
            formpagamento.ShowDialog();           
        }

        private void label8_Click(object sender, EventArgs e)
        {           
            pnConteudo.Controls.Clear();          
            ucEstoque estoque = new ucEstoque();            
            estoque.Dock = DockStyle.Fill;           
            pnConteudo.Controls.Add(estoque);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            pnConteudo.Controls.Clear();
            ucCliente cliente = new ucCliente();
            cliente.Dock = DockStyle.Fill;
            pnConteudo.Controls.Add(cliente);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pnConteudo.Controls.Clear();
            ucCaixa caixa = new ucCaixa();
            caixa.Dock = DockStyle.Fill;
            pnConteudo.Controls.Add(caixa);
        }
        public string Usuario { get; set; }

        // Método para preencher o campo txtUserInicial com o valor do usuário
        public void PreencherUsuario()
        {
            txtUserInicial.Text = Usuario;
        }

        public void IniciarCaixa()
        {
            // Instancia o UserControl ucCaixa
            ucCaixa caixa = new ucCaixa();

            // Adiciona o ucCaixa no formulário
            caixa.Dock = DockStyle.Fill; // Preenche o espaço disponível
            this.Controls.Add(caixa); // Adiciona o UC ao formulário

            // Se precisar de alguma configuração no ucCaixa, pode ser feita aqui.
            // Exemplo: caixa.Configurar(nomeUsuario);
        }

        private void pbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                formPagamento formPagamento = new formPagamento();
                formPagamento.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pnConteudo.Controls.Clear();
            DashboardControl dash = new DashboardControl();
            dash.Dock = DockStyle.Fill;
            pnConteudo.Controls.Add(dash);
        }
        private void MudarCor(Label lbl, Color corTexto, Color corFundo)
        {
            lbl.ForeColor = corTexto;  // Muda a cor do texto
            lbl.BackColor = corFundo;  // Muda a cor de fundo
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            MudarCor(label3, Color.Silver, Color.Transparent);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            MudarCor(label3, Color.White, Color.Transparent);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MudarCor(label1, Color.Silver, Color.Transparent);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            MudarCor(label1, Color.White, Color.Transparent);
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            MudarCor(label8, Color.Silver, Color.Transparent);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            MudarCor(label8, Color.White, Color.Transparent);
        }

        // Outras implementações do FormInicial...
    }

}


