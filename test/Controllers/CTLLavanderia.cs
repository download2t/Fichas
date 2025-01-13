using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Model;
using test.Views.Cadastros;

namespace test.Controllers
{
    public class CTLLavanderia
    {
        private DALLavanderia lavanderiaDAL = new DALLavanderia();

        public bool AdicionarLavanderia(Lavanderia lavanderia)
        {
            return lavanderiaDAL.AdicionarLavanderia(lavanderia);
        }

        public bool AtualizarLavanderia(Lavanderia lavanderia)
        {
            return lavanderiaDAL.AtualizarLavanderia(lavanderia);
        }

        public bool ExcluirLavanderia(int lavanderiaId)
        {
            return lavanderiaDAL.ExcluirLavanderia(lavanderiaId);
        }

        public Lavanderia BuscarLavanderiaPorId(int id)
        {
            return lavanderiaDAL.BuscarLavanderiaPorId(id);
        }

        public List<Lavanderia> ListarLavanderias(DateTime? dataInicio = null, DateTime? dataFim = null)
        {
            List<Lavanderia> lavanderia = lavanderiaDAL.ListarLavanderias(dataInicio, dataFim);
            return lavanderia;
        }
        public DataTable GerarRelatorios(DateTime? dataInicial = null, DateTime? dataFinal = null, int? codFuncionarios = null, int? codItem = null, string processo = null)
        {
            return lavanderiaDAL.RelatorioLavanderia(dataInicial, dataFinal, codFuncionarios, codItem, processo);
        }

        public void Incluir()
        {
            FrmCadastroLavanderia frm = new FrmCadastroLavanderia();
            frm.Text = "Incluir Lavanderia";
            frm.ShowDialog();
        }

        public void Alterar(Lavanderia lavanderia)
        {
            if (lavanderia != null)
            {
                FrmCadastroLavanderia frm = new FrmCadastroLavanderia();
                frm.ConhecaObj(lavanderia);
                frm.Text = "Alterar Lavanderia";
                frm.CarregarCampos();
                frm.ShowDialog();
            }
        }

        public void Excluir(Lavanderia lavanderia)
        {
            if (lavanderia != null)
            {
                FrmCadastroLavanderia frm = new FrmCadastroLavanderia();
                frm.ConhecaObj(lavanderia);
                frm.Text = "Excluir Lavanderia";
                frm.CarregarCampos();
                frm.BloquearCampos();
                frm.btnSalvar.Text = "Excluir";
                frm.ShowDialog();
            }
        }

        public void Visualizar(Lavanderia lavanderia)
        {
            if (lavanderia != null)
            {
                FrmCadastroLavanderia frm = new FrmCadastroLavanderia();
                frm.ConhecaObj(lavanderia);
                frm.Text = "Consultar Lavanderia";
                frm.CarregarCampos();
                frm.BloquearCampos();
                frm.btnSalvar.Enabled = false;
                frm.ShowDialog();
            }
        }

        public List<Lavanderia> PesquisarLavanderiasPorCriterio(string criterio, string valorPesquisa)
        {
            return lavanderiaDAL.PesquisarLavanderiasPorCriterio(criterio, valorPesquisa);
        }
    }
}
