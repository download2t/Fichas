namespace Controle.Views
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTopMenu = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnPatrimonio = new System.Windows.Forms.Button();
            this.btnFichas = new System.Windows.Forms.Button();
            this.btnOrdemDeServico = new System.Windows.Forms.Button();
            this.btnOperacoes = new System.Windows.Forms.Button();
            this.btnGov = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnLideranca = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnSenhas = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblbemVindo = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panelClima = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblDescricaoItem = new System.Windows.Forms.Label();
            this.panelLateral.SuspendLayout();
            this.pnTopMenu.SuspendLayout();
            this.panelClima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.panelLateral.Controls.Add(this.pnTopMenu);
            this.panelLateral.Controls.Add(this.btnPatrimonio);
            this.panelLateral.Controls.Add(this.btnFichas);
            this.panelLateral.Controls.Add(this.btnOrdemDeServico);
            this.panelLateral.Controls.Add(this.btnOperacoes);
            this.panelLateral.Controls.Add(this.btnGov);
            this.panelLateral.Controls.Add(this.btnAgenda);
            this.panelLateral.Controls.Add(this.btnRelatorios);
            this.panelLateral.Controls.Add(this.btnLideranca);
            this.panelLateral.Controls.Add(this.btnSistema);
            this.panelLateral.Controls.Add(this.btnSenhas);
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(251, 571);
            this.panelLateral.TabIndex = 22;
            // 
            // pnTopMenu
            // 
            this.pnTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.pnTopMenu.Controls.Add(this.lblDesc);
            this.pnTopMenu.Location = new System.Drawing.Point(3, 3);
            this.pnTopMenu.Name = "pnTopMenu";
            this.pnTopMenu.Size = new System.Drawing.Size(248, 50);
            this.pnTopMenu.TabIndex = 13;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.lblDesc.Location = new System.Drawing.Point(11, 14);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 21);
            this.lblDesc.TabIndex = 0;
            // 
            // btnPatrimonio
            // 
            this.btnPatrimonio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPatrimonio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.btnPatrimonio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatrimonio.FlatAppearance.BorderSize = 0;
            this.btnPatrimonio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatrimonio.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnPatrimonio.Image = global::Controle.Properties.Resources.Patrimonio_x32;
            this.btnPatrimonio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatrimonio.Location = new System.Drawing.Point(3, 59);
            this.btnPatrimonio.Name = "btnPatrimonio";
            this.btnPatrimonio.Size = new System.Drawing.Size(246, 45);
            this.btnPatrimonio.TabIndex = 0;
            this.btnPatrimonio.Tag = "Consultar Patrimonios";
            this.btnPatrimonio.Text = "PATRIMÔNIO";
            this.btnPatrimonio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatrimonio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatrimonio.UseVisualStyleBackColor = false;
            this.btnPatrimonio.Click += new System.EventHandler(this.btnPatrimonio_Click);
            // 
            // btnFichas
            // 
            this.btnFichas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFichas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.btnFichas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFichas.FlatAppearance.BorderSize = 0;
            this.btnFichas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichas.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnFichas.Image = global::Controle.Properties.Resources.Fichas_x32;
            this.btnFichas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichas.Location = new System.Drawing.Point(3, 110);
            this.btnFichas.Name = "btnFichas";
            this.btnFichas.Size = new System.Drawing.Size(246, 45);
            this.btnFichas.TabIndex = 1;
            this.btnFichas.Tag = "Consultar Fichas";
            this.btnFichas.Text = "FICHAS";
            this.btnFichas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFichas.UseVisualStyleBackColor = false;
            this.btnFichas.Click += new System.EventHandler(this.btnFichas_Click);
            // 
            // btnOrdemDeServico
            // 
            this.btnOrdemDeServico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOrdemDeServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.btnOrdemDeServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdemDeServico.FlatAppearance.BorderSize = 0;
            this.btnOrdemDeServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdemDeServico.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnOrdemDeServico.Image = global::Controle.Properties.Resources.Os_x32;
            this.btnOrdemDeServico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdemDeServico.Location = new System.Drawing.Point(3, 161);
            this.btnOrdemDeServico.Name = "btnOrdemDeServico";
            this.btnOrdemDeServico.Size = new System.Drawing.Size(246, 45);
            this.btnOrdemDeServico.TabIndex = 3;
            this.btnOrdemDeServico.Tag = "Consultar Ordem de Servico";
            this.btnOrdemDeServico.Text = "ORDEM DE SERVIÇO";
            this.btnOrdemDeServico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdemDeServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdemDeServico.UseVisualStyleBackColor = false;
            this.btnOrdemDeServico.Click += new System.EventHandler(this.btnOrdemDeServico_Click);
            // 
            // btnOperacoes
            // 
            this.btnOperacoes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOperacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.btnOperacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperacoes.FlatAppearance.BorderSize = 0;
            this.btnOperacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperacoes.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnOperacoes.Image = global::Controle.Properties.Resources.Editar_32;
            this.btnOperacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperacoes.Location = new System.Drawing.Point(3, 212);
            this.btnOperacoes.Name = "btnOperacoes";
            this.btnOperacoes.Size = new System.Drawing.Size(246, 45);
            this.btnOperacoes.TabIndex = 5;
            this.btnOperacoes.Tag = "Consultar Cofres";
            this.btnOperacoes.Text = "OPERAÇÕES";
            this.btnOperacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOperacoes.UseVisualStyleBackColor = false;
            this.btnOperacoes.Click += new System.EventHandler(this.btnCofres_Click);
            // 
            // btnGov
            // 
            this.btnGov.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.btnGov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGov.FlatAppearance.BorderSize = 0;
            this.btnGov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGov.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnGov.Image = global::Controle.Properties.Resources.Gov_x32;
            this.btnGov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGov.Location = new System.Drawing.Point(3, 263);
            this.btnGov.Name = "btnGov";
            this.btnGov.Size = new System.Drawing.Size(246, 45);
            this.btnGov.TabIndex = 6;
            this.btnGov.Tag = "Consultar Governanca";
            this.btnGov.Text = "GOVERNANÇA";
            this.btnGov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGov.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGov.UseVisualStyleBackColor = false;
            this.btnGov.Click += new System.EventHandler(this.btnGov_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.btnAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnAgenda.Image = global::Controle.Properties.Resources.Contatos_x32;
            this.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.Location = new System.Drawing.Point(3, 314);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(246, 45);
            this.btnAgenda.TabIndex = 7;
            this.btnAgenda.Tag = "Consultar Agenda";
            this.btnAgenda.Text = "AGENDA";
            this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnRelatorios.Image = global::Controle.Properties.Resources.Relatorios_x32;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(3, 365);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(246, 45);
            this.btnRelatorios.TabIndex = 14;
            this.btnRelatorios.Tag = "Consultar Relatorios";
            this.btnRelatorios.Text = "RELATÓRIOS";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnLideranca
            // 
            this.btnLideranca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLideranca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.btnLideranca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLideranca.FlatAppearance.BorderSize = 0;
            this.btnLideranca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLideranca.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnLideranca.Image = global::Controle.Properties.Resources.Rh_x32;
            this.btnLideranca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLideranca.Location = new System.Drawing.Point(3, 416);
            this.btnLideranca.Name = "btnLideranca";
            this.btnLideranca.Size = new System.Drawing.Size(246, 45);
            this.btnLideranca.TabIndex = 15;
            this.btnLideranca.Tag = "Consultar Sistema";
            this.btnLideranca.Text = "LIDERES";
            this.btnLideranca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLideranca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLideranca.UseVisualStyleBackColor = false;
            this.btnLideranca.Click += new System.EventHandler(this.btnLideranca_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.btnSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSistema.FlatAppearance.BorderSize = 0;
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnSistema.Image = global::Controle.Properties.Resources.Sistema_x32;
            this.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistema.Location = new System.Drawing.Point(3, 467);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(246, 45);
            this.btnSistema.TabIndex = 16;
            this.btnSistema.Tag = "Consultar Sistema";
            this.btnSistema.Text = "SISTEMA";
            this.btnSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSistema.UseVisualStyleBackColor = false;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnSenhas
            // 
            this.btnSenhas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSenhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(155)))), ((int)(((byte)(183)))));
            this.btnSenhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhas.FlatAppearance.BorderSize = 0;
            this.btnSenhas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenhas.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnSenhas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSenhas.Location = new System.Drawing.Point(3, 518);
            this.btnSenhas.Name = "btnSenhas";
            this.btnSenhas.Size = new System.Drawing.Size(246, 45);
            this.btnSenhas.TabIndex = 17;
            this.btnSenhas.Tag = "Consultar Senhas";
            this.btnSenhas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSenhas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSenhas.UseVisualStyleBackColor = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.lblDateTime.Location = new System.Drawing.Point(148, 62);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(47, 24);
            this.lblDateTime.TabIndex = 246;
            this.lblDateTime.Text = "Data";
            // 
            // lblTemperature
            // 
            this.lblTemperature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.lblTemperature.Location = new System.Drawing.Point(366, 35);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(118, 24);
            this.lblTemperature.TabIndex = 245;
            this.lblTemperature.Text = "Temperatura";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.lblCity.Location = new System.Drawing.Point(148, 35);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(70, 24);
            this.lblCity.TabIndex = 244;
            this.lblCity.Text = "Cidade";
            // 
            // lblbemVindo
            // 
            this.lblbemVindo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblbemVindo.AutoSize = true;
            this.lblbemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblbemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbemVindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.lblbemVindo.Location = new System.Drawing.Point(148, 9);
            this.lblbemVindo.Name = "lblbemVindo";
            this.lblbemVindo.Size = new System.Drawing.Size(158, 20);
            this.lblbemVindo.TabIndex = 242;
            this.lblbemVindo.Text = "Olá,  seja bem vindo: ";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.lblLogin.Location = new System.Drawing.Point(306, 7);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(199, 24);
            this.lblLogin.TabIndex = 243;
            this.lblLogin.Text = "Nome e Sobrenome";
            // 
            // panelClima
            // 
            this.panelClima.Controls.Add(this.lblDateTime);
            this.panelClima.Controls.Add(this.lblTemperature);
            this.panelClima.Controls.Add(this.lblCity);
            this.panelClima.Controls.Add(this.lblbemVindo);
            this.panelClima.Controls.Add(this.lblLogin);
            this.panelClima.Controls.Add(this.pbLogo);
            this.panelClima.Location = new System.Drawing.Point(119, 42);
            this.panelClima.Name = "panelClima";
            this.panelClima.Size = new System.Drawing.Size(657, 365);
            this.panelClima.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Controle.Properties.Resources.sanma_logo_color;
            this.pbLogo.Location = new System.Drawing.Point(64, 97);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(528, 228);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 247;
            this.pbLogo.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.panelClima);
            this.panelButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelButtons.Location = new System.Drawing.Point(261, 59);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(895, 513);
            this.panelButtons.TabIndex = 23;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(102, 0);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(207, 19);
            this.lblNomeFuncionario.TabIndex = 1;
            this.lblNomeFuncionario.Text = "Usuário não está logado";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.panel3.Controls.Add(this.lblNomeFuncionario);
            this.panel3.Controls.Add(this.lblBoasVindas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 572);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1171, 22);
            this.panel3.TabIndex = 24;
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.lblBoasVindas.ForeColor = System.Drawing.Color.White;
            this.lblBoasVindas.Location = new System.Drawing.Point(6, 0);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(104, 19);
            this.lblBoasVindas.TabIndex = 0;
            this.lblBoasVindas.Text = "Bem vindo ";
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.panelTop.Controls.Add(this.btnHome);
            this.panelTop.Controls.Add(this.lblDescricaoItem);
            this.panelTop.Location = new System.Drawing.Point(261, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(910, 50);
            this.panelTop.TabIndex = 25;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.btnHome.Image = global::Controle.Properties.Resources.Home_x32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(43, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Consultar Patrimonios";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblDescricaoItem
            // 
            this.lblDescricaoItem.AutoSize = true;
            this.lblDescricaoItem.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Bold);
            this.lblDescricaoItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.lblDescricaoItem.Location = new System.Drawing.Point(9, 14);
            this.lblDescricaoItem.Name = "lblDescricaoItem";
            this.lblDescricaoItem.Size = new System.Drawing.Size(0, 21);
            this.lblDescricaoItem.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 594);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SANMA HOTEL - MENU PRINCIPAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.panelLateral.ResumeLayout(false);
            this.pnTopMenu.ResumeLayout(false);
            this.pnTopMenu.PerformLayout();
            this.panelClima.ResumeLayout(false);
            this.panelClima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatrimonio;
        private System.Windows.Forms.Button btnFichas;
        private System.Windows.Forms.Button btnOrdemDeServico;
        private System.Windows.Forms.Button btnOperacoes;
        private System.Windows.Forms.Button btnGov;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnLideranca;
        private System.Windows.Forms.FlowLayoutPanel panelLateral;
        private System.Windows.Forms.Panel pnTopMenu;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblbemVindo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panelClima;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblDescricaoItem;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Button btnSenhas;
    }
}