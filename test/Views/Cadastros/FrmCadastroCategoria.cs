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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroCategoria : FrmCadastro
    {
        CTLCategorias aCTLCategorias;
        Categoria aCategoria;

        public FrmCadastroCategoria()
        {
            InitializeComponent();
            aCategoria = new Categoria();
            aCTLCategorias = new CTLCategorias();
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Categoria categoria)
            {
                aCategoria = categoria;
                CarregarCampos();
            }
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtCategoria.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtCategoria.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = aCategoria.Id.ToString();
            txtCategoria.Text = aCategoria.Nome;
        }


        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                ConfirmarExclusaoCategoria();
            }
        }

        public override void Salvar()
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Campo Categoria não pode estar vazio.");
                txtCategoria.Focus();
            }
            else
            {
                aCategoria.Nome = txtCategoria.Text;
                if (cbSenha.Checked)
                {
                    aCategoria.Senha = true; // Categoria de senhas
                    if (aCategoria.Id == 0)
                        aCTLCategorias.AdicionarCategoriaDeSenhas(aCategoria);
                    else
                        aCTLCategorias.AtualizarCategoriaDeSenhas(aCategoria);
                }
                else
                {
                    if (aCategoria.Id == 0) // Categoria de patrimônios
                        aCTLCategorias.AdicionarCategoria(aCategoria);
                    else
                        aCTLCategorias.AtualizarCategoria(aCategoria);
                }
                Close();
            }
        }

        private void ConfirmarExclusaoCategoria()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ExcluirCategoria();
            }
        }


        private void ExcluirCategoria()
        {
            if (aCategoria != null)
            {
                try
                {
                    CTLCategorias aCTLCategorias = new CTLCategorias();
                    aCTLCategorias.ExcluirCategoria(aCategoria.Id);
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


        // Buttons

    }
}