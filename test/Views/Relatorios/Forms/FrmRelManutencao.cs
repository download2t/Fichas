using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Controllers;
using test.Model;
using test.Views.Consultas;

namespace Controle.Views.Relatorios.Forms
{
    public partial class FrmRelManutencao : Controle.Views.Relatorios.Forms.FrmRelatoriosPai
    {
        int contadorManu = 1;
        FrmConsultaPatrimonios oFrmConsultaPatrimonio;
        CTLManutencao  aCTLManutencao;
        CTLPatrimonios aCTLPatrimonios;
    
        public FrmRelManutencao()
        {
            InitializeComponent();
            aCTLManutencao = new CTLManutencao();
            aCTLPatrimonios = new CTLPatrimonios();
        }
        protected override void GerarRelatorio()
        {

            // Validar campos antes de prosseguir
            if (!ValidarCampos())
            {
                return;
            }

            DataTable dt = ObterDadosRelatorio(null, null, null, null);
            if(dt.Rows.Count > 0)
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
                frmRelatorio.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle.Views.Relatorios.RDLC.Rel_Manutencao.rdlc";
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

            if (rbPro.Checked && string.IsNullOrEmpty(txtPro.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de texto para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rbPatri.Checked && string.IsNullOrEmpty(txtCodPatrimonio.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de texto para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (rbPeriodoManu.Checked && string.IsNullOrEmpty(DataInicio.Text) && string.IsNullOrEmpty(DataFim.Text))
            {
                MessageBox.Show("Por favor, preencha os campos de data para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private DataTable ObterDadosRelatorio(string procurar, int? idPatrimonio = null, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            DataTable dt = null;

            switch (contadorManu)
            {
                case 1:
                    dt = aCTLManutencao.GerarRelatorios(null, null, null, null); // Todos os Patrimônios
                    break;
                case 2:
                    dataInicial = DataInicio.Value.Date; dataFinal = DataFim.Value.Date;
                    if (dataInicial.Value.Date > dataFinal.Value.Date)
                        MessageBox.Show("A data inicial deve ser anterior ou igual à data final",
                            "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        // Define a data final com horário máximo (23:59:59)
                        dataFinal = dataFinal.Value.Date.AddDays(1).AddTicks(-1);
                        dt = aCTLManutencao.GerarRelatorios(null, null, dataInicial, dataFinal); // Por data
                    }        
                    break;
                case 3:
                    procurar = txtPro.Text;
                    dt = aCTLManutencao.GerarRelatorios(procurar, null,  null, null); // Por data
                    break;
                case 4:
                    idPatrimonio = Convert.ToInt32(txtCodPatrimonio.Text);
                    dt = aCTLManutencao.GerarRelatorios(null, idPatrimonio, null, null); // Por data
                    break;


                default:
                    break;
            }

            return dt;
        }

        public void SetConsultaPatrimonio(FrmConsultaPatrimonios consulta)
        {
            oFrmConsultaPatrimonio = consulta;
        }
        private void ValidarValorKeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }
        private void rbTotalManu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTotalManu.Checked)
                contadorManu = 1;
        }

        private void rbPeriodoManu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeriodoManu.Checked)
            {
                contadorManu = 2;
                DataInicio.Enabled = true;
                DataFim.Enabled = true;
            }
            else
            {
                DataInicio.Enabled = false;
                DataFim.Enabled = false;
            }
        }

        private void rbPro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPro.Checked)
            {
                contadorManu = 3;
                txtPro.Enabled = true;
                lblPro.ForeColor = Color.DarkGreen;
            }
            else
            {
                txtPro.Enabled = false;
                txtPro.Text = string.Empty;
                lblPro.ForeColor = Color.Black;
            }
        }

        private void rbPatri_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPatri.Checked)
            {
                contadorManu = 4;
                txtCodPatrimonio.Enabled = true;
                lblCodPatri.ForeColor = Color.DarkGreen;
                lblPatri.ForeColor = Color.DarkGreen;
                btnPesquisarPatrimonio.Enabled = true;
            }
            else
            {
                txtCodPatrimonio.Enabled = false;
                txtPatrimonio.Enabled = false;
                txtPatrimonio.Text = string.Empty;
                txtCodPatrimonio.Text = string.Empty;
                lblCodPatri.ForeColor = Color.Black;
                lblPatri.ForeColor = Color.Black;
                btnPesquisarPatrimonio.Enabled = false;

            }
        }
        private void btnPesquisarProfissional_Click(object sender, EventArgs e)
        {

        }
        private void btnPesquisarPatrimonio_Click(object sender, EventArgs e)
        {
            using (FrmConsultaPatrimonios consulta = new FrmConsultaPatrimonios())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodPatrimonio.Text = IdSelecionado.ToString();
                txtPatrimonio.Text = NomeSelecionado;
            }
        }
        private void txtCodPatrimonio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodPatrimonio.Text))
            {
                // Se o campo txtCodPatrimonio estiver vazio, limpe também o campo txtPatrimonio
                txtCodPatrimonio.Clear();
                txtPatrimonio.Clear();
            }
            else if (int.TryParse(txtCodPatrimonio.Text, out int codPatrimonio) && codPatrimonio > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtPatrimonio
                Patrimonios Valida = aCTLPatrimonios.BuscarPatrimonioPorId(codPatrimonio);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodPatrimonio.Clear();
                    txtPatrimonio.Clear();
                    txtCodPatrimonio.Focus();
                }
                else
                {
                    txtPatrimonio.Text = Valida.Patrimonio;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodPatrimonio.Clear();
                txtPatrimonio.Clear();
                txtCodPatrimonio.Focus();
            }
        }
    }
}
