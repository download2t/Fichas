using Controle.Views.Consultas;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;

namespace Controle.Views.Relatorios.Forms
{
    public partial class FrmRelLavanderia : Controle.Views.Relatorios.Forms.FrmRelatoriosPai
    {
        CTLLavanderia aCTLLavanderia;
        Lavanderia aLavanderia;
        int contador = 0;
        public FrmRelLavanderia()
        {
            InitializeComponent();
            aCTLLavanderia = new CTLLavanderia();
            aLavanderia = new Lavanderia();
        }
        private void HabilitarItensLavanderia(bool valor)
        {
            txtCodItemLavanderia.Enabled = valor;
            btnPesquisarLavanderia.Enabled = valor;

            if (valor)
            {
                contador += 1; // Adiciona 1 quando ativado
            }
            else
            {
                contador -= 1; // Subtrai 1 quando desativado
                txtCodItemLavanderia.Clear();
                txtItemLavanderia.Clear();
            }
        }

        private void HabilitarFuncionarios(bool valor)
        {
            txtCodFuncionario.Enabled = valor;
            btnPesquisarFuncionario.Enabled = valor;

            if (valor)
            {
                contador += 2; // Adiciona 2 quando ativado
            }
            else
            {
                contador -= 2; // Subtrai 2 quando desativado
                txtCodFuncionario.Clear();
                txtFuncionario.Clear();
            }
        }

        private void cbItemLavanderia_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarItensLavanderia(cbItemLavanderia.Checked);
            AtualizarEstadoBtnGerar();
        }

