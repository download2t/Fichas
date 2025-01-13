using System;
using System.Collections.Generic;
using test.Classes;
using test.Data;
using test.Model;
using test.Views.Cadastros;

namespace test.Controllers
{
    public class CTLSenhas
    {
        private DALSenhas senhasDAL = new DALSenhas();

        public void AdicionarSenha(Senhas senha)
        {
            senhasDAL.AdicionarSenha(senha);
        }

        public void AtualizarSenha(Senhas senha)
        {
            senhasDAL.AtualizarSenha(senha);
        }

        public void ExcluirSenha(int senhaId)
        {
            senhasDAL.ExcluirSenha(senhaId);
        }

        public Senhas BuscarSenhaPorId(int id)
        {
            return senhasDAL.BuscarSenhaPorId(id);
        }

        public List<Senhas> ListarSenhas()
        {
            return senhasDAL.ListarSenhas();
        }
        public void Incluir()
        {
            FrmCadastroSenhas frmCadastro = new FrmCadastroSenhas();
            frmCadastro.Text = "Incluir Senha";
            frmCadastro.ShowDialog();
        }

        public void Alterar(Senhas senha)
        {
            if (senha != null)
            {
                FrmCadastroSenhas frmCadastro = new FrmCadastroSenhas();
                frmCadastro.ConhecaObj(senha);
                frmCadastro.Text = "Alterar Senha";
                frmCadastro.CarregarCampos();
                frmCadastro.ShowDialog();
            }
        }

        public void Excluir(Senhas senha)
        {
            if (senha != null)
            {
                FrmCadastroSenhas frmCadastro = new FrmCadastroSenhas();
                frmCadastro.ConhecaObj(senha);
                frmCadastro.Text = "Excluir Senha";
                frmCadastro.CarregarCampos();
                frmCadastro.BloquearCampos();
                frmCadastro.btnSalvar.Text = "Excluir";
                frmCadastro.ShowDialog();
            }
        }
        public void Visualizar(Senhas senha)
        {
            if (senha != null)
            {
                FrmCadastroSenhas frmCadastro = new FrmCadastroSenhas();
                frmCadastro.ConhecaObj(senha);
                frmCadastro.Text = "Consultar Senha";
                frmCadastro.CarregarCampos();
                frmCadastro.BloquearCampos();
                frmCadastro.btnSalvar.Enabled = false;
                frmCadastro.txtDescricao.ReadOnly = true;
                frmCadastro.ShowDialog();
            }
        }
        public List<Senhas> PesquisarSenhasPorCriterio(string criterio, string valorPesquisa)
        {
            List<Senhas> senhasEncontradas = senhasDAL.PesquisarSenhasPorCriterio(criterio, valorPesquisa);
            return senhasEncontradas;
        }


    }//
}
