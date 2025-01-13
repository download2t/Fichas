using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Model;
using test.Views.Cadastros;

namespace test.Controllers
{
    public class CTLSetores
    {
        private DALSetores setoresDAL = new DALSetores();

        public void AdicionarSetor(Setores setor)
        {
            setoresDAL.AdicionarSetor(setor);
        }

        public void AtualizarSetor(Setores setor)
        {
            setoresDAL.AtualizarSetor(setor);
        }

        public void ExcluirSetor(int setorId)
        {
            setoresDAL.ExcluirSetor(setorId);
        }

        public Setores BuscarSetorPorId(int id)
        {
            return setoresDAL.BuscarSetorPorId(id);
        }

        public List<Setores> ListarSetores()
        {
            return setoresDAL.ListarSetores();
        }

        public void Incluir()
        {
            FrmCadastroSetores frmCadastroSetores = new FrmCadastroSetores();
            frmCadastroSetores.Text = "Incluir Setor";
            frmCadastroSetores.ShowDialog();
        }

        public void Alterar(Setores setor)
        {
            if (setor != null)
            {
                FrmCadastroSetores frmCadastroSetores = new FrmCadastroSetores();
                frmCadastroSetores.ConhecaObj(setor);
                frmCadastroSetores.Text = "Alterar Setor";
                frmCadastroSetores.CarregarCampos();
                frmCadastroSetores.ShowDialog();
            }
        }

        public void Excluir(Setores setor)
        {
            if (setor != null)
            {
                FrmCadastroSetores frmCadastroSetores = new FrmCadastroSetores();
                frmCadastroSetores.ConhecaObj(setor);
                frmCadastroSetores.Text = "Excluir Setor";
                frmCadastroSetores.CarregarCampos();
                frmCadastroSetores.BloquearCampos();
                frmCadastroSetores.btnSalvar.Text = "Excluir";
                frmCadastroSetores.ShowDialog();
            }
        }

        public void Visualizar(Setores setor)
        {
            if (setor != null)
            {
                FrmCadastroSetores frmCadastroSetores = new FrmCadastroSetores();
                frmCadastroSetores.ConhecaObj(setor);
                frmCadastroSetores.Text = "Consultar Setor";
                frmCadastroSetores.CarregarCampos();
                frmCadastroSetores.BloquearCampos();
                frmCadastroSetores.btnSalvar.Enabled = false;                       
                frmCadastroSetores.ShowDialog();
            }
        }
        public List<Setores> PesquisarSetorPorCriterio(string criterio, string valorPesquisa)
        {
            List<Setores> setoresEncontrados = new List<Setores>();

            if (criterio == "ID")
            {
                // Pesquisar por ID
                if (int.TryParse(valorPesquisa, out int id))
                {
                    Setores setor = BuscarSetorPorId(id);
                    if (setor != null)
                    {
                        setoresEncontrados.Add(setor);
                    }
                }
            }
            else if (criterio == "Setor")
            {

                setoresEncontrados = setoresDAL.BuscarSetorPorNome(valorPesquisa);
            }

            return setoresEncontrados;
        }
    }
}
