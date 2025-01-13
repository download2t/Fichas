namespace Controle.Views.Relatorios.Forms
{
    partial class FrmRelManutencao
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
            this.rbPatri = new System.Windows.Forms.RadioButton();
            this.txtCodPatrimonio = new System.Windows.Forms.TextBox();
            this.btnPesquisarPatrimonio = new System.Windows.Forms.Button();
            this.lblPatri = new System.Windows.Forms.Label();
            this.lblCodPatri = new System.Windows.Forms.Label();
            this.txtPatrimonio = new System.Windows.Forms.TextBox();
            this.lblPro = new System.Windows.Forms.Label();
            this.txtPro = new System.Windows.Forms.TextBox();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.DataFim = new System.Windows.Forms.DateTimePicker();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.rbPeriodoManu = new System.Windows.Forms.RadioButton();
            this.rbPro = new System.Windows.Forms.RadioButton();
            this.rbTotalManu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerar.Location = new System.Drawing.Point(725, 280);
            this.btnGerar.Size = new System.Drawing.Size(162, 36);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(895, 280);
            this.btnSair.Size = new System.Drawing.Size(133, 36);
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(54, 290);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(57, 310);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            // 
            // rbPatri
            // 
            this.rbPatri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPatri.AutoSize = true;
            this.rbPatri.BackColor = System.Drawing.Color.Transparent;
            this.rbPatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPatri.ForeColor = System.Drawing.Color.White;
            this.rbPatri.Location = new System.Drawing.Point(33, 196);
            this.rbPatri.Margin = new System.Windows.Forms.Padding(4);
            this.rbPatri.Name = "rbPatri";
            this.rbPatri.Size = new System.Drawing.Size(259, 28);
            this.rbPatri.TabIndex = 837;
            this.rbPatri.Text = "Manutenção por patrimônio";
            this.rbPatri.UseVisualStyleBackColor = false;
            this.rbPatri.CheckedChanged += new System.EventHandler(this.rbPatri_CheckedChanged);
            // 
            // txtCodPatrimonio
            // 
            this.txtCodPatrimonio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodPatrimonio.Enabled = false;
            this.txtCodPatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPatrimonio.Location = new System.Drawing.Point(345, 222);
            this.txtCodPatrimonio.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodPatrimonio.MaxLength = 6;
            this.txtCodPatrimonio.Name = "txtCodPatrimonio";
            this.txtCodPatrimonio.Size = new System.Drawing.Size(170, 26);
            this.txtCodPatrimonio.TabIndex = 833;
            this.txtCodPatrimonio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarValorKeyPress);
            this.txtCodPatrimonio.Leave += new System.EventHandler(this.txtCodPatrimonio_Leave);
            // 
            // btnPesquisarPatrimonio
            // 
            this.btnPesquisarPatrimonio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarPatrimonio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarPatrimonio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarPatrimonio.Enabled = false;
            this.btnPesquisarPatrimonio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarPatrimonio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarPatrimonio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarPatrimonio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPatrimonio.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarPatrimonio.Location = new System.Drawing.Point(895, 216);
            this.btnPesquisarPatrimonio.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisarPatrimonio.Name = "btnPesquisarPatrimonio";
            this.btnPesquisarPatrimonio.Size = new System.Drawing.Size(133, 36);
            this.btnPesquisarPatrimonio.TabIndex = 834;
            this.btnPesquisarPatrimonio.Text = "Pesquisar";
            this.btnPesquisarPatrimonio.UseVisualStyleBackColor = false;
            this.btnPesquisarPatrimonio.Click += new System.EventHandler(this.btnPesquisarPatrimonio_Click);
            // 
            // lblPatri
            // 
            this.lblPatri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatri.AutoSize = true;
            this.lblPatri.BackColor = System.Drawing.Color.Transparent;
            this.lblPatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatri.ForeColor = System.Drawing.Color.White;
            this.lblPatri.Location = new System.Drawing.Point(530, 190);
            this.lblPatri.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPatri.Name = "lblPatri";
            this.lblPatri.Size = new System.Drawing.Size(84, 20);
            this.lblPatri.TabIndex = 836;
            this.lblPatri.Text = "Patrimônio";
            // 
            // lblCodPatri
            // 
            this.lblCodPatri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodPatri.AutoSize = true;
            this.lblCodPatri.BackColor = System.Drawing.Color.Transparent;
            this.lblCodPatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPatri.ForeColor = System.Drawing.Color.White;
            this.lblCodPatri.Location = new System.Drawing.Point(345, 192);
            this.lblCodPatri.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodPatri.Name = "lblCodPatri";
            this.lblCodPatri.Size = new System.Drawing.Size(138, 20);
            this.lblCodPatri.TabIndex = 835;
            this.lblCodPatri.Text = "Código Patrimônio";
            // 
            // txtPatrimonio
            // 
            this.txtPatrimonio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatrimonio.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPatrimonio.Enabled = false;
            this.txtPatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatrimonio.Location = new System.Drawing.Point(530, 222);
            this.txtPatrimonio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatrimonio.MaxLength = 55;
            this.txtPatrimonio.Name = "txtPatrimonio";
            this.txtPatrimonio.Size = new System.Drawing.Size(357, 26);
            this.txtPatrimonio.TabIndex = 832;
            // 
            // lblPro
            // 
            this.lblPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPro.AutoSize = true;
            this.lblPro.BackColor = System.Drawing.Color.Transparent;
            this.lblPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPro.ForeColor = System.Drawing.Color.White;
            this.lblPro.Location = new System.Drawing.Point(346, 129);
            this.lblPro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(90, 20);
            this.lblPro.TabIndex = 831;
            this.lblPro.Text = "Profissional";
            // 
            // txtPro
            // 
            this.txtPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPro.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPro.Enabled = false;
            this.txtPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPro.Location = new System.Drawing.Point(345, 153);
            this.txtPro.Margin = new System.Windows.Forms.Padding(4);
            this.txtPro.MaxLength = 55;
            this.txtPro.Name = "txtPro";
            this.txtPro.Size = new System.Drawing.Size(683, 26);
            this.txtPro.TabIndex = 826;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.ForeColor = System.Drawing.Color.White;
            this.lblDataFinal.Location = new System.Drawing.Point(706, 40);
            this.lblDataFinal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(123, 20);
            this.lblDataFinal.TabIndex = 825;
            this.lblDataFinal.Text = "Data de término";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.ForeColor = System.Drawing.Color.White;
            this.lblDataInicial.Location = new System.Drawing.Point(345, 40);
            this.lblDataInicial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(105, 20);
            this.lblDataInicial.TabIndex = 824;
            this.lblDataInicial.Text = "Data de inicio";
            // 
            // DataFim
            // 
            this.DataFim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataFim.Enabled = false;
            this.DataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFim.Location = new System.Drawing.Point(711, 68);
            this.DataFim.Margin = new System.Windows.Forms.Padding(4);
            this.DataFim.Name = "DataFim";
            this.DataFim.Size = new System.Drawing.Size(317, 26);
            this.DataFim.TabIndex = 823;
            // 
            // DataInicio
            // 
            this.DataInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataInicio.Enabled = false;
            this.DataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicio.Location = new System.Drawing.Point(350, 68);
            this.DataInicio.Margin = new System.Windows.Forms.Padding(4);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(330, 26);
            this.DataInicio.TabIndex = 822;
            // 
            // rbPeriodoManu
            // 
            this.rbPeriodoManu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPeriodoManu.AutoSize = true;
            this.rbPeriodoManu.BackColor = System.Drawing.Color.Transparent;
            this.rbPeriodoManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPeriodoManu.ForeColor = System.Drawing.Color.White;
            this.rbPeriodoManu.Location = new System.Drawing.Point(33, 112);
            this.rbPeriodoManu.Margin = new System.Windows.Forms.Padding(4);
            this.rbPeriodoManu.Name = "rbPeriodoManu";
            this.rbPeriodoManu.Size = new System.Drawing.Size(204, 28);
            this.rbPeriodoManu.TabIndex = 821;
            this.rbPeriodoManu.Text = "Histórico por periodo";
            this.rbPeriodoManu.UseVisualStyleBackColor = false;
            this.rbPeriodoManu.CheckedChanged += new System.EventHandler(this.rbPeriodoManu_CheckedChanged);
            // 
            // rbPro
            // 
            this.rbPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPro.AutoSize = true;
            this.rbPro.BackColor = System.Drawing.Color.Transparent;
            this.rbPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPro.ForeColor = System.Drawing.Color.White;
            this.rbPro.Location = new System.Drawing.Point(33, 154);
            this.rbPro.Margin = new System.Windows.Forms.Padding(4);
            this.rbPro.Name = "rbPro";
            this.rbPro.Size = new System.Drawing.Size(265, 28);
            this.rbPro.TabIndex = 820;
            this.rbPro.Text = "Manutenção por profissional";
            this.rbPro.UseVisualStyleBackColor = false;
            this.rbPro.CheckedChanged += new System.EventHandler(this.rbPro_CheckedChanged);
            // 
            // rbTotalManu
            // 
            this.rbTotalManu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTotalManu.AutoSize = true;
            this.rbTotalManu.BackColor = System.Drawing.Color.Transparent;
            this.rbTotalManu.Checked = true;
            this.rbTotalManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTotalManu.ForeColor = System.Drawing.Color.White;
            this.rbTotalManu.Location = new System.Drawing.Point(33, 73);
            this.rbTotalManu.Margin = new System.Windows.Forms.Padding(4);
            this.rbTotalManu.Name = "rbTotalManu";
            this.rbTotalManu.Size = new System.Drawing.Size(276, 28);
            this.rbTotalManu.TabIndex = 819;
            this.rbTotalManu.TabStop = true;
            this.rbTotalManu.Text = "Histórico total de manutenção";
            this.rbTotalManu.UseVisualStyleBackColor = false;
            this.rbTotalManu.CheckedChanged += new System.EventHandler(this.rbTotalManu_CheckedChanged);
            // 
            // FrmRelManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1061, 348);
            this.Controls.Add(this.rbPatri);
            this.Controls.Add(this.txtCodPatrimonio);
            this.Controls.Add(this.btnPesquisarPatrimonio);
            this.Controls.Add(this.lblPatri);
            this.Controls.Add(this.lblCodPatri);
            this.Controls.Add(this.txtPatrimonio);
            this.Controls.Add(this.lblPro);
            this.Controls.Add(this.txtPro);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.DataFim);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.rbPeriodoManu);
            this.Controls.Add(this.rbPro);
            this.Controls.Add(this.rbTotalManu);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmRelManutencao";
            this.Text = "Relatório de Manutenção";
            this.Controls.SetChildIndex(this.rbTotalManu, 0);
            this.Controls.SetChildIndex(this.rbPro, 0);
            this.Controls.SetChildIndex(this.rbPeriodoManu, 0);
            this.Controls.SetChildIndex(this.DataInicio, 0);
            this.Controls.SetChildIndex(this.DataFim, 0);
            this.Controls.SetChildIndex(this.lblDataInicial, 0);
            this.Controls.SetChildIndex(this.lblDataFinal, 0);
            this.Controls.SetChildIndex(this.txtPro, 0);
            this.Controls.SetChildIndex(this.lblPro, 0);
            this.Controls.SetChildIndex(this.txtPatrimonio, 0);
            this.Controls.SetChildIndex(this.lblCodPatri, 0);
            this.Controls.SetChildIndex(this.lblPatri, 0);
            this.Controls.SetChildIndex(this.btnPesquisarPatrimonio, 0);
            this.Controls.SetChildIndex(this.txtCodPatrimonio, 0);
            this.Controls.SetChildIndex(this.rbPatri, 0);
            this.Controls.SetChildIndex(this.btnGerar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbPatri;
        public System.Windows.Forms.TextBox txtCodPatrimonio;
        private System.Windows.Forms.Button btnPesquisarPatrimonio;
        private System.Windows.Forms.Label lblPatri;
        private System.Windows.Forms.Label lblCodPatri;
        public System.Windows.Forms.TextBox txtPatrimonio;
        private System.Windows.Forms.Label lblPro;
        public System.Windows.Forms.TextBox txtPro;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker DataFim;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.RadioButton rbPeriodoManu;
        private System.Windows.Forms.RadioButton rbPro;
        private System.Windows.Forms.RadioButton rbTotalManu;
    }
}