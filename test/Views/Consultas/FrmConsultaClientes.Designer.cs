namespace test.Views.Consultas
{
    partial class FrmConsultaClientes
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
            this.clNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDocumento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbDocumento = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.clBairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLogradouro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizar.Location = new System.Drawing.Point(1189, 23);
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(1082, 725);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.Location = new System.Drawing.Point(976, 725);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.Location = new System.Drawing.Point(870, 725);
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbEmail);
            this.panel4.Controls.Add(this.rbCodigo);
            this.panel4.Controls.Add(this.rbDocumento);
            this.panel4.Controls.Add(this.rbNome);
            this.panel4.Location = new System.Drawing.Point(12, 52);
            this.panel4.Size = new System.Drawing.Size(1277, 32);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(1189, 725);
            // 
            // txtID
            // 
            this.txtID.MaxLength = 100;
            this.txtID.Size = new System.Drawing.Size(1170, 23);
            // 
            // clNome
            // 
            this.clNome.Text = "Nome";
            this.clNome.Width = 150;
            // 
            // clDocumento
            // 
            this.clDocumento.Text = "CPF / CNPJ";
            this.clDocumento.Width = 120;
            // 
            // clTelefone
            // 
            this.clTelefone.Text = "Telefone";
            this.clTelefone.Width = 120;
            // 
            // clEmail
            // 
            this.clEmail.Text = "Email";
            this.clEmail.Width = 150;
            // 
            // clCEP
            // 
            this.clCEP.Text = "CEP";
            this.clCEP.Width = 100;
            // 
            // clCidade
            // 
            this.clCidade.Text = "Cidade";
            this.clCidade.Width = 150;
            // 
            // clNumero
            // 
            this.clNumero.Text = "Número";
            // 
            // rbDocumento
            // 
            this.rbDocumento.AutoSize = true;
            this.rbDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbDocumento.ForeColor = System.Drawing.Color.White;
            this.rbDocumento.Location = new System.Drawing.Point(175, 3);
            this.rbDocumento.Name = "rbDocumento";
            this.rbDocumento.Size = new System.Drawing.Size(119, 26);
            this.rbDocumento.TabIndex = 17;
            this.rbDocumento.TabStop = true;
            this.rbDocumento.Text = "Documento";
            this.toolTip1.SetToolTip(this.rbDocumento, "Buscar cliente pelo número de documento.");
            this.rbDocumento.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(94, 3);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(75, 26);
            this.rbNome.TabIndex = 16;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.toolTip1.SetToolTip(this.rbNome, "Buscar cliente pelo nome.");
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(3, 3);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 26);
            this.rbCodigo.TabIndex = 15;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.toolTip1.SetToolTip(this.rbCodigo, "Buscar cliente por código.");
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // clBairro
            // 
            this.clBairro.Text = "Bairro";
            this.clBairro.Width = 150;
            // 
            // clLogradouro
            // 
            this.clLogradouro.Text = "Logradouro";
            this.clLogradouro.Width = 150;
            // 
            // clUF
            // 
            this.clUF.Text = "UF";
            this.clUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clUF.Width = 50;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbEmail.ForeColor = System.Drawing.Color.White;
            this.rbEmail.Location = new System.Drawing.Point(300, 3);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(72, 26);
            this.rbEmail.TabIndex = 18;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email";
            this.toolTip1.SetToolTip(this.rbEmail, "Buscar cliente por  endereço de e-mail.");
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv.Location = new System.Drawing.Point(12, 86);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1277, 634);
            this.dgv.TabIndex = 589;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // FrmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1302, 763);
            this.Controls.Add(this.dgv);
            this.Name = "FrmConsultaClientes";
            this.Text = "Consultar Clientes";
            this.Load += new System.EventHandler(this.FrmConsultaClientes_Load);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clNome;
        private System.Windows.Forms.ColumnHeader clDocumento;
        private System.Windows.Forms.ColumnHeader clTelefone;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clCEP;
        private System.Windows.Forms.ColumnHeader clCidade;
        private System.Windows.Forms.ColumnHeader clNumero;
        private System.Windows.Forms.RadioButton rbDocumento;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.ColumnHeader clBairro;
        private System.Windows.Forms.ColumnHeader clLogradouro;
        private System.Windows.Forms.ColumnHeader clUF;
        private System.Windows.Forms.RadioButton rbEmail;
        public System.Windows.Forms.DataGridView dgv;
    }
}
