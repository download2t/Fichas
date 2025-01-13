namespace test.Views.Consultas
{
    partial class FrmConsultaSenhas
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
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbLogin = new System.Windows.Forms.RadioButton();
            this.rbSenha = new System.Windows.Forms.RadioButton();
            this.clLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbContem = new System.Windows.Forms.RadioButton();
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
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(909, 620);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.Location = new System.Drawing.Point(803, 620);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.Location = new System.Drawing.Point(697, 620);
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbContem);
            this.panel4.Controls.Add(this.rbSenha);
            this.panel4.Controls.Add(this.rbLogin);
            this.panel4.Controls.Add(this.rbCodigo);
            this.panel4.Controls.Add(this.rbCategoria);
            this.panel4.Location = new System.Drawing.Point(12, 54);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(1016, 620);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Checked = true;
            this.rbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCategoria.ForeColor = System.Drawing.Color.White;
            this.rbCategoria.Location = new System.Drawing.Point(93, 3);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(106, 26);
            this.rbCategoria.TabIndex = 18;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "Categoria";
            this.toolTip1.SetToolTip(this.rbCategoria, "Buscar senha por uma categoria.");
            this.rbCategoria.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(2, 3);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 26);
            this.rbCodigo.TabIndex = 17;
            this.rbCodigo.Text = "Código";
            this.toolTip1.SetToolTip(this.rbCodigo, "Buscar senha por código.");
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbLogin
            // 
            this.rbLogin.AutoSize = true;
            this.rbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbLogin.ForeColor = System.Drawing.Color.White;
            this.rbLogin.Location = new System.Drawing.Point(205, 3);
            this.rbLogin.Name = "rbLogin";
            this.rbLogin.Size = new System.Drawing.Size(72, 26);
            this.rbLogin.TabIndex = 19;
            this.rbLogin.Text = "Login";
            this.toolTip1.SetToolTip(this.rbLogin, "Buscar senha pelo login.");
            this.rbLogin.UseVisualStyleBackColor = true;
            // 
            // rbSenha
            // 
            this.rbSenha.AutoSize = true;
            this.rbSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbSenha.ForeColor = System.Drawing.Color.White;
            this.rbSenha.Location = new System.Drawing.Point(283, 3);
            this.rbSenha.Name = "rbSenha";
            this.rbSenha.Size = new System.Drawing.Size(80, 26);
            this.rbSenha.TabIndex = 20;
            this.rbSenha.Text = "Senha";
            this.toolTip1.SetToolTip(this.rbSenha, "Buscar senha pela senha.");
            this.rbSenha.UseVisualStyleBackColor = true;
            // 
            // clLogin
            // 
            this.clLogin.Text = "Login";
            this.clLogin.Width = 150;
            // 
            // clSenha
            // 
            this.clSenha.Text = "Senha";
            this.clSenha.Width = 150;
            // 
            // clCategoria
            // 
            this.clCategoria.Text = "Categoria";
            this.clCategoria.Width = 150;
            // 
            // clDescricao
            // 
            this.clDescricao.Text = "Descrição";
            this.clDescricao.Width = 400;
            // 
            // clLink
            // 
            this.clLink.Text = "Link";
            this.clLink.Width = 185;
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbContem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbContem.ForeColor = System.Drawing.Color.White;
            this.rbContem.Location = new System.Drawing.Point(369, 3);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(90, 26);
            this.rbContem.TabIndex = 21;
            this.rbContem.Text = "Contem";
            this.toolTip1.SetToolTip(this.rbContem, "Buscar senha pela senha.");
            this.rbContem.UseVisualStyleBackColor = true;
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
            this.dgv.Location = new System.Drawing.Point(12, 91);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1106, 524);
            this.dgv.TabIndex = 594;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // FrmConsultaSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1129, 658);
            this.Controls.Add(this.dgv);
            this.Name = "FrmConsultaSenhas";
            this.Text = "Consultar Senhas";
            this.Load += new System.EventHandler(this.FrmConsultaSenhas_Load);
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

        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbLogin;
        private System.Windows.Forms.RadioButton rbSenha;
        private System.Windows.Forms.ColumnHeader clLogin;
        private System.Windows.Forms.ColumnHeader clSenha;
        private System.Windows.Forms.ColumnHeader clCategoria;
        private System.Windows.Forms.ColumnHeader clDescricao;
        private System.Windows.Forms.ColumnHeader clLink;
        private System.Windows.Forms.RadioButton rbContem;
        public System.Windows.Forms.DataGridView dgv;
    }
}
