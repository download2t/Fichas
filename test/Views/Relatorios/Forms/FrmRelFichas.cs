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
using test.Views.Consultas;

namespace Controle.Views.Relatorios.Forms
{
    public partial class FrmRelFichas : Controle.Views.Relatorios.Forms.FrmRelatoriosPai
    {
        CTLUsuarios aCTLUsuarios;
        CTLClientes aCTLClientes;
        CTLFichas aCTLFichas;
        int contadorFichas = 1;
        public FrmRelFichas()
        {
            InitializeComponent();
            aCTLClientes = new CTLClientes();
            aCTLUsuarios = new CTLUsuarios();
            aCTLFichas = new CTLFichas();
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
                frmRelatorio.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle.Views.Relatorios.RDLC.Rel_Fichas.rdlc";
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

            if (rbClientes.Checked && string.IsNullOrEmpty(txtCodCliente.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de texto para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (rbUsuarios.Checked && string.IsNullOrEmpty(txtCodUsuario.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de texto para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (rbPeriodoFichas.Checked && string.IsNullOrEmpty(DataInicio.Text) && string.IsNullOrEmpty(DataFim.Text))
            {
                MessageBox.Show("Por favor, preencha os campos de data para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private DataTable ObterDadosRelatorio(int? codUsuarios, int? codClientes = null, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            DataTable dt = null;

            switch (contadorFichas)
            {
                case 1:
                    dt = aCTLFichas.GerarRelatorios(null, null, null, null); // Todos os registros
                    break;
                case 2:
                    dataInicial = DataInicio.Value.Date;
                    dataFinal = DataFim.Value.Date;
                    if (dataInicial.Value.Date > dataFinal.Value.Date)
                    {
                        MessageBox.Show("A data inicial deve ser anterior ou igual à data final",
                            "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Define a data final com horário máximo (23:59:59)
                        dataFinal = dataFinal.Value.Date.AddDays(1).AddTicks(-1);

                        dt = aCTLFichas.GerarRelatorios(null, null, dataInicial, dataFinal); // Por data
                    }
                    break;
                case 3:
                    codUsuarios = Convert.ToInt32(txtCodUsuario.Text);
                    dt = aCTLFichas.GerarRelatorios(codUsuarios, null, null, null); // Por data
                    break;
                case 4:
                    codClientes = Convert.ToInt32(txtCodCliente.Text);
                    dt = aCTLFichas.GerarRelatorios(null, codClientes, null, null); // Por data
                    break;


                default:
                    break;
            }

            return dt;
        }

        private void rbTotalFichas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTotalFichas.Checked)
                contadorFichas = 1;
        }

        private void rbPeriodoFichas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeriodoFichas.Checked)
            {
                contadorFichas = 2;
                DataInicio.Enabled = true;
                DataFim.Enabled = true;
            }
            else
            {
                DataInicio.Enabled = false;
                DataFim.Enabled = false;
            }
        }

        private void rbUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuarios.Checked)
            {
                contadorFichas = 3;
                txtCodUsuario.Enabled = true;
                lblCodUser.ForeColor = Color.DarkGreen;
                lblUser.ForeColor = Color.DarkGreen;
                btnPesquisarUsuario.Enabled = true;
            }
            else
            {
                txtCodUsuario.Enabled = false;
                txtUsuario.Text = string.Empty;
                txtCodUsuario.Text = string.Empty;
                lblCodUser.ForeColor = Color.Black;
                lblUser.ForeColor = Color.Black;
                btnPesquisarUsuario.Enabled = false;
            }
        }

        private void rbClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClientes.Checked)
            {
                contadorFichas = 4;
                txtCodCliente.Enabled = true;
                lblCodCliente.ForeColor = Color.DarkGreen;
                lblCliente.ForeColor = Color.DarkGreen;
                btnPesquisarCliente.Enabled = true;
            }
            else
            {
                txtCodCliente.Enabled = false;
                txtCliente.Text = string.Empty;
                txtCodCliente.Text = string.Empty;
                lblCodCliente.ForeColor = Color.Black;
                lblCliente.ForeColor = Color.Black;
                btnPesquisarCliente.Enabled = false;
            }
        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            using (FrmConsultaUsuarios consulta = new FrmConsultaUsuarios())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodUsuario.Text = IdSelecionado.ToString();
                txtUsuario.Text = NomeSelecionado;
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            using (FrmConsultaClientes consulta = new FrmConsultaClientes())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodCliente.Text = IdSelecionado.ToString();
                txtCliente.Text = NomeSelecionado;
            }

        }
        private void ValidarValorKeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        private void txtCodUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodUsuario.Text))
            {
                // Se o campo txtCodPatrimonio estiver vazio, limpe também o campo txtPatrimonio
                txtCodUsuario.Clear();
                txtUsuario.Clear();
            }
            else if (int.TryParse(txtCodUsuario.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtPatrimonio
                Usuarios Valida = aCTLUsuarios.BuscarUsuarioPorId(cod);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodUsuario.Clear();
                    txtUsuario.Clear();
                    txtCodUsuario.Focus();
                }
                else
                {
                    txtUsuario.Text = Valida.Usuario;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodUsuario.Clear();
                txtUsuario.Clear();
                txtCodUsuario.Focus();
            }
        }

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCliente.Text))
            {
                // Se o campo txtCodPatrimonio estiver vazio, limpe também o campo txtPatrimonio
                txtCodCliente.Clear();
                txtCliente.Clear();
            }
            else if (int.TryParse(txtCodUsuario.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtPatrimonio
                Clientes Valida = aCTLClientes.BuscarClientePorId(cod);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodCliente.Clear();
                    txtCliente.Clear();
                    txtCodCliente.Focus();
                }
                else
                {
                    txtCliente.Text = Valida.Nome;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodCliente.Clear();
                txtCliente.Clear();
                txtCodCliente.Focus();
            }
        }
    }
}
