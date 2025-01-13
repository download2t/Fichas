namespace test.Views.Cadastros
{
    partial class FrmCadastroSubCategoria
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
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(318, 202);
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(179, 188);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(424, 202);
            this.btnSair.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(182, 208);
            this.txtID.TabIndex = 500;
            this.txtID.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(91, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 31);
            this.label11.TabIndex = 517;
            this.label11.Text = "*";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.BackColor = System.Drawing.Color.Transparent;
            this.lbNumero.ForeColor = System.Drawing.Color.White;
            this.lbNumero.Location = new System.Drawing.Point(115, 144);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(98, 17);
            this.lbNumero.TabIndex = 516;
            this.lbNumero.Text = "Sub Categoria";
            this.toolTip1.SetToolTip(this.lbNumero, "Nome da subcategoria.");
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubCategoria.Location = new System.Drawing.Point(118, 164);
            this.txtSubCategoria.MaxLength = 20;
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(406, 23);
            this.txtSubCategoria.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtSubCategoria, "Nome da subcategoria.");
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(424, 111);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(91, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 31);
            this.label1.TabIndex = 521;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 520;
            this.label2.Text = "Cód Categoria";
            this.toolTip1.SetToolTip(this.label2, "Código da categoria.");
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(250, 114);
            this.txtCategoria.MaxLength = 20;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(164, 23);
            this.txtCategoria.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtCategoria, "Nome da categoria.");
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Location = new System.Drawing.Point(118, 114);
            this.txtCodCategoria.MaxLength = 6;
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(126, 23);
            this.txtCodCategoria.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCodCategoria, "Código da categoria.");
            this.txtCodCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarValorKeyPress);
            this.txtCodCategoria.Leave += new System.EventHandler(this.txtCodCategoria_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 523;
            this.label3.Text = "Categoria";
            this.toolTip1.SetToolTip(this.label3, "Nome da categoria.");
            // 
            // FrmCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(575, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.txtSubCategoria);
            this.Name = "FrmCadastroSubCategoria";
            this.Text = "Sub Categoria";
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtSubCategoria, 0);
            this.Controls.SetChildIndex(this.lbNumero, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtCategoria, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodCategoria, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox txtSubCategoria;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.Label label3;
    }
}
