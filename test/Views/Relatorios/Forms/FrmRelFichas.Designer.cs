namespace Controle.Views.Relatorios.Forms
{
    partial class FrmRelFichas
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
            this.rbClientes = new System.Windows.Forms.RadioButton();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.DataFim = new System.Windows.Forms.DateTimePicker();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.rbPeriodoFichas = new System.Windows.Forms.RadioButton();
            this.rbUsuarios = new System.Windows.Forms.RadioButton();
            this.rbTotalFichas = new System.Windows.Forms.RadioButton();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.btnPesquisarUsuario = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCodUser = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerar.Location = new System.Drawing.Point(713, 301);
            this.btnGerar.Size = new System.Drawing.Size(162, 36);
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(8, 295);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(882, 301);
            this.btnSair.Size = new System.Drawing.Size(134, 36);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(11, 315);
            // 
            // rbClientes
            // 
            this.rbClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbClientes.AutoSize = true;
            this.rbClientes.BackColor = System.Drawing.Color.Transparent;
            this.rbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClientes.ForeColor = System.Drawing.Color.White;
            this.rbClientes.Location = new System.Drawing.Point(43, 195);
            this.rbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(189, 28);
            this.rbClientes.TabIndex = 852;
            this.rbClientes.Text = "Fichas por Clientes";
            this.rbClientes.UseVisualStyleBackColor = false;
            this.rbClientes.CheckedChanged += new System.EventHandler(this.rbClientes_CheckedChanged);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(333, 221);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodCliente.MaxLength = 6;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(170, 26);
            this.txtCodCliente.TabIndex = 848;
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarValorKeyPress);
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarCliente.Enabled = false;
            this.btnPesquisarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(884, 216);
            this.btnPesquisarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(133, 36);
            this.btnPesquisarCliente.TabIndex = 849;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(518, 189);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 851;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCliente.ForeColor = System.Drawing.Color.White;
            this.lblCodCliente.Location = new System.Drawing.Point(333, 191);
            this.lblCodCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(120, 20);
            this.lblCodCliente.TabIndex = 850;
            this.lblCodCliente.Text = "Código Clientes";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(518, 221);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.MaxLength = 55;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(357, 26);
            this.txtCliente.TabIndex = 847;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.ForeColor = System.Drawing.Color.White;
            this.lblDataFinal.Location = new System.Drawing.Point(694, 39);
            this.lblDataFinal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(123, 20);
            this.lblDataFinal.TabIndex = 844;
            this.lblDataFinal.Text = "Data de término";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.ForeColor = System.Drawing.Color.White;
            this.lblDataInicial.Location = new System.Drawing.Point(333, 39);
            this.lblDataInicial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(105, 20);
            this.lblDataInicial.TabIndex = 843;
            this.lblDataInicial.Text = "Data de inicio";
            // 
            // DataFim
            // 
            this.DataFim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataFim.Enabled = false;
            this.DataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFim.Location = new System.Drawing.Point(699, 67);
            this.DataFim.Margin = new System.Windows.Forms.Padding(4);
            this.DataFim.Name = "DataFim";
            this.DataFim.Size = new System.Drawing.Size(317, 26);
            this.DataFim.TabIndex = 842;
            // 
            // DataInicio
            // 
            this.DataInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataInicio.Enabled = false;
            this.DataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicio.Location = new System.Drawing.Point(338, 67);
            this.DataInicio.Margin = new System.Windows.Forms.Padding(4);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(330, 26);
            this.DataInicio.TabIndex = 841;
            // 
            // rbPeriodoFichas
            // 
            this.rbPeriodoFichas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPeriodoFichas.AutoSize = true;
            this.rbPeriodoFichas.BackColor = System.Drawing.Color.Transparent;
            this.rbPeriodoFichas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeriodoFichas.ForeColor = System.Drawing.Color.White;
            this.rbPeriodoFichas.Location = new System.Drawing.Point(43, 111);
            this.rbPeriodoFichas.Margin = new System.Windows.Forms.Padding(4);
            this.rbPeriodoFichas.Name = "rbPeriodoFichas";
            this.rbPeriodoFichas.Size = new System.Drawing.Size(204, 28);
            this.rbPeriodoFichas.TabIndex = 840;
            this.rbPeriodoFichas.Text = "Histórico por periodo";
            this.rbPeriodoFichas.UseVisualStyleBackColor = false;
            this.rbPeriodoFichas.CheckedChanged += new System.EventHandler(this.rbPeriodoFichas_CheckedChanged);
            // 
            // rbUsuarios
            // 
            this.rbUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbUsuarios.AutoSize = true;
            this.rbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.rbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsuarios.ForeColor = System.Drawing.Color.White;
            this.rbUsuarios.Location = new System.Drawing.Point(43, 153);
            this.rbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsuarios.Name = "rbUsuarios";
            this.rbUsuarios.Size = new System.Drawing.Size(193, 28);
            this.rbUsuarios.TabIndex = 839;
            this.rbUsuarios.Text = "Fichas por usuários";
            this.rbUsuarios.UseVisualStyleBackColor = false;
            this.rbUsuarios.CheckedChanged += new System.EventHandler(this.rbUsuarios_CheckedChanged);
            // 
            // rbTotalFichas
            // 
            this.rbTotalFichas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTotalFichas.AutoSize = true;
            this.rbTotalFichas.BackColor = System.Drawing.Color.Transparent;
            this.rbTotalFichas.Checked = true;
            this.rbTotalFichas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTotalFichas.ForeColor = System.Drawing.Color.White;
            this.rbTotalFichas.Location = new System.Drawing.Point(43, 72);
            this.rbTotalFichas.Margin = new System.Windows.Forms.Padding(4);
            this.rbTotalFichas.Name = "rbTotalFichas";
            this.rbTotalFichas.Size = new System.Drawing.Size(219, 28);
            this.rbTotalFichas.TabIndex = 838;
            this.rbTotalFichas.TabStop = true;
            this.rbTotalFichas.Text = "Histórico total de fichas";
            this.rbTotalFichas.UseVisualStyleBackColor = false;
            this.rbTotalFichas.CheckedChanged += new System.EventHandler(this.rbTotalFichas_CheckedChanged);
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUsuario.Location = new System.Drawing.Point(333, 155);
            this.txtCodUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodUsuario.MaxLength = 6;
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(170, 26);
            this.txtCodUsuario.TabIndex = 854;
            this.txtCodUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarValorKeyPress);
            this.txtCodUsuario.Leave += new System.EventHandler(this.txtCodUsuario_Leave);
            // 
            // btnPesquisarUsuario
            // 
            this.btnPesquisarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarUsuario.Enabled = false;
            this.btnPesquisarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarUsuario.Location = new System.Drawing.Point(883, 149);
            this.btnPesquisarUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            this.btnPesquisarUsuario.Size = new System.Drawing.Size(133, 36);
            this.btnPesquisarUsuario.TabIndex = 855;
            this.btnPesquisarUsuario.Text = "Pesquisar";
            this.btnPesquisarUsuario.UseVisualStyleBackColor = false;
            this.btnPesquisarUsuario.Click += new System.EventHandler(this.btnPesquisarUsuario_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(518, 123);
            this.lblUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 20);
            this.lblUser.TabIndex = 857;
            this.lblUser.Text = "Usuário";
            // 
            // lblCodUser
            // 
            this.lblCodUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodUser.AutoSize = true;
            this.lblCodUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCodUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodUser.ForeColor = System.Drawing.Color.White;
            this.lblCodUser.Location = new System.Drawing.Point(333, 125);
            this.lblCodUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodUser.Name = "lblCodUser";
            this.lblCodUser.Size = new System.Drawing.Size(118, 20);
            this.lblCodUser.TabIndex = 856;
            this.lblCodUser.Text = "Código Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(518, 155);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 55;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(357, 26);
            this.txtUsuario.TabIndex = 853;
            // 
            // FrmRelFichas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1061, 348);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.btnPesquisarUsuario);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblCodUser);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.rbClientes);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.DataFim);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.rbPeriodoFichas);
            this.Controls.Add(this.rbUsuarios);
            this.Controls.Add(this.rbTotalFichas);
            this.Name = "FrmRelFichas";
            this.Text = "Relatório de Fichas";
            this.Controls.SetChildIndex(this.btnGerar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.rbTotalFichas, 0);
            this.Controls.SetChildIndex(this.rbUsuarios, 0);
            this.Controls.SetChildIndex(this.rbPeriodoFichas, 0);
            this.Controls.SetChildIndex(this.DataInicio, 0);
            this.Controls.SetChildIndex(this.DataFim, 0);
            this.Controls.SetChildIndex(this.lblDataInicial, 0);
            this.Controls.SetChildIndex(this.lblDataFinal, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.lblCodCliente, 0);
            this.Controls.SetChildIndex(this.lblCliente, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCliente, 0);
            this.Controls.SetChildIndex(this.txtCodCliente, 0);
            this.Controls.SetChildIndex(this.rbClientes, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.lblCodUser, 0);
            this.Controls.SetChildIndex(this.lblUser, 0);
            this.Controls.SetChildIndex(this.btnPesquisarUsuario, 0);
            this.Controls.SetChildIndex(this.txtCodUsuario, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbClientes;
        public System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCodCliente;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker DataFim;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.RadioButton rbPeriodoFichas;
        private System.Windows.Forms.RadioButton rbUsuarios;
        private System.Windows.Forms.RadioButton rbTotalFichas;
        public System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Button btnPesquisarUsuario;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCodUser;
        public System.Windows.Forms.TextBox txtUsuario;
    }
}