        private void cbFuncionarios_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarFuncionarios(cbFuncionarios.Checked);
            AtualizarEstadoBtnGerar();
        }

        private void cbProcessos_CheckedChanged(object sender, EventArgs e)
        {
            bool valor = cbProcessos.Checked;
            cmbProcesso.Enabled = valor;

            if (valor)
            {
                contador += 4; // Adiciona 4 quando ativado
            }
            else
            {
                contador -= 4; // Subtrai 4 quando desativado
                cmbProcesso.SelectedIndex = -1;
            }
            AtualizarEstadoBtnGerar();
        }

        private void AtualizarEstadoBtnGerar()
        {
            // Habilita o botão Gerar se o contador for maior que 0
            btnGerar.Enabled = contador > 0;
        }

        protected override void GerarRelatorio()
        {

            // Validar campos antes de prosseguir
            if (!ValidarCampos())
            {
                return;
            }

            DataTable dt = ObterDadosRelatorio(null, null, null, null);
            if (dt.Rows.Count > 0)
                ExibirRelatorio(dt);
            else
            {
                MessageBox.Show("a Busca não encontrou nenhum resultado!");
            }
        }
        private void ExibirRelatorio(DataTable dt)
        {
            if (dt != null)
            {
                FrmRelatorio frmRelatorio = new FrmRelatorio();
                frmRelatorio.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle.Views.Relatorios.RDLC.Rel_Lavanderia.rdlc";
                frmRelatorio.reportViewer1.LocalReport.DataSources.Clear();
                frmRelatorio.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                frmRelatorio.reportViewer1.RefreshReport();
                frmRelatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro inesperado.");
            }
        }
        private bool ValidarCampos()
        {
            DateTime? dataInicio = null;
            DateTime? dataFim = null;

            if (DataInicio.Value.Date > DateTime.MinValue.Date)
            {
                if (DataFim.Value.Date > DateTime.MinValue.Date)
                {
                    if (DataInicio.Value.Date <= DataFim.Value.Date)
                    {
                        dataInicio = DataInicio.Value.Date;
                        dataFim = DataFim.Value.Date;
                    }
                    else
                    {
                        MessageBox.Show("A data de início deve ser anterior à data de término.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma data de término.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (DataFim.Value.Date > DateTime.MinValue.Date)
            {
                MessageBox.Show("Selecione uma data de início.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbItemLavanderia.Checked && string.IsNullOrEmpty(txtCodItemLavanderia.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de texto para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbFuncionarios.Checked && string.IsNullOrEmpty(txtCodFuncionario.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de texto para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbProcessos.Checked && string.IsNullOrEmpty(cmbProcesso.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de texto para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private DataTable ObterDadosRelatorio(DateTime? dataInicial = null, DateTime? dataFinal = null, int? codFuncionarios = null, int? codItem = null, string processo = null)
        {
            // Verifica se as datas foram fornecidas
            dataInicial = DataInicio.Value.Date;
            dataFinal = DataFim.Value.Date;

            if (dataInicial > dataFinal)
            {
                MessageBox.Show("A data inicial deve ser anterior ou igual à data final",
                    "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            DataTable dt = new DataTable();

            switch (contador)
            {
                case 1: // Itens da lavanderia
                    if (int.TryParse(txtCodItemLavanderia.Text, out int itemCode))
                    {
                        codItem = itemCode;
                        dt = aCTLLavanderia.GerarRelatorios(dataInicial, dataFinal, null, codItem, null);
                    }
                    else
                    {
                        MessageBox.Show("Código do item inválido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 2: // Funcionários
                    if (int.TryParse(txtCodFuncionario.Text, out int funcionarioCode))
                    {
                        codFuncionarios = funcionarioCode;
                        dt = aCTLLavanderia.GerarRelatorios(dataInicial, dataFinal, codFuncionarios, null, null);
                    }
                    else
                    {
                        MessageBox.Show("Código do funcionário inválido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 3: // Itens da lavanderia + Funcionários
                    if (int.TryParse(txtCodItemLavanderia.Text, out itemCode) && int.TryParse(txtCodFuncionario.Text, out funcionarioCode))
                    {
                        codItem = itemCode;
                        codFuncionarios = funcionarioCode;
                        dt = aCTLLavanderia.GerarRelatorios(dataInicial, dataFinal, codFuncionarios, codItem, null);
                    }
                    else
                    {
                        MessageBox.Show("Código do item ou do funcionário inválido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 4: // Processo
                    processo = cmbProcesso.Text.Trim(); // Remove espaços em branco ao redor do valor
                    if (!string.IsNullOrEmpty(processo))
                    {
                        dt = aCTLLavanderia.GerarRelatorios(dataInicial, dataFinal, null, null, processo);
                    }
                    else
                    {
                        MessageBox.Show("Selecione um processo válido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 5: // Processo + Itens da lavanderia
                    processo = cmbProcesso.Text.Trim(); // Remove espaços em branco ao redor do valor
                    if (int.TryParse(txtCodItemLavanderia.Text, out itemCode) && !string.IsNullOrEmpty(processo))
                    {
                        codItem = itemCode;
                        dt = aCTLLavanderia.GerarRelatorios(dataInicial, dataFinal, null, codItem, processo);
                    }
                    else
                    {
                        MessageBox.Show("Código do item ou processo inválido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 6: // Processo + Funcionários
                    processo = cmbProcesso.Text.Trim(); // Remove espaços em branco ao redor do valor
                    if (int.TryParse(txtCodFuncionario.Text, out funcionarioCode) && !string.IsNullOrEmpty(processo))
                    {
                        codFuncionarios = funcionarioCode;
                        dt = aCTLLavanderia.GerarRelatorios(dataInicial, dataFinal, codFuncionarios, null, processo);
                    }
                    else
                    {
                        MessageBox.Show("Código do funcionário ou processo inválido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 7: // Processo + Itens da lavanderia + Funcionários
                    processo = cmbProcesso.Text.Trim(); // Remove espaços em branco ao redor do valor
                    if (int.TryParse(txtCodItemLavanderia.Text, out itemCode) && int.TryParse(txtCodFuncionario.Text, out funcionarioCode) && !string.IsNullOrEmpty(processo))
                    {
                        codItem = itemCode;
                        codFuncionarios = funcionarioCode;
                        dt = aCTLLavanderia.GerarRelatorios(dataInicial, dataFinal, codFuncionarios, codItem, processo);
                    }
                    else
                    {
                        MessageBox.Show("Código do item, do funcionário ou processo inválido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Contador inválido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            return dt;
        }

        private void txtCodItemLavanderia_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "Salvar" como botão padrão
        }

        private void txtCodItemLavanderia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        private void txtCodItemLavanderia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodItemLavanderia.Text))
            {
                LimparLav();
            }
            else if (int.TryParse(txtCodItemLavanderia.Text, out int cod) && cod > 0)
            {
                CTLLavanderia aCTLLavanderia = new CTLLavanderia();
                Lavanderia Valida = aCTLLavanderia.BuscarLavanderiaPorId(cod);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparLav();
                }
                else
                {
                    txtItemLavanderia.Text = Valida.ItensLavanderia.Nome;
                }
            }
            else
            {

                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparLav();

            }
            this.AcceptButton = btnGerar; // Restaura o botão "Salvar" como botão padrão
        }
        private void LimparFunc()
        {
            txtCodFuncionario.Clear();
            txtFuncionario.Clear();
        }
        private void LimparLav()
        {
            txtCodItemLavanderia.Clear();
            txtItemLavanderia.Clear();

        }
        private void txtCodFuncionario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodFuncionario.Text))
            {
                LimparFunc();
            }
            else if (int.TryParse(txtCodFuncionario.Text, out int cod) && cod > 0)
            {
                CTLFuncionarios aCTLFuncionario = new CTLFuncionarios();
                Funcionario Valida = aCTLFuncionario.BuscarFuncionarioPorId(cod);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparFunc();
                }
                else
                {
                    txtFuncionario.Text = Valida.Nome;
                }
            }
            else
            {

                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparFunc();

            }
            this.AcceptButton = btnGerar; // Restaura o botão "Salvar" como botão padrão
        }

        private void btnPesquisarLavanderia_Click(object sender, EventArgs e)
        {
            using (FrmConsultaItensLavanderia frm = new FrmConsultaItensLavanderia())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodItemLavanderia.Text = IdSelecionado.ToString();
                txtItemLavanderia.Text = NomeSelecionado;
                txtCodItemLavanderia_Leave(txtCodItemLavanderia, EventArgs.Empty);
            }
        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            using (FrmConsultaFuncionarios frm = new FrmConsultaFuncionarios())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodFuncionario.Text = IdSelecionado.ToString();
                txtFuncionario.Text = NomeSelecionado;
                txtCodFuncionario_Leave(txtCodFuncionario, EventArgs.Empty);
            }
        }


    }
}
