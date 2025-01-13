namespace test.Views.Cadastros
{
    partial class FrmCadastroMensagens
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroMensagens));
            this.cbTodos = new System.Windows.Forms.CheckBox();
            this.cbSegunda = new System.Windows.Forms.CheckBox();
            this.cbTerca = new System.Windows.Forms.CheckBox();
            this.cbQuarta = new System.Windows.Forms.CheckBox();
            this.cbQuinta = new System.Windows.Forms.CheckBox();
            this.cbSexta = new System.Windows.Forms.CheckBox();
            this.cbSabado = new System.Windows.Forms.CheckBox();
            this.cbDomingo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timerRelógio = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clContato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserirContato = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbUnico = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtEnvio = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarContatos = new System.Windows.Forms.Button();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtCodContato = new System.Windows.Forms.TextBox();
            this.tbMultiplos = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMsg2 = new System.Windows.Forms.TextBox();
            this.lblHorario2 = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAnoTodo = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.tbDelete = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPesquisar6 = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.TextBox();
            this.txtCodExcluir = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cbHora = new System.Windows.Forms.MaskedTextBox();
            this.cbHora2 = new System.Windows.Forms.MaskedTextBox();
            this.pbAjuda = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tbUnico.SuspendLayout();
            this.tbMultiplos.SuspendLayout();
            this.tbDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(395, 565);
            this.btnSalvar.TabIndex = 90;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbID.Location = new System.Drawing.Point(253, 574);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(512, 565);
            this.btnSair.TabIndex = 91;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtID.Location = new System.Drawing.Point(280, 571);
            this.txtID.Visible = false;
            // 
            // cbTodos
            // 
            this.cbTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTodos.AutoSize = true;
            this.cbTodos.BackColor = System.Drawing.Color.Transparent;
            this.cbTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cbTodos.ForeColor = System.Drawing.Color.White;
            this.cbTodos.Location = new System.Drawing.Point(640, 100);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(109, 35);
            this.cbTodos.TabIndex = 80;
            this.cbTodos.Text = "Todos";
            this.toolTip1.SetToolTip(this.cbTodos, "As mensagens serão enviadas todos os dias da semana caso este campo esteja marcad" +
        "o.");
            this.cbTodos.UseVisualStyleBackColor = false;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.cbTodos_CheckedChanged);
            // 
            // cbSegunda
            // 
            this.cbSegunda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSegunda.AutoSize = true;
            this.cbSegunda.BackColor = System.Drawing.Color.Transparent;
            this.cbSegunda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cbSegunda.ForeColor = System.Drawing.Color.White;
            this.cbSegunda.Location = new System.Drawing.Point(773, 100);
            this.cbSegunda.Name = "cbSegunda";
            this.cbSegunda.Size = new System.Drawing.Size(141, 35);
            this.cbSegunda.TabIndex = 81;
            this.cbSegunda.Text = "Segunda";
            this.toolTip1.SetToolTip(this.cbSegunda, "Mensagem será enviada neste dia caso este campo esteja marcado.");
            this.cbSegunda.UseVisualStyleBackColor = false;
            // 
            // cbTerca
            // 
            this.cbTerca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTerca.AutoSize = true;
            this.cbTerca.BackColor = System.Drawing.Color.Transparent;
            this.cbTerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cbTerca.ForeColor = System.Drawing.Color.White;
            this.cbTerca.Location = new System.Drawing.Point(946, 100);
            this.cbTerca.Name = "cbTerca";
            this.cbTerca.Size = new System.Drawing.Size(103, 35);
            this.cbTerca.TabIndex = 82;
            this.cbTerca.Text = "Terça";
            this.toolTip1.SetToolTip(this.cbTerca, "Mensagem será enviada neste dia caso este campo esteja marcado.");
            this.cbTerca.UseVisualStyleBackColor = false;
            // 
            // cbQuarta
            // 
            this.cbQuarta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbQuarta.AutoSize = true;
            this.cbQuarta.BackColor = System.Drawing.Color.Transparent;
            this.cbQuarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbQuarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cbQuarta.ForeColor = System.Drawing.Color.White;
            this.cbQuarta.Location = new System.Drawing.Point(1055, 100);
            this.cbQuarta.Name = "cbQuarta";
            this.cbQuarta.Size = new System.Drawing.Size(116, 35);
            this.cbQuarta.TabIndex = 83;
            this.cbQuarta.Text = "Quarta";
            this.toolTip1.SetToolTip(this.cbQuarta, "Mensagem será enviada neste dia caso este campo esteja marcado.");
            this.cbQuarta.UseVisualStyleBackColor = false;
            // 
            // cbQuinta
            // 
            this.cbQuinta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbQuinta.AutoSize = true;
            this.cbQuinta.BackColor = System.Drawing.Color.Transparent;
            this.cbQuinta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbQuinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cbQuinta.ForeColor = System.Drawing.Color.White;
            this.cbQuinta.Location = new System.Drawing.Point(643, 160);
            this.cbQuinta.Name = "cbQuinta";
            this.cbQuinta.Size = new System.Drawing.Size(113, 35);
            this.cbQuinta.TabIndex = 84;
            this.cbQuinta.Text = "Quinta";
            this.toolTip1.SetToolTip(this.cbQuinta, "Mensagem será enviada neste dia caso este campo esteja marcado.");
            this.cbQuinta.UseVisualStyleBackColor = false;
            // 
            // cbSexta
            // 
            this.cbSexta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSexta.AutoSize = true;
            this.cbSexta.BackColor = System.Drawing.Color.Transparent;
            this.cbSexta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSexta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cbSexta.ForeColor = System.Drawing.Color.White;
            this.cbSexta.Location = new System.Drawing.Point(773, 160);
            this.cbSexta.Name = "cbSexta";
            this.cbSexta.Size = new System.Drawing.Size(102, 35);
            this.cbSexta.TabIndex = 85;
            this.cbSexta.Text = "Sexta";
            this.toolTip1.SetToolTip(this.cbSexta, "Mensagem será enviada neste dia caso este campo esteja marcado.");
            this.cbSexta.UseVisualStyleBackColor = false;
            // 
            // cbSabado
            // 
            this.cbSabado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSabado.AutoSize = true;
            this.cbSabado.BackColor = System.Drawing.Color.Transparent;
            this.cbSabado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cbSabado.ForeColor = System.Drawing.Color.White;
            this.cbSabado.Location = new System.Drawing.Point(920, 160);
            this.cbSabado.Name = "cbSabado";
            this.cbSabado.Size = new System.Drawing.Size(126, 35);
            this.cbSabado.TabIndex = 86;
            this.cbSabado.Text = "Sábado";
            this.toolTip1.SetToolTip(this.cbSabado, "Mensagem será enviada neste dia caso este campo esteja marcado.");
            this.cbSabado.UseVisualStyleBackColor = false;
            // 
            // cbDomingo
            // 
            this.cbDomingo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDomingo.AutoSize = true;
            this.cbDomingo.BackColor = System.Drawing.Color.Transparent;
            this.cbDomingo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cbDomingo.ForeColor = System.Drawing.Color.White;
            this.cbDomingo.Location = new System.Drawing.Point(1055, 160);
            this.cbDomingo.Name = "cbDomingo";
            this.cbDomingo.Size = new System.Drawing.Size(141, 35);
            this.cbDomingo.TabIndex = 87;
            this.cbDomingo.Text = "Domingo";
            this.toolTip1.SetToolTip(this.cbDomingo, "Mensagem será enviada neste dia caso este campo esteja marcado.");
            this.cbDomingo.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(639, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 22);
            this.label6.TabIndex = 781;
            this.label6.Text = "Escala de repetição";
            this.toolTip1.SetToolTip(this.label6, "Escala será realizada de acordo com os dias marcados.");
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.clContato});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(643, 222);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(553, 323);
            this.listView1.TabIndex = 787;
            this.toolTip1.SetToolTip(this.listView1, "Lista de contatos que receberão as mensagens. ( utilizado com agendamento em mass" +
        "a).");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            // 
            // clContato
            // 
            this.clContato.Text = "Contato";
            this.clContato.Width = 480;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(1065, 565);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(131, 29);
            this.btnRemover.TabIndex = 89;
            this.btnRemover.Text = "Remover da lista";
            this.toolTip1.SetToolTip(this.btnRemover, "Selecione um contato na lista para removê-lo.");
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInserirContato
            // 
            this.btnInserirContato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInserirContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnInserirContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirContato.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInserirContato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInserirContato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInserirContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirContato.ForeColor = System.Drawing.Color.White;
            this.btnInserirContato.Location = new System.Drawing.Point(931, 565);
            this.btnInserirContato.Name = "btnInserirContato";
            this.btnInserirContato.Size = new System.Drawing.Size(128, 29);
            this.btnInserirContato.TabIndex = 88;
            this.btnInserirContato.Text = "Inserir Contato";
            this.toolTip1.SetToolTip(this.btnInserirContato, "Adcionar um contato para receber a mensagem.");
            this.btnInserirContato.UseVisualStyleBackColor = false;
            this.btnInserirContato.Click += new System.EventHandler(this.btnInserirContato_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbUnico);
            this.tabControl1.Controls.Add(this.tbMultiplos);
            this.tabControl1.Controls.Add(this.tbDelete);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 514);
            this.tabControl1.TabIndex = 789;
            this.toolTip1.SetToolTip(this.tabControl1, "Agendamento de mensagens / Exclusão.");
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tbUnico
            // 
            this.tbUnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbUnico.Controls.Add(this.cbHora);
            this.tbUnico.Controls.Add(this.label20);
            this.tbUnico.Controls.Add(this.label16);
            this.tbUnico.Controls.Add(this.txtMsg);
            this.tbUnico.Controls.Add(this.label2);
            this.tbUnico.Controls.Add(this.label21);
            this.tbUnico.Controls.Add(this.label1);
            this.tbUnico.Controls.Add(this.lblHorario);
            this.tbUnico.Controls.Add(this.Horario);
            this.tbUnico.Controls.Add(this.label3);
            this.tbUnico.Controls.Add(this.label5);
            this.tbUnico.Controls.Add(this.label4);
            this.tbUnico.Controls.Add(this.dtEnvio);
            this.tbUnico.Controls.Add(this.btnBuscarContatos);
            this.tbUnico.Controls.Add(this.txtContato);
            this.tbUnico.Controls.Add(this.txtCodContato);
            this.tbUnico.Location = new System.Drawing.Point(4, 25);
            this.tbUnico.Name = "tbUnico";
            this.tbUnico.Padding = new System.Windows.Forms.Padding(3);
            this.tbUnico.Size = new System.Drawing.Size(593, 485);
            this.tbUnico.TabIndex = 0;
            this.tbUnico.Text = "Agendamento Unico";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(34, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 20);
            this.label20.TabIndex = 782;
            this.label20.Text = "Mensagem";
            this.toolTip1.SetToolTip(this.label20, "Menságem a ser agendada.");
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(13, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 781;
            this.label16.Text = "*";
            // 
            // txtMsg
            // 
            this.txtMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.ForeColor = System.Drawing.Color.Black;
            this.txtMsg.Location = new System.Drawing.Point(38, 166);
            this.txtMsg.MaxLength = 5000;
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(537, 302);
            this.txtMsg.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtMsg, "Menságem a ser agendada.");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 779;
            this.label2.Text = "*";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(203, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 20);
            this.label21.TabIndex = 778;
            this.label21.Text = "Contato";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 777;
            this.label1.Text = "Codigo Contato";
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHorario.AutoSize = true;
            this.lblHorario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(504, 59);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(71, 20);
            this.lblHorario.TabIndex = 776;
            this.lblHorario.Text = "00:00:00";
            // 
            // Horario
            // 
            this.Horario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Horario.AutoSize = true;
            this.Horario.Cursor = System.Windows.Forms.Cursors.Default;
            this.Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Horario.ForeColor = System.Drawing.Color.White;
            this.Horario.Location = new System.Drawing.Point(421, 31);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(61, 20);
            this.Horario.TabIndex = 775;
            this.Horario.Text = "Horário";
            this.toolTip1.SetToolTip(this.Horario, "Horário da entrega da menságem.");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(400, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 774;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 773;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 772;
            this.label4.Text = "Data de envio";
            // 
            // dtEnvio
            // 
            this.dtEnvio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtEnvio.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtEnvio.Location = new System.Drawing.Point(38, 54);
            this.dtEnvio.Name = "dtEnvio";
            this.dtEnvio.Size = new System.Drawing.Size(377, 23);
            this.dtEnvio.TabIndex = 1;
            // 
            // btnBuscarContatos
            // 
            this.btnBuscarContatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarContatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBuscarContatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarContatos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarContatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarContatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarContatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarContatos.ForeColor = System.Drawing.Color.White;
            this.btnBuscarContatos.Location = new System.Drawing.Point(475, 100);
            this.btnBuscarContatos.Name = "btnBuscarContatos";
            this.btnBuscarContatos.Size = new System.Drawing.Size(100, 29);
            this.btnBuscarContatos.TabIndex = 5;
            this.btnBuscarContatos.Text = "Pesquisar";
            this.btnBuscarContatos.UseVisualStyleBackColor = false;
            this.btnBuscarContatos.Click += new System.EventHandler(this.btnBuscarContatos_Click_1);
            // 
            // txtContato
            // 
            this.txtContato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContato.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtContato.Enabled = false;
            this.txtContato.Location = new System.Drawing.Point(208, 103);
            this.txtContato.MaxLength = 55;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(261, 23);
            this.txtContato.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtContato, "Nome do contato.");
            // 
            // txtCodContato
            // 
            this.txtCodContato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodContato.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCodContato.Location = new System.Drawing.Point(38, 103);
            this.txtCodContato.MaxLength = 6;
            this.txtCodContato.Name = "txtCodContato";
            this.txtCodContato.Size = new System.Drawing.Size(155, 23);
            this.txtCodContato.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtCodContato, "código da menságem");
            this.txtCodContato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodContato_KeyPress);
            this.txtCodContato.Leave += new System.EventHandler(this.txtCodContato_Leave);
            // 
            // tbMultiplos
            // 
            this.tbMultiplos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbMultiplos.Controls.Add(this.cbHora2);
            this.tbMultiplos.Controls.Add(this.label11);
            this.tbMultiplos.Controls.Add(this.label12);
            this.tbMultiplos.Controls.Add(this.txtMsg2);
            this.tbMultiplos.Controls.Add(this.lblHorario2);
            this.tbMultiplos.Controls.Add(this.labelH);
            this.tbMultiplos.Controls.Add(this.label13);
            this.tbMultiplos.Controls.Add(this.label9);
            this.tbMultiplos.Controls.Add(this.label7);
            this.tbMultiplos.Controls.Add(this.cbAnoTodo);
            this.tbMultiplos.Controls.Add(this.label17);
            this.tbMultiplos.Controls.Add(this.label18);
            this.tbMultiplos.Controls.Add(this.cmbAno);
            this.tbMultiplos.Controls.Add(this.cmbMes);
            this.tbMultiplos.Location = new System.Drawing.Point(4, 25);
            this.tbMultiplos.Name = "tbMultiplos";
            this.tbMultiplos.Padding = new System.Windows.Forms.Padding(3);
            this.tbMultiplos.Size = new System.Drawing.Size(593, 485);
            this.tbMultiplos.TabIndex = 1;
            this.tbMultiplos.Text = "Agendamento em Massa";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(39, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 802;
            this.label11.Text = "Mensagem";
            this.toolTip1.SetToolTip(this.label11, "Mensagem a ser agendada.");
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(18, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 801;
            this.label12.Text = "*";
            // 
            // txtMsg2
            // 
            this.txtMsg2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMsg2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMsg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg2.ForeColor = System.Drawing.Color.Black;
            this.txtMsg2.Location = new System.Drawing.Point(38, 166);
            this.txtMsg2.MaxLength = 5000;
            this.txtMsg2.Multiline = true;
            this.txtMsg2.Name = "txtMsg2";
            this.txtMsg2.Size = new System.Drawing.Size(537, 302);
            this.txtMsg2.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtMsg2, "Mensagem a ser agendada.");
            // 
            // lblHorario2
            // 
            this.lblHorario2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHorario2.AutoSize = true;
            this.lblHorario2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHorario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHorario2.ForeColor = System.Drawing.Color.White;
            this.lblHorario2.Location = new System.Drawing.Point(504, 98);
            this.lblHorario2.Name = "lblHorario2";
            this.lblHorario2.Size = new System.Drawing.Size(71, 20);
            this.lblHorario2.TabIndex = 799;
            this.lblHorario2.Text = "00:00:00";
            // 
            // labelH
            // 
            this.labelH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelH.AutoSize = true;
            this.labelH.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelH.ForeColor = System.Drawing.Color.White;
            this.labelH.Location = new System.Drawing.Point(378, 72);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(61, 20);
            this.labelH.TabIndex = 798;
            this.labelH.Text = "Horário";
            this.toolTip1.SetToolTip(this.labelH, "Horário da entrega da menságem.");
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(361, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 797;
            this.label13.Text = "*";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(215, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 794;
            this.label9.Text = "*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(19, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 793;
            this.label7.Text = "*";
            // 
            // cbAnoTodo
            // 
            this.cbAnoTodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAnoTodo.AutoSize = true;
            this.cbAnoTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAnoTodo.ForeColor = System.Drawing.Color.White;
            this.cbAnoTodo.Location = new System.Drawing.Point(38, 33);
            this.cbAnoTodo.Name = "cbAnoTodo";
            this.cbAnoTodo.Size = new System.Drawing.Size(176, 21);
            this.cbAnoTodo.TabIndex = 1;
            this.cbAnoTodo.Text = "Incluir Todos os Meses.";
            this.toolTip1.SetToolTip(this.cbAnoTodo, "Este campo faz com que todos os meses do ano selecionado recebam a mensagem nos d" +
        "ias selecionados.");
            this.cbAnoTodo.UseVisualStyleBackColor = true;
            this.cbAnoTodo.CheckedChanged += new System.EventHandler(this.cbAnoTodo_CheckedChanged);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(236, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 22);
            this.label17.TabIndex = 789;
            this.label17.Text = "Ano";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(35, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 22);
            this.label18.TabIndex = 788;
            this.label18.Text = "Mês";
            // 
            // cmbAno
            // 
            this.cmbAno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAno.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(240, 96);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(133, 28);
            this.cmbAno.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbAno, "Ano de agendamento");
            // 
            // cmbMes
            // 
            this.cmbMes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMes.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(39, 96);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(191, 28);
            this.cmbMes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmbMes, "Mes de agendamento");
            // 
            // tbDelete
            // 
            this.tbDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tbDelete.Controls.Add(this.pbAjuda);
            this.tbDelete.Controls.Add(this.label14);
            this.tbDelete.Controls.Add(this.btnPesquisar6);
            this.tbDelete.Controls.Add(this.txtExcluir);
            this.tbDelete.Controls.Add(this.txtCodExcluir);
            this.tbDelete.Controls.Add(this.label22);
            this.tbDelete.Controls.Add(this.btnExcluir);
            this.tbDelete.Location = new System.Drawing.Point(4, 25);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tbDelete.Size = new System.Drawing.Size(593, 485);
            this.tbDelete.TabIndex = 2;
            this.tbDelete.Text = "Excluir Mensagens";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(159, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 785;
            this.label14.Text = "Contato";
            // 
            // btnPesquisar6
            // 
            this.btnPesquisar6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisar6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisar6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisar6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisar6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar6.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar6.Location = new System.Drawing.Point(449, 76);
            this.btnPesquisar6.Name = "btnPesquisar6";
            this.btnPesquisar6.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar6.TabIndex = 3;
            this.btnPesquisar6.Text = "Pesquisar";
            this.btnPesquisar6.UseVisualStyleBackColor = false;
            this.btnPesquisar6.Click += new System.EventHandler(this.btnBuscarContatos_Click_1);
            // 
            // txtExcluir
            // 
            this.txtExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtExcluir.Location = new System.Drawing.Point(163, 79);
            this.txtExcluir.MaxLength = 55;
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.ReadOnly = true;
            this.txtExcluir.Size = new System.Drawing.Size(280, 23);
            this.txtExcluir.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtExcluir, "Nome do contato.");
            // 
            // txtCodExcluir
            // 
            this.txtCodExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCodExcluir.Location = new System.Drawing.Point(26, 79);
            this.txtCodExcluir.MaxLength = 6;
            this.txtCodExcluir.Name = "txtCodExcluir";
            this.txtCodExcluir.Size = new System.Drawing.Size(131, 23);
            this.txtCodExcluir.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCodExcluir, "Código do contato.");
            this.txtCodExcluir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodContato_KeyPress);
            this.txtCodExcluir.Leave += new System.EventHandler(this.txtCodContato_Leave);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(22, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 20);
            this.label22.TabIndex = 781;
            this.label22.Text = "Código Contato";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(404, 122);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(145, 29);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir por Contato";
            this.toolTip1.SetToolTip(this.btnExcluir, "Todas as menságens agendadas para este contato serão excluidas.");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cbHora
            // 
            this.cbHora.Location = new System.Drawing.Point(425, 54);
            this.cbHora.Mask = "90:00";
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(44, 23);
            this.cbHora.TabIndex = 783;
            this.cbHora.ValidatingType = typeof(System.DateTime);
            this.cbHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hora_KeyPress);
            this.cbHora.Leave += new System.EventHandler(this.Hora_Leave);
            // 
            // cbHora2
            // 
            this.cbHora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHora2.Location = new System.Drawing.Point(382, 95);
            this.cbHora2.Mask = "90:00";
            this.cbHora2.Name = "cbHora2";
            this.cbHora2.Size = new System.Drawing.Size(44, 27);
            this.cbHora2.TabIndex = 803;
            this.cbHora2.ValidatingType = typeof(System.DateTime);
            // 
            // pbAjuda
            // 
            this.pbAjuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAjuda.BackColor = System.Drawing.Color.Transparent;
            this.pbAjuda.Image = global::Controle.Properties.Resources.ajuda;
            this.pbAjuda.Location = new System.Drawing.Point(363, 122);
            this.pbAjuda.Name = "pbAjuda";
            this.pbAjuda.Size = new System.Drawing.Size(35, 30);
            this.pbAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAjuda.TabIndex = 810;
            this.pbAjuda.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAjuda, resources.GetString("pbAjuda.ToolTip"));
            this.pbAjuda.Click += new System.EventHandler(this.pbAjuda_Click);
            // 
            // FrmCadastroMensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1268, 643);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnInserirContato);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDomingo);
            this.Controls.Add(this.cbSabado);
            this.Controls.Add(this.cbSexta);
            this.Controls.Add(this.cbQuinta);
            this.Controls.Add(this.cbQuarta);
            this.Controls.Add(this.cbTerca);
            this.Controls.Add(this.cbSegunda);
            this.Controls.Add(this.cbTodos);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FrmCadastroMensagens";
            this.Text = "Cadastrar Mensagem";
            this.Controls.SetChildIndex(this.cbTodos, 0);
            this.Controls.SetChildIndex(this.cbSegunda, 0);
            this.Controls.SetChildIndex(this.cbTerca, 0);
            this.Controls.SetChildIndex(this.cbQuarta, 0);
            this.Controls.SetChildIndex(this.cbQuinta, 0);
            this.Controls.SetChildIndex(this.cbSexta, 0);
            this.Controls.SetChildIndex(this.cbSabado, 0);
            this.Controls.SetChildIndex(this.cbDomingo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnRemover, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.btnInserirContato, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.tabControl1.ResumeLayout(false);
            this.tbUnico.ResumeLayout(false);
            this.tbUnico.PerformLayout();
            this.tbMultiplos.ResumeLayout(false);
            this.tbMultiplos.PerformLayout();
            this.tbDelete.ResumeLayout(false);
            this.tbDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbTodos;
        private System.Windows.Forms.CheckBox cbSegunda;
        private System.Windows.Forms.CheckBox cbTerca;
        private System.Windows.Forms.CheckBox cbQuarta;
        private System.Windows.Forms.CheckBox cbQuinta;
        private System.Windows.Forms.CheckBox cbSexta;
        private System.Windows.Forms.CheckBox cbSabado;
        private System.Windows.Forms.CheckBox cbDomingo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerRelógio;
        protected System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Codigo;
        protected System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ColumnHeader clContato;
        private System.Windows.Forms.Button btnInserirContato;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbUnico;
        private System.Windows.Forms.TabPage tbMultiplos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label Horario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtEnvio;
        private System.Windows.Forms.Button btnBuscarContatos;
        public System.Windows.Forms.TextBox txtContato;
        public System.Windows.Forms.TextBox txtCodContato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbAnoTodo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblHorario2;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMsg2;
        private System.Windows.Forms.TabPage tbDelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPesquisar6;
        public System.Windows.Forms.TextBox txtExcluir;
        public System.Windows.Forms.TextBox txtCodExcluir;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox cbHora;
        private System.Windows.Forms.MaskedTextBox cbHora2;
        private System.Windows.Forms.PictureBox pbAjuda;
    }
}
