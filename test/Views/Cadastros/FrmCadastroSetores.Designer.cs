namespace test.Views.Cadastros
{
    partial class FrmCadastroSetores
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
            this.lbsetor = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(292, 158);
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Enabled = false;
            this.lbID.Location = new System.Drawing.Point(153, 144);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(398, 158);
            this.btnSair.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(156, 164);
            this.txtID.TabIndex = 100;
            this.txtID.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(130, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 31);
            this.label11.TabIndex = 517;
            this.label11.Text = "*";
            // 
            // lbsetor
            // 
            this.lbsetor.AutoSize = true;
            this.lbsetor.BackColor = System.Drawing.Color.Transparent;
            this.lbsetor.ForeColor = System.Drawing.Color.White;
            this.lbsetor.Location = new System.Drawing.Point(153, 95);
            this.lbsetor.Name = "lbsetor";
            this.lbsetor.Size = new System.Drawing.Size(42, 17);
            this.lbsetor.TabIndex = 516;
            this.lbsetor.Text = "Setor";
            // 
            // txtSetor
            // 
            this.txtSetor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSetor.Location = new System.Drawing.Point(156, 115);
            this.txtSetor.MaxLength = 150;
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(342, 23);
            this.txtSetor.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtSetor, "Nome do setor.");
            // 
            // FrmCadastroSetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(651, 251);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbsetor);
            this.Controls.Add(this.txtSetor);
            this.Name = "FrmCadastroSetores";
            this.Text = "Setores";
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtSetor, 0);
            this.Controls.SetChildIndex(this.lbsetor, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbsetor;
        private System.Windows.Forms.TextBox txtSetor;
    }
}
