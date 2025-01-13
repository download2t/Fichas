namespace Controle.Views.Cadastros
{
    partial class FrmCadastroCameras
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
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.cmbAudio = new System.Windows.Forms.ComboBox();
            this.cmbSituação = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(240, 190);
            this.btnSalvar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.Location = new System.Drawing.Point(71, 176);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(346, 190);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(74, 196);
            this.txtID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(53, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 535;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 534;
            this.label1.Text = "Localização";
            this.toolTip1.SetToolTip(this.label1, "Função do funcionário.");
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizacao.Location = new System.Drawing.Point(74, 146);
            this.txtLocalizacao.MaxLength = 30;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(372, 26);
            this.txtLocalizacao.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtLocalizacao, "Função do funcionário.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(53, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 533;
            this.label4.Text = "*";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbCliente.ForeColor = System.Drawing.Color.White;
            this.lbCliente.Location = new System.Drawing.Point(71, 73);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(20, 17);
            this.lbCliente.TabIndex = 532;
            this.lbCliente.Text = "IP";
            this.toolTip1.SetToolTip(this.lbCliente, "Minimo 3 Máximo 10 pontos.");
            // 
            // cmbAudio
            // 
            this.cmbAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAudio.FormattingEnabled = true;
            this.cmbAudio.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cmbAudio.Location = new System.Drawing.Point(212, 94);
            this.cmbAudio.Name = "cmbAudio";
            this.cmbAudio.Size = new System.Drawing.Size(131, 26);
            this.cmbAudio.TabIndex = 2;
            // 
            // cmbSituação
            // 
            this.cmbSituação.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituação.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSituação.FormattingEnabled = true;
            this.cmbSituação.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVADO"});
            this.cmbSituação.Location = new System.Drawing.Point(349, 94);
            this.cmbSituação.Name = "cmbSituação";
            this.cmbSituação.Size = new System.Drawing.Size(97, 26);
            this.cmbSituação.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(191, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 539;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(209, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 538;
            this.label5.Text = "Audio";
            this.toolTip1.SetToolTip(this.label5, "Minimo 3 Máximo 10 pontos.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(328, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 541;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(346, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 540;
            this.label7.Text = "Situação";
            this.toolTip1.SetToolTip(this.label7, "Minimo 3 Máximo 10 pontos.");
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(74, 94);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(132, 26);
            this.txtIP.TabIndex = 1;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            this.txtIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIP_KeyDown);
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            // 
            // FrmCadastroCameras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(515, 255);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSituação);
            this.Controls.Add(this.cmbAudio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCliente);
            this.Name = "FrmCadastroCameras";
            this.Text = "Cadastrar Camera";
            this.Controls.SetChildIndex(this.lbCliente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtLocalizacao, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbAudio, 0);
            this.Controls.SetChildIndex(this.cmbSituação, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtIP, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.ComboBox cmbAudio;
        private System.Windows.Forms.ComboBox cmbSituação;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIP;
    }
}
