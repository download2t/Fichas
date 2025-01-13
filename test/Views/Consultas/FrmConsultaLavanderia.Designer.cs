namespace Controle.Views.Consultas
{
    partial class FrmConsultaLavanderia
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.rbProcesso = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.dtData2 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtData1 = new System.Windows.Forms.DateTimePicker();
            this.rbItem = new System.Windows.Forms.RadioButton();
            this.rbFuncionario = new System.Windows.Forms.RadioButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizar.Location = new System.Drawing.Point(974, 22);
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(868, 527);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.Location = new System.Drawing.Point(762, 527);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.Location = new System.Drawing.Point(656, 527);
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbFuncionario);
            this.panel4.Controls.Add(this.rbItem);
            this.panel4.Controls.Add(this.rbProcesso);
            this.panel4.Controls.Add(this.rbCodigo);
            this.panel4.Size = new System.Drawing.Size(1062, 32);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(975, 527);
            // 
            // txtID
            // 
            this.txtID.Size = new System.Drawing.Size(274, 23);
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
            this.dgv.Location = new System.Drawing.Point(12, 92);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1063, 430);
            this.dgv.TabIndex = 596;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentDoubleClick);
            // 
            // rbProcesso
            // 
            this.rbProcesso.AutoSize = true;
            this.rbProcesso.Checked = true;
            this.rbProcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbProcesso.ForeColor = System.Drawing.Color.White;
            this.rbProcesso.Location = new System.Drawing.Point(94, 3);
            this.rbProcesso.Name = "rbProcesso";
            this.rbProcesso.Size = new System.Drawing.Size(75, 26);
            this.rbProcesso.TabIndex = 23;
            this.rbProcesso.TabStop = true;
            this.rbProcesso.Text = "Nome";
            this.toolTip1.SetToolTip(this.rbProcesso, "Buscar funcionário por nome.");
            this.rbProcesso.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(3, 3);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 26);
            this.rbCodigo.TabIndex = 22;
            this.rbCodigo.Text = "Código";
            this.toolTip1.SetToolTip(this.rbCodigo, "Buscar funcionário por código.");
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // dtData2
            // 
            this.dtData2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData2.Location = new System.Drawing.Point(577, 26);
            this.dtData2.Name = "dtData2";
            this.dtData2.Size = new System.Drawing.Size(279, 23);
            this.dtData2.TabIndex = 598;
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
            this.btnFiltrar.Location = new System.Drawing.Point(865, 22);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 29);
            this.btnFiltrar.TabIndex = 599;
            this.btnFiltrar.Text = "Filtrar";
            this.toolTip1.SetToolTip(this.btnFiltrar, "Novos Lançamentos e exclusão de lançamentos.");
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(574, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 601;
            this.label1.Text = "Periodo : Fim da busca";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(289, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 600;
            this.label3.Text = "Periodo : Inicio de busca";
            // 
            // dtData1
            // 
            this.dtData1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData1.Location = new System.Drawing.Point(292, 26);
            this.dtData1.Name = "dtData1";
            this.dtData1.Size = new System.Drawing.Size(279, 23);
            this.dtData1.TabIndex = 597;
            // 
            // rbItem
            // 
            this.rbItem.AutoSize = true;
            this.rbItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbItem.ForeColor = System.Drawing.Color.White;
            this.rbItem.Location = new System.Drawing.Point(175, 3);
            this.rbItem.Name = "rbItem";
            this.rbItem.Size = new System.Drawing.Size(61, 26);
            this.rbItem.TabIndex = 24;
            this.rbItem.Text = "Item";
            this.toolTip1.SetToolTip(this.rbItem, "Buscar funcionário por código.");
            this.rbItem.UseVisualStyleBackColor = true;
            // 
            // rbFuncionario
            // 
            this.rbFuncionario.AutoSize = true;
            this.rbFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbFuncionario.ForeColor = System.Drawing.Color.White;
            this.rbFuncionario.Location = new System.Drawing.Point(242, 3);
            this.rbFuncionario.Name = "rbFuncionario";
            this.rbFuncionario.Size = new System.Drawing.Size(122, 26);
            this.rbFuncionario.TabIndex = 25;
            this.rbFuncionario.Text = "Funcionário";
            this.toolTip1.SetToolTip(this.rbFuncionario, "Buscar funcionário por código.");
            this.rbFuncionario.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaLavanderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 565);
            this.Controls.Add(this.dtData2);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtData1);
            this.Controls.Add(this.dgv);
            this.Name = "FrmConsultaLavanderia";
            this.Text = "Consulta Lavanderia";
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.dtData1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnFiltrar, 0);
            this.Controls.SetChildIndex(this.dtData2, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RadioButton rbProcesso;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.DateTimePicker dtData2;
        protected System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtData1;
        private System.Windows.Forms.RadioButton rbFuncionario;
        private System.Windows.Forms.RadioButton rbItem;
    }
}