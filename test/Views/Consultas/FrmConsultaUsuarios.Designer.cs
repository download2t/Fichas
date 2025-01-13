namespace test.Views.Consultas
{
    partial class FrmConsultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaUsuarios));
            this.clNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataNasc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPerfil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataCad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.btnAcessos = new System.Windows.Forms.Button();
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
            this.btnAtualizar.Location = new System.Drawing.Point(1189, 22);
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(1082, 717);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.Location = new System.Drawing.Point(976, 717);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.Location = new System.Drawing.Point(870, 717);
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbEmail);
            this.panel4.Controls.Add(this.rbCodigo);
            this.panel4.Controls.Add(this.rbNome);
            this.panel4.Location = new System.Drawing.Point(11, 52);
            this.panel4.Size = new System.Drawing.Size(1277, 32);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(1189, 717);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 25);
            this.txtID.MaxLength = 100;
            this.txtID.Size = new System.Drawing.Size(1170, 23);
            // 
            // clNome
            // 
            this.clNome.Text = "Nome";
            this.clNome.Width = 100;
            // 
            // clSobrenome
            // 
            this.clSobrenome.Text = "Sobrenome";
            this.clSobrenome.Width = 100;
            // 
            // clEmail
            // 
            this.clEmail.Text = "Email";
            this.clEmail.Width = 150;
            // 
            // clUsuario
            // 
            this.clUsuario.Text = "Usuário";
            this.clUsuario.Width = 150;
            // 
            // clDataNasc
            // 
            this.clDataNasc.Text = "Data de nascimento";
            this.clDataNasc.Width = 140;
            // 
            // clSenha
            // 
            this.clSenha.Text = "Senha";
            this.clSenha.Width = 90;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            this.clStatus.Width = 80;
            // 
            // clPerfil
            // 
            this.clPerfil.Text = "Perfil";
            this.clPerfil.Width = 100;
            // 
            // clDataCad
            // 
            this.clDataCad.Text = "Data de Cadastro";
            this.clDataCad.Width = 140;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbEmail.ForeColor = System.Drawing.Color.White;
            this.rbEmail.Location = new System.Drawing.Point(175, 3);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(72, 26);
            this.rbEmail.TabIndex = 17;
            this.rbEmail.Text = "Email";
            this.toolTip1.SetToolTip(this.rbEmail, "Buscar usuário por e-mail.");
            this.rbEmail.UseVisualStyleBackColor = true;
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
            this.toolTip1.SetToolTip(this.rbNome, "Buscar usuário por nome.");
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
            this.toolTip1.SetToolTip(this.rbCodigo, "Buscar usuário por código.");
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // btnAcessos
            // 
            this.btnAcessos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcessos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAcessos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcessos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessos.ForeColor = System.Drawing.Color.White;
            this.btnAcessos.Location = new System.Drawing.Point(764, 717);
            this.btnAcessos.Name = "btnAcessos";
            this.btnAcessos.Size = new System.Drawing.Size(100, 29);
            this.btnAcessos.TabIndex = 99;
            this.btnAcessos.Text = "Acessos";
            this.btnAcessos.UseVisualStyleBackColor = false;
            this.btnAcessos.Click += new System.EventHandler(this.btnAcessos_Click);
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
            this.dgv.Location = new System.Drawing.Point(11, 88);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1278, 624);
            this.dgv.TabIndex = 594;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // FrmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1300, 754);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnAcessos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaUsuarios";
            this.Text = "Consultar Usuários";
            this.Load += new System.EventHandler(this.FrmConsultaUsuarios_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAcessos, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clNome;
        private System.Windows.Forms.ColumnHeader clSobrenome;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clUsuario;
        private System.Windows.Forms.ColumnHeader clDataNasc;
        private System.Windows.Forms.ColumnHeader clSenha;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.ColumnHeader clPerfil;
        private System.Windows.Forms.ColumnHeader clDataCad;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
        protected System.Windows.Forms.Button btnAcessos;
        public System.Windows.Forms.DataGridView dgv;
    }
}
