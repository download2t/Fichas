namespace test.Views.Consultas
{
    partial class FrmConsultaContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaContatos));
            this.clNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbNumero = new System.Windows.Forms.RadioButton();
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
            this.btnAtualizar.Location = new System.Drawing.Point(630, 20);
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(524, 604);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.Location = new System.Drawing.Point(418, 604);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.Location = new System.Drawing.Point(312, 604);
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbNumero);
            this.panel4.Controls.Add(this.rbCodigo);
            this.panel4.Controls.Add(this.rbNome);
            this.panel4.Location = new System.Drawing.Point(12, 53);
            this.panel4.Size = new System.Drawing.Size(718, 32);
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(9, 4);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(631, 604);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 24);
            this.txtID.Size = new System.Drawing.Size(612, 23);
            // 
            // clNome
            // 
            this.clNome.Text = "Nome";
            this.clNome.Width = 200;
            // 
            // clTelefone
            // 
            this.clTelefone.Text = "Telefone";
            this.clTelefone.Width = 250;
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
            this.rbNome.TabIndex = 18;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.toolTip1.SetToolTip(this.rbNome, "Buscar contato por nome.");
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
            this.rbCodigo.TabIndex = 17;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.toolTip1.SetToolTip(this.rbCodigo, "Buscar contato por código.");
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbNumero
            // 
            this.rbNumero.AutoSize = true;
            this.rbNumero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbNumero.ForeColor = System.Drawing.Color.White;
            this.rbNumero.Location = new System.Drawing.Point(175, 3);
            this.rbNumero.Name = "rbNumero";
            this.rbNumero.Size = new System.Drawing.Size(91, 26);
            this.rbNumero.TabIndex = 19;
            this.rbNumero.TabStop = true;
            this.rbNumero.Text = "Número";
            this.toolTip1.SetToolTip(this.rbNumero, "Buscar contato por número de telefone.");
            this.rbNumero.UseVisualStyleBackColor = true;
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
            this.dgv.Location = new System.Drawing.Point(12, 87);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(718, 512);
            this.dgv.TabIndex = 591;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // FrmConsultaContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(744, 642);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaContatos";
            this.Text = "Consultar Contatos";
            this.Load += new System.EventHandler(this.FrmConsultaContatos_Load);
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
        private System.Windows.Forms.ColumnHeader clTelefone;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbNumero;
        public System.Windows.Forms.DataGridView dgv;
    }
}
