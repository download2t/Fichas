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
    public partial class FrmRelPatrimonios : Controle.Views.Relatorios.Forms.FrmRelatoriosPai
    {
        int Contador = 0;
        public int ValorCategoria = 0;
        FrmConsultaCategorias oFrmConsultaCategoria;
        FrmConsultaSubCategorias oFrmConsultaSubCategoria;
        FrmConsultaSetores oFrmConsultaSetor;
        CTLSetores aCTLSetores;
        CTLCategorias aCTLCategorias;
        CTLSubCategorias aCTLSubCategorias;
        CTLPatrimonios aCTLPatrimonios;
        public FrmRelPatrimonios()
        {
            InitializeComponent();
            aCTLSetores = new CTLSetores();
            aCTLCategorias = new CTLCategorias();
            aCTLSubCategorias = new CTLSubCategorias();
            aCTLPatrimonios = new CTLPatrimonios();
            
        }
        public void SetConsultaCategorias(FrmConsultaCategorias consulta)
        {
            oFrmConsultaCategoria = consulta;
        }
        public void SetConsultaSubCategorias(FrmConsultaSubCategorias consulta)
        {
            oFrmConsultaSubCategoria = consulta;
        }
        public void SetConsultaSetor(FrmConsultaSetores consulta)
        {
            oFrmConsultaSetor = consulta;
        }

        private bool ValidarCampos()
        {
            if (!cbTotalPatrimonios.Checked && !cbSetorPatrimonios.Checked &&
                !(cbCategoriaPatrimonios.Checked && !string.IsNullOrEmpty(txtCodCategoria.Text)) &&
                !(cbSubPatrimonios.Checked && !string.IsNullOrEmpty(txtCodSubCategoria.Text)))
            {
                MessageBox.Show("Por favor, selecione pelo menos um campo para buscar ou preencha os campos obrigatórios.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbCategoriaPatrimonios.Checked && string.IsNullOrEmpty(txtCodCategoria.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Categoria para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbSubPatrimonios.Checked && string.IsNullOrEmpty(txtCodSubCategoria.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Subcategoria para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbSetorPatrimonios.Checked && string.IsNullOrEmpty(txtCodSetor.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Setor para buscar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        protected override void GerarRelatorio()
        {         
            // Validar campos antes de prosseguir
            if (!ValidarCampos())
            {
                return;
            }

            DataTable dt = ObterDadosRelatorio();
            if (dt.Rows.Count > 0)
                ExibirRelatorio(dt);
            else
            {
                MessageBox.Show("a Busca não encontrou nenhum resultado!");
            }
        }
        private void ExibirRelatorio(DataTable dt)
        {
            string ValorRDLC = "";
            if(rbAtivo.Checked)
                ValorRDLC = "Controle.Views.Relatorios.RDLC.Rel_Patrimonios.rdlc";
            else
                ValorRDLC = "Controle.Views.Relatorios.RDLC.Rel_Baixas.rdlc";

            if (dt != null)
            {
                FrmRelatorio frmRelatorio = new FrmRelatorio();
                frmRelatorio.reportViewer1.LocalReport.ReportEmbeddedResource = ValorRDLC;
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
        private DataTable ObterDadosRelatorio(string categoria = null, string setor = null, string subcategoria = null, bool? status = null)
        {
            DataTable dt = null;
            if (rbAtivo.Checked)
                status = true;
            else
                status = false;

            switch (Contador)
            {
                case 1:
                    dt = aCTLPatrimonios.GerarRelatorios(null, null, null, status); // Todos os Patrimônios
                    break;
                case 2:
                    dt = aCTLPatrimonios.GerarRelatorios(null, txtSetor.Text, null, status); // Patrimonios por Setor
                    break;
                case 3:
                    dt = aCTLPatrimonios.GerarRelatorios(txtCategoria.Text, null, null, status); // patrimonios por categoria
                    break;
                case 5:
                    dt = aCTLPatrimonios.GerarRelatorios(txtCategoria.Text, txtSetor.Text, null, status); // patrimonios por categoria + setor
                    break;
                case 7:
                    dt = aCTLPatrimonios.GerarRelatorios(txtCategoria.Text, null, txtSubCategoria.Text, status); // patrimonios por categoria + subcategoria
                    break;
                case 9:
                    dt = aCTLPatrimonios.GerarRelatorios(txtCategoria.Text, txtSetor.Text, txtSubCategoria.Text, status); // patrimonios por categoria, setor e subcategoria
                    break;

                default:
                    break;
            }

            return dt;
        }

        private void btnPesquisarSetor_Click(object sender, EventArgs e)
        {
            using (FrmConsultaSetores consulta = new FrmConsultaSetores())
            {

                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;
                txtCodSetor.Text = IdSelecionado.ToString();
                txtSetor.Text = NomeSelecionado;
            }
        }
        private void btnPesquisarCategoria_Click(object sender, EventArgs e)
        {
            using (FrmConsultaCategorias consulta = new FrmConsultaCategorias())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodCategoria.Text = IdSelecionado.ToString();
                txtCategoria.Text = NomeSelecionado;
            }
        }

        private void btnPesquisarSubCategoria_Click(object sender, EventArgs e)
        {
            if (txtCodCategoria.Text != "")
            {
                int valor = Convert.ToInt32(txtCodCategoria.Text);
                ValorCategoria = Convert.ToInt32(txtCodCategoria.Text);
                using (FrmConsultaSubCategorias consulta = new FrmConsultaSubCategorias(valor))
                {
                    consulta.btnSair.Text = "Selecionar";
                    consulta.ShowDialog();

                    // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                    int IdSelecionado = consulta.IdSelecionado;
                    string NomeSelecionado2 = consulta.NomeSelecionado2;

                    // Agora, defina os valores nos campos do seu formulário de cadastro
                    txtCodSubCategoria.Text = IdSelecionado.ToString();
                    txtSubCategoria.Text = NomeSelecionado2;
                }
            }
            else
            {
                MessageBox.Show("Campo de categoria prescisa estár preenchido para selecionar uma sub categoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
        private void TravarControlesPatrimonio()
        {
            //checkbox
            cbSetorPatrimonios.Checked = false;
            cbCategoriaPatrimonios.Checked = false;
            cbSubPatrimonios.Checked = false;
            //texts
            txtCodCategoria.Enabled = false;
            txtCodSubCategoria.Enabled = false;
            txtCodSetor.Enabled = false;

        }

        private void cbTotalPatrimonios_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTotalPatrimonios.Checked)
            {
                Contador += 1;
                TravarControlesPatrimonio();
            }
            else
            {
                Contador -= 1;
            }

        }

        private void cbSetorPatrimonios_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSetorPatrimonios.Checked)
            {
                Contador += 2;
                cbTotalPatrimonios.Checked = false;
                btnPesquisarSetor.Enabled = true;
                lbCodSetor.ForeColor = Color.DarkGreen;
                lbSetor.ForeColor = Color.DarkGreen;
                txtCodSetor.Enabled = true;
            }
            else
            {
                Contador -= 2;
                txtCodSetor.Enabled = false;
                lbCodSetor.ForeColor = Color.Black;
                lbSetor.ForeColor = Color.Black;
                btnPesquisarSetor.Enabled = false;
                txtCodSetor.Text = string.Empty;
                txtSetor.Text = string.Empty;
            }
        }

        private void cbCategoriaPatrimonios_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCategoriaPatrimonios.Checked)
            {
                Contador += 3;
                cbSubPatrimonios.Enabled = true;
                txtCodCategoria.Enabled = true;
                btnPesquisarCategoria.Enabled = true;
                cbTotalPatrimonios.Checked = false;
                lbCodCategoria.ForeColor = Color.DarkGreen;
                lbCategoria.ForeColor = Color.DarkGreen;
            }
            else
            {
                Contador -= 3;
                btnPesquisarCategoria.Enabled = false;
                cbSubPatrimonios.Enabled = false;
                txtCodCategoria.Enabled = false;
                cbSubPatrimonios.Checked = false;
                lbCodCategoria.ForeColor = Color.Black;
                lbCategoria.ForeColor = Color.Black;
                txtCodCategoria.Text = string.Empty;
                txtCategoria.Text = string.Empty;
            }
        }
        private  void ValidarValorKeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }
        private void cbSubPatrimonios_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSubPatrimonios.Checked)
            {
                Contador += 4;

                if (txtCodCategoria.TextLength > 0)
                {
                    txtCodSubCategoria.Enabled = true;
                    btnPesquisarSubCategoria.Enabled = true;
                    lbCodSubCategoria.ForeColor = Color.DarkGreen;
                    lbSubCategoria.ForeColor = Color.DarkGreen;
                }
                else
                {
                    MessageBox.Show("Selecione uma categoria!", "Campo nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbSubPatrimonios.Checked = false;
                }
            }
            else
            {
                btnPesquisarSubCategoria.Enabled = false;
                txtCodSubCategoria.Enabled = false;
                lbCodSubCategoria.ForeColor = Color.Black;
                lbSubCategoria.ForeColor = Color.Black;
                txtCodSubCategoria.Text = string.Empty;
                txtSubCategoria.Text = string.Empty;
                Contador -= 4;
            }
        }
        private void txtCodSetor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodSetor.Text))
            {
                // Se o campo txtCodSetor estiver vazio, limpe também o campo txtSetor
                txtCodSetor.Clear();
                txtSetor.Clear();
            }
            else if (int.TryParse(txtCodSetor.Text, out int codSetor) && codSetor > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtSetor
                Setores Valida = aCTLSetores.BuscarSetorPorId(codSetor);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodSetor.Clear();
                    txtSetor.Clear();
                    txtCodSetor.Focus();
                }
                else
                {
                    txtSetor.Text = Valida.Setor;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodSetor.Clear();
                txtSetor.Clear();
                txtCodSetor.Focus();
            }
        }

        private void txtCodCategoria_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCategoria.Text))
            {
                // Se o campo txtCodCategoria estiver vazio, limpe também o campo txtCategoria
                txtCodCategoria.Clear();
                txtCategoria.Clear();
            }
            else if (int.TryParse(txtCodCategoria.Text, out int codCategoria) && codCategoria > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtCategoria
                Categoria Valida = aCTLCategorias.BuscarCategoriaPorId(codCategoria);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodCategoria.Clear();
                    txtCategoria.Clear();
                    txtCodCategoria.Focus();
                }
                else
                {
                    txtCategoria.Text = Valida.Nome;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodCategoria.Clear();
                txtCategoria.Clear();
                txtCodCategoria.Focus();
            }
        }

        private void txtCodSubCategoria_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodSubCategoria.Text))
            {
                // Se o campo txtCodSubCategoria estiver vazio, limpe também o campo txtSubCategoria
                txtCodSubCategoria.Clear();
                txtSubCategoria.Clear();
            }
            else if (int.TryParse(txtCodSubCategoria.Text, out int codSubCategoria) && codSubCategoria > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtSubCategoria
                Subcategoria Valida = aCTLSubCategorias.BuscarSubcategoriaPorId(codSubCategoria);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodSubCategoria.Clear();
                    txtSubCategoria.Clear();
                }
                else
                {
                    txtSubCategoria.Text = Valida.Nome;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodSubCategoria.Clear();
                txtSubCategoria.Clear();
            }
        }

    }
}
