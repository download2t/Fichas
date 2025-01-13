using Controle.Views.Cadastros;
using Controle.Views.Consultas;
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
    public class CTLFuncionarios
    {
        private DALFuncionarios funcionariosDAL = new DALFuncionarios();

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionariosDAL.AdicionarFuncionario(funcionario);
        }

        public void AtualizarFuncionario(Funcionario funcionario)
        {
            funcionariosDAL.AtualizarFuncionario(funcionario);
        }

        public void ExcluirFuncionario(int funcionarioId)
        {
            funcionariosDAL.ExcluirFuncionario(funcionarioId);
        }

        public Funcionario BuscarFuncionarioPorId(int id)
        {
            return funcionariosDAL.BuscarFuncionarioPorId(id);
        }

        public List<Funcionario> ListarFuncionarios(string ativo)
        {
            return funcionariosDAL.ListarFuncionarios(ativo);
        }

        public void Incluir()
        {
            FrmCadastroFuncionarios frm = new FrmCadastroFuncionarios();
            frm.Text = "Incluir Funcionário";
            frm.ShowDialog();
        }

        public void Alterar(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                FrmCadastroFuncionarios frm = new FrmCadastroFuncionarios();
                frm.ConhecaObj(funcionario);
                frm.Text = "Alterar Funcionário";
                frm.CarregarCampos();
                frm.ShowDialog();
            }
        }

        public void Excluir(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                FrmCadastroFuncionarios frm = new FrmCadastroFuncionarios();
                frm.ConhecaObj(funcionario);
                frm.Text = "Excluir Funcionário";
                frm.CarregarCampos();
                frm.BloquearCampos();
                frm.btnSalvar.Text = "Excluir";
                frm.ShowDialog();
            }
        }

        public void Visualizar(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                FrmCadastroFuncionarios frm = new FrmCadastroFuncionarios();
                frm.ConhecaObj(funcionario);
                frm.Text = "Consultar Funcionário";
                frm.CarregarCampos();
                frm.BloquearCampos();
                frm.btnSalvar.Enabled = false;
                frm.ShowDialog();
            }
        }
        public void SelecionarControle(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                // Aqui você cria um objeto ControleGov com base no Funcionario
                ControleGov controleDoFuncionario = new ControleGov();
                controleDoFuncionario.Funcionarios.Id = funcionario.Id;
                controleDoFuncionario.Funcionarios.Nome = funcionario.Nome;
                FrmConsultaControleGov frm = new FrmConsultaControleGov();
                frm.ConhecaObj(controleDoFuncionario);
                frm.Text = "Consultar Controles do usuário.";
                frm.txtID.Text = funcionario.Nome;
                frm.ShowDialog();
            }
        }

        public List<Funcionario> PesquisarFuncionariosPorCriterio(string criterio, string valorPesquisa)
        {
            List<Funcionario> FuncionariosEncontrados = funcionariosDAL.PesquisarFuncionariosPorCriterio(criterio, valorPesquisa);
            return FuncionariosEncontrados;
        }
        public List<Funcionario> PesquisarFuncionariosPorCriterioSetor7(string criterio, string valorPesquisa)
        {
            try
            {
                // Realiza a pesquisa inicial
                List<Funcionario> funcionariosEncontrados = funcionariosDAL.PesquisarFuncionariosPorCriterio(criterio, valorPesquisa);

                // Filtra a lista para conter apenas funcionários do setor 7
                funcionariosEncontrados = funcionariosEncontrados.Where(func => func.Setor.Id== 7).ToList();

                return funcionariosEncontrados;
            }
            catch (Exception )
            {
                return new List<Funcionario>();
            }
        }


    }
}
