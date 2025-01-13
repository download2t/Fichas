namespace Controle.Views.Consultas
{
    partial class FrmConsultaControleGov
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtData2 = new System.Windows.Forms.DateTimePicker();
            this.dtData1 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.clData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPermanece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSaidas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clRSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPerm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clRealizados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPerc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFunci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1103, 10);
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(12, 9);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // txtID
            // 
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(318, 23);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(618, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 565;
            this.label1.Text = "Periodo : Fim da busca";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(333, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 564;
            this.label3.Text = "Periodo : Inicio de busca";
            // 
            // dtData2
            // 
            this.dtData2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData2.Location = new System.Drawing.Point(621, 26);
            this.dtData2.Name = "dtData2";
            this.dtData2.Size = new System.Drawing.Size(279, 23);
            this.dtData2.TabIndex = 4;
            // 
            // dtData1
            // 
            this.dtData1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData1.Location = new System.Drawing.Point(336, 26);
            this.dtData1.Name = "dtData1";
            this.dtData1.Size = new System.Drawing.Size(279, 23);
            this.dtData1.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(909, 22);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 29);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.toolTip1.SetToolTip(this.btnFiltrar, "Novos Lançamentos e exclusão de lançamentos.");
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // clData
            // 
            this.clData.Text = "DATA";
            this.clData.Width = 130;
            // 
            // clPermanece
            // 
            this.clPermanece.Text = "PERMANECE";
            this.clPermanece.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clPermanece.Width = 100;
            // 
            // clSaidas
            // 
            this.clSaidas.Text = "SAÍDAS";
            this.clSaidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSaidas.Width = 100;
            // 
            // clRSV
            // 
            this.clRSV.Text = "RSV";
            this.clRSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clRSV.Width = 100;
            // 
            // clPerm
            // 
            this.clPerm.Text = "PERMANECE";
            this.clPerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clPerm.Width = 100;
            // 
            // clSaid
            // 
            this.clSaid.Text = "SAIDAS";
            this.clSaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSaid.Width = 100;
            // 
            // clRealizados
            // 
            this.clRealizados.Text = "REALIZADOS";
            this.clRealizados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clRealizados.Width = 100;
            // 
            // clPerc
            // 
            this.clPerc.Text = "%";
            this.clPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clPerc.Width = 50;
            // 
            // clFunci
            // 
            this.clFunci.Text = "FUNCIONÁRIO";
            this.clFunci.Width = 200;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 566;
            this.label2.Text = "TOTAL REALIZADO";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Orange;
            this.lblTotal.Location = new System.Drawing.Point(189, 582);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 24);
            this.lblTotal.TabIndex = 567;
            this.lblTotal.Text = "000";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.ForeColor = System.Drawing.Color.Orange;
            this.lblPorcentagem.Location = new System.Drawing.Point(361, 582);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(65, 24);
            this.lblPorcentagem.TabIndex = 569;
            this.lblPorcentagem.Text = "000 %";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(246, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 568;
            this.label6.Text = "% Realizada";
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
            this.dgv.Location = new System.Drawing.Point(12, 71);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1103, 503);
            this.dgv.TabIndex = 592;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // FrmConsultaControleGov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1129, 617);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtData2);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtData1);
            this.Name = "FrmConsultaControleGov";
            this.Text = "Controle Governança";
            this.Load += new System.EventHandler(this.FrmConsultaControleGov_Load);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.dtData1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnFiltrar, 0);
            this.Controls.SetChildIndex(this.dtData2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblPorcentagem, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtData2;
        private System.Windows.Forms.DateTimePicker dtData1;
        protected System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ColumnHeader clData;
        private System.Windows.Forms.ColumnHeader clPermanece;
        private System.Windows.Forms.ColumnHeader clSaidas;
        private System.Windows.Forms.ColumnHeader clRSV;
        private System.Windows.Forms.ColumnHeader clPerm;
        private System.Windows.Forms.ColumnHeader clSaid;
        private System.Windows.Forms.ColumnHeader clRealizados;
        private System.Windows.Forms.ColumnHeader clPerc;
        private System.Windows.Forms.ColumnHeader clFunci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgv;
    }
}
