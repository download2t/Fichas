using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Views.Cadastros;

namespace Controle.Views.Cadastros
{
    public partial class FrmCadastroItensLavanderia :FrmCadastro
    {
        CTLItensLavanderia oCtlItensLavanderia;
        ItensLavanderia oItensLavanderia;

        public FrmCadastroItensLavanderia()
        {
            InitializeComponent();
            oItensLavanderia = new ItensLavanderia();
            oCtlItensLavanderia = new CTLItensLavanderia();
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is ItensLavanderia itensLavanderia)
            {
                oItensLavanderia = itensLavanderia;
                CarregarCampos();
            }
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtNome.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtNome.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oItensLavanderia.Id.ToString();
            txtNome.Text = oItensLavanderia.Nome;
        }

        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                ConfirmarExclusaoItem();
            }
        }


        public override void Salvar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Campo Nome não pode estar vazio.");
                txtNome.Focus();
            }
            else
            {
                oItensLavanderia.Nome = txtNome.Text;

                if (oItensLavanderia.Id == 0)
                    oCtlItensLavanderia.AdicionarItensLavanderia(oItensLavanderia);
                else
                    oCtlItensLavanderia.AtualizarItensLavanderia(oItensLavanderia);

                Close();
            }
        }

        private void ConfirmarExclusaoItem()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este item de lavanderia?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ExcluirItem();
            }
        }
        private void ExcluirItem()
        {
            if (oItensLavanderia != null)
            {
                try
                {
                    oCtlItensLavanderia.ExcluirItensLavanderia(oItensLavanderia.Id);
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível excluir o item de lavanderia devido a outros registros estarem vinculados a este item.");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir o item de lavanderia. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }
    }
}
