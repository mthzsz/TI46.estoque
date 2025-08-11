namespace TI46.estoque._0._1
{
    partial class ucPagCartao
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblUltimosDigitos = new System.Windows.Forms.Label();
            this.lblParcelamento = new System.Windows.Forms.Label();
            this.txtUltimosDigitos = new System.Windows.Forms.TextBox();
            this.cbParcelamento = new System.Windows.Forms.ComboBox();
            this.progressBarPagamento = new System.Windows.Forms.ProgressBar();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(42, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 24);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Subtotal:";
            // 
            // lblUltimosDigitos
            // 
            this.lblUltimosDigitos.AutoSize = true;
            this.lblUltimosDigitos.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimosDigitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimosDigitos.Location = new System.Drawing.Point(42, 44);
            this.lblUltimosDigitos.Name = "lblUltimosDigitos";
            this.lblUltimosDigitos.Size = new System.Drawing.Size(116, 24);
            this.lblUltimosDigitos.TabIndex = 2;
            this.lblUltimosDigitos.Text = "Dig. cartão:";
            // 
            // lblParcelamento
            // 
            this.lblParcelamento.AutoSize = true;
            this.lblParcelamento.BackColor = System.Drawing.Color.Transparent;
            this.lblParcelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelamento.Location = new System.Drawing.Point(42, 84);
            this.lblParcelamento.Name = "lblParcelamento";
            this.lblParcelamento.Size = new System.Drawing.Size(96, 24);
            this.lblParcelamento.TabIndex = 3;
            this.lblParcelamento.Text = "Parcelas:";
            // 
            // txtUltimosDigitos
            // 
            this.txtUltimosDigitos.Location = new System.Drawing.Point(217, 48);
            this.txtUltimosDigitos.MaxLength = 4;
            this.txtUltimosDigitos.Name = "txtUltimosDigitos";
            this.txtUltimosDigitos.Size = new System.Drawing.Size(121, 20);
            this.txtUltimosDigitos.TabIndex = 5;
            // 
            // cbParcelamento
            // 
            this.cbParcelamento.FormattingEnabled = true;
            this.cbParcelamento.Location = new System.Drawing.Point(217, 84);
            this.cbParcelamento.Name = "cbParcelamento";
            this.cbParcelamento.Size = new System.Drawing.Size(121, 21);
            this.cbParcelamento.TabIndex = 6;
            // 
            // progressBarPagamento
            // 
            this.progressBarPagamento.ForeColor = System.Drawing.Color.SteelBlue;
            this.progressBarPagamento.Location = new System.Drawing.Point(77, 162);
            this.progressBarPagamento.Name = "progressBarPagamento";
            this.progressBarPagamento.Size = new System.Drawing.Size(209, 24);
            this.progressBarPagamento.TabIndex = 7;
            this.progressBarPagamento.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Location = new System.Drawing.Point(43, 121);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(106, 24);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(217, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 24);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(212, 11);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(61, 25);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "R$ 0";
            // 
            // ucPagCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.progressBarPagamento);
            this.Controls.Add(this.cbParcelamento);
            this.Controls.Add(this.txtUltimosDigitos);
            this.Controls.Add(this.lblParcelamento);
            this.Controls.Add(this.lblUltimosDigitos);
            this.Controls.Add(this.lblTotal);
            this.Name = "ucPagCartao";
            this.Size = new System.Drawing.Size(387, 242);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblUltimosDigitos;
        private System.Windows.Forms.Label lblParcelamento;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.TextBox txtUltimosDigitos;
        public System.Windows.Forms.ComboBox cbParcelamento;
        public System.Windows.Forms.ProgressBar progressBarPagamento;
        public System.Windows.Forms.Label lblSubtotal;
    }
}
