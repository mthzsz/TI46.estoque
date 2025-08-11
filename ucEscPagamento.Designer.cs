namespace TI46.estoque._0._1
{
    partial class ucEscPagamento
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
            this.btnDinheiro = new System.Windows.Forms.Button();
            this.btnCartao = new System.Windows.Forms.Button();
            this.btnPix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDinheiro
            // 
            this.btnDinheiro.BackColor = System.Drawing.Color.Transparent;
            this.btnDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinheiro.Location = new System.Drawing.Point(117, 98);
            this.btnDinheiro.Name = "btnDinheiro";
            this.btnDinheiro.Size = new System.Drawing.Size(133, 42);
            this.btnDinheiro.TabIndex = 0;
            this.btnDinheiro.Text = "Cartão (2)";
            this.btnDinheiro.UseVisualStyleBackColor = false;
            // 
            // btnCartao
            // 
            this.btnCartao.BackColor = System.Drawing.Color.Transparent;
            this.btnCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartao.Location = new System.Drawing.Point(117, 38);
            this.btnCartao.Name = "btnCartao";
            this.btnCartao.Size = new System.Drawing.Size(133, 42);
            this.btnCartao.TabIndex = 1;
            this.btnCartao.Text = "Dinheiro (1)";
            this.btnCartao.UseVisualStyleBackColor = false;
            // 
            // btnPix
            // 
            this.btnPix.BackColor = System.Drawing.Color.Transparent;
            this.btnPix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPix.Location = new System.Drawing.Point(117, 161);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(133, 42);
            this.btnPix.TabIndex = 2;
            this.btnPix.Text = "Pix (3)";
            this.btnPix.UseVisualStyleBackColor = false;
            // 
            // ucEscPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.btnCartao);
            this.Controls.Add(this.btnDinheiro);
            this.Name = "ucEscPagamento";
            this.Size = new System.Drawing.Size(387, 242);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDinheiro;
        private System.Windows.Forms.Button btnCartao;
        private System.Windows.Forms.Button btnPix;
    }
}
