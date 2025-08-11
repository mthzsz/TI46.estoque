using System;

namespace TI46.estoque._0._1
{
    partial class ucEstoque
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
            this.dgEstoque = new System.Windows.Forms.DataGridView();
            this.btnAdcProd = new System.Windows.Forms.Button();
            this.btnRmvProd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEstoque
            // 
            this.dgEstoque.AllowUserToAddRows = false;
            this.dgEstoque.AllowUserToDeleteRows = false;
            this.dgEstoque.AllowUserToResizeColumns = false;
            this.dgEstoque.AllowUserToResizeRows = false;
            this.dgEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEstoque.BackgroundColor = System.Drawing.Color.White;
            this.dgEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoque.Location = new System.Drawing.Point(17, 0);
            this.dgEstoque.MultiSelect = false;
            this.dgEstoque.Name = "dgEstoque";
            this.dgEstoque.ReadOnly = true;
            this.dgEstoque.RowHeadersVisible = false;
            this.dgEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgEstoque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstoque.ShowCellErrors = false;
            this.dgEstoque.ShowCellToolTips = false;
            this.dgEstoque.Size = new System.Drawing.Size(1051, 411);
            this.dgEstoque.TabIndex = 0;
            // 
            // btnAdcProd
            // 
            this.btnAdcProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnAdcProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcProd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdcProd.Location = new System.Drawing.Point(68, 72);
            this.btnAdcProd.Name = "btnAdcProd";
            this.btnAdcProd.Size = new System.Drawing.Size(180, 36);
            this.btnAdcProd.TabIndex = 1;
            this.btnAdcProd.Text = "&Adicionar Produto";
            this.btnAdcProd.UseVisualStyleBackColor = false;
            this.btnAdcProd.Click += new System.EventHandler(this.btnAdcProd_Click);
            // 
            // btnRmvProd
            // 
            this.btnRmvProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.btnRmvProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmvProd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRmvProd.Location = new System.Drawing.Point(264, 72);
            this.btnRmvProd.Name = "btnRmvProd";
            this.btnRmvProd.Size = new System.Drawing.Size(180, 36);
            this.btnRmvProd.TabIndex = 2;
            this.btnRmvProd.Text = "&Remover Produto";
            this.btnRmvProd.UseVisualStyleBackColor = false;
            this.btnRmvProd.Click += new System.EventHandler(this.btnRmvProd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dgEstoque);
            this.panel1.Location = new System.Drawing.Point(86, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 414);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.panel2.Location = new System.Drawing.Point(70, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 446);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::TI46.estoque._0._1.Properties.Resources.vecteezy_line_shadow_effect_png_21104595;
            this.pictureBox4.Location = new System.Drawing.Point(-3, -89);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1267, 178);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // ucEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRmvProd);
            this.Controls.Add(this.btnAdcProd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Name = "ucEstoque";
            this.Size = new System.Drawing.Size(1264, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEstoque;
        private System.Windows.Forms.Button btnAdcProd;
        private System.Windows.Forms.Button btnRmvProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
