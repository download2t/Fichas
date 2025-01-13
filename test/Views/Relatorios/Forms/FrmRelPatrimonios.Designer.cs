namespace Controle.Views.Relatorios.Forms
{
    partial class FrmRelPatrimonios
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
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rbBaixa = new System.Windows.Forms.RadioButton();
            this.cbSubPatrimonios = new System.Windows.Forms.CheckBox();
            this.cbCategoriaPatrimonios = new System.Windows.Forms.CheckBox();
            this.cbSetorPatrimonios = new System.Windows.Forms.CheckBox();
            this.cbTotalPatrimonios = new System.Windows.Forms.CheckBox();
            this.btnPesquisarSubCategoria = new System.Windows.Forms.Button();
            this.lbSubCategoria = new System.Windows.Forms.Label();
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.txtCodSubCategoria = new System.Windows.Forms.TextBox();
            this.txtCodSetor = new System.Windows.Forms.TextBox();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.lbCodSubCategoria = new System.Windows.Forms.Label();
            this.btnPesquisarCategoria = new System.Windows.Forms.Button();
            this.lbCodSetor = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbSetor = new System.Windows.Forms.Label();
            this.lbCodCategoria = new System.Windows.Forms.Label();
            this.btnPesquisarSetor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerar.Location = new System.Drawing.Point(814, 298);
            this.btnGerar.Size = new System.Drawing.Size(162, 36);
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.Location = new System.Drawing.Point(62, 282);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(990, 298);
            this.btnSair.Size = new System.Drawing.Size(133, 36);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(65, 302);
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.BackColor = System.Drawing.Color.Transparent;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtivo.ForeColor = System.Drawing.Color.White;
            this.rbAtivo.Location = new System.Drawing.Point(48, 45);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(176, 26);
            this.rbAtivo.TabIndex = 839;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Patrimônios Ativos";
            this.rbAtivo.UseVisualStyleBackColor = false;
            // 
            // rbBaixa
            // 
            this.rbBaixa.AutoSize = true;
            this.rbBaixa.BackColor = System.Drawing.Color.Transparent;
            this.rbBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBaixa.ForeColor = System.Drawing.Color.White;
            this.rbBaixa.Location = new System.Drawing.Point(230, 45);
            this.rbBaixa.Name = "rbBaixa";
            this.rbBaixa.Size = new System.Drawing.Size(206, 26);
            this.rbBaixa.TabIndex = 838;
            this.rbBaixa.Text = "Baixas de Patrimônios";
            this.rbBaixa.UseVisualStyleBackColor = false;
            // 
            // cbSubPatrimonios
            // 
            this.cbSubPatrimonios.AutoSize = true;
            this.cbSubPatrimonios.BackColor = System.Drawing.Color.Transparent;
            this.cbSubPatrimonios.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubPatrimonios.ForeColor = System.Drawing.Color.White;
            this.cbSubPatrimonios.Location = new System.Drawing.Point(48, 213);
            this.cbSubPatrimonios.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubPatrimonios.Name = "cbSubPatrimonios";
            this.cbSubPatrimonios.Size = new System.Drawing.Size(281, 29);
            this.cbSubPatrimonios.TabIndex = 837;
            this.cbSubPatrimonios.Text = "Relatório por sub categoria";
            this.cbSubPatrimonios.UseVisualStyleBackColor = false;
            this.cbSubPatrimonios.CheckedChanged += new System.EventHandler(this.cbSubPatrimonios_CheckedChanged);
            // 
            // cbCategoriaPatrimonios
            // 
            this.cbCategoriaPatrimonios.AutoSize = true;
            this.cbCategoriaPatrimonios.BackColor = System.Drawing.Color.Transparent;
            this.cbCategoriaPatrimonios.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaPatrimonios.ForeColor = System.Drawing.Color.White;
            this.cbCategoriaPatrimonios.Location = new System.Drawing.Point(48, 173);
            this.cbCategoriaPatrimonios.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoriaPatrimonios.Name = "cbCategoriaPatrimonios";
            this.cbCategoriaPatrimonios.Size = new System.Drawing.Size(242, 29);
            this.cbCategoriaPatrimonios.TabIndex = 836;
            this.cbCategoriaPatrimonios.Text = "Relatório por categoria";
            this.cbCategoriaPatrimonios.UseVisualStyleBackColor = false;
            this.cbCategoriaPatrimonios.CheckedChanged += new System.EventHandler(this.cbCategoriaPatrimonios_CheckedChanged);
            // 
            // cbSetorPatrimonios
            // 
            this.cbSetorPatrimonios.AutoSize = true;
            this.cbSetorPatrimonios.BackColor = System.Drawing.Color.Transparent;
            this.cbSetorPatrimonios.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSetorPatrimonios.ForeColor = System.Drawing.Color.White;
            this.cbSetorPatrimonios.Location = new System.Drawing.Point(48, 132);
            this.cbSetorPatrimonios.Margin = new System.Windows.Forms.Padding(4);
            this.cbSetorPatrimonios.Name = "cbSetorPatrimonios";
            this.cbSetorPatrimonios.Size = new System.Drawing.Size(202, 29);
            this.cbSetorPatrimonios.TabIndex = 835;
            this.cbSetorPatrimonios.Text = "Relatório por setor";
            this.cbSetorPatrimonios.UseVisualStyleBackColor = false;
            this.cbSetorPatrimonios.CheckedChanged += new System.EventHandler(this.cbSetorPatrimonios_CheckedChanged);
            // 
            // cbTotalPatrimonios
            // 
            this.cbTotalPatrimonios.AutoSize = true;
            this.cbTotalPatrimonios.BackColor = System.Drawing.Color.Transparent;
            this.cbTotalPatrimonios.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTotalPatrimonios.ForeColor = System.Drawing.Color.White;
            this.cbTotalPatrimonios.Location = new System.Drawing.Point(48, 91);
            this.cbTotalPatrimonios.Margin = new System.Windows.Forms.Padding(4);
            this.cbTotalPatrimonios.Name = "cbTotalPatrimonios";
            this.cbTotalPatrimonios.Size = new System.Drawing.Size(306, 29);
            this.cbTotalPatrimonios.TabIndex = 834;
            this.cbTotalPatrimonios.Text = "Relatório total de patrimônios";
            this.cbTotalPatrimonios.UseVisualStyleBackColor = false;
            this.cbTotalPatrimonios.CheckedChanged += new System.EventHandler(this.cbTotalPatrimonios_CheckedChanged);
            // 
            // btnPesquisarSubCategoria
            // 
            this.btnPesquisarSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarSubCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarSubCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarSubCategoria.Enabled = false;
            this.btnPesquisarSubCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarSubCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarSubCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarSubCategoria.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarSubCategoria.Location = new System.Drawing.Point(990, 231);
            this.btnPesquisarSubCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarSubCategoria.Name = "btnPesquisarSubCategoria";
            this.btnPesquisarSubCategoria.Size = new System.Drawing.Size(133, 36);
            this.btnPesquisarSubCategoria.TabIndex = 824;
            this.btnPesquisarSubCategoria.Text = "Pesquisar";
            this.btnPesquisarSubCategoria.UseVisualStyleBackColor = false;
            this.btnPesquisarSubCategoria.Click += new System.EventHandler(this.btnPesquisarSubCategoria_Click);
            // 
            // lbSubCategoria
            // 
            this.lbSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSubCategoria.AutoSize = true;
            this.lbSubCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubCategoria.ForeColor = System.Drawing.Color.White;
            this.lbSubCategoria.Location = new System.Drawing.Point(599, 212);
            this.lbSubCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubCategoria.Name = "lbSubCategoria";
            this.lbSubCategoria.Size = new System.Drawing.Size(115, 20);
            this.lbSubCategoria.TabIndex = 833;
            this.lbSubCategoria.Text = " Sub Categoria";
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubCategoria.Enabled = false;
            this.txtSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCategoria.Location = new System.Drawing.Point(599, 237);
            this.txtSubCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubCategoria.MaxLength = 55;
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(377, 26);
            this.txtSubCategoria.TabIndex = 831;
            // 
            // txtCodSubCategoria
            // 
            this.txtCodSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodSubCategoria.Enabled = false;
            this.txtCodSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSubCategoria.Location = new System.Drawing.Point(365, 237);
            this.txtCodSubCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodSubCategoria.MaxLength = 6;
            this.txtCodSubCategoria.Name = "txtCodSubCategoria";
            this.txtCodSubCategoria.Size = new System.Drawing.Size(220, 26);
            this.txtCodSubCategoria.TabIndex = 823;
            this.txtCodSubCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarValorKeyPress);
            this.txtCodSubCategoria.Leave += new System.EventHandler(this.txtCodSubCategoria_Leave);
            // 
            // txtCodSetor
            // 
            this.txtCodSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodSetor.Enabled = false;
            this.txtCodSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSetor.Location = new System.Drawing.Point(365, 114);
            this.txtCodSetor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodSetor.MaxLength = 6;
            this.txtCodSetor.Name = "txtCodSetor";
            this.txtCodSetor.Size = new System.Drawing.Size(220, 26);
            this.txtCodSetor.TabIndex = 819;
            this.txtCodSetor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarValorKeyPress);
            this.txtCodSetor.Leave += new System.EventHandler(this.txtCodSetor_Leave);
            // 
            // txtSetor
            // 
            this.txtSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSetor.Enabled = false;
            this.txtSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetor.Location = new System.Drawing.Point(599, 114);
            this.txtSetor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSetor.MaxLength = 55;
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(377, 26);
            this.txtSetor.TabIndex = 825;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(599, 173);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.MaxLength = 55;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(377, 26);
            this.txtCategoria.TabIndex = 828;
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCategoria.Enabled = false;
            this.txtCodCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCategoria.Location = new System.Drawing.Point(365, 173);
            this.txtCodCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCategoria.MaxLength = 6;
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(220, 26);
            this.txtCodCategoria.TabIndex = 821;
            this.txtCodCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarValorKeyPress);
            this.txtCodCategoria.Leave += new System.EventHandler(this.txtCodCategoria_Leave);
            // 
            // lbCodSubCategoria
            // 
            this.lbCodSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCodSubCategoria.AutoSize = true;
            this.lbCodSubCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbCodSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodSubCategoria.ForeColor = System.Drawing.Color.White;
            this.lbCodSubCategoria.Location = new System.Drawing.Point(365, 212);
            this.lbCodSubCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodSubCategoria.Name = "lbCodSubCategoria";
            this.lbCodSubCategoria.Size = new System.Drawing.Size(144, 20);
            this.lbCodSubCategoria.TabIndex = 832;
            this.lbCodSubCategoria.Text = "Cód Sub Categoria";
            // 
            // btnPesquisarCategoria
            // 
            this.btnPesquisarCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarCategoria.Enabled = false;
            this.btnPesquisarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarCategoria.Location = new System.Drawing.Point(990, 167);
            this.btnPesquisarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarCategoria.Name = "btnPesquisarCategoria";
            this.btnPesquisarCategoria.Size = new System.Drawing.Size(133, 36);
            this.btnPesquisarCategoria.TabIndex = 822;
            this.btnPesquisarCategoria.Text = "Pesquisar";
            this.btnPesquisarCategoria.UseVisualStyleBackColor = false;
            this.btnPesquisarCategoria.Click += new System.EventHandler(this.btnPesquisarCategoria_Click);
            // 
            // lbCodSetor
            // 
            this.lbCodSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCodSetor.AutoSize = true;
            this.lbCodSetor.BackColor = System.Drawing.Color.Transparent;
            this.lbCodSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodSetor.ForeColor = System.Drawing.Color.White;
            this.lbCodSetor.Location = new System.Drawing.Point(365, 88);
            this.lbCodSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodSetor.Name = "lbCodSetor";
            this.lbCodSetor.Size = new System.Drawing.Size(102, 20);
            this.lbCodSetor.TabIndex = 826;
            this.lbCodSetor.Text = "Código Setor";
            // 
            // lbCategoria
            // 
            this.lbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.White;
            this.lbCategoria.Location = new System.Drawing.Point(599, 148);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(78, 20);
            this.lbCategoria.TabIndex = 830;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbSetor
            // 
            this.lbSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSetor.AutoSize = true;
            this.lbSetor.BackColor = System.Drawing.Color.Transparent;
            this.lbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetor.ForeColor = System.Drawing.Color.White;
            this.lbSetor.Location = new System.Drawing.Point(599, 88);
            this.lbSetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(48, 20);
            this.lbSetor.TabIndex = 827;
            this.lbSetor.Text = "Setor";
            // 
            // lbCodCategoria
            // 
            this.lbCodCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCodCategoria.AutoSize = true;
            this.lbCodCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbCodCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodCategoria.ForeColor = System.Drawing.Color.White;
            this.lbCodCategoria.Location = new System.Drawing.Point(365, 148);
            this.lbCodCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodCategoria.Name = "lbCodCategoria";
            this.lbCodCategoria.Size = new System.Drawing.Size(132, 20);
            this.lbCodCategoria.TabIndex = 829;
            this.lbCodCategoria.Text = "Código Categoria";
            // 
            // btnPesquisarSetor
            // 
            this.btnPesquisarSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarSetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarSetor.Enabled = false;
            this.btnPesquisarSetor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarSetor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarSetor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarSetor.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarSetor.Location = new System.Drawing.Point(990, 108);
            this.btnPesquisarSetor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarSetor.Name = "btnPesquisarSetor";
            this.btnPesquisarSetor.Size = new System.Drawing.Size(133, 36);
            this.btnPesquisarSetor.TabIndex = 820;
            this.btnPesquisarSetor.Text = "Pesquisar";
            this.btnPesquisarSetor.UseVisualStyleBackColor = false;
            this.btnPesquisarSetor.Click += new System.EventHandler(this.btnPesquisarSetor_Click);
            // 
            // FrmRelPatrimonios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1175, 359);
            this.Controls.Add(this.rbAtivo);
            this.Controls.Add(this.rbBaixa);
            this.Controls.Add(this.cbSubPatrimonios);
            this.Controls.Add(this.cbCategoriaPatrimonios);
            this.Controls.Add(this.cbSetorPatrimonios);
            this.Controls.Add(this.cbTotalPatrimonios);
            this.Controls.Add(this.btnPesquisarSubCategoria);
            this.Controls.Add(this.lbSubCategoria);
            this.Controls.Add(this.txtSubCategoria);
            this.Controls.Add(this.txtCodSubCategoria);
            this.Controls.Add(this.txtCodSetor);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtCodCategoria);
            this.Controls.Add(this.lbCodSubCategoria);
            this.Controls.Add(this.btnPesquisarCategoria);
            this.Controls.Add(this.lbCodSetor);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbSetor);
            this.Controls.Add(this.lbCodCategoria);
            this.Controls.Add(this.btnPesquisarSetor);
            this.Name = "FrmRelPatrimonios";
            this.Text = " ";
            this.Controls.SetChildIndex(this.btnPesquisarSetor, 0);
            this.Controls.SetChildIndex(this.lbCodCategoria, 0);
            this.Controls.SetChildIndex(this.lbSetor, 0);
            this.Controls.SetChildIndex(this.lbCategoria, 0);
            this.Controls.SetChildIndex(this.lbCodSetor, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCategoria, 0);
            this.Controls.SetChildIndex(this.lbCodSubCategoria, 0);
            this.Controls.SetChildIndex(this.txtCodCategoria, 0);
            this.Controls.SetChildIndex(this.txtCategoria, 0);
            this.Controls.SetChildIndex(this.txtSetor, 0);
            this.Controls.SetChildIndex(this.txtCodSetor, 0);
            this.Controls.SetChildIndex(this.txtCodSubCategoria, 0);
            this.Controls.SetChildIndex(this.txtSubCategoria, 0);
            this.Controls.SetChildIndex(this.lbSubCategoria, 0);
            this.Controls.SetChildIndex(this.btnPesquisarSubCategoria, 0);
            this.Controls.SetChildIndex(this.cbTotalPatrimonios, 0);
            this.Controls.SetChildIndex(this.cbSetorPatrimonios, 0);
            this.Controls.SetChildIndex(this.cbCategoriaPatrimonios, 0);
            this.Controls.SetChildIndex(this.cbSubPatrimonios, 0);
            this.Controls.SetChildIndex(this.rbBaixa, 0);
            this.Controls.SetChildIndex(this.rbAtivo, 0);
            this.Controls.SetChildIndex(this.btnGerar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.RadioButton rbBaixa;
        private System.Windows.Forms.CheckBox cbSubPatrimonios;
        private System.Windows.Forms.CheckBox cbCategoriaPatrimonios;
        private System.Windows.Forms.CheckBox cbSetorPatrimonios;
        private System.Windows.Forms.CheckBox cbTotalPatrimonios;
        private System.Windows.Forms.Button btnPesquisarSubCategoria;
        private System.Windows.Forms.Label lbSubCategoria;
        public System.Windows.Forms.TextBox txtSubCategoria;
        public System.Windows.Forms.TextBox txtCodSubCategoria;
        public System.Windows.Forms.TextBox txtCodSetor;
        public System.Windows.Forms.TextBox txtSetor;
        public System.Windows.Forms.TextBox txtCategoria;
        public System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.Label lbCodSubCategoria;
        private System.Windows.Forms.Button btnPesquisarCategoria;
        private System.Windows.Forms.Label lbCodSetor;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbSetor;
        private System.Windows.Forms.Label lbCodCategoria;
        private System.Windows.Forms.Button btnPesquisarSetor;
    }
}
