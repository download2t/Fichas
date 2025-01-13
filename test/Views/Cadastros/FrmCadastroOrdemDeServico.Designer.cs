namespace Controle.Views.Cadastros
{
    partial class FrmCadastroOrdemDeServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroOrdemDeServico));
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReabrir = new System.Windows.Forms.Button();
            this.btnEncerrarOS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.pbAjuda = new System.Windows.Forms.PictureBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(1041, 570);
            this.btnSalvar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.Location = new System.Drawing.Point(4, 645);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(1147, 570);
            this.btnSair.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(39, 573);
            this.txtID.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(20, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 518;
            this.label5.Text = "*";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Location = new System.Drawing.Point(39, 211);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(651, 348);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.Text = "";
            this.toolTip1.SetToolTip(this.txtDescricao, "Descreva o problema a ser tratado nesta OS.");
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // lbDescricao
            // 
            this.lbDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lbDescricao.ForeColor = System.Drawing.Color.White;
            this.lbDescricao.Location = new System.Drawing.Point(36, 191);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(71, 17);
            this.lbDescricao.TabIndex = 517;
            this.lbDescricao.Text = "Descrição";
            this.toolTip1.SetToolTip(this.lbDescricao, "Descreva o problema a ser tratado nesta OS.");
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(33, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 20);
            this.label21.TabIndex = 790;
            this.label21.Text = "Assunto";
            this.toolTip1.SetToolTip(this.label21, "Assunto a ser tratado nesta OS.");
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTitulo.Location = new System.Drawing.Point(38, 96);
            this.txtTitulo.MaxLength = 55;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(651, 23);
            this.txtTitulo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtTitulo, "Assunto a ser tratado nesta OS.");
            // 
            // btnFoto
            // 
            this.btnFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.ForeColor = System.Drawing.Color.White;
            this.btnFoto.Location = new System.Drawing.Point(737, 570);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(142, 29);
            this.btnFoto.TabIndex = 7;
            this.btnFoto.Text = "Inserir Foto";
            this.toolTip1.SetToolTip(this.btnFoto, "Adcionar uma nova foto.");
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
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
            this.btnRemover.Location = new System.Drawing.Point(890, 570);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(145, 29);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover Foto";
            this.toolTip1.SetToolTip(this.btnRemover, "Remover uma foto existente.");
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.clDescricao});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(737, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(510, 242);
            this.listView1.TabIndex = 795;
            this.toolTip1.SetToolTip(this.listView1, "Lista de fotos relacionadas a OS.");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 0;
            // 
            // clDescricao
            // 
            this.clDescricao.Text = "Descricao";
            this.clDescricao.Width = 404;
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPrioridade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Items.AddRange(new object[] {
            "Urgente",
            "Alta",
            "Média",
            "Baixa"});
            this.cmbPrioridade.Location = new System.Drawing.Point(38, 155);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(652, 24);
            this.cmbPrioridade.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbPrioridade, "Ordem de prioridade.");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 797;
            this.label1.Text = "Prioridade";
            this.toolTip1.SetToolTip(this.label1, "Ordem de prioridade.");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 798;
            this.label2.Text = "*";
            // 
            // btnReabrir
            // 
            this.btnReabrir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReabrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnReabrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReabrir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReabrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReabrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReabrir.ForeColor = System.Drawing.Color.White;
            this.btnReabrir.Location = new System.Drawing.Point(260, 570);
            this.btnReabrir.Name = "btnReabrir";
            this.btnReabrir.Size = new System.Drawing.Size(128, 29);
            this.btnReabrir.TabIndex = 5;
            this.btnReabrir.Text = "Reabrir OS";
            this.toolTip1.SetToolTip(this.btnReabrir, "Reabertura de ordem de serviço.");
            this.btnReabrir.UseVisualStyleBackColor = false;
            this.btnReabrir.Visible = false;
            this.btnReabrir.Click += new System.EventHandler(this.btnReabrir_Click);
            // 
            // btnEncerrarOS
            // 
            this.btnEncerrarOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEncerrarOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEncerrarOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrarOS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEncerrarOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEncerrarOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEncerrarOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrarOS.ForeColor = System.Drawing.Color.White;
            this.btnEncerrarOS.Location = new System.Drawing.Point(394, 570);
            this.btnEncerrarOS.Name = "btnEncerrarOS";
            this.btnEncerrarOS.Size = new System.Drawing.Size(296, 29);
            this.btnEncerrarOS.TabIndex = 6;
            this.btnEncerrarOS.Tag = "";
            this.btnEncerrarOS.Text = "Encerrar OS";
            this.toolTip1.SetToolTip(this.btnEncerrarOS, "Encerra está ordem de serviço.");
            this.btnEncerrarOS.UseVisualStyleBackColor = false;
            this.btnEncerrarOS.Visible = false;
            this.btnEncerrarOS.Click += new System.EventHandler(this.btnEncerrarOS_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(541, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 803;
            this.label4.Text = "Ticket";
            this.toolTip1.SetToolTip(this.label4, "Número de ticket caso tenha um.");
            // 
            // txtTicket
            // 
            this.txtTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTicket.Location = new System.Drawing.Point(545, 52);
            this.txtTicket.MaxLength = 55;
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(145, 23);
            this.txtTicket.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtTicket, "Número de ticket caso tenha um.");
            this.txtTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicket_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(20, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 805;
            this.label6.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(390, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 807;
            this.label3.Text = "Status";
            this.toolTip1.SetToolTip(this.label3, "Status da OS.");
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Aberto",
            "Encerrado",
            "Encaminhado a TOTVS",
            "Em andamento",
            "Em análise",
            "Manutenção",
            "Aguardando aprovação"});
            this.txtStatus.Location = new System.Drawing.Point(394, 51);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(145, 24);
            this.txtStatus.TabIndex = 808;
            // 
            // pbAjuda
            // 
            this.pbAjuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAjuda.BackColor = System.Drawing.Color.Transparent;
            this.pbAjuda.Image = global::Controle.Properties.Resources.ajuda;
            this.pbAjuda.Location = new System.Drawing.Point(696, 152);
            this.pbAjuda.Name = "pbAjuda";
            this.pbAjuda.Size = new System.Drawing.Size(35, 30);
            this.pbAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAjuda.TabIndex = 809;
            this.pbAjuda.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAjuda, resources.GetString("pbAjuda.ToolTip"));
            this.pbAjuda.Click += new System.EventHandler(this.pbAjuda_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFoto.BackgroundImage = global::Controle.Properties.Resources.sem_foto1;
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFoto.Location = new System.Drawing.Point(737, 279);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(510, 280);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 794;
            this.pbFoto.TabStop = false;
            this.pbFoto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbFoto_MouseDoubleClick);
            // 
            // FrmCadastroOrdemDeServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1286, 607);
            this.Controls.Add(this.pbAjuda);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.btnEncerrarOS);
            this.Controls.Add(this.btnReabrir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPrioridade);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.label5);
            this.Name = "FrmCadastroOrdemDeServico";
            this.Text = "Ordem de Serviço";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lbDescricao, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnRemover, 0);
            this.Controls.SetChildIndex(this.btnFoto, 0);
            this.Controls.SetChildIndex(this.txtTitulo, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.pbFoto, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.cmbPrioridade, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnReabrir, 0);
            this.Controls.SetChildIndex(this.btnEncerrarOS, 0);
            this.Controls.SetChildIndex(this.txtTicket, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtStatus, 0);
            this.Controls.SetChildIndex(this.pbAjuda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txtTitulo;
        protected System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnReabrir;
        private System.Windows.Forms.ColumnHeader clDescricao;
        public System.Windows.Forms.Button btnEncerrarOS;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.PictureBox pbAjuda;
        public System.Windows.Forms.ComboBox cmbPrioridade;
        public System.Windows.Forms.Button btnFoto;
        public System.Windows.Forms.Button btnRemover;
    }
}
