using System;
using System.Collections.Generic;
using test.Model;
using test.Data;
using test.Views.Cadastros;
using System.Linq;
using System.Data;

namespace test.Controllers
{
    public class CTLManutencao
    {
        private DALManutencao manutencaoDAL = new DALManutencao();

        public void AdicionarManutencao(Manutencao manutencao)
        {
            manutencaoDAL.AdicionarManutencao(manutencao);
        }

        public void AtualizarManutencao(Manutencao manutencao)
        {
            manutencaoDAL.AtualizarManutencao(manutencao);
        }

        public void ExcluirManutencao(int manutencaoId)
        {
            manutencaoDAL.ExcluirManutencao(manutencaoId);
        }

        public Manutencao BuscarManutencaoPorId(int id)
        {
            return manutencaoDAL.BuscarManutencaoPorId(id);
        }

        public List<Manutencao> ListarManutencoes(DateTime? dataInicio = null, DateTime? dataFim = null)
        {
            List<Manutencao> manutencoes = manutencaoDAL.ListarManutencoes();

            if (dataInicio.HasValue && dataFim.HasValue)
            {
                // Filtra as manutenções com base nas datas, se fornecidas
                manutencoes = manutencoes.Where(manutencao => manutencao.DataReparo >= dataInicio.Value && manutencao.DataReparo <= dataFim.Value).ToList();
            }

            return manutencoes;
        }
        public List<Manutencao> PesquisarManutencaoPorCriterio(string criterio, string valorPesquisa)
        {
            return manutencaoDAL.PesquisarManutencoesPorCriterio(criterio, valorPesquisa);
        }
        public DataTable GerarRelatorios(string procurar, int? idPatrimonio = null, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            return manutencaoDAL.RelatorioManutencao(procurar,idPatrimonio, dataInicial, dataFinal);
        }

        public void Incluir()
        {
            FrmCadastroManutencao frmCadastromanutencao = new FrmCadastroManutencao();
            frmCadastromanutencao.Text = "Incluir Manutenção";
            frmCadastromanutencao.ShowDialog();
        }

        public void Alterar(Manutencao manutencao)
        {
            if (manutencao != null)
            {
                FrmCadastroManutencao frmCadastromanutencao = new FrmCadastroManutencao();
                frmCadastromanutencao.Text = "Alterar Manutenção";
                frmCadastromanutencao.ConhecaObj(manutencao);
                frmCadastromanutencao.CarregarCampos();
                frmCadastromanutencao.ShowDialog();
            }
        }


        public void Excluir(Manutencao manutencao)
        {
            if (manutencao != null)
            {
                FrmCadastroManutencao frmCadastroManutencao = new FrmCadastroManutencao();
                frmCadastroManutencao.ConhecaObj(manutencao);
                frmCadastroManutencao.Text = "Excluir Manutenção";
                frmCadastroManutencao.CarregarCampos();
                frmCadastroManutencao.BloquearCampos();
                frmCadastroManutencao.btnSalvar.Text = "Excluir";
                frmCadastroManutencao.btnSalvar.Enabled = true;
                frmCadastroManutencao.ShowDialog();
            }
        }

        public void Visualizar(Manutencao manutencao)
        {
            if (manutencao != null)
            {
                FrmCadastroManutencao frmCadastroManutencao = new FrmCadastroManutencao();
                frmCadastroManutencao.ConhecaObj(manutencao);
                frmCadastroManutencao.Text = "Consultar Manutenção";
                frmCadastroManutencao.CarregarCampos();
                frmCadastroManutencao.BloquearCampos();
                frmCadastroManutencao.btnSalvar.Enabled = false;
                frmCadastroManutencao.txtDescricao.Enabled = true;
                frmCadastroManutencao.txtDescricao.ReadOnly = true;
                frmCadastroManutencao.ShowDialog();
            }
        }

    }
}