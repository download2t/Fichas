namespace test.Views.Cadastros
{
    partial class FrmCadastroCategoria
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
            this.label11 = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.cbSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(246, 163);
            this.btnSalvar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Enabled = false;
            this.lbID.Location = new System.Drawing.Point(107, 149);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(352, 163);
            this.btnSair.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(110, 169);
            this.txtID.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(79, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 31);
            this.label11.TabIndex = 513;
            this.label11.Text = "*";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.BackColor = System.Drawing.Color.Transparent;
            this.lbNumero.ForeColor = System.Drawing.Color.White;
            this.lbNumero.Location = new System.Drawing.Point(107, 100);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(69, 17);
            this.lbNumero.TabIndex = 512;
            this.lbNumero.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Location = new System.Drawing.Point(110, 120);
            this.txtCategoria.MaxLength = 20;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(342, 23);
            this.txtCategoria.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCategoria, "Nome da categoria.");
            // 
            // cbSenha
            // 
            this.cbSenha.AutoSize = true;
            this.cbSenha.BackColor = System.Drawing.Color.Transparent;
            this.cbSenha.ForeColor = System.Drawing.Color.White;
            this.cbSenha.Location = new System.Drawing.Point(110, 198);
            this.cbSenha.Name = "cbSenha";
            this.cbSenha.Size = new System.Drawing.Size(160, 21);
            this.cbSenha.TabIndex = 516;
            this.cbSenha.Text = "Categoria de Senhas";
            this.cbSenha.UseVisualStyleBackColor = false;
            this.cbSenha.Visible = false;
            // 
            // FrmCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(559, 249);
            this.Controls.Add(this.cbSenha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.txtCategoria);
            this.Name = "FrmCadastroCategoria";
            this.Text = "Categoria";
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCategoria, 0);
            this.Controls.SetChildIndex(this.lbNumero, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.cbSenha, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox txtCategoria;
        public System.Windows.Forms.CheckBox cbSenha;
    }
}
