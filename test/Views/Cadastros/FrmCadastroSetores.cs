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
    public partial class FrmCadastroSetores : FrmCadastro
    {
        Setores oSetor;
        CTLSetores aCTLSetores;
        public FrmCadastroSetores()
        {
            InitializeComponent();
            oSetor = new Setores();
            aCTLSetores = new CTLSetores();
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Setores setor)
            {
                oSetor = setor;
                CarregarCampos();
            }
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtSetor.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtSetor.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oSetor.Id.ToString();
            txtSetor.Text = oSetor.Setor;
        }

        public override void Salvar()
        {

            if (VerificarCamposVazios())
            {
                oSetor.Setor = txtSetor.Text;

                if (oSetor.Id == 0)
                    aCTLSetores.AdicionarSetor(oSetor);
                else
                    aCTLSetores.AtualizarSetor(oSetor);
                Close();
            }
        }

        protected override bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txtSetor.Text))
            {
                MessageBox.Show("Campo Setor não pode estar vazio.");
                txtSetor.Focus();
                return false;
            }
            return true;
        }
        private void ExcluirSetor()
        {
            if (oSetor != null)
            {
                try
                {
                    CTLSetores aCTLSetores = new CTLSetores();
                    aCTLSetores.ExcluirSetor(oSetor.Id);

                    // Feche o formulário após a exclusão
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o setor devido a outros registros estarem vinclulados a este setor.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o setor. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }
        //buttons
        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este setor?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirSetor();
                }
            }
        }
    }
}
