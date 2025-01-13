namespace Controle.Views.Relatorios.Forms
{
    partial class FrmRelLavanderia
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
            this.cbItemLavanderia = new System.Windows.Forms.CheckBox();
            this.txtCodItemLavanderia = new System.Windows.Forms.TextBox();
            this.txtItemLavanderia = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.lbCodSetor = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbSetor = new System.Windows.Forms.Label();
            this.lbCodCategoria = new System.Windows.Forms.Label();
            this.btnPesquisarLavanderia = new System.Windows.Forms.Button();
            this.cmbProcesso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.DataFim = new System.Windows.Forms.DateTimePicker();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.cbFuncionarios = new System.Windows.Forms.CheckBox();
            this.cbProcessos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Enabled = false;
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerar.Location = new System.Drawing.Point(241, 381);
            this.btnGerar.TabIndex = 20;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(410, 381);
            this.btnSair.TabIndex = 23;
            // 
            // cbItemLavanderia
            // 
            this.cbItemLavanderia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbItemLavanderia.AutoSize = true;
            this.cbItemLavanderia.BackColor = System.Drawing.Color.Transparent;
            this.cbItemLavanderia.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItemLavanderia.ForeColor = System.Drawing.Color.White;
            this.cbItemLavanderia.Location = new System.Drawing.Point(38, 226);
            this.cbItemLavanderia.Margin = new System.Windows.Forms.Padding(4);
            this.cbItemLavanderia.Name = "cbItemLavanderia";
            this.cbItemLavanderia.Size = new System.Drawing.Size(15, 14);
            this.cbItemLavanderia.TabIndex = 3;
            this.cbItemLavanderia.UseVisualStyleBackColor = false;
            this.cbItemLavanderia.CheckedChanged += new System.EventHandler(this.cbItemLavanderia_CheckedChanged);
            // 
            // txtCodItemLavanderia
            // 
            this.txtCodItemLavanderia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodItemLavanderia.Enabled = false;
            this.txtCodItemLavanderia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodItemLavanderia.Location = new System.Drawing.Point(77, 220);
            this.txtCodItemLavanderia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodItemLavanderia.MaxLength = 6;
            this.txtCodItemLavanderia.Name = "txtCodItemLavanderia";
            this.txtCodItemLavanderia.Size = new System.Drawing.Size(71, 26);
            this.txtCodItemLavanderia.TabIndex = 4;
            this.txtCodItemLavanderia.Enter += new System.EventHandler(this.txtCodItemLavanderia_Enter);
            this.txtCodItemLavanderia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodItemLavanderia_KeyPress);
            this.txtCodItemLavanderia.Leave += new System.EventHandler(this.txtCodItemLavanderia_Leave);
            // 
            // txtItemLavanderia
            // 
            this.txtItemLavanderia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemLavanderia.Enabled = false;
            this.txtItemLavanderia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemLavanderia.Location = new System.Drawing.Point(152, 220);
            this.txtItemLavanderia.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemLavanderia.MaxLength = 55;
            this.txtItemLavanderia.Name = "txtItemLavanderia";
            this.txtItemLavanderia.Size = new System.Drawing.Size(243, 26);
            this.txtItemLavanderia.TabIndex = 5;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionario.Location = new System.Drawing.Point(152, 279);
            this.txtFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuncionario.MaxLength = 55;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(243, 26);
            this.txtFuncionario.TabIndex = 8;
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFuncionario.Enabled = false;
            this.txtCodFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFuncionario.Location = new System.Drawing.Point(77, 279);
            this.txtCodFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodFuncionario.MaxLength = 6;
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.Size = new System.Drawing.Size(71, 26);
            this.txtCodFuncionario.TabIndex = 7;
            this.txtCodFuncionario.Enter += new System.EventHandler(this.txtCodItemLavanderia_Enter);
            this.txtCodFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodItemLavanderia_KeyPress);
            this.txtCodFuncionario.Leave += new System.EventHandler(this.txtCodFuncionario_Leave);
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarFuncionario.Enabled = false;
            this.btnPesquisarFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(403, 277);
            this.btnPesquisarFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(107, 31);
            this.btnPesquisarFuncionario.TabIndex = 9;
            this.btnPesquisarFuncionario.Text = "Pesquisar";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = false;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click);
            // 
            // lbCodSetor
            // 
            this.lbCodSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCodSetor.AutoSize = true;
            this.lbCodSetor.BackColor = System.Drawing.Color.Transparent;
            this.lbCodSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodSetor.ForeColor = System.Drawing.Color.White;
            this.lbCodSetor.Location = new System.Drawing.Point(73, 197);
            this.lbCodSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodSetor.Name = "lbCodSetor";
            this.lbCodSetor.Size = new System.Drawing.Size(59, 20);
            this.lbCodSetor.TabIndex = 847;
            this.lbCodSetor.Text = "Código";
            // 
            // lbCategoria
            // 
            this.lbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.White;
            this.lbCategoria.Location = new System.Drawing.Point(152, 257);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(92, 20);
            this.lbCategoria.TabIndex = 851;
            this.lbCategoria.Text = "Funcionário";
            // 
            // lbSetor
            // 
            this.lbSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSetor.AutoSize = true;
            this.lbSetor.BackColor = System.Drawing.Color.Transparent;
            this.lbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetor.ForeColor = System.Drawing.Color.White;
            this.lbSetor.Location = new System.Drawing.Point(152, 197);
            this.lbSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(139, 20);
            this.lbSetor.TabIndex = 848;
            this.lbSetor.Text = "Item da lavanderia";
            // 
            // lbCodCategoria
            // 
            this.lbCodCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCodCategoria.AutoSize = true;
            this.lbCodCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbCodCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodCategoria.ForeColor = System.Drawing.Color.White;
            this.lbCodCategoria.Location = new System.Drawing.Point(73, 257);
            this.lbCodCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodCategoria.Name = "lbCodCategoria";
            this.lbCodCategoria.Size = new System.Drawing.Size(59, 20);
            this.lbCodCategoria.TabIndex = 850;
            this.lbCodCategoria.Text = "Código";
            // 
            // btnPesquisarLavanderia
            // 
            this.btnPesquisarLavanderia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarLavanderia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarLavanderia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarLavanderia.Enabled = false;
            this.btnPesquisarLavanderia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarLavanderia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarLavanderia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarLavanderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarLavanderia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarLavanderia.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarLavanderia.Location = new System.Drawing.Point(403, 219);
            this.btnPesquisarLavanderia.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarLavanderia.Name = "btnPesquisarLavanderia";
            this.btnPesquisarLavanderia.Size = new System.Drawing.Size(107, 29);
            this.btnPesquisarLavanderia.TabIndex = 6;
            this.btnPesquisarLavanderia.Text = "Pesquisar";
            this.btnPesquisarLavanderia.UseVisualStyleBackColor = false;
            this.btnPesquisarLavanderia.Click += new System.EventHandler(this.btnPesquisarLavanderia_Click);
            // 
            // cmbProcesso
            // 
            this.cmbProcesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProcesso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProcesso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcesso.Enabled = false;
            this.cmbProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProcesso.ForeColor = System.Drawing.Color.Black;
            this.cmbProcesso.FormattingEnabled = true;
            this.cmbProcesso.Items.AddRange(new object[] {
            "1 - TOALHA PISCINA  / ROUPA COLORIDA",
            "2 - TOALHAS BRANCAS",
            "3 - COBERTOR",
            "4 - RESTAURANTE",
            "5 - PANO DE CHÃO",
            "6 - REMOVEDOR DE GOMA "});
            this.cmbProcesso.Location = new System.Drawing.Point(76, 335);
            this.cmbProcesso.Name = "cmbProcesso";
            this.cmbProcesso.Size = new System.Drawing.Size(434, 28);
            this.cmbProcesso.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 862;
            this.label1.Text = "Processo";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.ForeColor = System.Drawing.Color.White;
            this.lblDataFinal.Location = new System.Drawing.Point(73, 134);
            this.lblDataFinal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(123, 20);
            this.lblDataFinal.TabIndex = 866;
            this.lblDataFinal.Text = "Data de término";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.ForeColor = System.Drawing.Color.White;
            this.lblDataInicial.Location = new System.Drawing.Point(72, 79);
            this.lblDataInicial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(105, 20);
            this.lblDataInicial.TabIndex = 865;
            this.lblDataInicial.Text = "Data de inicio";
            // 
            // DataFim
            // 
            this.DataFim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFim.Location = new System.Drawing.Point(76, 158);
            this.DataFim.Margin = new System.Windows.Forms.Padding(4);
            this.DataFim.Name = "DataFim";
            this.DataFim.Size = new System.Drawing.Size(434, 26);
            this.DataFim.TabIndex = 2;
            // 
            // DataInicio
            // 
            this.DataInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicio.Location = new System.Drawing.Point(76, 103);
            this.DataInicio.Margin = new System.Windows.Forms.Padding(4);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(433, 26);
            this.DataInicio.TabIndex = 1;
            // 
            // cbFuncionarios
            // 
            this.cbFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFuncionarios.AutoSize = true;
            this.cbFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.cbFuncionarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionarios.ForeColor = System.Drawing.Color.White;
            this.cbFuncionarios.Location = new System.Drawing.Point(38, 285);
            this.cbFuncionarios.Margin = new System.Windows.Forms.Padding(4);
            this.cbFuncionarios.Name = "cbFuncionarios";
            this.cbFuncionarios.Size = new System.Drawing.Size(15, 14);
            this.cbFuncionarios.TabIndex = 7;
            this.cbFuncionarios.UseVisualStyleBackColor = false;
            this.cbFuncionarios.CheckedChanged += new System.EventHandler(this.cbFuncionarios_CheckedChanged);
            // 
            // cbProcessos
            // 
            this.cbProcessos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProcessos.AutoSize = true;
            this.cbProcessos.BackColor = System.Drawing.Color.Transparent;
            this.cbProcessos.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProcessos.ForeColor = System.Drawing.Color.White;
            this.cbProcessos.Location = new System.Drawing.Point(38, 342);
            this.cbProcessos.Margin = new System.Windows.Forms.Padding(4);
            this.cbProcessos.Name = "cbProcessos";
            this.cbProcessos.Size = new System.Drawing.Size(15, 14);
            this.cbProcessos.TabIndex = 10;
            this.cbProcessos.UseVisualStyleBackColor = false;
            this.cbProcessos.CheckedChanged += new System.EventHandler(this.cbProcessos_CheckedChanged);
            // 
            // FrmRelLavanderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(549, 433);
            this.Controls.Add(this.cbProcessos);
            this.Controls.Add(this.cbFuncionarios);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.DataFim);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProcesso);
            this.Controls.Add(this.cbItemLavanderia);
            this.Controls.Add(this.txtCodItemLavanderia);
            this.Controls.Add(this.txtItemLavanderia);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.txtCodFuncionario);
            this.Controls.Add(this.btnPesquisarFuncionario);
            this.Controls.Add(this.lbCodSetor);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbSetor);
            this.Controls.Add(this.lbCodCategoria);
            this.Controls.Add(this.btnPesquisarLavanderia);
            this.Name = "FrmRelLavanderia";
            this.Text = "Relatórios de lavanderia";
            this.Controls.SetChildIndex(this.btnGerar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnPesquisarLavanderia, 0);
            this.Controls.SetChildIndex(this.lbCodCategoria, 0);
            this.Controls.SetChildIndex(this.lbSetor, 0);
            this.Controls.SetChildIndex(this.lbCategoria, 0);
            this.Controls.SetChildIndex(this.lbCodSetor, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFuncionario, 0);
            this.Controls.SetChildIndex(this.txtCodFuncionario, 0);
            this.Controls.SetChildIndex(this.txtFuncionario, 0);
            this.Controls.SetChildIndex(this.txtItemLavanderia, 0);
            this.Controls.SetChildIndex(this.txtCodItemLavanderia, 0);
            this.Controls.SetChildIndex(this.cbItemLavanderia, 0);
            this.Controls.SetChildIndex(this.cmbProcesso, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.DataInicio, 0);
            this.Controls.SetChildIndex(this.DataFim, 0);
            this.Controls.SetChildIndex(this.lblDataInicial, 0);
            this.Controls.SetChildIndex(this.lblDataFinal, 0);
            this.Controls.SetChildIndex(this.cbFuncionarios, 0);
            this.Controls.SetChildIndex(this.cbProcessos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbItemLavanderia;
        public System.Windows.Forms.TextBox txtCodItemLavanderia;
        public System.Windows.Forms.TextBox txtItemLavanderia;
        public System.Windows.Forms.TextBox txtFuncionario;
        public System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.Label lbCodSetor;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbSetor;
        private System.Windows.Forms.Label lbCodCategoria;
        private System.Windows.Forms.Button btnPesquisarLavanderia;
        private System.Windows.Forms.ComboBox cmbProcesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker DataFim;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.CheckBox cbFuncionarios;
        private System.Windows.Forms.CheckBox cbProcessos;
    }
}
