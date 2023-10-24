namespace test.Views.Consultas
{
    partial class FrmConsultaFichas
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
            this.clUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
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
            this.clUsuario,
            this.clCliente,
            this.clData,
            this.clDescricao});
            this.listView1.Size = new System.Drawing.Size(1277, 625);
            // 
            // txtID
            // 
            this.txtID.MaxLength = 100;
            this.txtID.Size = new System.Drawing.Size(1171, 23);
            // 
            // lbID
            // 
            this.lbID.Size = new System.Drawing.Size(81, 17);
            this.lbID.Text = "Buscar por:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1189, 686);
            // 
            // clUsuario
            // 
            this.clUsuario.Text = "Usuário";
            this.clUsuario.Width = 120;
            // 
            // clCliente
            // 
            this.clCliente.Text = "Cliente";
            this.clCliente.Width = 120;
            // 
            // clData
            // 
            this.clData.Text = "Criação";
            this.clData.Width = 120;
            // 
            // clDescricao
            // 
            this.clDescricao.Text = "Descrição";
            this.clDescricao.Width = 850;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(108, 3);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(70, 21);
            this.rbCodigo.TabIndex = 12;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Location = new System.Drawing.Point(184, 3);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(75, 21);
            this.rbUsuario.TabIndex = 13;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Checked = true;
            this.rbCliente.Location = new System.Drawing.Point(265, 3);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(69, 21);
            this.rbCliente.TabIndex = 14;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaFichas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1302, 724);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.rbUsuario);
            this.Controls.Add(this.rbCodigo);
            this.Name = "FrmConsultaFichas";
            this.Text = "Consultar Fichas";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.rbCodigo, 0);
            this.Controls.SetChildIndex(this.rbUsuario, 0);
            this.Controls.SetChildIndex(this.rbCliente, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clUsuario;
        private System.Windows.Forms.ColumnHeader clCliente;
        private System.Windows.Forms.ColumnHeader clData;
        private System.Windows.Forms.ColumnHeader clDescricao;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.RadioButton rbCliente;
    }
}
