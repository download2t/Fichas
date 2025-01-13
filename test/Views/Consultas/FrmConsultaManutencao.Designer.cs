namespace test.Views.Consultas
{
    partial class FrmConsultaManutencao
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
            this.rbPatrimonio = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.clCodPatrimonio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPatrimonio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataReparo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtData2 = new System.Windows.Forms.DateTimePicker();
            this.dtData1 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltro = new System.Windows.Forms.Button();
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
            this.btnAtualizar.Location = new System.Drawing.Point(1124, 22);
            this.btnAtualizar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(1018, 696);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.Location = new System.Drawing.Point(912, 696);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.Location = new System.Drawing.Point(806, 696);
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbPatrimonio);
            this.panel4.Controls.Add(this.rbCodigo);
            this.panel4.Size = new System.Drawing.Size(1212, 32);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(1125, 696);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtID.Size = new System.Drawing.Size(452, 23);
            // 
            // rbPatrimonio
            // 
            this.rbPatrimonio.AutoSize = true;
            this.rbPatrimonio.Checked = true;
            this.rbPatrimonio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbPatrimonio.ForeColor = System.Drawing.Color.White;
            this.rbPatrimonio.Location = new System.Drawing.Point(92, 3);
            this.rbPatrimonio.Name = "rbPatrimonio";
            this.rbPatrimonio.Size = new System.Drawing.Size(113, 26);
            this.rbPatrimonio.TabIndex = 16;
            this.rbPatrimonio.TabStop = true;
            this.rbPatrimonio.Text = "Patrimonio";
            this.toolTip1.SetToolTip(this.rbPatrimonio, "Buscar manutenção por nome do patrimônio.");
            this.rbPatrimonio.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(1, 2);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 26);
            this.rbCodigo.TabIndex = 15;
            this.rbCodigo.Text = "Código";
            this.toolTip1.SetToolTip(this.rbCodigo, "Buscar manutenção por código.");
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // clCodPatrimonio
            // 
            this.clCodPatrimonio.Text = "Cód Pat";
            this.clCodPatrimonio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clPatrimonio
            // 
            this.clPatrimonio.Text = "Patrimonio";
            this.clPatrimonio.Width = 200;
            // 
            // clDataReparo
            // 
            this.clDataReparo.Text = "Data do Reparo";
            this.clDataReparo.Width = 120;
            // 
            // clDescricao
            // 
            this.clDescricao.Text = "Descrição";
            this.clDescricao.Width = 430;
            // 
            // clPro
            // 
            this.clPro.Text = "Profissional";
            this.clPro.Width = 110;
            // 
            // clTelefone
            // 
            this.clTelefone.Text = "Telefone";
            this.clTelefone.Width = 111;
            // 
            // clValor
            // 
            this.clValor.Text = "Valor";
            this.clValor.Width = 111;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(743, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 552;
            this.label2.Text = "Periodo : Fim da busca";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 551;
            this.label1.Text = "Periodo : Inicio de busca";
            // 
            // dtData2
            // 
            this.dtData2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtData2.Location = new System.Drawing.Point(746, 26);
            this.dtData2.Name = "dtData2";
            this.dtData2.Size = new System.Drawing.Size(266, 23);
            this.dtData2.TabIndex = 3;
            // 
            // dtData1
            // 
            this.dtData1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtData1.Location = new System.Drawing.Point(470, 26);
            this.dtData1.Name = "dtData1";
            this.dtData1.Size = new System.Drawing.Size(266, 23);
            this.dtData1.TabIndex = 2;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.Location = new System.Drawing.Point(1018, 22);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(100, 29);
            this.btnFiltro.TabIndex = 4;
            this.btnFiltro.Text = "Filtrar";
            this.toolTip1.SetToolTip(this.btnFiltro, "Busca entre uma data especifica");
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
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
            this.dgv.Location = new System.Drawing.Point(12, 93);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1215, 598);
            this.dgv.TabIndex = 594;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // FrmConsultaManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1238, 734);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtData2);
            this.Controls.Add(this.dtData1);
            this.Controls.Add(this.btnFiltro);
            this.Name = "FrmConsultaManutencao";
            this.Text = "Manutenção";
            this.Load += new System.EventHandler(this.FrmConsultaManutencao_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnFiltro, 0);
            this.Controls.SetChildIndex(this.dtData1, 0);
            this.Controls.SetChildIndex(this.dtData2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPatrimonio;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.ColumnHeader clCodPatrimonio;
        private System.Windows.Forms.ColumnHeader clPatrimonio;
        private System.Windows.Forms.ColumnHeader clDataReparo;
        private System.Windows.Forms.ColumnHeader clDescricao;
        private System.Windows.Forms.ColumnHeader clPro;
        private System.Windows.Forms.ColumnHeader clTelefone;
        private System.Windows.Forms.ColumnHeader clValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtData2;
        private System.Windows.Forms.DateTimePicker dtData1;
        protected System.Windows.Forms.Button btnFiltro;
        public System.Windows.Forms.DataGridView dgv;
    }
}
