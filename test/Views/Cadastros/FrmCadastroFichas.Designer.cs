namespace test.Views.Cadastros
{
    partial class FrmCadastroFichas
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
            this.lbCodClientes = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbCodUsuario = new System.Windows.Forms.Label();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(582, 401);
            this.btnSalvar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Enabled = false;
            this.lbID.Location = new System.Drawing.Point(71, 388);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(688, 401);
            this.btnSair.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(74, 409);
            this.txtID.TabIndex = 500;
            this.txtID.Visible = false;
            // 
            // lbCodClientes
            // 
            this.lbCodClientes.AutoSize = true;
            this.lbCodClientes.BackColor = System.Drawing.Color.Transparent;
            this.lbCodClientes.ForeColor = System.Drawing.Color.White;
            this.lbCodClientes.Location = new System.Drawing.Point(71, 40);
            this.lbCodClientes.Name = "lbCodClientes";
            this.lbCodClientes.Size = new System.Drawing.Size(99, 17);
            this.lbCodClientes.TabIndex = 226;
            this.lbCodClientes.Text = "Código Cliente";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(74, 60);
            this.txtCodCliente.MaxLength = 6;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(166, 23);
            this.txtCodCliente.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCodCliente, "Código do cliente.");
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarValorKeyPress);
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lbDescricao.ForeColor = System.Drawing.Color.White;
            this.lbDescricao.Location = new System.Drawing.Point(71, 145);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(71, 17);
            this.lbDescricao.TabIndex = 224;
            this.lbDescricao.Text = "Descrição";
            this.toolTip1.SetToolTip(this.lbDescricao, "Descrição da visita técnica, (atividades, tópicos, acordos, ofertas entre outros)" +
        ".");
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbCliente.ForeColor = System.Drawing.Color.White;
            this.lbCliente.Location = new System.Drawing.Point(250, 40);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(51, 17);
            this.lbCliente.TabIndex = 232;
            this.lbCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(253, 60);
            this.txtCliente.MaxLength = 55;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(429, 23);
            this.txtCliente.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtCliente, "Nome do cliente.");
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(688, 57);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisarCliente.TabIndex = 3;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(74, 118);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(274, 23);
            this.dtData.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 235;
            this.label2.Text = "Data do Contato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 237;
            this.label1.Text = "Usuário que realizou o contato";
            this.toolTip1.SetToolTip(this.label1, "Nome de quem realizou o cadastro.");
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(488, 118);
            this.txtUsuario.MaxLength = 55;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(300, 23);
            this.txtUsuario.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtUsuario, "Nome de quem realizou o cadastro.");
            // 
            // lbCodUsuario
            // 
            this.lbCodUsuario.AutoSize = true;
            this.lbCodUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbCodUsuario.ForeColor = System.Drawing.Color.White;
            this.lbCodUsuario.Location = new System.Drawing.Point(362, 96);
            this.lbCodUsuario.Name = "lbCodUsuario";
            this.lbCodUsuario.Size = new System.Drawing.Size(86, 17);
            this.lbCodUsuario.TabIndex = 239;
            this.lbCodUsuario.Text = "Cód Usuário";
            this.toolTip1.SetToolTip(this.lbCodUsuario, "Código de quem realizou o cadastro.");
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.Location = new System.Drawing.Point(365, 118);
            this.txtCodUsuario.MaxLength = 6;
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(111, 23);
            this.txtCodUsuario.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtCodUsuario, "Código de quem realizou o cadastro.");
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(74, 165);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(714, 220);
            this.txtDescricao.TabIndex = 7;
            this.txtDescricao.Text = "";
            this.toolTip1.SetToolTip(this.txtDescricao, "Descrição da visita técnica, (atividades, tópicos, acordos, ofertas entre outros)" +
        ".");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(57, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 503;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(57, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 504;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(57, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 505;
            this.label5.Text = "*";
            // 
            // FrmCadastroFichas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(859, 445);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lbCodUsuario);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lbCodClientes);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.lbDescricao);
            this.Name = "FrmCadastroFichas";
            this.Text = "Registro de visitas";
            this.Load += new System.EventHandler(this.FrmCadastroFichas_Load);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lbDescricao, 0);
            this.Controls.SetChildIndex(this.txtCodCliente, 0);
            this.Controls.SetChildIndex(this.lbCodClientes, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.lbCliente, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCliente, 0);
            this.Controls.SetChildIndex(this.dtData, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodUsuario, 0);
            this.Controls.SetChildIndex(this.lbCodUsuario, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCodClientes;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbCodUsuario;
        private System.Windows.Forms.TextBox txtCodUsuario;
        public System.Windows.Forms.TextBox txtCodCliente;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RichTextBox txtDescricao;
    }
}
