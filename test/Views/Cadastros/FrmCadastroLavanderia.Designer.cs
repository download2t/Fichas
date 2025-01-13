namespace Controle.Views.Cadastros
{
    partial class FrmCadastroLavanderia
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.lbFunc = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lbCodFunc = new System.Windows.Forms.Label();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.DATA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbProcesso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisarItens = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemLavanderia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(417, 288);
            this.btnSalvar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar Operação.");
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.Location = new System.Drawing.Point(109, 274);
            this.lbID.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(523, 288);
            this.btnSair.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(112, 291);
            this.txtID.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(95, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 521;
            this.label4.Text = "*";
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(523, 147);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisarCliente.TabIndex = 4;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // lbFunc
            // 
            this.lbFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFunc.AutoSize = true;
            this.lbFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbFunc.ForeColor = System.Drawing.Color.White;
            this.lbFunc.Location = new System.Drawing.Point(208, 129);
            this.lbFunc.Name = "lbFunc";
            this.lbFunc.Size = new System.Drawing.Size(82, 17);
            this.lbFunc.TabIndex = 520;
            this.lbFunc.Text = "Funcionário";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFuncionario.Location = new System.Drawing.Point(211, 150);
            this.txtFuncionario.MaxLength = 55;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.Size = new System.Drawing.Size(306, 23);
            this.txtFuncionario.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtFuncionario, "Nome do funcionário.");
            // 
            // lbCodFunc
            // 
            this.lbCodFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCodFunc.AutoSize = true;
            this.lbCodFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbCodFunc.ForeColor = System.Drawing.Color.White;
            this.lbCodFunc.Location = new System.Drawing.Point(109, 129);
            this.lbCodFunc.Name = "lbCodFunc";
            this.lbCodFunc.Size = new System.Drawing.Size(52, 17);
            this.lbCodFunc.TabIndex = 519;
            this.lbCodFunc.Text = "Código";
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFuncionario.Location = new System.Drawing.Point(112, 150);
            this.txtCodFuncionario.MaxLength = 6;
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.Size = new System.Drawing.Size(93, 23);
            this.txtCodFuncionario.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtCodFuncionario, "Código do funcionário.");
            this.txtCodFuncionario.Enter += new System.EventHandler(this.txtCodFuncionario_Enter);
            this.txtCodFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFuncionario_KeyPress);
            this.txtCodFuncionario.Leave += new System.EventHandler(this.txtCodFuncionario_Leave);
            // 
            // dtData
            // 
            this.dtData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Location = new System.Drawing.Point(112, 93);
            this.dtData.Margin = new System.Windows.Forms.Padding(4);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(308, 24);
            this.dtData.TabIndex = 1;
            // 
            // DATA
            // 
            this.DATA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DATA.AutoSize = true;
            this.DATA.BackColor = System.Drawing.Color.Transparent;
            this.DATA.ForeColor = System.Drawing.Color.White;
            this.DATA.Location = new System.Drawing.Point(109, 72);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(120, 17);
            this.DATA.TabIndex = 562;
            this.DATA.Text = "Data de pesagem";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(92, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 563;
            this.label1.Text = "*";
            // 
            // lbCliente
            // 
            this.lbCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCliente.AutoSize = true;
            this.lbCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbCliente.ForeColor = System.Drawing.Color.White;
            this.lbCliente.Location = new System.Drawing.Point(109, 224);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(40, 17);
            this.lbCliente.TabIndex = 565;
            this.lbCliente.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPeso.Location = new System.Drawing.Point(112, 247);
            this.txtPeso.MaxLength = 9;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(160, 23);
            this.txtPeso.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtPeso, "Peso das roupas ");
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(95, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 566;
            this.label2.Text = "*";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(277, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 568;
            this.label11.Text = "Processo";
            this.toolTip1.SetToolTip(this.label11, "Caso funcionario não esteja ativo não entra no calculo de folha.");
            // 
            // cmbProcesso
            // 
            this.cmbProcesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProcesso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProcesso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProcesso.ForeColor = System.Drawing.Color.Black;
            this.cmbProcesso.FormattingEnabled = true;
            this.cmbProcesso.Items.AddRange(new object[] {
            "1 - TOALHA PISCINA  / ROUPA COLORIDA",
            "2 - TOALHAS BRANCAS",
            "3 - COBERTOR",
            "4 - RESTAURANTE",
            "5 - PANO DE CHÃO",
            "6 - REMOVEDOR DE GOMA "});
            this.cmbProcesso.Location = new System.Drawing.Point(278, 246);
            this.cmbProcesso.Name = "cmbProcesso";
            this.cmbProcesso.Size = new System.Drawing.Size(345, 24);
            this.cmbProcesso.TabIndex = 567;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(95, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 575;
            this.label3.Text = "*";
            // 
            // btnPesquisarItens
            // 
            this.btnPesquisarItens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarItens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPesquisarItens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarItens.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarItens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisarItens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisarItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarItens.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarItens.Location = new System.Drawing.Point(523, 194);
            this.btnPesquisarItens.Name = "btnPesquisarItens";
            this.btnPesquisarItens.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisarItens.TabIndex = 7;
            this.btnPesquisarItens.Text = "Pesquisar";
            this.btnPesquisarItens.UseVisualStyleBackColor = false;
            this.btnPesquisarItens.Click += new System.EventHandler(this.btnPesquisarItens_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(208, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 574;
            this.label5.Text = "Item da lavanderia";
            // 
            // txtItemLavanderia
            // 
            this.txtItemLavanderia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemLavanderia.Location = new System.Drawing.Point(211, 197);
            this.txtItemLavanderia.MaxLength = 55;
            this.txtItemLavanderia.Name = "txtItemLavanderia";
            this.txtItemLavanderia.ReadOnly = true;
            this.txtItemLavanderia.Size = new System.Drawing.Size(306, 23);
            this.txtItemLavanderia.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtItemLavanderia, "Nome do funcionário.");
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(109, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 573;
            this.label6.Text = "Código";
            // 
            // txtCodigoItem
            // 
            this.txtCodigoItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoItem.Location = new System.Drawing.Point(112, 197);
            this.txtCodigoItem.MaxLength = 6;
            this.txtCodigoItem.Name = "txtCodigoItem";
            this.txtCodigoItem.Size = new System.Drawing.Size(93, 23);
            this.txtCodigoItem.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtCodigoItem, "Código do funcionário.");
            this.txtCodigoItem.Enter += new System.EventHandler(this.txtCodFuncionario_Enter);
            this.txtCodigoItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFuncionario_KeyPress);
            this.txtCodigoItem.Leave += new System.EventHandler(this.txtCodigoItem_Leave);
            // 
            // FrmCadastroLavanderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPesquisarItens);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemLavanderia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigoItem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbProcesso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.DATA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.lbFunc);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.lbCodFunc);
            this.Controls.Add(this.txtCodFuncionario);
            this.Name = "FrmCadastroLavanderia";
            this.Text = "Cadastro lavanderia";
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lbID, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtCodFuncionario, 0);
            this.Controls.SetChildIndex(this.lbCodFunc, 0);
            this.Controls.SetChildIndex(this.txtFuncionario, 0);
            this.Controls.SetChildIndex(this.lbFunc, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCliente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.DATA, 0);
            this.Controls.SetChildIndex(this.dtData, 0);
            this.Controls.SetChildIndex(this.txtPeso, 0);
            this.Controls.SetChildIndex(this.lbCliente, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbProcesso, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtCodigoItem, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtItemLavanderia, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnPesquisarItens, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Label lbFunc;
        private System.Windows.Forms.Label lbCodFunc;
        public System.Windows.Forms.TextBox txtCodFuncionario;
        public System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label DATA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCliente;
        public System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbProcesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisarItens;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtItemLavanderia;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCodigoItem;
    }
}