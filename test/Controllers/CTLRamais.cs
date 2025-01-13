using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Controle.Models;
using Controle.DAL;
using Controle.Views.Cadastros;

namespace Controle.Controllers
{
    public class CTLRamais
    {
        private DALRamais ramaisDAL = new DALRamais();

        public void AdicionarRamal(Ramal ramal)
        {
            ramaisDAL.AdicionarRamal(ramal);
        }

        public void AtualizarRamal(Ramal ramal)
        {
            ramaisDAL.AtualizarRamal(ramal);
        }

        public void ExcluirRamal(int ramalId)
        {
            ramaisDAL.ExcluirRamal(ramalId);
        }

        public Ramal BuscarRamalPorId(int id)
        {
            return ramaisDAL.BuscarRamalPorId(id);
        }

        public List<Ramal> ListarRamais()
        {
            return ramaisDAL.ListarRamais();
        }
        public List<Ramal> PesquisarRamal(string valorPesquisa)
        {
            List<Ramal> ramaisEncontrados = ramaisDAL.PesquisarRamal(valorPesquisa);
            return ramaisEncontrados;
        }
        public void Incluir()
        {
            FrmCadastroRamais frmCadastroRamais = new FrmCadastroRamais();
            frmCadastroRamais.Text = "Incluir Ramal";
            frmCadastroRamais.ShowDialog();
        }

        public void Alterar(Ramal ramal)
        {
            if (ramal != null)
            {
                FrmCadastroRamais frmCadastroRamais = new FrmCadastroRamais();
                frmCadastroRamais.ConhecaObj(ramal);
                frmCadastroRamais.Text = "Alterar Ramal";
                frmCadastroRamais.CarregarCampos();
                frmCadastroRamais.ShowDialog();
            }
        }

        public void Excluir(Ramal ramal)
        {
            if (ramal != null)
            {
                FrmCadastroRamais frmCadastroRamais = new FrmCadastroRamais();
                frmCadastroRamais.ConhecaObj(ramal);
                frmCadastroRamais.Text = "Excluir Ramal";
                frmCadastroRamais.CarregarCampos();
                frmCadastroRamais.BloquearCampos();
                frmCadastroRamais.btnSalvar.Text = "Excluir";
                frmCadastroRamais.ShowDialog();
            }
        }

        public void Visualizar(Ramal ramal)
        {
            if (ramal != null)
            {
                FrmCadastroRamais frmCadastroRamais = new FrmCadastroRamais();
                frmCadastroRamais.ConhecaObj(ramal);
                frmCadastroRamais.Text = "Consultar Ramal";
                frmCadastroRamais.CarregarCampos();
                frmCadastroRamais.BloquearCampos();
                frmCadastroRamais.btnSalvar.Enabled = false;
                frmCadastroRamais.ShowDialog();
            }
        }

      
    }
}
