namespace test.Views.Consultas
{
    partial class FrmConsultaClientes
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
            this.clNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDocumento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbDocumento = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.clBairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLogradouro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1189, 23);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1082, 686);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(976, 686);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(870, 686);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNome,
            this.clDocumento,
            this.clTelefone,
            this.clEmail,
            this.clCEP,
            this.clCidade,
            this.clBairro,
            this.clLogradouro,
            this.clNumero,
            this.clUF});
            this.listView1.Size = new System.Drawing.Size(1277, 625);
            // 
            // txtID
            // 
            this.txtID.MaxLength = 100;
            this.txtID.Size = new System.Drawing.Size(1171, 23);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1189, 686);
            // 
            // clNome
            // 
            this.clNome.Text = "Nome";
            this.clNome.Width = 150;
            // 
            // clDocumento
            // 
            this.clDocumento.Text = "CPF / CNPJ";
            this.clDocumento.Width = 120;
            // 
            // clTelefone
            // 
            this.clTelefone.Text = "Telefone";
            this.clTelefone.Width = 120;
            // 
            // clEmail
            // 
            this.clEmail.Text = "Email";
            this.clEmail.Width = 150;
            // 
            // clCEP
            // 
            this.clCEP.Text = "CEP";
            this.clCEP.Width = 100;
            // 
            // clCidade
            // 
            this.clCidade.Text = "Cidade";
            this.clCidade.Width = 150;
            // 
            // clNumero
            // 
            this.clNumero.Text = "Número";
            // 
            // rbDocumento
            // 
            this.rbDocumento.AutoSize = true;
            this.rbDocumento.Location = new System.Drawing.Point(225, 3);
            this.rbDocumento.Name = "rbDocumento";
            this.rbDocumento.Size = new System.Drawing.Size(98, 21);
            this.rbDocumento.TabIndex = 17;
            this.rbDocumento.TabStop = true;
            this.rbDocumento.Text = "Documento";
            this.rbDocumento.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(144, 3);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(63, 21);
            this.rbNome.TabIndex = 16;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(68, 3);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(70, 21);
            this.rbCodigo.TabIndex = 15;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // clBairro
            // 
            this.clBairro.Text = "Bairro";
            this.clBairro.Width = 150;
            // 
            // clLogradouro
            // 
            this.clLogradouro.Text = "Logradouro";
            this.clLogradouro.Width = 150;
            // 
            // clUF
            // 
            this.clUF.Text = "UF";
            this.clUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clUF.Width = 50;
            // 
            // FrmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1302, 724);
            this.Controls.Add(this.rbDocumento);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.rbCodigo);
            this.Name = "FrmConsultaClientes";
            this.Text = "Consultar Clientes";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.rbCodigo, 0);
            this.Controls.SetChildIndex(this.rbNome, 0);
            this.Controls.SetChildIndex(this.rbDocumento, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clNome;
        private System.Windows.Forms.ColumnHeader clDocumento;
        private System.Windows.Forms.ColumnHeader clTelefone;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clCEP;
        private System.Windows.Forms.ColumnHeader clCidade;
        private System.Windows.Forms.ColumnHeader clNumero;
        private System.Windows.Forms.RadioButton rbDocumento;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.ColumnHeader clBairro;
        private System.Windows.Forms.ColumnHeader clLogradouro;
        private System.Windows.Forms.ColumnHeader clUF;
    }
}
