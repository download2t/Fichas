using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Views.Cadastros;

namespace test.Controllers
{
    public class CTLFichas
    {
        private DALFichas fichasDAL = new DALFichas();

        public void AdicionarFicha(Fichas ficha)
        {
            fichasDAL.AdicionarFicha(ficha);
        }

        public void AtualizarFicha(Fichas ficha)
        {

            fichasDAL.AtualizarFicha(ficha);
        }

        public void ExcluirFicha(int fichaId)
        {
            fichasDAL.ExcluirFicha(fichaId);
        }

        public Fichas BuscarFichaPorId(int id)
        {
            return fichasDAL.BuscarFichaPorId(id);
        }

        public List<Fichas> ListarFichas(DateTime? dataInicio = null, DateTime? dataFim = null)
        {
            List<Fichas> fichas = fichasDAL.ListarFichas();

            if (dataInicio.HasValue && dataFim.HasValue)
            {
                // Filtra as fichas com base nas datas, se fornecidas
                fichas = fichas.Where(ficha => ficha.DataCriacao >= dataInicio.Value && ficha.DataCriacao <= dataFim.Value).ToList();
            }

            return fichas;
        }
        public DataTable GerarRelatorios(int? idUsuario = null, int? idCliente = null, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            return fichasDAL.RelatorioFichas(idUsuario, idCliente, dataInicial, dataFinal);
        }

        public void Incluir()
        {
            FrmCadastroFichas frmCadastroFichas = new FrmCadastroFichas();
            frmCadastroFichas.Text = "Incluir Ficha";
            frmCadastroFichas.ShowDialog();
        }

        public void Alterar(Fichas ficha)
        {
            if (ficha != null)
            {
                FrmCadastroFichas frmCadastroFichas = new FrmCadastroFichas();
                frmCadastroFichas.ConhecaObj(ficha);
                frmCadastroFichas.Text = "Alterar Ficha";
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
                frmCadastroFichas.Text = "Excluir Ficha";
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
                frmCadastroFichas.Text = "Consultar Ficha";
                frmCadastroFichas.CarregarCampos();
                frmCadastroFichas.BloquearCampos();
                frmCadastroFichas.btnSalvar.Enabled = false;
                frmCadastroFichas.txtDescricao.ReadOnly = true;
                frmCadastroFichas.ShowDialog();
            }
        }
        public List<Fichas> PesquisarFichasPorCriterio(string criterio, string valorPesquisa)
        {
            List<Fichas> fichasEncontradas = fichasDAL.PesquisarFichasPorCriterio(criterio, valorPesquisa);
            return fichasEncontradas;
        }


    }
}
