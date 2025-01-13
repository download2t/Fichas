namespace Controle.Views.Consultas
{
    partial class FrmConsultaFolhaTaxa
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
            this.clFuncionarios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSalarioBase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clValorPontos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNumPontos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPontosTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSalarioTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOperacoes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizar.Location = new System.Drawing.Point(1023, 22);
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(917, 627);
            this.btnExcluir.TabIndex = 103;
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.Location = new System.Drawing.Point(811, 627);
            this.btnAlterar.TabIndex = 102;
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.Location = new System.Drawing.Point(705, 627);
            this.btnIncluir.TabIndex = 101;
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 

            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1101, 55);
            this.panel4.Size = new System.Drawing.Size(22, 32);
            // 

            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(1024, 627);
            this.btnSair.TabIndex = 104;
            // 
            // txtID
            // 
            this.txtID.Size = new System.Drawing.Size(632, 23);
            this.toolTip1.SetToolTip(this.txtID, "Ajuda no filtro especifico de um funcionário.");
            // 
            // clFuncionarios
            // 
            this.clFuncionarios.Text = "Funcionários";
            this.clFuncionarios.Width = 320;
            // 
            // clSalarioBase
            // 
            this.clSalarioBase.Text = "Salário Bruto";
            this.clSalarioBase.Width = 120;
            // 
            // clValorPontos
            // 
            this.clValorPontos.Text = "Valor Pontos";
            this.clValorPontos.Width = 90;
            // 
            // clNumPontos
            // 
            this.clNumPontos.Text = "Num. Pontos";
            this.clNumPontos.Width = 90;
            // 
            // clPontosTotal
            // 
            this.clPontosTotal.Text = "Total de pontos";
            this.clPontosTotal.Width = 120;
            // 
            // clSalarioTotal
            // 
            this.clSalarioTotal.Text = "Salário Total";
            this.clSalarioTotal.Width = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(787, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 552;
            this.label4.Text = "Ano";
            // 
            // cmbMes
            // 
            this.cmbMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(650, 22);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 26);
            this.cmbMes.TabIndex = 549;
            // 
            // cmbAno
            // 
            this.cmbAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(790, 22);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(121, 26);
            this.cmbAno.TabIndex = 550;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(647, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 551;
            this.label5.Text = "Mês";
            // 
            // btnOperacoes
            // 
            this.btnOperacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOperacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnOperacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperacoes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOperacoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOperacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOperacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperacoes.ForeColor = System.Drawing.Color.White;
            this.btnOperacoes.Location = new System.Drawing.Point(599, 627);
            this.btnOperacoes.Name = "btnOperacoes";
            this.btnOperacoes.Size = new System.Drawing.Size(100, 29);
            this.btnOperacoes.TabIndex = 100;
            this.btnOperacoes.Text = "Operações";
            this.toolTip1.SetToolTip(this.btnOperacoes, "Novos Lançamentos e exclusão de lançamentos.");
            this.btnOperacoes.UseVisualStyleBackColor = false;
            this.btnOperacoes.Click += new System.EventHandler(this.btnOperacoes_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(917, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 554;
            this.button1.Text = "Filtrar";
            this.toolTip1.SetToolTip(this.button1, "Novos Lançamentos e exclusão de lançamentos.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv.Location = new System.Drawing.Point(12, 58);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1112, 564);
            this.dgv.TabIndex = 594;
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // FrmConsultaFolhaTaxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1137, 665);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOperacoes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.label5);
            this.Name = "FrmConsultaFolhaTaxa";
            this.Text = "Consultar Pontos / Taxa de serviço";
            this.Controls.SetChildIndex(this.panel4, 0);

            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);

            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbAno, 0);
            this.Controls.SetChildIndex(this.cmbMes, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnOperacoes, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader clFuncionarios;
        private System.Windows.Forms.ColumnHeader clSalarioBase;
        private System.Windows.Forms.ColumnHeader clValorPontos;
        private System.Windows.Forms.ColumnHeader clNumPontos;
        private System.Windows.Forms.ColumnHeader clPontosTotal;
        private System.Windows.Forms.ColumnHeader clSalarioTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnOperacoes;
        protected System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgv;
    }
}
