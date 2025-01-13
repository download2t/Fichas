using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Model;
using test.Views.Cadastros;
using test.Views.Consultas;

namespace test.Controllers
{
    public class CTLMensagens
    {
        private DALMensagens mensagensDAL = new DALMensagens();

        public string AdicionarMensagem(Mensagens mensagem)
        {
           return  mensagensDAL.AdicionarMensagem(mensagem);
        }

        public string AtualizarMensagem(Mensagens mensagem)
        {
            return mensagensDAL.AtualizarMensagem(mensagem);
        }

        public bool ExcluirMensagem(int mensagemId)
        {
            return mensagensDAL.ExcluirMensagem(mensagemId);
        }

        public Mensagens BuscarMensagemPorId(int id)
        {
            return mensagensDAL.BuscarMensagemPorId(id);
        }
        public List<string> AdicionarEmLote(List<Mensagens> mensagens)
        {
            List<string> erros = new List<string>();

            try
            {
                foreach (var mensagem in mensagens)
                {
                    string resultado = mensagensDAL.AdicionarMensagem(mensagem);
                    if (resultado != "OK")
                    {
                        erros.Add($"Erro ao adicionar mensagem: {resultado}");
                    } 
                }
            }
            catch (Exception ex)
            {
                erros.Add($"Erro durante a operação de adição em lote: {ex.Message}");
            }

            return erros;
        }
        public bool ExcluirTodasMensagensPorContato(int contatoId)
        {
            try
            {
                return mensagensDAL.ExcluirTodasPorId(contatoId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir as mensagens: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<Mensagens> ListarMensagens(string criterioLista,string criterioPesquisa,string valorPesquisa, DateTime? dataInicio = null, DateTime? dataFim = null)
        {
            List<Mensagens> mensagens = mensagensDAL.ListarMensagens(criterioLista,criterioPesquisa,valorPesquisa,dataInicio,dataFim);

            return mensagens;
        }

        public void Incluir()
        {
            FrmCadastroMensagens frmCadastroMensagens = new FrmCadastroMensagens();
            frmCadastroMensagens.Text = "Incluir Mensagem";
            frmCadastroMensagens.ShowDialog();
        }

        public void Alterar(Mensagens mensagem)
        {
            if (mensagem != null)
            {
                FrmCadastroMensagens frmCadastroMensagens = new FrmCadastroMensagens();
                frmCadastroMensagens.Text = "Alterar Mensagem";
                frmCadastroMensagens.ConhecaObj(mensagem);
                frmCadastroMensagens.CarregarCampos();
                frmCadastroMensagens.ShowDialog();
            }
        }

        public void Excluir(Mensagens mensagem)
        {
            if (mensagem != null)
            {
                FrmCadastroMensagens frmCadastroMensagens = new FrmCadastroMensagens();
                frmCadastroMensagens.ConhecaObj(mensagem);
                frmCadastroMensagens.Text = "Excluir Mensagem";
                frmCadastroMensagens.CarregarCampos();
                frmCadastroMensagens.BloquearCampos();
                frmCadastroMensagens.btnSalvar.Text = "Excluir";
                frmCadastroMensagens.ShowDialog();
            }
        }

        public void Visualizar(Mensagens mensagem)
        {
            if (mensagem != null)
            {
                FrmCadastroMensagens frmCadastroMensagens = new FrmCadastroMensagens();
                frmCadastroMensagens.ConhecaObj(mensagem);
                frmCadastroMensagens.Text = "Consultar Mensagem";
                frmCadastroMensagens.CarregarCampos();
                frmCadastroMensagens.BloquearCampos();
                frmCadastroMensagens.btnSalvar.Enabled = false;
                frmCadastroMensagens.ShowDialog();
            }
        }
    }
}
