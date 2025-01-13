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
    public class CTLItensLavanderia
    {
        private DALItensLavanderia itensLavanderiaDAL = new DALItensLavanderia();

        public void AdicionarItensLavanderia(ItensLavanderia itensLavanderia)
        {
            itensLavanderiaDAL.AdicionarItemLavanderia(itensLavanderia);
        }

        public void AtualizarItensLavanderia(ItensLavanderia itensLavanderia)
        {
            itensLavanderiaDAL.AtualizarItemLavanderia(itensLavanderia);
        }

        public void ExcluirItensLavanderia(int itensLavanderiaId)
        {
            itensLavanderiaDAL.ExcluirItemLavanderia(itensLavanderiaId);
        }

        public ItensLavanderia BuscarItensLavanderiaPorId(int id)
        {
            return itensLavanderiaDAL.BuscarItemLavanderiaPorId(id);
        }

        public List<ItensLavanderia> ListarItensLavanderia()
        {
            return itensLavanderiaDAL.ListarItensLavanderia();
        }

        public void Incluir()
        {
            FrmCadastroItensLavanderia frm = new FrmCadastroItensLavanderia();
            frm.Text = "Incluir Item de Lavanderia";
            frm.ShowDialog();
        }

        public void Alterar(ItensLavanderia itensLavanderia)
        {
            if (itensLavanderia != null)
            {
                FrmCadastroItensLavanderia frm = new FrmCadastroItensLavanderia();
                frm.ConhecaObj(itensLavanderia);
                frm.Text = "Alterar Item de Lavanderia";
                frm.CarregarCampos();
                frm.ShowDialog();
            }
        }

        public void Excluir(ItensLavanderia itensLavanderia)
        {
            if (itensLavanderia != null)
            {
                FrmCadastroItensLavanderia frm = new FrmCadastroItensLavanderia();
                frm.ConhecaObj(itensLavanderia);
                frm.Text = "Excluir Item de Lavanderia";
                frm.CarregarCampos();
                frm.BloquearCampos();
                frm.btnSalvar.Text = "Excluir";
                frm.ShowDialog();
            }
        }

        public void Visualizar(ItensLavanderia itensLavanderia)
        {
            if (itensLavanderia != null)
            {
                FrmCadastroItensLavanderia frm = new FrmCadastroItensLavanderia();
                frm.ConhecaObj(itensLavanderia);
                frm.Text = "Consultar Item de Lavanderia";
                frm.CarregarCampos();
                frm.BloquearCampos();
                frm.btnSalvar.Enabled = false;
                frm.ShowDialog();
            }
        }

        public List<ItensLavanderia> PesquisarItensLavanderiaPorCriterio(string criterio, string valorPesquisa)
        {
            return itensLavanderiaDAL.PesquisarItensLavanderiaPorCriterio(criterio, valorPesquisa);
        }
    }
}
