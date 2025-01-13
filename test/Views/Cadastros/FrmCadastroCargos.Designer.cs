namespace Controle.Views.Cadastros
{
    partial class FrmCadastroCargos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtPontos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(179, 169);
            this.btnSalvar.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(33, 155);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(285, 169);
            this.btnSair.TabIndex = 40;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(36, 175);
            this.txtID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(95, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 529;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 528;
            this.label1.Text = "Função";
            this.toolTip1.SetToolTip(this.label1, "Função do funcionário.");
            // 
            // txtFuncao
            // 
            this.txtFuncao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncao.Location = new System.Drawing.Point(116, 124);
            this.txtFuncao.MaxLength = 30;
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(269, 23);
            this.txtFuncao.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtFuncao, "Função do funcionário.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(95, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 526;
            this.label4.Text = "*";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbCliente.ForeColor = System.Drawing.Color.White;
            this.lbCliente.Location = new System.Drawing.Point(113, 53);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(125, 17);
            this.lbCliente.TabIndex = 525;
            this.lbCliente.Text = "Número de pontos";
            this.toolTip1.SetToolTip(this.lbCliente, "Minimo 3 Máximo 10 pontos.");
            // 
            // txtPontos
            // 
            this.txtPontos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPontos.Location = new System.Drawing.Point(116, 73);
            this.txtPontos.MaxLength = 2;
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.Size = new System.Drawing.Size(269, 23);
            this.txtPontos.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtPontos, "Minimo 3 Máximo 10 pontos.");
            this.txtPontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPontos_KeyPress);
            // 
            // FrmCadastroCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(473, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.txtPontos);
            this.Name = "FrmCadastroCargos";
            this.Text = "Cargos";
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtPontos, 0);
            this.Controls.SetChildIndex(this.lbCliente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtFuncao, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCliente;
        public System.Windows.Forms.TextBox txtPontos;
    }
}
