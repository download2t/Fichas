using Controle.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Model;

namespace Controle.Views.Cadastros
{
    public partial class FrmOperacoesFolha : Form
    {
        CTLPontosM aCTLPontoM;
        PontosM oPontoM;
        public FrmOperacoesFolha()
        {
            InitializeComponent();
            aCTLPontoM = new CTLPontosM();
            oPontoM = new PontosM();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            
            var result = aCTLPontoM.GerarMes();
            if (result)
            {
                MessageBox.Show("Sucesso, registros criados.");
            }
            else
            {
                MessageBox.Show("Nenhum, registro foi criado.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtPontos.Text != "")
            {
                DialogResult result = MessageBox.Show("Deseja Excluir Todos os lançamentos do mês " + txtPontos.Text + "?", "confirmation", MessageBoxButtons.YesNo); ;
                if (result == DialogResult.Yes)
                {

                    Excluir();
                }
                else
                {
                    //Nada a fazer.
                }

            }
            else
            {
                MessageBox.Show("Digite o código para excluir.", "erro",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Excluir()
        {
            var campochave = txtPontos.Text;
            oPontoM.CodPontoM = campochave;
            var result = aCTLPontoM.ExcluirMensal(oPontoM.CodPontoM);
            if (result)
            {
                MessageBox.Show("O item selecionado foi excluído com sucesso.", "Exclusão concluída",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPontos.Text = "";
            }
            else
            {
                MessageBox.Show("Falha na exclusão");
            }

        }
    }
}
