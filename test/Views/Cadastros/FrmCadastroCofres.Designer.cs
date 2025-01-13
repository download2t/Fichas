namespace test.Views.Cadastros
{
    partial class FrmCadastroCofres
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
            this.label11 = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumQuarto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(298, 212);
            this.btnSalvar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(159, 198);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(404, 212);
            this.btnSair.TabIndex = 25;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(162, 218);
            this.txtID.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(143, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 518;
            this.label11.Text = "*";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.BackColor = System.Drawing.Color.Transparent;
            this.lbNumero.ForeColor = System.Drawing.Color.White;
            this.lbNumero.Location = new System.Drawing.Point(159, 101);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(114, 17);
            this.lbNumero.TabIndex = 517;
            this.lbNumero.Text = "Código da chave";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(162, 121);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(342, 23);
            this.txtCodigo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCodigo, "Nome da categoria.");
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(143, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 521;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 520;
            this.label2.Text = "Número do quarto";
            // 
            // txtNumQuarto
            // 
            this.txtNumQuarto.Location = new System.Drawing.Point(162, 173);
            this.txtNumQuarto.MaxLength = 3;
            this.txtNumQuarto.Name = "txtNumQuarto";
            this.txtNumQuarto.Size = new System.Drawing.Size(342, 23);
            this.txtNumQuarto.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtNumQuarto, "Nome da categoria.");
            this.txtNumQuarto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // FrmCadastroCofres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumQuarto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.txtCodigo);
            this.Name = "FrmCadastroCofres";
            this.Text = "Cadastrar Cofres";
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lbNumero, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtNumQuarto, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumQuarto;
    }
}