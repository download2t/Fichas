namespace test.Views.Cadastros
{
    partial class FrmCadastroContatos
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(279, 131);
            this.btnSalvar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(92, 163);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(385, 131);
            this.btnSair.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(95, 183);
            this.txtID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(64, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 31);
            this.label6.TabIndex = 521;
            this.label6.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(64, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 31);
            this.label3.TabIndex = 520;
            this.label3.Text = "*";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lbTelefone.ForeColor = System.Drawing.Color.White;
            this.lbTelefone.Location = new System.Drawing.Point(92, 117);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(175, 17);
            this.lbTelefone.TabIndex = 519;
            this.lbTelefone.Text = "Telefone (45) XXXX-XXXX";
            this.toolTip1.SetToolTip(this.lbTelefone, "Número de telefone com DDD (sem 0).");
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(95, 137);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(172, 23);
            this.txtTelefone.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtTelefone, "Telefone para contato.");
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(92, 66);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 17);
            this.lbNome.TabIndex = 518;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 86);
            this.txtNome.MaxLength = 55;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(390, 23);
            this.txtNome.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNome, "Nome de contato.");
            // 
            // FrmCadastroContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(549, 217);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNome);
            this.Name = "FrmCadastroContatos";
            this.Text = "Cadastrar Contato";
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.lbNome, 0);
            this.Controls.SetChildIndex(this.txtTelefone, 0);
            this.Controls.SetChildIndex(this.lbTelefone, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}
