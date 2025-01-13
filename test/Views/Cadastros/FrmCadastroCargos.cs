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

namespace Controle.Views.Cadastros
{
    public partial class FrmCadastroCargos : test.Views.Cadastros.FrmCadastro
    {
        CTLCargos oCtlCargos;
        Cargo oCargo;
        public FrmCadastroCargos()
        {
            InitializeComponent();
            oCargo = new Cargo();
            oCtlCargos = new CTLCargos();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Cargo cargo)
            {
                oCargo = cargo;
                CarregarCampos();
            }
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtFuncao.Enabled = false;
            txtPontos.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtFuncao.Enabled = true;
            txtPontos.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oCargo.Id.ToString();
            txtFuncao.Text = oCargo.Funcao;
            txtPontos.Text = oCargo.Pontos.ToString();
        }
        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                ConfirmarExclusaoCargo();
            }
        }

        public override void Salvar()
        {
            if (string.IsNullOrWhiteSpace(txtPontos.Text))
            {
                MessageBox.Show("Campo Pontos não pode estar vazio.");
                txtPontos.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtFuncao.Text))
            {
                MessageBox.Show("Campo Função não pode estar vazio.");
                txtFuncao.Focus();
            }
            else
            {
                oCargo.Funcao = txtFuncao.Text;
                oCargo.Pontos = Convert.ToInt32(txtPontos.Text);

                if (oCargo.Id == 0)
                    oCtlCargos.AdicionarCargo(oCargo);
                else
                    oCtlCargos.AtualizarCargo(oCargo);

                Close();
            }
        }

        private void ConfirmarExclusaoCargo()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ExcluirCargo();
            }
        }


        private void ExcluirCargo()
        {
            if (oCargo != null)
            {
                try
                {
                    CTLCategorias aCTLCategorias = new CTLCategorias();
                    aCTLCategorias.ExcluirCategoria(oCargo.Id);
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível excluir a categoria devido a outros registros estarem vinculados a esta categoria.");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir a categoria. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }

        private void txtPontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((TextBox)sender, e);
        }
    }
}
