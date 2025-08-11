namespace TI46.estoque._0._1
{
    partial class inicial
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicial));
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.bdProjetoV1DataSet = new TI46.estoque._0._1.bdProjetoV1DataSet();
            this.table_ProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_ProdTableAdapter = new TI46.estoque._0._1.bdProjetoV1DataSetTableAdapters.Table_ProdTableAdapter();
            this.tableAdapterManager = new TI46.estoque._0._1.bdProjetoV1DataSetTableAdapters.TableAdapterManager();
            this.bdProjetoV1DataSet3 = new TI46.estoque._0._1.bdProjetoV1DataSet3();
            this.tableProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_ProdTableAdapter1 = new TI46.estoque._0._1.bdProjetoV1DataSet3TableAdapters.Table_ProdTableAdapter();
            this.pnBack = new System.Windows.Forms.Panel();
            this.pnConteudo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserInicial = new System.Windows.Forms.Label();
            this.pnSombra = new System.Windows.Forms.Panel();
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdProjetoV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdProjetoV1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProdBindingSource)).BeginInit();
            this.pnBack.SuspendLayout();
            this.pnConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnSombra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // bdProjetoV1DataSet
            // 
            this.bdProjetoV1DataSet.DataSetName = "bdProjetoV1DataSet";
            this.bdProjetoV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_ProdBindingSource
            // 
            this.table_ProdBindingSource.DataMember = "Table_Prod";
            this.table_ProdBindingSource.DataSource = this.bdProjetoV1DataSet;
            // 
            // table_ProdTableAdapter
            // 
            this.table_ProdTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabela_clienteTableAdapter = null;
            this.tableAdapterManager.Table_ProdTableAdapter = this.table_ProdTableAdapter;
            this.tableAdapterManager.tb_item_pedidoTableAdapter = null;
            this.tableAdapterManager.tb_itemvendaTableAdapter = null;
            this.tableAdapterManager.tb_pedidoTableAdapter = null;
            this.tableAdapterManager.tb_VendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TI46.estoque._0._1.bdProjetoV1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdProjetoV1DataSet3
            // 
            this.bdProjetoV1DataSet3.DataSetName = "bdProjetoV1DataSet3";
            this.bdProjetoV1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableProdBindingSource
            // 
            this.tableProdBindingSource.DataMember = "Table_Prod";
            this.tableProdBindingSource.DataSource = this.bdProjetoV1DataSet3;
            // 
            // table_ProdTableAdapter1
            // 
            this.table_ProdTableAdapter1.ClearBeforeFill = true;
            // 
            // pnBack
            // 
            this.pnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.pnBack.Controls.Add(this.pnConteudo);
            this.pnBack.Controls.Add(this.pnMenu);
            this.pnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBack.Location = new System.Drawing.Point(0, 0);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(1280, 720);
            this.pnBack.TabIndex = 0;
            // 
            // pnConteudo
            // 
            this.pnConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnConteudo.Controls.Add(this.pictureBox3);
            this.pnConteudo.Location = new System.Drawing.Point(0, 87);
            this.pnConteudo.Name = "pnConteudo";
            this.pnConteudo.Size = new System.Drawing.Size(1280, 633);
            this.pnConteudo.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TI46.estoque._0._1.Properties.Resources.vecteezy_line_shadow_effect_png_21104595;
            this.pictureBox3.Location = new System.Drawing.Point(3, -39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1917, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.pnMenu.Controls.Add(this.label3);
            this.pnMenu.Controls.Add(this.pictureBox2);
            this.pnMenu.Controls.Add(this.pictureBox1);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.label8);
            this.pnMenu.Controls.Add(this.txtUserInicial);
            this.pnMenu.Controls.Add(this.pnSombra);
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1280, 87);
            this.pnMenu.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(741, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CAIXAS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TI46.estoque._0._1.Properties.Resources.profile_user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(1117, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TI46.estoque._0._1.Properties.Resources.urano1;
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(858, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CLIENTES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(989, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "ESTOQUE";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            this.label8.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // txtUserInicial
            // 
            this.txtUserInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserInicial.AutoSize = true;
            this.txtUserInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInicial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUserInicial.Location = new System.Drawing.Point(1158, 31);
            this.txtUserInicial.Name = "txtUserInicial";
            this.txtUserInicial.Size = new System.Drawing.Size(0, 20);
            this.txtUserInicial.TabIndex = 0;
            // 
            // pnSombra
            // 
            this.pnSombra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSombra.BackColor = System.Drawing.Color.Transparent;
            this.pnSombra.Controls.Add(this.pbCancel);
            this.pnSombra.Controls.Add(this.label2);
            this.pnSombra.Location = new System.Drawing.Point(0, 0);
            this.pnSombra.Name = "pnSombra";
            this.pnSombra.Size = new System.Drawing.Size(1264, 107);
            this.pnSombra.TabIndex = 9;
            // 
            // pbCancel
            // 
            this.pbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCancel.Image = global::TI46.estoque._0._1.Properties.Resources.cancel__1_;
            this.pbCancel.Location = new System.Drawing.Point(1241, 7);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(20, 19);
            this.pbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancel.TabIndex = 1;
            this.pbCancel.TabStop = false;
            this.pbCancel.Click += new System.EventHandler(this.pbCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(118, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Orbita+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnBack);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orbita+";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inicial_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bdProjetoV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdProjetoV1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProdBindingSource)).EndInit();
            this.pnBack.ResumeLayout(false);
            this.pnConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnSombra.ResumeLayout(false);
            this.pnSombra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerFade;
        private bdProjetoV1DataSet bdProjetoV1DataSet;
        private System.Windows.Forms.BindingSource table_ProdBindingSource;
        private bdProjetoV1DataSetTableAdapters.Table_ProdTableAdapter table_ProdTableAdapter;
        private bdProjetoV1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bdProjetoV1DataSet3 bdProjetoV1DataSet3;
        private System.Windows.Forms.BindingSource tableProdBindingSource;
        private bdProjetoV1DataSet3TableAdapters.Table_ProdTableAdapter table_ProdTableAdapter1;
        private System.Windows.Forms.Panel pnBack;
        public System.Windows.Forms.Panel pnConteudo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label txtUserInicial;
        private System.Windows.Forms.Panel pnSombra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCancel;
    }
}

