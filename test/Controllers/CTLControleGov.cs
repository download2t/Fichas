using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Model;
using test.Views.Cadastros;

namespace test.Controllers
{
    public class CTLControleGov
    {
        private DALControleGov controleGovDAL = new DALControleGov();

        public string AdicionarControleGov(ControleGov ControleGov)
        {
            return controleGovDAL.AdicionarControleGov(ControleGov);
        }

        public string AtualizarControleGov(ControleGov ControleGov)
        {
            return controleGovDAL.AtualizarControleGov(ControleGov);
        }

        public bool ExcluirControleGov(int controleID)
        {
            return controleGovDAL.ExcluirControleGov(controleID);
        }

        public ControleGov BuscarControleGovPorId(int id)
        {
            return controleGovDAL.BuscarControleGovPorID(id);
        }

        public List<ControleGov> ListarControleGov()
        {
            return controleGovDAL.ListarControleGov();
        }
        public List<ControleGov> ListarControleGov(DateTime? dataInicio = null, DateTime? dataFim = null, string nome = "")
        {
            // Chama o método da camada de acesso a dados para buscar os registros diretamente do banco de dados
            List<ControleGov> controle = controleGovDAL.ListarControleGov(dataInicio, dataFim, nome);

            return controle;
        }


        public void Incluir(ControleGov controle)
        {

            if (controle != null)
            {
                FrmCadastroControleGov frmCadastroControleGov = new FrmCadastroControleGov();
                frmCadastroControleGov.Text = "Incluir Controle Governamental";
                frmCadastroControleGov.txtCodFuncionario.Text = controle.Funcionarios.Id.ToString();
                frmCadastroControleGov.txtFuncionario.Text = controle.Funcionarios.Nome.ToString();
                frmCadastroControleGov.ShowDialog();
            }

           
        }

        public void Alterar(ControleGov ControleGov)
        {
            if (ControleGov != null)
            {
                FrmCadastroControleGov frmCadastroControleGov = new FrmCadastroControleGov();
                frmCadastroControleGov.Text = "Alterar Controle Governamental";
                frmCadastroControleGov.ConhecaObj(ControleGov);
                frmCadastroControleGov.CarregarCampos();
                frmCadastroControleGov.ShowDialog();
            }
        }

        public void Excluir(ControleGov ControleGov)
        {
            if (ControleGov != null)
            {
                FrmCadastroControleGov frmCadastroControleGov = new FrmCadastroControleGov();
                frmCadastroControleGov.ConhecaObj(ControleGov);
                frmCadastroControleGov.Text = "Excluir Controle Governamental";
                frmCadastroControleGov.CarregarCampos();
                frmCadastroControleGov.BloquearCampos();
                frmCadastroControleGov.btnSalvar.Text = "Excluir";
                frmCadastroControleGov.btnSalvar.Enabled = true;
                frmCadastroControleGov.ShowDialog();
            }
        }

        public void Visualizar(ControleGov ControleGov)
        {
            if (ControleGov != null)
            {
                FrmCadastroControleGov frmCadastroControleGov = new FrmCadastroControleGov();
                frmCadastroControleGov.ConhecaObj(ControleGov);
                frmCadastroControleGov.Text = "Consultar Controle Governamental";
                frmCadastroControleGov.CarregarCampos();
                frmCadastroControleGov.BloquearCampos();
                frmCadastroControleGov.btnSalvar.Enabled = false;
                frmCadastroControleGov.ShowDialog();
            }
        }

        /* public List<ControleGov> PesquisarControleGovPorCriterio(string criterio, string valorPesquisa)
         {
             return controleGovDAL.PesquisarControleGovPorCriterio(criterio, valorPesquisa);
         }*/

        // Se houver necessidade, adicione outros métodos conforme necessário
    }
}
