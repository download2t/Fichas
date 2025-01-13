namespace Controle.Views.Cadastros
{
    partial class FrmCadastroFuncionarios
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbAtivo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisarSetor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.lbCodClientes = new System.Windows.Forms.Label();
            this.txtCodSetor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisarFuncao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodFuncao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(354, 367);
            this.btnSalvar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(126, 353);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(460, 367);
            this.btnSair.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 373);
            this.txtID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(112, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 520;
            this.label4.Text = "*";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbCliente.ForeColor = System.Drawing.Color.White;
            this.lbCliente.Location = new System.Drawing.Point(126, 36);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(45, 17);
            this.lbCliente.TabIndex = 519;
            this.lbCliente.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 56);
            this.txtNome.MaxLength = 55;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(431, 23);
            this.txtNome.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNome, "Nome do funcionário.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 522;
            this.label1.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(129, 107);
            this.txtCpf.MaxLength = 55;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(431, 23);
            this.txtCpf.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtCpf, "Cpf do funcionário.");
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFuncao_KeyPress);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(112, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 532;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(126, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 531;
            this.label9.Text = "Salário bruto";
            this.toolTip1.SetToolTip(this.label9, "Salário bruto( sem descontos).");
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(129, 260);
            this.txtValor.MaxLength = 55;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(431, 23);
            this.txtValor.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtValor, "Salário bruto( sem descontos).");
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // cmbAtivo
            // 
            this.cmbAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAtivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAtivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAtivo.ForeColor = System.Drawing.Color.Black;
            this.cmbAtivo.FormattingEnabled = true;
            this.cmbAtivo.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cmbAtivo.Location = new System.Drawing.Point(129, 319);
            this.cmbAtivo.Name = "cmbAtivo";
            this.cmbAtivo.Size = new System.Drawing.Size(142, 24);
            this.cmbAtivo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cmbAtivo, "Caso funcionario não esteja ativo não entra no calculo de folha.");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(114, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 535;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(128, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 17);
            this.label11.TabIndex = 534;
            this.label11.Text = "Funcionário ativo?";
            this.toolTip1.SetToolTip(this.label11, "Caso funcionario não esteja ativo não entra no calculo de folha.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(110, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 541;
            this.label6.Text = "*";
            // 
            // btnPesquisarSetor
            // 
            this.btnPesquisarSetor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarSetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarSetor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarSetor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarSetor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarSetor.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarSetor.Location = new System.Drawing.Point(460, 206);
            this.btnPesquisarSetor.Name = "btnPesquisarSetor";
            this.btnPesquisarSetor.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisarSetor.TabIndex = 8;
            this.btnPesquisarSetor.Text = "Pesquisar";
            this.btnPesquisarSetor.UseVisualStyleBackColor = false;
            this.btnPesquisarSetor.Click += new System.EventHandler(this.btnPesquisarSetor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(209, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 540;
            this.label7.Text = "Setor";
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(212, 209);
            this.txtSetor.MaxLength = 55;
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.ReadOnly = true;
            this.txtSetor.Size = new System.Drawing.Size(231, 23);
            this.txtSetor.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSetor, "Setor do funcionário.");
            // 
            // lbCodClientes
            // 
            this.lbCodClientes.AutoSize = true;
            this.lbCodClientes.BackColor = System.Drawing.Color.Transparent;
            this.lbCodClientes.ForeColor = System.Drawing.Color.White;
            this.lbCodClientes.Location = new System.Drawing.Point(126, 189);
            this.lbCodClientes.Name = "lbCodClientes";
            this.lbCodClientes.Size = new System.Drawing.Size(52, 17);
            this.lbCodClientes.TabIndex = 539;
            this.lbCodClientes.Text = "Código";
            // 
            // txtCodSetor
            // 
            this.txtCodSetor.Location = new System.Drawing.Point(129, 209);
            this.txtCodSetor.MaxLength = 6;
            this.txtCodSetor.Name = "txtCodSetor";
            this.txtCodSetor.Size = new System.Drawing.Size(65, 23);
            this.txtCodSetor.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtCodSetor, "Código do setor.");
            this.txtCodSetor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFuncao_KeyPress);
            this.txtCodSetor.Leave += new System.EventHandler(this.txtCodSetor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(110, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 547;
            this.label3.Text = "*";
            // 
            // btnPesquisarFuncao
            // 
            this.btnPesquisarFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarFuncao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarFuncao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarFuncao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarFuncao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarFuncao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarFuncao.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarFuncao.Location = new System.Drawing.Point(460, 160);
            this.btnPesquisarFuncao.Name = "btnPesquisarFuncao";
            this.btnPesquisarFuncao.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisarFuncao.TabIndex = 5;
            this.btnPesquisarFuncao.Text = "Pesquisar";
            this.btnPesquisarFuncao.UseVisualStyleBackColor = false;
            this.btnPesquisarFuncao.Click += new System.EventHandler(this.btnPesquisarFuncao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(209, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 546;
            this.label5.Text = "Função";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(212, 163);
            this.txtFuncao.MaxLength = 55;
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.ReadOnly = true;
            this.txtFuncao.Size = new System.Drawing.Size(231, 23);
            this.txtFuncao.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtFuncao, "Função / Cargo do funcionário.");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(126, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 545;
            this.label12.Text = "Código";
            // 
            // txtCodFuncao
            // 
            this.txtCodFuncao.Location = new System.Drawing.Point(129, 163);
            this.txtCodFuncao.MaxLength = 6;
            this.txtCodFuncao.Name = "txtCodFuncao";
            this.txtCodFuncao.Size = new System.Drawing.Size(65, 23);
            this.txtCodFuncao.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtCodFuncao, "Código da função / cargo.");
            this.txtCodFuncao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFuncao_KeyPress);
            this.txtCodFuncao.Leave += new System.EventHandler(this.txtCodFuncao_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(303, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 549;
            this.label14.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(306, 319);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(254, 24);
            this.txtTelefone.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtTelefone, "Telefone do funcionário.");
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFuncao_KeyPress);
            // 
            // FrmCadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(658, 429);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPesquisarFuncao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCodFuncao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisarSetor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.lbCodClientes);
            this.Controls.Add(this.txtCodSetor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbAtivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.txtNome);
            this.Name = "FrmCadastroFuncionarios";
            this.Text = "Funcionários";
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.lbCliente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCpf, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbAtivo, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtCodSetor, 0);
            this.Controls.SetChildIndex(this.lbCodClientes, 0);
            this.Controls.SetChildIndex(this.txtSetor, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnPesquisarSetor, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtCodFuncao, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtFuncao, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFuncao, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtTelefone, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCliente;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbAtivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisarSetor;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label lbCodClientes;
        public System.Windows.Forms.TextBox txtCodSetor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisarFuncao;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtCodFuncao;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtTelefone;
    }
}
