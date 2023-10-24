namespace test.Views.Consultas
{
    partial class FrmConsultaUsuarios
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
            this.clSobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataNasc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPerfil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataCad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1192, 22);
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
            this.clSobrenome,
            this.clEmail,
            this.clUsuario,
            this.clDataNasc,
            this.clSenha,
            this.clStatus,
            this.clPerfil,
            this.clDataCad});
            this.listView1.Size = new System.Drawing.Size(1280, 625);
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
            this.clNome.Width = 100;
            // 
            // clSobrenome
            // 
            this.clSobrenome.Text = "Sobrenome";
            this.clSobrenome.Width = 100;
            // 
            // clEmail
            // 
            this.clEmail.Text = "Email";
            this.clEmail.Width = 150;
            // 
            // clUsuario
            // 
            this.clUsuario.Text = "Usuário";
            this.clUsuario.Width = 150;
            // 
            // clDataNasc
            // 
            this.clDataNasc.Text = "Data de nascimento";
            this.clDataNasc.Width = 140;
            // 
            // clSenha
            // 
            this.clSenha.Text = "Senha";
            this.clSenha.Width = 90;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            this.clStatus.Width = 80;
            // 
            // clPerfil
            // 
            this.clPerfil.Text = "Perfil";
            this.clPerfil.Width = 100;
            // 
            // clDataCad
            // 
            this.clDataCad.Text = "Data de Cadastro";
            this.clDataCad.Width = 140;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(229, 2);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(60, 21);
            this.rbEmail.TabIndex = 17;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(148, 2);
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
            this.rbCodigo.Location = new System.Drawing.Point(72, 2);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(70, 21);
            this.rbCodigo.TabIndex = 15;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1302, 724);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.rbCodigo);
            this.Name = "FrmConsultaUsuarios";
            this.Text = "Consultar Usuários";
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
            this.Controls.SetChildIndex(this.rbEmail, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clNome;
        private System.Windows.Forms.ColumnHeader clSobrenome;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clUsuario;
        private System.Windows.Forms.ColumnHeader clDataNasc;
        private System.Windows.Forms.ColumnHeader clSenha;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.ColumnHeader clPerfil;
        private System.Windows.Forms.ColumnHeader clDataCad;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
    }
}
