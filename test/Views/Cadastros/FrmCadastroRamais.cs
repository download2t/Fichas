using Controle.Controllers;
using Controle.Model;
using Controle.Models;
using Controle.Views.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Consultas;

namespace Controle.Views.Cadastros
{
    public partial class FrmCadastroRamais : test.Views.Cadastros.FrmCadastro
    {
        CTLRamais aCTLRamais;
        Ramal oRamal;
        public FrmCadastroRamais()
        {
            InitializeComponent();
            this.txtRamal.TextChanged += new EventHandler(this.txtRamal_TextChanged);
            aCTLRamais = new CTLRamais();
            oRamal = new Ramal();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Ramal ramal)
            {
                oRamal = ramal;
                CarregarCampos();
            }
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtRamal.Enabled = false;
            txtLinha.Enabled = false;
            txtNome.Enabled = false;
            txtCodSetor.Enabled = false;
            txtSetor.Enabled = false;
            txtFone.Enabled = false;
            btnPesquisarSetor.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtRamal.Enabled = true;
            txtLinha.Enabled = true;
            txtNome.Enabled = true;
            txtCodSetor.Enabled = true;
            txtSetor.Enabled = true;
            txtFone.Enabled = true;
            btnPesquisarSetor.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oRamal.Id.ToString();
            txtRamal.Text  = oRamal.NumRamal;
            txtLinha.Text = oRamal.Linha.ToString();
            txtNome.Text = oRamal.Nome;
            txtCodSetor.Text = oRamal.Setor.Id.ToString();
            txtFone.Text = oRamal.Fone.ToString();
            txtSetor.Text = oRamal.Setor.Setor;     
        }
        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                ExcluirRamal();
            }
        }
        protected override bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtCodSetor.Text))
            {
                camposFaltantes.Add("Codigo do setor");
            }

            if (string.IsNullOrWhiteSpace(txtRamal.Text))
            {
                camposFaltantes.Add("Audio");
            }

            if (camposFaltantes.Count > 0)
            {
                string camposFaltantesStr = string.Join(", ", camposFaltantes);
                MessageBox.Show("Os seguintes campos são obrigatórios e não foram preenchidos: " + camposFaltantesStr, "Campos em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public override void Salvar()
        {

            if (VerificarCamposVazios())
            {
                oRamal.NumRamal = txtRamal.Text;
                oRamal.Linha = txtLinha.Text;
                oRamal.Nome = txtNome.Text;
                oRamal.Setor.Id = Convert.ToInt32(txtCodSetor.Text);
                oRamal.Fone = txtFone.Text.ToString();

                if (oRamal.Id == 0)
                    aCTLRamais.AdicionarRamal(oRamal);
                else
                    aCTLRamais.AtualizarRamal(oRamal);

                Close();
            }
        }

        private void ExcluirRamal()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (oRamal != null)
                {
                    try
                    {
                        aCTLRamais.ExcluirRamal(oRamal.Id);
                        Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir a categoria. Detalhes: " + ex.Message);
                    }
                }
            }

        }

        private void txtPontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((TextBox)sender, e);
        }

        private void txtRamal_TextChanged(object sender, EventArgs e)
        {
            txtLinha.Text = $"3521 - {txtRamal.Text}";
        }

        private void btnPesquisarSetor_Click(object sender, EventArgs e)
        {
            using (FrmConsultaSetores frm = new FrmConsultaSetores())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodSetor.Text = IdSelecionado.ToString();
                txtSetor.Text = NomeSelecionado;
                txtCodSetor_Leave(txtCodSetor, EventArgs.Empty);
            }
        }

        private void txtCodSetor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodSetor.Text))
            {
                Limpar();
            }
            else if (int.TryParse(txtCodSetor.Text, out int cod) && cod > 0)
            {
                CTLSetores aCTLSetor = new CTLSetores();
                Setores Valida = aCTLSetor.BuscarSetorPorId(cod);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    Limpar();
                }
                else
                {
                    txtSetor.Text = Valida.Setor;
                }
            }
            else
            {

                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                Limpar();

            }
            this.AcceptButton = btnSalvar; // Restaura o botão "Salvar" como botão padrão
        }
        private void Limpar()
        {
            txtCodSetor.Clear();
            txtSetor.Clear();
            txtCodSetor.Focus();

        }

        private void txtCodSetor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        private void txtCodSetor_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "Salvar" como botão padrão
        }
    }
}
