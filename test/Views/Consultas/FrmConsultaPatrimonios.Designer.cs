namespace test.Views.Consultas
{
    partial class FrmConsultaPatrimonios
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
            this.clPatrimonio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSubCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbSubCategoria = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbPatrimonio = new System.Windows.Forms.RadioButton();
            this.clSetor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbSetor = new System.Windows.Forms.RadioButton();
            this.clValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.btnAtualizar.Location = new System.Drawing.Point(1364, 22);
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(1258, 725);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.Location = new System.Drawing.Point(1152, 725);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.Location = new System.Drawing.Point(1046, 725);
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbSetor);
            this.panel4.Controls.Add(this.rbPatrimonio);
            this.panel4.Controls.Add(this.rbCodigo);
            this.panel4.Controls.Add(this.rbSubCategoria);
            this.panel4.Controls.Add(this.rbCategoria);
            this.panel4.Location = new System.Drawing.Point(12, 53);
            this.panel4.Size = new System.Drawing.Size(1452, 32);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(1365, 725);
            // 
            // txtID
            // 
            this.txtID.Size = new System.Drawing.Size(1346, 23);
            // 
            // clPatrimonio
            // 
            this.clPatrimonio.Text = "Patrimonio";
            this.clPatrimonio.Width = 250;
            // 
            // clCategoria
            // 
            this.clCategoria.Text = "Categoria";
            this.clCategoria.Width = 120;
            // 
            // clSubCategoria
            // 
            this.clSubCategoria.Text = "Sub Categoria";
            this.clSubCategoria.Width = 120;
            // 
            // clDescricao
            // 
            this.clDescricao.Text = "Descrição";
            this.clDescricao.Width = 657;
            // 
            // rbSubCategoria
            // 
            this.rbSubCategoria.AutoSize = true;
            this.rbSubCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbSubCategoria.ForeColor = System.Drawing.Color.White;
            this.rbSubCategoria.Location = new System.Drawing.Point(281, 3);
            this.rbSubCategoria.Name = "rbSubCategoria";
            this.rbSubCategoria.Size = new System.Drawing.Size(138, 26);
            this.rbSubCategoria.TabIndex = 21;
            this.rbSubCategoria.Text = "SubCategoria";
            this.toolTip1.SetToolTip(this.rbSubCategoria, "Buscar patrimônio por subcategoria.");
            this.rbSubCategoria.UseVisualStyleBackColor = true;
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCategoria.ForeColor = System.Drawing.Color.White;
            this.rbCategoria.Location = new System.Drawing.Point(169, 3);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(106, 26);
            this.rbCategoria.TabIndex = 20;
            this.rbCategoria.Text = "Categoria";
            this.toolTip1.SetToolTip(this.rbCategoria, "Buscar patrimônio por categoria.");
            this.rbCategoria.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(1, 3);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 26);
            this.rbCodigo.TabIndex = 15;
            this.rbCodigo.Text = "Código";
            this.toolTip1.SetToolTip(this.rbCodigo, "Buscar patrimônio por código.");
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbPatrimonio
            // 
            this.rbPatrimonio.AutoSize = true;
            this.rbPatrimonio.Checked = true;
            this.rbPatrimonio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbPatrimonio.ForeColor = System.Drawing.Color.White;
            this.rbPatrimonio.Location = new System.Drawing.Point(425, 3);
            this.rbPatrimonio.Name = "rbPatrimonio";
            this.rbPatrimonio.Size = new System.Drawing.Size(113, 26);
            this.rbPatrimonio.TabIndex = 22;
            this.rbPatrimonio.TabStop = true;
            this.rbPatrimonio.Text = "Patrimônio";
            this.toolTip1.SetToolTip(this.rbPatrimonio, "Buscar patrimônio por nome do patrimônio.");
            this.rbPatrimonio.UseVisualStyleBackColor = true;
            // 
            // clSetor
            // 
            this.clSetor.Text = "Setor";
            this.clSetor.Width = 129;
            // 
            // rbSetor
            // 
            this.rbSetor.AutoSize = true;
            this.rbSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbSetor.ForeColor = System.Drawing.Color.White;
            this.rbSetor.Location = new System.Drawing.Point(92, 3);
            this.rbSetor.Name = "rbSetor";
            this.rbSetor.Size = new System.Drawing.Size(71, 26);
            this.rbSetor.TabIndex = 19;
            this.rbSetor.Text = "Setor";
            this.toolTip1.SetToolTip(this.rbSetor, "Buscar patrimônio por setor.");
            this.rbSetor.UseVisualStyleBackColor = true;
            // 
            // clValor
            // 
            this.clValor.Text = "Valor";
            this.clValor.Width = 111;
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
            this.dgv.Size = new System.Drawing.Size(1454, 633);
            this.dgv.TabIndex = 594;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // FrmConsultaPatrimonios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1478, 763);
            this.Controls.Add(this.dgv);
            this.Name = "FrmConsultaPatrimonios";
            this.Text = "Patrimônios";
            this.Load += new System.EventHandler(this.FrmConsultaPatrimonios_Load);
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

        private System.Windows.Forms.ColumnHeader clPatrimonio;
        private System.Windows.Forms.ColumnHeader clCategoria;
        private System.Windows.Forms.ColumnHeader clSubCategoria;
        private System.Windows.Forms.ColumnHeader clDescricao;
        private System.Windows.Forms.RadioButton rbSubCategoria;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbPatrimonio;
        private System.Windows.Forms.ColumnHeader clSetor;
        private System.Windows.Forms.RadioButton rbSetor;
        private System.Windows.Forms.ColumnHeader clValor;
        public System.Windows.Forms.DataGridView dgv;
    }
}
