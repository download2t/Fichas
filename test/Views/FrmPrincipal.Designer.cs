namespace test
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCadUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCadClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCadFichas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFichas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolCadastros,
            this.ToolConsultas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolCadastros
            // 
            this.ToolCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCadUsuarios,
            this.toolCadClientes,
            this.toolCadFichas});
            this.ToolCadastros.Name = "ToolCadastros";
            this.ToolCadastros.Size = new System.Drawing.Size(86, 24);
            this.ToolCadastros.Text = "Cadastros";
            // 
            // toolCadUsuarios
            // 
            this.toolCadUsuarios.Name = "toolCadUsuarios";
            this.toolCadUsuarios.Size = new System.Drawing.Size(180, 24);
            this.toolCadUsuarios.Tag = "3";
            this.toolCadUsuarios.Text = "Usuários";
            this.toolCadUsuarios.Click += new System.EventHandler(this.toolCadUsuarios_Click);
            // 
            // toolCadClientes
            // 
            this.toolCadClientes.Name = "toolCadClientes";
            this.toolCadClientes.Size = new System.Drawing.Size(180, 24);
            this.toolCadClientes.Tag = "4";
            this.toolCadClientes.Text = "Clientes";
            this.toolCadClientes.Click += new System.EventHandler(this.toolCadClientes_Click);
            // 
            // toolCadFichas
            // 
            this.toolCadFichas.Name = "toolCadFichas";
            this.toolCadFichas.Size = new System.Drawing.Size(180, 24);
            this.toolCadFichas.Tag = "5";
            this.toolCadFichas.Text = "Fichas";
            this.toolCadFichas.Click += new System.EventHandler(this.toolCadFichas_Click);
            // 
            // ToolConsultas
            // 
            this.ToolConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUsuarios,
            this.toolClientes,
            this.toolFichas});
            this.ToolConsultas.Name = "ToolConsultas";
            this.ToolConsultas.Size = new System.Drawing.Size(84, 24);
            this.ToolConsultas.Text = "Consultas";
            // 
            // toolUsuarios
            // 
            this.toolUsuarios.Name = "toolUsuarios";
            this.toolUsuarios.Size = new System.Drawing.Size(134, 24);
            this.toolUsuarios.Tag = "0";
            this.toolUsuarios.Text = "Usuários";
            this.toolUsuarios.Click += new System.EventHandler(this.toolUsuarios_Click);
            // 
            // toolClientes
            // 
            this.toolClientes.Name = "toolClientes";
            this.toolClientes.Size = new System.Drawing.Size(134, 24);
            this.toolClientes.Tag = "1";
            this.toolClientes.Text = "Clientes";
            this.toolClientes.Click += new System.EventHandler(this.toolClientes_Click);
            // 
            // toolFichas
            // 
            this.toolFichas.Name = "toolFichas";
            this.toolFichas.Size = new System.Drawing.Size(134, 24);
            this.toolFichas.Tag = "2";
            this.toolFichas.Text = "Fichas";
            this.toolFichas.Click += new System.EventHandler(this.toolFichas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 511);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolConsultas;
        private System.Windows.Forms.ToolStripMenuItem toolUsuarios;
        private System.Windows.Forms.ToolStripMenuItem toolClientes;
        private System.Windows.Forms.ToolStripMenuItem toolFichas;
        private System.Windows.Forms.ToolStripMenuItem ToolCadastros;
        private System.Windows.Forms.ToolStripMenuItem toolCadUsuarios;
        private System.Windows.Forms.ToolStripMenuItem toolCadClientes;
        private System.Windows.Forms.ToolStripMenuItem toolCadFichas;
    }
}

