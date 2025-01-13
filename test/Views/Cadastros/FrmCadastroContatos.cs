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

namespace test.Views.Cadastros
{
    public partial class FrmCadastroContatos : test.Views.Cadastros.FrmCadastro
    {

        Contatos oContato;
        CTLContatos aCTLContatos;
        public FrmCadastroContatos()
        {
            InitializeComponent();
            oContato = new Contatos();
            aCTLContatos = new CTLContatos();
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Contatos contato)
            {
                oContato = contato;
                CarregarCampos();
            }
        }
        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = false;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oContato.Id.ToString();
            txtNome.Text = oContato.Nome;
            txtTelefone.Text = oContato.Numero;
        }
        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                txtTelefone_Leave(txtTelefone, EventArgs.Empty);
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Excluir();
                }
            }
        }
        private void Excluir()
        {
            if (oContato != null)
            {
                try
                {
                    aCTLContatos.ExcluirContato(oContato.Id);

                    // Feche o formulário após a exclusão
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o contato devido a outros registros estarem vinclulados a este contato.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o contato. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }
        public override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                oContato.Nome = txtNome.Text;
                oContato.Numero = txtTelefone.Text;

                if (oContato.Id == 0)
                {
                    aCTLContatos.AdicionarContato(oContato);
                    Close();
                }
                else
                {
                    aCTLContatos.AtualizarContato(oContato);
                    Close();
                }

                return;
            }

        }
        protected override bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                camposFaltantes.Add("Nome");
            }
            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                camposFaltantes.Add("Telefone");
            }
            if (camposFaltantes.Count > 0)
            {
                string camposFaltantesStr = string.Join(", ", camposFaltantes);
                MessageBox.Show("Os seguintes campos são obrigatórios e não foram preenchidos: " + camposFaltantesStr, "Campos em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }




        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifique se o caractere digitado não é um dígito numérico (0-9) e não é Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Impede a entrada do caractere não numérico
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            string fone = txtTelefone.Text.Trim();

            if (!string.IsNullOrEmpty(fone) && !Operacao.IsTelefone(fone))
            {
                MessageBox.Show("Número de telefone inválido. Por favor, insira um Número válido.");
                txtTelefone.Focus();
            }
        }
    }
}
