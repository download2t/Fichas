namespace Controle.Views.Cadastros
{
    partial class FrmCadastroRamais
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
            this.txtRamal = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtLinha = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarSetor = new System.Windows.Forms.Button();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtCodSetor = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(301, 200);
            this.btnSalvar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.Location = new System.Drawing.Point(12, 211);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(407, 200);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(12, 231);
            this.txtID.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(67, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 547;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 546;
            this.label1.Text = "Ramal";
            this.toolTip1.SetToolTip(this.label1, "Função do funcionário.");
            // 
            // txtRamal
            // 
            this.txtRamal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRamal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRamal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRamal.Location = new System.Drawing.Point(88, 101);
            this.txtRamal.MaxLength = 4;
            this.txtRamal.Name = "txtRamal";
            this.txtRamal.Size = new System.Drawing.Size(79, 26);
            this.txtRamal.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtRamal, "Função do funcionário.");
            this.txtRamal.TextChanged += new System.EventHandler(this.txtRamal_TextChanged);
            this.txtRamal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodSetor_KeyPress);
            // 
            // lbCliente
            // 
            this.lbCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCliente.AutoSize = true;
            this.lbCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbCliente.ForeColor = System.Drawing.Color.White;
            this.lbCliente.Location = new System.Drawing.Point(170, 80);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(43, 17);
            this.lbCliente.TabIndex = 544;
            this.lbCliente.Text = "Linha";
            this.toolTip1.SetToolTip(this.lbCliente, "Minimo 3 Máximo 10 pontos.");
            // 
            // txtLinha
            // 
            this.txtLinha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLinha.Enabled = false;
            this.txtLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinha.Location = new System.Drawing.Point(173, 101);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(132, 26);
            this.txtLinha.TabIndex = 2;
            this.txtLinha.Text = "3521 - ";
            // 
            // btnPesquisarSetor
            // 
            this.btnPesquisarSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarSetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarSetor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarSetor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarSetor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarSetor.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarSetor.Location = new System.Drawing.Point(418, 151);
            this.btnPesquisarSetor.Name = "btnPesquisarSetor";
            this.btnPesquisarSetor.Size = new System.Drawing.Size(89, 26);
            this.btnPesquisarSetor.TabIndex = 6;
            this.btnPesquisarSetor.Text = "Pesquisar";
            this.btnPesquisarSetor.UseVisualStyleBackColor = false;
            this.btnPesquisarSetor.Click += new System.EventHandler(this.btnPesquisarSetor_Click);
            // 
            // txtSetor
            // 
            this.txtSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetor.Location = new System.Drawing.Point(161, 152);
            this.txtSetor.MaxLength = 55;
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.ReadOnly = true;
            this.txtSetor.Size = new System.Drawing.Size(251, 24);
            this.txtSetor.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtSetor, "Função / Cargo do funcionário.");
            // 
            // txtCodSetor
            // 
            this.txtCodSetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSetor.Location = new System.Drawing.Point(88, 152);
            this.txtCodSetor.MaxLength = 6;
            this.txtCodSetor.Name = "txtCodSetor";
            this.txtCodSetor.Size = new System.Drawing.Size(67, 24);
            this.txtCodSetor.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtCodSetor, "Código da função / cargo.");
            this.txtCodSetor.Enter += new System.EventHandler(this.txtCodSetor_Enter);
            this.txtCodSetor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodSetor_KeyPress);
            this.txtCodSetor.Leave += new System.EventHandler(this.txtCodSetor_Leave);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(161, 132);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 17);
            this.lblUser.TabIndex = 559;
            this.lblUser.Text = "Setor";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(85, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 558;
            this.label12.Text = "Código";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(69, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 560;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(308, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 562;
            this.label5.Text = "Nome";
            this.toolTip1.SetToolTip(this.label5, "Função do funcionário.");
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(311, 101);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(196, 26);
            this.txtNome.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNome, "Função do funcionário.");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 564;
            this.label4.Text = "Fone";
            this.toolTip1.SetToolTip(this.label4, "Função do funcionário.");
            // 
            // txtFone
            // 
            this.txtFone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFone.Location = new System.Drawing.Point(88, 200);
            this.txtFone.MaxLength = 15;
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(196, 26);
            this.txtFone.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtFone, "Função do funcionário.");
            this.txtFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodSetor_KeyPress);
            // 
            // FrmCadastroRamais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(574, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnPesquisarSetor);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.txtCodSetor);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLinha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRamal);
            this.Controls.Add(this.lbCliente);
            this.Name = "FrmCadastroRamais";
            this.Text = "Cadastrar Ramal";
            this.Controls.SetChildIndex(this.lbCliente, 0);
            this.Controls.SetChildIndex(this.txtRamal, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtLinha, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.lblUser, 0);
            this.Controls.SetChildIndex(this.txtCodSetor, 0);
            this.Controls.SetChildIndex(this.txtSetor, 0);
            this.Controls.SetChildIndex(this.btnPesquisarSetor, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtFone, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtRamal;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.MaskedTextBox txtLinha;
        private System.Windows.Forms.Button btnPesquisarSetor;
        public System.Windows.Forms.TextBox txtSetor;
        public System.Windows.Forms.TextBox txtCodSetor;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtFone;
    }
}
