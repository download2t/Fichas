using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroCofres : FrmCadastro
    {
        CTLCofres controleCofres;
        Cofres cofre;

        public FrmCadastroCofres()
        {
            InitializeComponent();
            controleCofres = new CTLCofres();
            cofre = new Cofres();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Cofres cofre)
            {
                this.cofre = cofre;
                CarregarCampos();
            }
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtCodigo.Enabled = false;
            txtNumQuarto.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtCodigo.Enabled = true;
            txtNumQuarto.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = cofre.CodCofres.ToString();
            txtCodigo.Text = cofre.CodChave.ToString();
            txtNumQuarto.Text = cofre.Quarto.ToString();
        }

        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                ExcluirCofre();
            }
        }

        public override void Salvar()
        {
            if (string.IsNullOrWhiteSpace(lbNumero.Text) || string.IsNullOrWhiteSpace(txtNumQuarto.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
            }
            else
            {
                cofre.CodChave = int.Parse(txtCodigo.Text);
                cofre.Quarto = int.Parse(txtNumQuarto.Text);

                if (cofre.CodCofres == 0)
                    controleCofres.AdicionarCofre(cofre);
                else
                    controleCofres.AtualizarCofre(cofre);

                Close();
            }
        }

        private void ExcluirCofre()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cofre?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (cofre != null)
                {
                    try
                    {
                        controleCofres.ExcluirCofre(cofre.CodCofres);
                        Close();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Não é possível excluir o cofre devido a outros registros estarem vinculados a ele.");
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro ao excluir o cofre. Detalhes: " + ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                    }
                }
            }

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((TextBox)sender, e);
        }
    }
}
