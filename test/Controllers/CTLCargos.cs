using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Views.Cadastros;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace test.Controllers
{
    public class CTLCargos
    {

        private DALCargos cargosDAL = new DALCargos();

        public void AdicionarCargo(Cargo cargo)
        {
            cargosDAL.AdicionarCargo(cargo);
        }

        public void AtualizarCargo(Cargo cargo)
        {
            cargosDAL.AtualizarCargo(cargo);
        }

        public void ExcluirCargo(int cargoId)
        {
            cargosDAL.ExcluirCargo(cargoId);
        }

        public Cargo BuscarCargoPorId(int id)
        {
            return cargosDAL.BuscarCargoPorId(id);
        }

        public List<Cargo> ListarCargos()
        {
            return cargosDAL.ListarCargos();
        }


        public void Incluir()
        {
            FrmCadastroCargos frm = new FrmCadastroCargos();
            frm.Text = "Incluir Cargo";
            frm.ShowDialog();
        }

        public void Alterar(Cargo cargo)
        {
            if (cargo != null)
            {
                FrmCadastroCargos frm = new FrmCadastroCargos();
                frm.ConhecaObj(cargo);
                frm.Text = "Alterar Cargo";
                frm.CarregarCampos();
                frm.ShowDialog();
            }
        }

        public void Excluir(Cargo cargo)
        {
            if (cargo != null)
            {
                FrmCadastroCargos frm = new FrmCadastroCargos();
                frm.ConhecaObj(cargo);
                frm.Text = "Excluir Cargo";
                frm.CarregarCampos();
                frm.BloquearCampos();
                frm.btnSalvar.Text = "Excluir";
                frm.ShowDialog();
            }
        }

        public void Visualizar(Cargo cargo)
        {
            if (cargo != null)
            {
                FrmCadastroCargos frm = new FrmCadastroCargos();
                frm.ConhecaObj(cargo);
                frm.Text = "Consultar Cargo";
                frm.CarregarCampos();
                frm.BloquearCampos();
                frm.btnSalvar.Enabled = false;
                frm.ShowDialog();
            }
        }

        public List<Cargo> PesquisarCargosPorCriterio(string criterio, string valorPesquisa)
        {
            List<Cargo> cargoEncontrado = new List<Cargo>();

            if (criterio == "Pontos")
            {
                cargoEncontrado = cargosDAL.BuscarCargosPorPontos(valorPesquisa);
            }
            else if (criterio == "Cargos")
            {
                cargoEncontrado = cargosDAL.BuscarCargosPorNome(valorPesquisa);
            }

            return cargoEncontrado;
        }

    }
}
