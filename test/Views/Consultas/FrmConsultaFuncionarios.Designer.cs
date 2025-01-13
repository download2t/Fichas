namespace Controle.Views.Consultas
{
    partial class FrmConsultaFuncionarios
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
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.clNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSetor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSalario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAtivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbAtivos = new System.Windows.Forms.CheckBox();
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
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbAtivos);
            this.panel4.Controls.Add(this.rbNome);
            this.panel4.Controls.Add(this.rbCpf);
            this.panel4.Controls.Add(this.rbCodigo);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.rbCodigo.TabIndex = 13;
            this.rbCodigo.Text = "Código";
            this.toolTip1.SetToolTip(this.rbCodigo, "Buscar funcionário por código.");
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(94, 3);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(75, 26);
            this.rbNome.TabIndex = 15;
            this.rbNome.Text = "Nome";
            this.toolTip1.SetToolTip(this.rbNome, "Buscar funcionário por nome.");
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Checked = true;
            this.rbCpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCpf.ForeColor = System.Drawing.Color.White;
            this.rbCpf.Location = new System.Drawing.Point(175, 3);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(56, 26);
            this.rbCpf.TabIndex = 16;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "Cpf";
            this.toolTip1.SetToolTip(this.rbCpf, "Buscar funcionário por cpf.");
            this.rbCpf.UseVisualStyleBackColor = true;
            // 
            // clNome
            // 
            this.clNome.Text = "Nome";
            this.clNome.Width = 300;
            // 
            // clSetor
            // 
            this.clSetor.Text = "Setor";
            this.clSetor.Width = 120;
            // 
            // clCargo
            // 
            this.clCargo.Text = "Cargo / Função";
            this.clCargo.Width = 170;
            // 
            // clCpf
            // 
            this.clCpf.Text = "CPF";
            this.clCpf.Width = 130;
            // 
            // clTelefone
            // 
            this.clTelefone.Text = "Telefone";
            this.clTelefone.Width = 130;
            // 
            // clSalario
            // 
            this.clSalario.Text = "Salário Bruto";
            this.clSalario.Width = 120;
            // 
            // clAtivo
            // 
            this.clAtivo.Text = "Ativo?";
            this.clAtivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbAtivos
            // 
            this.cbAtivos.AutoSize = true;
            this.cbAtivos.Checked = true;
            this.cbAtivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAtivos.ForeColor = System.Drawing.Color.White;
            this.cbAtivos.Location = new System.Drawing.Point(237, 6);
            this.cbAtivos.Name = "cbAtivos";
            this.cbAtivos.Size = new System.Drawing.Size(149, 21);
            this.cbAtivos.TabIndex = 17;
            this.cbAtivos.Text = "Funcionários ativos";
            this.toolTip1.SetToolTip(this.cbAtivos, "Quando marcado serão visto apenas os funcionários ativos na empresa.");
            this.cbAtivos.UseVisualStyleBackColor = true;
            this.cbAtivos.CheckedChanged += new System.EventHandler(this.cbAtivos_CheckedChanged);
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
            this.dgv.Size = new System.Drawing.Size(1104, 481);
            this.dgv.TabIndex = 594;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // FrmConsultaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1129, 617);
            this.Controls.Add(this.dgv);
            this.Name = "FrmConsultaFuncionarios";
            this.Text = "Consultar Funcionarios";
            this.Load += new System.EventHandler(this.FrmConsultaFuncionarios_Load);
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

        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.ColumnHeader clNome;
        private System.Windows.Forms.ColumnHeader clSetor;
        private System.Windows.Forms.ColumnHeader clCargo;
        private System.Windows.Forms.ColumnHeader clCpf;
        private System.Windows.Forms.ColumnHeader clTelefone;
        private System.Windows.Forms.ColumnHeader clSalario;
        private System.Windows.Forms.ColumnHeader clAtivo;
        private System.Windows.Forms.CheckBox cbAtivos;
        public System.Windows.Forms.DataGridView dgv;
    }
}
