namespace Controle.Views.Cadastros
{
    partial class FrmOperacoesFolha
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
            this.components = new System.ComponentModel.Container();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPontos = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(269, 250);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 29);
            this.btnSair.TabIndex = 516;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtPontos
            // 
            this.txtPontos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontos.ForeColor = System.Drawing.Color.Black;
            this.txtPontos.Location = new System.Drawing.Point(91, 168);
            this.txtPontos.MaxLength = 6;
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.Size = new System.Drawing.Size(278, 27);
            this.txtPontos.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPontos, "Excluir o lançamento realizado.( código  mes/ano, exemplo JAN23).");
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.Color.White;
            this.labelCategoria.Location = new System.Drawing.Point(88, 148);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(143, 17);
            this.labelCategoria.TabIndex = 540;
            this.labelCategoria.Text = "Código a ser excluido";
            this.toolTip1.SetToolTip(this.labelCategoria, "Excluir o lançamento realizado.( código  mes/ano, exemplo JAN23).");
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(91, 201);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(278, 29);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir Lançamentos Mensal";
            this.toolTip1.SetToolTip(this.btnExcluir, "Realiza a exclusão do mes lançado.");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(91, 92);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(278, 29);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar Lançamentos Mensal";
            this.toolTip1.SetToolTip(this.btnGerar, "Cadastrar novos lançamentos de pontos.");
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // FrmOperacoesFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(457, 291);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtPontos);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmOperacoesFolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operações folha de pontos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtPontos;
        private System.Windows.Forms.Label labelCategoria;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnGerar;
        protected System.Windows.Forms.ToolTip toolTip1;
    }
}