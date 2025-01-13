using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.DAL;
using test.Data;
using test.Model;
using test.Views.Cadastros;

namespace test.Controllers
{
    public class CTLBaixasPatrimonios
    {
        private DALBaixasPatrimoniais baixasDAL = new DALBaixasPatrimoniais();
        public void AtualizarBaixasPatrimonio(Patrimonios patrimonio)
        {
            byte[] foto = GetFoto(patrimonio.CaminhoFoto);

            if (foto == null)
                baixasDAL.AtualizarBaixaSemFoto(patrimonio);
            else
                baixasDAL.AtualizarBaixaPatrimonio(patrimonio);
        }
        public void DarBaixaPatrimonial(Patrimonios patrimonio)
        {
            baixasDAL.DarBaixaNoPatrimonio(patrimonio);
        }
        public void AlterarBaixas(Patrimonios patrimonio)
        {
            if (patrimonio != null)
            {
                FrmCadastroPatrimonios frmCadastroPatrimonios = new FrmCadastroPatrimonios();
                frmCadastroPatrimonios.ConhecaObj(patrimonio);
                frmCadastroPatrimonios.Text = "Alterar Baixas de patrimônio";
                frmCadastroPatrimonios.CarregarCampos();
                frmCadastroPatrimonios.BloquearCampos();
                frmCadastroPatrimonios.txtValor.Enabled = true;
                frmCadastroPatrimonios.btnBaixa.Enabled = true;
                frmCadastroPatrimonios.toolTip1.SetToolTip(frmCadastroPatrimonios.btnBaixa, "Restaurar patrimônio.");
                frmCadastroPatrimonios.btnBaixa.Text = "Recuperar Patrimônio";
                frmCadastroPatrimonios.btnBaixa.Visible = true;
                frmCadastroPatrimonios.ShowDialog();
            }
        }
        public void Visualizar(Patrimonios patrimonio)
        {
            if (patrimonio != null)
            {
                FrmCadastroPatrimonios frmCadastroPatrimonios = new FrmCadastroPatrimonios();
                frmCadastroPatrimonios.ConhecaObj(patrimonio);
                frmCadastroPatrimonios.Text = "Consultar Baixas de patrimônio";
                frmCadastroPatrimonios.CarregarCampos();
                frmCadastroPatrimonios.BloquearCampos();
                frmCadastroPatrimonios.ShowDialog();
            }
        }
        public Patrimonios BuscarBaixasPorId(int id)
        {
            return baixasDAL.BuscarBaixaPorId(id);
        }
        public List<Patrimonios> ListarBaixasPatrimonios()
        {
            return baixasDAL.ListarBaixasDePatrimonios();
        }
        public List<Patrimonios> PesquisarBaixaPorCriterio(string criterio, string valorPesquisa)
        {
            List<Patrimonios> patrimoniosEncontrados = baixasDAL.PesquisarBaixasPatrimoniosPorCriterio(criterio, valorPesquisa);
            return patrimoniosEncontrados;
        }
        public byte[] GetFoto(string caminhoFoto)
        {
            try
            {
                byte[] foto;
                using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        foto = reader.ReadBytes((int)stream.Length);
                    }
                }
                return foto;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;//a exeção é para ser ignorada.
            }

        }
    }
}
