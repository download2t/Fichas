using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Views.Cadastros;

namespace test.Controllers
{
    public class FichasController
    {
        private FichasDAO fichasDAO = new FichasDAO();

        public void AdicionarFicha(Fichas ficha)
        {
            fichasDAO.AdicionarFicha(ficha);
        }

        public void AtualizarFicha(Fichas ficha)
        {
            fichasDAO.AtualizarFicha(ficha);
        }

        public void ExcluirFicha(int fichaId)
        {
            fichasDAO.ExcluirFicha(fichaId);
        }

        public Fichas BuscarFichaPorId(int id)
        {
            return fichasDAO.BuscarFichaPorId(id);
        }

        public List<Fichas> ListarFichas()
        {
            return fichasDAO.ListarFichas();
        }

        public void Incluir()
        {
            FrmCadastroFichas frmCadastroFichas = new FrmCadastroFichas();
            frmCadastroFichas.ShowDialog();
        }

        public void Alterar(Fichas ficha)
        {
            if (ficha != null)
            {
                FrmCadastroFichas frmCadastroFichas = new FrmCadastroFichas();
                frmCadastroFichas.ConhecaObj(ficha);
                frmCadastroFichas.CarregarCampos();
                frmCadastroFichas.ShowDialog();
            }
        }

        public void Excluir(Fichas ficha)
        {
            if (ficha != null)
            {
                FrmCadastroFichas frmCadastroFichas = new FrmCadastroFichas();
                frmCadastroFichas.ConhecaObj(ficha);
                frmCadastroFichas.CarregarCampos();
                frmCadastroFichas.BloquearCampos();
                frmCadastroFichas.btnSalvar.Text = "Excluir";
                frmCadastroFichas.ShowDialog();
            }
        }
        public void Visualizar(Fichas ficha)
        {
            if (ficha != null)
            {
                FrmCadastroFichas frmCadastroFichas = new FrmCadastroFichas();
                frmCadastroFichas.ConhecaObj(ficha);
                frmCadastroFichas.CarregarCampos();
                frmCadastroFichas.BloquearCampos();
                frmCadastroFichas.btnSalvar.Enabled = false;
                frmCadastroFichas.ShowDialog();
            }
        }
        public List<Fichas> PesquisarFichasPorCriterio(string criterio, string valorPesquisa)
        {
            List<Fichas> fichasEncontradas = new List<Fichas>();

            if (criterio == "ID")
            {
                // Pesquisar por ID
                if (int.TryParse(valorPesquisa, out int id))
                {
                    Fichas ficha = BuscarFichaPorId(id);
                    if (ficha != null)
                    {
                        fichasEncontradas.Add(ficha);
                    }
                }
            }
            else if (criterio == "Usuario")
            {
                // Pesquisar por Usuário
                fichasEncontradas = fichasDAO.PesquisarFichasPorUsuario(valorPesquisa);
            }
            else if (criterio == "Clientes")
            {
                // Pesquisar por Clientes
                fichasEncontradas = fichasDAO.PesquisarFichasPorClientes(valorPesquisa);
            }

            return fichasEncontradas;
        }

    }
}
