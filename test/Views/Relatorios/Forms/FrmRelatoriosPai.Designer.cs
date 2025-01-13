namespace Controle.Views.Relatorios.Forms
{
    partial class FrmRelatoriosPai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatoriosPai));
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.Location = new System.Drawing.Point(10, 444);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(370, 469);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(13, 464);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Visible = false;
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(201, 468);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(162, 29);
            this.btnGerar.TabIndex = 791;
            this.btnGerar.Text = "Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click_1);
            // 
            // FrmRelatoriosPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(482, 510);
            this.Controls.Add(this.btnGerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmRelatoriosPai";
            this.Text = "Relatórios Pai";
            this.Controls.SetChildIndex(this.btnGerar, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnGerar;
    }
}