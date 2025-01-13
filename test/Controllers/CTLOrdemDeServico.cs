using System;
using System.Collections.Generic;
using test.Model;
using test.Data;
using test.Views.Cadastros;
using System.Linq;
using System.Data;
using Controle.Views.Cadastros;
using Controle.Model;
using System.Windows.Forms;
using test.Classes;
using static test.Views.FrmLogin;

namespace test.Controllers
{
    public class CTLOrdemDeServico
    {
        CTLUsuarios aCTLUsuarios = new CTLUsuarios();
        Usuarios usuarios = new Usuarios();

        private DALOrdemDeServico ordemDeServicoDAL = new DALOrdemDeServico();

        public void AdicionarOrdemDeServico(OrdemDeServico ordemDeServico, List<Fotos> fotos)
        {
            ordemDeServicoDAL.AdicionarOrdemDeServico(ordemDeServico, fotos);
        }
        public void FecharOS(OrdemDeServico ordemDeServico)
        {
            ordemDeServicoDAL.FecharOS(ordemDeServico);
        }
        public void ReabrirOS(OrdemDeServico ordemDeServico)
        {
            ordemDeServicoDAL.ReabrirOS(ordemDeServico);
        }
        public void AtualizarOrdemDeServico(OrdemDeServico ordemDeServico, List<Fotos> fotos, List<int> FotosExclusao)
        {
            try
            {
                // Chama o método na DAL para atualizar a ordem de serviço no banco de dados
                ordemDeServicoDAL.AtualizarOrdemDeServico(ordemDeServico, fotos, FotosExclusao);
            }
            catch (Exception ex)
            {
                // Trata qualquer exceção e mostra uma mensagem de erro
                MessageBox.Show("Erro ao atualizar ordem de serviço na controladora: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExcluirOrdemDeServico(int ordemDeServicoId)
        {
            ordemDeServicoDAL.ExcluirOrdemDeServico(ordemDeServicoId);
        }
        public OrdemDeServico BuscarOrdemDeServicoPorId(int id)
        {
            return ordemDeServicoDAL.BuscarOrdemDeServicoPorId(id);
        }
        public List<OrdemDeServico> ListarOrdensDeServico(DateTime? dataInicio, DateTime? dataFim, string status)
        {
            return ordemDeServicoDAL.ListarOrdensDeServico(dataInicio, dataFim, status);
        }
        public List<OrdemDeServico> ListarOrdensDeServicoPorSetor(DateTime? dataInicio, DateTime? dataFim, string status, int id, int? idUser)
        {
            return ordemDeServicoDAL.ListarOrdensDeServicoPorSetor(dataInicio, dataFim, status, id, idUser);
        }
        public List<OrdemDeServico> PesquisarOrdemDeServicoPorCriterio(string criterio, string valorPesquisa)
        {
            return ordemDeServicoDAL.PesquisarOsPorCriterio(criterio, valorPesquisa);
        }
        public List<OrdemDeServico> PesquisarOrdemDeServicoPorCriterioPorSetor(string criterio, string valorPesquisa,int? setor, int? idUser)
        {
            return ordemDeServicoDAL.PesquisarOsPorCriterioPorSetor(criterio, valorPesquisa, setor, idUser);
        }
        public DataTable GerarRelatorios(string procurar, int? idPatrimonio = null, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            return null;//ordemDeServicoDAL.GerarRelatorios(procurar, idPatrimonio, dataInicial, dataFinal);
        }
        public void Incluir()
        {
            FrmCadastroOrdemDeServico frmCadastroOrdemDeServico = new FrmCadastroOrdemDeServico();
            frmCadastroOrdemDeServico.Text = "Cadastrar Ordem de Serviço";
            frmCadastroOrdemDeServico.txtStatus.Text = "Aberto";
            frmCadastroOrdemDeServico.txtTicket.Enabled = false;
            frmCadastroOrdemDeServico.txtStatus.Enabled = false;
            frmCadastroOrdemDeServico.ShowDialog();
        }
        public void Alterar(OrdemDeServico ordemDeServico)
        {

            FrmCadastroOrdemDeServico frmCadastroOrdemDeServico = new FrmCadastroOrdemDeServico();
            if (ordemDeServico != null)
            {
                usuarios = aCTLUsuarios.BuscarUsuarioPorId(UserSession.User.Id);
                if (usuarios != null)
                {
                    if (usuarios.Perfil == "Admin" || (usuarios.Perfil == "Chefe"))
                    {
                        frmCadastroOrdemDeServico.txtTicket.Enabled = true;
                        frmCadastroOrdemDeServico.txtStatus.Enabled = true;
                        frmCadastroOrdemDeServico.cmbPrioridade.Enabled = true;
                    }
                    else
                    {
                        frmCadastroOrdemDeServico.txtTicket.Enabled = false;
                        frmCadastroOrdemDeServico.txtStatus.Enabled = false;
                        frmCadastroOrdemDeServico.cmbPrioridade.Enabled = false;
                    }
                }
                frmCadastroOrdemDeServico.ConhecaObj(ordemDeServico);
                if (ordemDeServico.Status == "Encerrado")
                {
                    frmCadastroOrdemDeServico.btnReabrir.Visible = true;
                    frmCadastroOrdemDeServico.btnFoto.Enabled = false;
                    frmCadastroOrdemDeServico.btnSalvar.Enabled = false;
                    frmCadastroOrdemDeServico.btnRemover.Enabled = false;
                    frmCadastroOrdemDeServico.txtDescricao.ReadOnly = true;
                    frmCadastroOrdemDeServico.txtTicket.ReadOnly = true;
                    frmCadastroOrdemDeServico.txtStatus.Enabled = false;
                }

                frmCadastroOrdemDeServico.Text = "Alterar Ordem de Serviço";
                frmCadastroOrdemDeServico.btnEncerrarOS.Visible = true;
                frmCadastroOrdemDeServico.CarregarCampos();
                frmCadastroOrdemDeServico.ShowDialog();
            }
        }
        public void Excluir(OrdemDeServico ordemDeServico)
        {
            if (ordemDeServico != null)
            {
                FrmCadastroOrdemDeServico frmCadastroOrdemDeServico = new FrmCadastroOrdemDeServico();
                frmCadastroOrdemDeServico.ConhecaObj(ordemDeServico);
                frmCadastroOrdemDeServico.Text = "Excluir Ordem de Serviço";
                frmCadastroOrdemDeServico.CarregarCampos();
                frmCadastroOrdemDeServico.BloquearCampos();
                frmCadastroOrdemDeServico.btnSalvar.Text = "Excluir";
                frmCadastroOrdemDeServico.btnSalvar.Enabled = true;
                frmCadastroOrdemDeServico.ShowDialog();
            }
        }
        public void Visualizar(OrdemDeServico ordemDeServico)
        {
            if (ordemDeServico != null)
            {
                FrmCadastroOrdemDeServico frmCadastroOrdemDeServico = new FrmCadastroOrdemDeServico();
                frmCadastroOrdemDeServico.ConhecaObj(ordemDeServico);
                frmCadastroOrdemDeServico.Text = "Consultar Ordem de Serviço";
                frmCadastroOrdemDeServico.CarregarCampos();
                frmCadastroOrdemDeServico.BloquearCampos();
                frmCadastroOrdemDeServico.txtDescricao.Enabled = true;
                frmCadastroOrdemDeServico.txtDescricao.ReadOnly = true;
                frmCadastroOrdemDeServico.btnSalvar.Enabled = false;
                frmCadastroOrdemDeServico.ShowDialog();
            }
        }
    }
}
