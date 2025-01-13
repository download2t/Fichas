namespace test.Views.Cadastros
{
    partial class FrmCadastroUsuarios
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbNasc = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbConfirma = new System.Windows.Forms.Label();
            this.txtConfirma = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPesquisarSetor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.lbCodClientes = new System.Windows.Forms.Label();
            this.txtCodSetor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(583, 313);
            this.btnSalvar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Enabled = false;
            this.lbID.Location = new System.Drawing.Point(444, 299);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(689, 313);
            this.btnSair.TabIndex = 25;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(447, 319);
            this.txtID.TabIndex = 199;
            this.txtID.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 106);
            this.txtNome.MaxLength = 55;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(342, 23);
            this.txtNome.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNome, "Nome do usuário do sistema.");
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(72, 86);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 17);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.BackColor = System.Drawing.Color.Transparent;
            this.lbSobrenome.ForeColor = System.Drawing.Color.White;
            this.lbSobrenome.Location = new System.Drawing.Point(444, 86);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(81, 17);
            this.lbSobrenome.TabIndex = 4;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(447, 106);
            this.txtSobrenome.MaxLength = 55;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(342, 23);
            this.txtSobrenome.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtSobrenome, "Sobrenome do usuário.");
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(72, 137);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email";
            this.toolTip1.SetToolTip(this.lbEmail, "Endereço de e-mail válido.");
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 157);
            this.txtEmail.MaxLength = 55;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 23);
            this.txtEmail.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtEmail, "Endereço de e-mail válido.");
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(444, 137);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(57, 17);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "Usuário";
            this.toolTip1.SetToolTip(this.lbUsuario, "Usuário, utilizado para fazer o login no sistema.");
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(447, 157);
            this.txtUsuario.MaxLength = 55;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(236, 23);
            this.txtUsuario.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtUsuario, "Usuário, utilizado para fazer o login no sistema.");
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // dtNascimento
            // 
            this.dtNascimento.Location = new System.Drawing.Point(75, 213);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(342, 23);
            this.dtNascimento.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dtNascimento, "Data de nascimento do usuário.");
            // 
            // lbNasc
            // 
            this.lbNasc.AutoSize = true;
            this.lbNasc.BackColor = System.Drawing.Color.Transparent;
            this.lbNasc.ForeColor = System.Drawing.Color.White;
            this.lbNasc.Location = new System.Drawing.Point(72, 193);
            this.lbNasc.Name = "lbNasc";
            this.lbNasc.Size = new System.Drawing.Size(134, 17);
            this.lbNasc.TabIndex = 11;
            this.lbNasc.Text = "Data de nascimento";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbSenha.ForeColor = System.Drawing.Color.White;
            this.lbSenha.Location = new System.Drawing.Point(72, 246);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(49, 17);
            this.lbSenha.TabIndex = 13;
            this.lbSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(75, 266);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(342, 23);
            this.txtSenha.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtSenha, "Senha do usuário.");
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lbConfirma
            // 
            this.lbConfirma.AutoSize = true;
            this.lbConfirma.BackColor = System.Drawing.Color.Transparent;
            this.lbConfirma.ForeColor = System.Drawing.Color.White;
            this.lbConfirma.Location = new System.Drawing.Point(444, 246);
            this.lbConfirma.Name = "lbConfirma";
            this.lbConfirma.Size = new System.Drawing.Size(114, 17);
            this.lbConfirma.TabIndex = 15;
            this.lbConfirma.Text = "Confirmar Senha";
            // 
            // txtConfirma
            // 
            this.txtConfirma.Location = new System.Drawing.Point(447, 266);
            this.txtConfirma.MaxLength = 20;
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.PasswordChar = '*';
            this.txtConfirma.Size = new System.Drawing.Size(342, 23);
            this.txtConfirma.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtConfirma, "Confirmar senha do usuário.");
            this.txtConfirma.UseSystemPasswordChar = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(444, 195);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(48, 17);
            this.lbStatus.TabIndex = 17;
            this.lbStatus.Text = "Status";
            this.toolTip1.SetToolTip(this.lbStatus, "Caso status não seja ativo o usuário perde permissão de entrar no sistema.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(627, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Perfil";
            this.toolTip1.SetToolTip(this.label1, "Tipo de usuário pré definido.");
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.DisplayMember = "0";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Bloqueado"});
            this.cmbStatus.Location = new System.Drawing.Point(447, 215);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(159, 24);
            this.cmbStatus.TabIndex = 201;
            this.toolTip1.SetToolTip(this.cmbStatus, "Caso status não seja ativo o usuário perde permissão de entrar no sistema.");
            this.cmbStatus.ValueMember = "0";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPerfil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPerfil.DisplayMember = "0";
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfil.ForeColor = System.Drawing.Color.Black;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Visualisação",
            "Usuário",
            "Chefe",
            "Admin"});
            this.cmbPerfil.Location = new System.Drawing.Point(630, 215);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(159, 24);
            this.cmbPerfil.TabIndex = 202;
            this.toolTip1.SetToolTip(this.cmbPerfil, "Tipo de usuário pré definido.");
            this.cmbPerfil.ValueMember = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(58, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 503;
            this.label4.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(58, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 504;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(429, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 505;
            this.label3.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(58, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 507;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(429, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 508;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(58, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 509;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(429, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 510;
            this.label9.Text = "*";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(689, 154);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 29);
            this.btnVerificar.TabIndex = 511;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(429, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 512;
            this.label10.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(612, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 506;
            this.label5.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(56, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 547;
            this.label11.Text = "*";
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
            this.btnPesquisarSetor.Location = new System.Drawing.Point(317, 316);
            this.btnPesquisarSetor.Name = "btnPesquisarSetor";
            this.btnPesquisarSetor.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisarSetor.TabIndex = 12;
            this.btnPesquisarSetor.Text = "Pesquisar";
            this.btnPesquisarSetor.UseVisualStyleBackColor = false;
            this.btnPesquisarSetor.Click += new System.EventHandler(this.btnPesquisarSetor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(155, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 546;
            this.label12.Text = "Setor";
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(158, 319);
            this.txtSetor.MaxLength = 55;
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.ReadOnly = true;
            this.txtSetor.Size = new System.Drawing.Size(153, 23);
            this.txtSetor.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtSetor, "Setor do funcionário.");
            // 
            // lbCodClientes
            // 
            this.lbCodClientes.AutoSize = true;
            this.lbCodClientes.BackColor = System.Drawing.Color.Transparent;
            this.lbCodClientes.ForeColor = System.Drawing.Color.White;
            this.lbCodClientes.Location = new System.Drawing.Point(72, 299);
            this.lbCodClientes.Name = "lbCodClientes";
            this.lbCodClientes.Size = new System.Drawing.Size(52, 17);
            this.lbCodClientes.TabIndex = 545;
            this.lbCodClientes.Text = "Código";
            // 
            // txtCodSetor
            // 
            this.txtCodSetor.Location = new System.Drawing.Point(75, 319);
            this.txtCodSetor.MaxLength = 6;
            this.txtCodSetor.Name = "txtCodSetor";
            this.txtCodSetor.Size = new System.Drawing.Size(77, 23);
            this.txtCodSetor.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtCodSetor, "Código do setor.");
            this.txtCodSetor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodSetor_KeyPress);
            this.txtCodSetor.Leave += new System.EventHandler(this.txtCodSetor_Leave);
            // 
            // FrmCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(860, 384);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPesquisarSetor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.lbCodClientes);
            this.Controls.Add(this.txtCodSetor);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbConfirma);
            this.Controls.Add(this.txtConfirma);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbNasc);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbSobrenome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "FrmCadastroUsuarios";
            this.Text = "Usuários";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.dtNascimento, 0);
            this.Controls.SetChildIndex(this.txtSenha, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lbNome, 0);
            this.Controls.SetChildIndex(this.txtSobrenome, 0);
            this.Controls.SetChildIndex(this.lbSobrenome, 0);
            this.Controls.SetChildIndex(this.lbEmail, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.lbUsuario, 0);
            this.Controls.SetChildIndex(this.lbNasc, 0);
            this.Controls.SetChildIndex(this.lbSenha, 0);
            this.Controls.SetChildIndex(this.txtConfirma, 0);
            this.Controls.SetChildIndex(this.lbConfirma, 0);
            this.Controls.SetChildIndex(this.lbStatus, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbStatus, 0);
            this.Controls.SetChildIndex(this.cmbPerfil, 0);
            this.Controls.SetChildIndex(this.btnVerificar, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodSetor, 0);
            this.Controls.SetChildIndex(this.lbCodClientes, 0);
            this.Controls.SetChildIndex(this.txtSetor, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.btnPesquisarSetor, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label lbNasc;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbConfirma;
        private System.Windows.Forms.TextBox txtConfirma;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPesquisarSetor;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label lbCodClientes;
        public System.Windows.Forms.TextBox txtCodSetor;
    }
}
