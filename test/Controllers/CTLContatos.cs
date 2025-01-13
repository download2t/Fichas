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
    public class CTLContatos
    {
        private DALContatos contatosDAL = new DALContatos();

        public void AdicionarContato(Contatos contato)
        {
            contatosDAL.AdicionarContato(contato);
        }

        public void AtualizarContato(Contatos contato)
        {
            contatosDAL.AtualizarContato(contato);
        }

        public void ExcluirContato(int contatoId)
        {
            contatosDAL.ExcluirContato(contatoId);
        }

        public Contatos BuscarContatoPorId(int id)
        {
            return contatosDAL.BuscarContatoPorId(id);
        }

        public List<Contatos> ListarContatos()
        {
            return contatosDAL.ListarContatos();
        }


        public void Incluir()
        {
            FrmCadastroContatos frmCadastroContatos = new FrmCadastroContatos();
            frmCadastroContatos.Text = "Incluir Contato";
            frmCadastroContatos.ShowDialog();
        }

        public void Alterar(Contatos contato)
        {
            if (contato != null)
            {
                FrmCadastroContatos frmCadastroContatos = new FrmCadastroContatos();
                frmCadastroContatos.ConhecaObj(contato);
                frmCadastroContatos.Text = "Alterar Contato";
                frmCadastroContatos.CarregarCampos();
                frmCadastroContatos.ShowDialog();
            }
        }

        public void Excluir(Contatos contato)
        {
            if (contato != null)
            {
                FrmCadastroContatos frmCadastroContatos = new FrmCadastroContatos();
                frmCadastroContatos.ConhecaObj(contato);
                frmCadastroContatos.Text = "Excluir Contato";
                frmCadastroContatos.CarregarCampos();
                frmCadastroContatos.BloquearCampos();
                frmCadastroContatos.btnSalvar.Text = "Excluir";
                frmCadastroContatos.ShowDialog();
            }
        }

        public void Visualizar(Contatos contato)
        {
            if (contato != null)
            {
                FrmCadastroContatos frmCadastroContatos = new FrmCadastroContatos();
                frmCadastroContatos.ConhecaObj(contato);
                frmCadastroContatos.Text = "Consultar Contato";
                frmCadastroContatos.CarregarCampos();
                frmCadastroContatos.BloquearCampos();
                frmCadastroContatos.btnSalvar.Enabled = false;
                frmCadastroContatos.ShowDialog();
            }
        }

        public List<Contatos> PesquisarContatosPorCriterio(string criterio, string valorPesquisa)
        {
            List<Contatos> contatosEncontrados = contatosDAL.PesquisarContatosPorCriterio(criterio, valorPesquisa);
            return contatosEncontrados;
        }
    }
}

