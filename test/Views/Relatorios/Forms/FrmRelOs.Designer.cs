namespace Controle.Views.Relatorios.Forms
{
    partial class FrmRelOs
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
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.btnPesquisarUsuario = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCodUser = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.DataFim = new System.Windows.Forms.DateTimePicker();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.rbPeriodoOs = new System.Windows.Forms.RadioButton();
            this.rbUsuarios = new System.Windows.Forms.RadioButton();
            this.rbTotalOs = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerar.Location = new System.Drawing.Point(622, 301);
            this.btnGerar.Size = new System.Drawing.Size(162, 35);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(791, 301);
            this.btnSair.Size = new System.Drawing.Size(135, 35);
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUsuario.Location = new System.Drawing.Point(266, 250);
            this.txtCodUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodUsuario.MaxLength = 6;
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(170, 26);
            this.txtCodUsuario.TabIndex = 872;
            // 
            // btnPesquisarUsuario
            // 
            this.btnPesquisarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarUsuario.Enabled = false;
            this.btnPesquisarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarUsuario.Location = new System.Drawing.Point(793, 245);
            this.btnPesquisarUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            this.btnPesquisarUsuario.Size = new System.Drawing.Size(133, 36);
            this.btnPesquisarUsuario.TabIndex = 873;
            this.btnPesquisarUsuario.Text = "Pesquisar";
            this.btnPesquisarUsuario.UseVisualStyleBackColor = false;
            this.btnPesquisarUsuario.Click += new System.EventHandler(this.btnPesquisarUsuario_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(451, 218);
            this.lblUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 20);
            this.lblUser.TabIndex = 875;
            this.lblUser.Text = "Usuário";
            // 
            // lblCodUser
            // 
            this.lblCodUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodUser.AutoSize = true;
            this.lblCodUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCodUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodUser.ForeColor = System.Drawing.Color.White;
            this.lblCodUser.Location = new System.Drawing.Point(266, 220);
            this.lblCodUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodUser.Name = "lblCodUser";
            this.lblCodUser.Size = new System.Drawing.Size(118, 20);
            this.lblCodUser.TabIndex = 874;
            this.lblCodUser.Text = "Código Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(445, 250);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 55;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(339, 26);
            this.txtUsuario.TabIndex = 871;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.ForeColor = System.Drawing.Color.White;
            this.lblDataFinal.Location = new System.Drawing.Point(604, 148);
            this.lblDataFinal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(123, 20);
            this.lblDataFinal.TabIndex = 864;
            this.lblDataFinal.Text = "Data de término";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.ForeColor = System.Drawing.Color.White;
            this.lblDataInicial.Location = new System.Drawing.Point(262, 148);
            this.lblDataInicial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(105, 20);
            this.lblDataInicial.TabIndex = 863;
            this.lblDataInicial.Text = "Data de inicio";
            // 
            // DataFim
            // 
            this.DataFim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataFim.Enabled = false;
            this.DataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFim.Location = new System.Drawing.Point(609, 176);
            this.DataFim.Margin = new System.Windows.Forms.Padding(4);
            this.DataFim.Name = "DataFim";
            this.DataFim.Size = new System.Drawing.Size(317, 26);
            this.DataFim.TabIndex = 862;
            // 
            // DataInicio
            // 
            this.DataInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataInicio.Enabled = false;
            this.DataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicio.Location = new System.Drawing.Point(266, 176);
            this.DataInicio.Margin = new System.Windows.Forms.Padding(4);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(330, 26);
            this.DataInicio.TabIndex = 861;
            // 
            // rbPeriodoOs
            // 
            this.rbPeriodoOs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPeriodoOs.AutoSize = true;
            this.rbPeriodoOs.BackColor = System.Drawing.Color.Transparent;
            this.rbPeriodoOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeriodoOs.ForeColor = System.Drawing.Color.White;
            this.rbPeriodoOs.Location = new System.Drawing.Point(35, 174);
            this.rbPeriodoOs.Margin = new System.Windows.Forms.Padding(4);
            this.rbPeriodoOs.Name = "rbPeriodoOs";
            this.rbPeriodoOs.Size = new System.Drawing.Size(204, 28);
            this.rbPeriodoOs.TabIndex = 860;
            this.rbPeriodoOs.Text = "Histórico por periodo";
            this.rbPeriodoOs.UseVisualStyleBackColor = false;
            // 
            // rbUsuarios
            // 
            this.rbUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbUsuarios.AutoSize = true;
            this.rbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.rbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsuarios.ForeColor = System.Drawing.Color.White;
            this.rbUsuarios.Location = new System.Drawing.Point(35, 216);
            this.rbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsuarios.Name = "rbUsuarios";
            this.rbUsuarios.Size = new System.Drawing.Size(193, 28);
            this.rbUsuarios.TabIndex = 859;
            this.rbUsuarios.Text = "Fichas por usuários";
            this.rbUsuarios.UseVisualStyleBackColor = false;
            // 
            // rbTotalOs
            // 
            this.rbTotalOs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTotalOs.AutoSize = true;
            this.rbTotalOs.BackColor = System.Drawing.Color.Transparent;
            this.rbTotalOs.Checked = true;
            this.rbTotalOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTotalOs.ForeColor = System.Drawing.Color.White;
            this.rbTotalOs.Location = new System.Drawing.Point(35, 135);
            this.rbTotalOs.Margin = new System.Windows.Forms.Padding(4);
            this.rbTotalOs.Name = "rbTotalOs";
            this.rbTotalOs.Size = new System.Drawing.Size(188, 28);
            this.rbTotalOs.TabIndex = 858;
            this.rbTotalOs.TabStop = true;
            this.rbTotalOs.Text = "Histório total de OS";
            this.rbTotalOs.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(263, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 878;
            this.label3.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Todos",
            "Aberto",
            "Encerrado",
            "Encaminhado a TOTVS",
            "Em andamento",
            "Em análise",
            "Manutenção",
            "Aguardando aprovação"});
            this.cmbStatus.Location = new System.Drawing.Point(266, 109);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(194, 24);
            this.cmbStatus.TabIndex = 876;
            // 
            // FrmRelOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(964, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.btnPesquisarUsuario);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblCodUser);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.DataFim);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.rbPeriodoOs);
            this.Controls.Add(this.rbUsuarios);
            this.Controls.Add(this.rbTotalOs);
            this.Name = "FrmRelOs";
            this.Text = "Relatório de Ordem de Serviço";
            this.Controls.SetChildIndex(this.rbTotalOs, 0);
            this.Controls.SetChildIndex(this.rbUsuarios, 0);
            this.Controls.SetChildIndex(this.rbPeriodoOs, 0);
            this.Controls.SetChildIndex(this.DataInicio, 0);
            this.Controls.SetChildIndex(this.DataFim, 0);
            this.Controls.SetChildIndex(this.lblDataInicial, 0);
            this.Controls.SetChildIndex(this.lblDataFinal, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.lblCodUser, 0);
            this.Controls.SetChildIndex(this.lblUser, 0);
            this.Controls.SetChildIndex(this.btnPesquisarUsuario, 0);
            this.Controls.SetChildIndex(this.txtCodUsuario, 0);
            this.Controls.SetChildIndex(this.btnGerar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.cmbStatus, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Button btnPesquisarUsuario;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCodUser;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker DataFim;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.RadioButton rbPeriodoOs;
        private System.Windows.Forms.RadioButton rbUsuarios;
        private System.Windows.Forms.RadioButton rbTotalOs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}
