using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using test.Model;
using test.Data;
using test.Views.Cadastros;
using System.Drawing;
using System.IO;
using System.Data;

namespace test.Controllers
{
    public class CTLPatrimonios
    {
        private DALPatrimonios patrimoniosDAL = new DALPatrimonios();

        public void AdicionarPatrimonio(Patrimonios patrimonio)
        {
            patrimoniosDAL.AdicionarPatrimonio(patrimonio);
        }

        public void AtualizarPatrimonio(Patrimonios patrimonio)
        {
            
            byte[] foto = patrimoniosDAL.GetFoto(patrimonio.CaminhoFoto);

            if (foto == null)
                patrimoniosDAL.AtualizarPatrimonioSemFoto(patrimonio);     
            else
                patrimoniosDAL.AtualizarPatrimonio(patrimonio);
        }
        public void ExcluirPatrimonio(int patrimonioId)
        {
            patrimoniosDAL.ExcluirPatrimonio(patrimonioId);
        }

        public Patrimonios BuscarPatrimonioPorId(int id)
        {
            return patrimoniosDAL.BuscarPatrimonioPorId(id);
        }

        public List<Patrimonios> ListarPatrimonios()
        {
            return patrimoniosDAL.ListarPatrimonios();
        }
        public DataTable GerarRelatorios(string categoria = null, string setor = null, string subcategoria = null, bool? status = null)
        {
            return patrimoniosDAL.Relatorios(categoria, setor, subcategoria, status);
        }
        public void Incluir()
        {
            FrmCadastroPatrimonios frmCadastroPatrimonios = new FrmCadastroPatrimonios();
            frmCadastroPatrimonios.Text = "Incluir Patrimonio";
            frmCadastroPatrimonios.ShowDialog();
        }

        public void Alterar(Patrimonios patrimonio)
        {
            if (patrimonio != null)
            {
                FrmCadastroPatrimonios frmCadastroPatrimonios = new FrmCadastroPatrimonios();
                frmCadastroPatrimonios.ConhecaObj(patrimonio);
                frmCadastroPatrimonios.Text = "Alterar Patrimonio";
                frmCadastroPatrimonios.CarregarCampos();
                frmCadastroPatrimonios.btnBaixa.Visible = true;
                frmCadastroPatrimonios.ShowDialog();
            }
        }


        public void Excluir(Patrimonios patrimonio)
        {
            if (patrimonio != null)
            {
                FrmCadastroPatrimonios frmCadastroPatrimonios = new FrmCadastroPatrimonios();
                frmCadastroPatrimonios.ConhecaObj(patrimonio);
                frmCadastroPatrimonios.Text = "Excluir Patrimonio";
                frmCadastroPatrimonios.CarregarCampos();
                frmCadastroPatrimonios.BloquearCampos();
                frmCadastroPatrimonios.btnSalvar.Text = "Excluir";
                frmCadastroPatrimonios.btnSalvar.Enabled = true;
                frmCadastroPatrimonios.ShowDialog();
            }
        }

        public void Visualizar(Patrimonios patrimonio)
        {
            if (patrimonio != null)
            {
                FrmCadastroPatrimonios frmCadastroPatrimonios = new FrmCadastroPatrimonios();
                frmCadastroPatrimonios.ConhecaObj(patrimonio);
                frmCadastroPatrimonios.Text = "Consultar Patrimonio";
                frmCadastroPatrimonios.CarregarCampos();
                frmCadastroPatrimonios.BloquearCampos();
                frmCadastroPatrimonios.btnSalvar.Enabled = false;
                frmCadastroPatrimonios.txtDescricao.Enabled = true;
                frmCadastroPatrimonios.txtDescricao.ReadOnly = true;
                frmCadastroPatrimonios.ShowDialog();
            }
        }
        public List<Patrimonios> PesquisarPatrimoniosPorCriterio(string criterio, string valorPesquisa)
        {
            List<Patrimonios> patrimoniosEncontrados = patrimoniosDAL.PesquisarPatrimoniosPorCriterio(criterio, valorPesquisa);
            return patrimoniosEncontrados;
        }

        
    }
}
