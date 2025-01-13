namespace test.Views.Consultas
{
    partial class FrmConsultaMensagens
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtData2 = new System.Windows.Forms.DateTimePicker();
            this.dtData1 = new System.Windows.Forms.DateTimePicker();
            this.clContato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clWhatsApp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMensagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbAgendadas = new System.Windows.Forms.RadioButton();
            this.rbEnviadas = new System.Windows.Forms.RadioButton();
            this.rbFalhas = new System.Windows.Forms.RadioButton();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbContato = new System.Windows.Forms.RadioButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizar.Location = new System.Drawing.Point(1161, 22);
            this.btnAtualizar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(1055, 671);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.Location = new System.Drawing.Point(949, 671);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.Location = new System.Drawing.Point(843, 671);
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.rbAgendadas);
            this.panel4.Controls.Add(this.rbEnviadas);
            this.panel4.Controls.Add(this.rbFalhas);
            this.panel4.Size = new System.Drawing.Size(1249, 32);
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(9, 7);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(1162, 671);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtID.Location = new System.Drawing.Point(12, 25);
            this.txtID.Size = new System.Drawing.Size(217, 23);
            this.toolTip1.SetToolTip(this.txtID, "Buscar por um contato expecifico, selecione o campo código ou contato.");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(778, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 561;
            this.label1.Text = "Periodo : Fim da busca";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(502, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 560;
            this.label3.Text = "Periodo : Inicio de busca";
            // 
            // dtData2
            // 
            this.dtData2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData2.Location = new System.Drawing.Point(781, 25);
            this.dtData2.Name = "dtData2";
            this.dtData2.Size = new System.Drawing.Size(266, 23);
            this.dtData2.TabIndex = 3;
            // 
            // dtData1
            // 
            this.dtData1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData1.Location = new System.Drawing.Point(505, 25);
            this.dtData1.Name = "dtData1";
            this.dtData1.Size = new System.Drawing.Size(266, 23);
            this.dtData1.TabIndex = 2;
            // 
            // clContato
            // 
            this.clContato.Text = "Contato";
            this.clContato.Width = 150;
            // 
            // clWhatsApp
            // 
            this.clWhatsApp.Text = "WhatsApp";
            this.clWhatsApp.Width = 120;
            // 
            // clData
            // 
            this.clData.Text = "Data";
            this.clData.Width = 150;
            // 
            // clMensagem
            // 
            this.clMensagem.Text = "Mensagens";
            this.clMensagem.Width = 780;
            // 
            // rbAgendadas
            // 
            this.rbAgendadas.AutoSize = true;
            this.rbAgendadas.Checked = true;
            this.rbAgendadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAgendadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbAgendadas.ForeColor = System.Drawing.Color.White;
            this.rbAgendadas.Location = new System.Drawing.Point(1, 4);
            this.rbAgendadas.Name = "rbAgendadas";
            this.rbAgendadas.Size = new System.Drawing.Size(119, 26);
            this.rbAgendadas.TabIndex = 15;
            this.rbAgendadas.TabStop = true;
            this.rbAgendadas.Text = "Agendadas";
            this.toolTip1.SetToolTip(this.rbAgendadas, "Buscar por mensagens agendadas.");
            this.rbAgendadas.UseVisualStyleBackColor = true;
            this.rbAgendadas.CheckedChanged += new System.EventHandler(this.rbAgendadas_CheckedChanged);
            // 
            // rbEnviadas
            // 
            this.rbEnviadas.AutoSize = true;
            this.rbEnviadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEnviadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbEnviadas.ForeColor = System.Drawing.Color.White;
            this.rbEnviadas.Location = new System.Drawing.Point(126, 4);
            this.rbEnviadas.Name = "rbEnviadas";
            this.rbEnviadas.Size = new System.Drawing.Size(102, 26);
            this.rbEnviadas.TabIndex = 16;
            this.rbEnviadas.Text = "Enviadas";
            this.toolTip1.SetToolTip(this.rbEnviadas, "Buscar por mensagens que já foram enviadas");
            this.rbEnviadas.UseVisualStyleBackColor = true;
            this.rbEnviadas.CheckedChanged += new System.EventHandler(this.rbAgendadas_CheckedChanged);
            // 
            // rbFalhas
            // 
            this.rbFalhas.AutoSize = true;
            this.rbFalhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFalhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbFalhas.ForeColor = System.Drawing.Color.White;
            this.rbFalhas.Location = new System.Drawing.Point(234, 4);
            this.rbFalhas.Name = "rbFalhas";
            this.rbFalhas.Size = new System.Drawing.Size(140, 26);
            this.rbFalhas.TabIndex = 17;
            this.rbFalhas.Text = "Não Enviadas";
            this.toolTip1.SetToolTip(this.rbFalhas, "Buscar por mensagens ainda não enviadas");
            this.rbFalhas.UseVisualStyleBackColor = true;
            this.rbFalhas.CheckedChanged += new System.EventHandler(this.rbAgendadas_CheckedChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.Location = new System.Drawing.Point(1058, 22);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(100, 29);
            this.btnFiltro.TabIndex = 4;
            this.btnFiltro.Text = "Filtrar";
            this.toolTip1.SetToolTip(this.btnFiltro, "Busca entre uma data especifica");
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            this.clStatus.Width = 100;
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
            this.dgv.Location = new System.Drawing.Point(12, 92);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1250, 574);
            this.dgv.TabIndex = 594;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.rbCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(235, 22);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 26);
            this.rbCodigo.TabIndex = 595;
            this.rbCodigo.Text = "Código";
            this.toolTip1.SetToolTip(this.rbCodigo, "Auxilia na busca especifica de um ma mensagem, código do contato");
            this.rbCodigo.UseVisualStyleBackColor = false;
            // 
            // rbContato
            // 
            this.rbContato.AutoSize = true;
            this.rbContato.BackColor = System.Drawing.Color.Transparent;
            this.rbContato.Checked = true;
            this.rbContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbContato.ForeColor = System.Drawing.Color.White;
            this.rbContato.Location = new System.Drawing.Point(326, 22);
            this.rbContato.Name = "rbContato";
            this.rbContato.Size = new System.Drawing.Size(91, 26);
            this.rbContato.TabIndex = 596;
            this.rbContato.TabStop = true;
            this.rbContato.Text = "Contato";
            this.toolTip1.SetToolTip(this.rbContato, "Auxilia na busca especifica de um ma mensagem, nome do contato");
            this.rbContato.UseVisualStyleBackColor = false;
            // 
            // FrmConsultaMensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1275, 709);
            this.Controls.Add(this.rbCodigo);
            this.Controls.Add(this.rbContato);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtData2);
            this.Controls.Add(this.dtData1);
            this.Name = "FrmConsultaMensagens";
            this.Text = "Consultar Mensagens";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.dtData1, 0);
            this.Controls.SetChildIndex(this.dtData2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnFiltro, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.rbContato, 0);
            this.Controls.SetChildIndex(this.rbCodigo, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clContato;
        private System.Windows.Forms.ColumnHeader clWhatsApp;
        private System.Windows.Forms.ColumnHeader clData;
        private System.Windows.Forms.ColumnHeader clMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtData2;
        private System.Windows.Forms.DateTimePicker dtData1;
        public System.Windows.Forms.RadioButton rbAgendadas;
        public System.Windows.Forms.RadioButton rbEnviadas;
        public System.Windows.Forms.RadioButton rbFalhas;
        protected System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ColumnHeader clStatus;
        public System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.RadioButton rbCodigo;
        public System.Windows.Forms.RadioButton rbContato;
    }
}
