namespace Controle.Views.Consultas
{
    partial class FrmConsultaOrdemDeServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtData2 = new System.Windows.Forms.DateTimePicker();
            this.dtData1 = new System.Windows.Forms.DateTimePicker();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbTicket = new System.Windows.Forms.RadioButton();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.clUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrioridade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbTodos = new System.Windows.Forms.CheckBox();
            this.clData2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbStatus2 = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizar.Location = new System.Drawing.Point(1211, 24);
            this.btnAtualizar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(1105, 545);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            this.btnExcluir.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.Location = new System.Drawing.Point(999, 545);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            this.btnAlterar.Visible = false;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.Image = global::Controle.Properties.Resources.add_x32;
            this.btnIncluir.Location = new System.Drawing.Point(1275, 56);
            this.btnIncluir.Size = new System.Drawing.Size(34, 29);
            this.btnIncluir.Text = "";
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSetor);
            this.panel4.Controls.Add(this.rbUser);
            this.panel4.Controls.Add(this.rbCodigo);
            this.panel4.Controls.Add(this.rbTicket);
            this.panel4.Size = new System.Drawing.Size(1299, 32);
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(9, 5);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(1212, 545);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Size = new System.Drawing.Size(198, 24);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(661, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 553;
            this.label2.Text = "Periodo : Fim da busca";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 552;
            this.label1.Text = "Periodo : Inicio de busca";
            // 
            // dtData2
            // 
            this.dtData2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData2.Location = new System.Drawing.Point(664, 26);
            this.dtData2.Name = "dtData2";
            this.dtData2.Size = new System.Drawing.Size(285, 24);
            this.dtData2.TabIndex = 6;
            // 
            // dtData1
            // 
            this.dtData1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData1.Location = new System.Drawing.Point(366, 26);
            this.dtData1.Name = "dtData1";
            this.dtData1.Size = new System.Drawing.Size(285, 24);
            this.dtData1.TabIndex = 5;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Checked = true;
            this.rbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbUser.ForeColor = System.Drawing.Color.White;
            this.rbUser.Location = new System.Drawing.Point(94, 3);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(90, 26);
            this.rbUser.TabIndex = 22;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "Usuário";
            this.toolTip1.SetToolTip(this.rbUser, "Busar OS por um usuário especifico");
            this.rbUser.UseVisualStyleBackColor = true;
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
            this.rbCodigo.TabIndex = 20;
            this.rbCodigo.Text = "Código";
            this.toolTip1.SetToolTip(this.rbCodigo, "Busar OS por código");
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbTicket
            // 
            this.rbTicket.AutoSize = true;
            this.rbTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbTicket.ForeColor = System.Drawing.Color.White;
            this.rbTicket.Location = new System.Drawing.Point(190, 3);
            this.rbTicket.Name = "rbTicket";
            this.rbTicket.Size = new System.Drawing.Size(77, 26);
            this.rbTicket.TabIndex = 23;
            this.rbTicket.Text = "Ticket";
            this.toolTip1.SetToolTip(this.rbTicket, "Busar OS pelo número de ticket");
            this.rbTicket.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Todos",
            "Aberto",
            "Encerrado",
            "Encaminhado a TOTVS",
            "Em andamento",
            "Em análise",
            "Manutenção",
            "Aguardando aprovação"});
            this.cmbStatus.Location = new System.Drawing.Point(216, 25);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(144, 26);
            this.cmbStatus.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmbStatus, "Filtrar por status");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(213, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 798;
            this.label3.Text = "Status";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.Location = new System.Drawing.Point(955, 24);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(100, 29);
            this.btnFiltro.TabIndex = 7;
            this.btnFiltro.Text = "Filtrar";
            this.toolTip1.SetToolTip(this.btnFiltro, "Busca entre uma data especifica, necessário selecionar o status.");
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // clUsuario
            // 
            this.clUsuario.Text = "Usuário";
            this.clUsuario.Width = 130;
            // 
            // clTitulo
            // 
            this.clTitulo.Text = "Titulo";
            this.clTitulo.Width = 320;
            // 
            // clDescricao
            // 
            this.clDescricao.Text = "Descrição";
            this.clDescricao.Width = 225;
            // 
            // clData
            // 
            this.clData.Text = "Data";
            this.clData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clData.Width = 90;
            // 
            // clPrioridade
            // 
            this.clPrioridade.Text = "Prioridade";
            this.clPrioridade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clPrioridade.Width = 120;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            this.clStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clStatus.Width = 160;
            // 
            // clTicket
            // 
            this.clTicket.Text = "Ticket";
            this.clTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTicket.Width = 100;
            // 
            // cbTodos
            // 
            this.cbTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTodos.AutoSize = true;
            this.cbTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTodos.ForeColor = System.Drawing.Color.White;
            this.cbTodos.Location = new System.Drawing.Point(345, 8);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(15, 14);
            this.cbTodos.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cbTodos, "Quando está opção está marcada desativa a função de busca por período.");
            this.cbTodos.UseVisualStyleBackColor = true;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.cbTodos_CheckedChanged);
            // 
            // clData2
            // 
            this.clData2.Text = "Encerrado";
            this.clData2.Width = 90;
            // 
            // cmbStatus2
            // 
            this.cmbStatus2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatus2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus2.FormattingEnabled = true;
            this.cmbStatus2.Items.AddRange(new object[] {
            "Todos",
            "Aberto",
            "Encerrado",
            "Encaminhado a TOTVS",
            "Em andamento",
            "Em análise",
            "Manutenção",
            "Aguardando aprovação"});
            this.cmbStatus2.Location = new System.Drawing.Point(1061, 25);
            this.cmbStatus2.Name = "cmbStatus2";
            this.cmbStatus2.Size = new System.Drawing.Size(144, 26);
            this.cmbStatus2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.cmbStatus2, "Filtrar por status");
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
            this.dgv.Location = new System.Drawing.Point(13, 92);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1299, 447);
            this.dgv.TabIndex = 799;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1058, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 800;
            this.label4.Text = "Status";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.ForeColor = System.Drawing.Color.White;
            this.lblSetor.Location = new System.Drawing.Point(273, 3);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(81, 25);
            this.lblSetor.TabIndex = 24;
            this.lblSetor.Text = "SETOR";
            this.lblSetor.Visible = false;
            // 
            // FrmConsultaOrdemDeServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1325, 582);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cmbStatus2);
            this.Controls.Add(this.cbTodos);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtData2);
            this.Controls.Add(this.dtData1);
            this.Name = "FrmConsultaOrdemDeServico";
            this.Text = "Consultar Ordem de Serviço";
            this.Load += new System.EventHandler(this.FrmConsultaOrdemDeServico_Load);
            this.Controls.SetChildIndex(this.dtData1, 0);
            this.Controls.SetChildIndex(this.dtData2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbStatus, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnFiltro, 0);
            this.Controls.SetChildIndex(this.cbTodos, 0);
            this.Controls.SetChildIndex(this.cmbStatus2, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtData2;
        private System.Windows.Forms.DateTimePicker dtData1;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ColumnHeader clUsuario;
        private System.Windows.Forms.ColumnHeader clTitulo;
        private System.Windows.Forms.ColumnHeader clDescricao;
        private System.Windows.Forms.ColumnHeader clData;
        private System.Windows.Forms.ColumnHeader clPrioridade;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.ColumnHeader clTicket;
        private System.Windows.Forms.CheckBox cbTodos;
        private System.Windows.Forms.ColumnHeader clData2;
        private System.Windows.Forms.ComboBox cmbStatus2;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSetor;
    }
}
