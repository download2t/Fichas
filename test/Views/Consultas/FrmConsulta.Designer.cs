namespace test.Views.Consultas
{
    partial class FrmConsulta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(9, 6);
            this.lbID.Size = new System.Drawing.Size(52, 17);
            this.lbID.Text = "Buscar";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(1016, 579);
            this.btnSair.TabIndex = 103;
            this.toolTip1.SetToolTip(this.btnSair, "Sair da operação");
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(12, 26);
            this.txtID.MaxLength = 50;
            this.txtID.Size = new System.Drawing.Size(997, 23);
            this.toolTip1.SetToolTip(this.txtID, "Busca de informações, selecione uma das opções a baixo para ajuda-lo");
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(1015, 22);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 29);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualiza os dados da lista");
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(909, 579);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 29);
            this.btnExcluir.TabIndex = 102;
            this.btnExcluir.Text = "Excluir";
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um dado para excluir");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(803, 579);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 29);
            this.btnAlterar.TabIndex = 101;
            this.btnAlterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione  um dado para alterar");
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(697, 579);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 29);
            this.btnIncluir.TabIndex = 100;
            this.btnIncluir.Text = "Incluir";
            this.toolTip1.SetToolTip(this.btnIncluir, "Adcionar novo");
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.panel4.Location = new System.Drawing.Point(12, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1103, 32);
            this.panel4.TabIndex = 548;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1129, 617);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.Name = "FrmConsulta";
            this.Text = "Consultas Pai";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button btnAtualizar;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnIncluir;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.ToolTip toolTip1;
    }
}
