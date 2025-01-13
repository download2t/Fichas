using Controle.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Controllers;
using test.Model;

namespace Controle.Views.Cadastros
{
    public partial class FrmCadastroFolhaTaxa : test.Views.Cadastros.FrmCadastro
    {
        PontosM oPontoM;
        CTLPontosM aCTLPontosM;
        public FrmCadastroFolhaTaxa()
        {
            InitializeComponent();
            PreencherComboBoxes();
            oPontoM = new PontosM();
            aCTLPontosM = new CTLPontosM();
        }
        private void PreencherComboBoxes()
        {
            // Preencher combobox de mês
            string[] nomesMeses = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            cmbMes.DataSource = nomesMeses.Take(12).ToList(); // Leva apenas os primeiros 12 meses

            // Selecionar o mês atual
            int mesAtual = DateTime.Now.Month;
            cmbMes.SelectedIndex = mesAtual - 1; // Índice começa em 0

            // Preencher combobox de ano
            int anoAtual = DateTime.Now.Year;
            List<int> anos = Enumerable.Range(anoAtual, 10).ToList(); // Preenche 10 anos a partir do ano atual
            cmbAno.DataSource = anos;

            // Selecionar o ano atual
            cmbAno.SelectedItem = anoAtual;

        }
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows only the entry of numbers and the backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }

        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is PontosM pontoM)
            {
                oPontoM = pontoM;
                CarregarCampos();
            }
        }
        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtTotal.Clear();
            txtRecisao.Clear();
            cmbMes.SelectedIndex = 0;
            cmbAno.SelectedIndex = 0;
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtTotal.Enabled = false;
            txtRecisao.Enabled = false;
            cmbMes.Enabled = false;
            cmbAno.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtTotal.Enabled = true;
            txtRecisao.Enabled = true;
            cmbMes.Enabled = true;
            cmbAno.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oPontoM.CodPontoM;
            txtTotal.Text = oPontoM.TotalDistribuicao.ToString();
            txtRecisao.Text = oPontoM.ValorRecisao.ToString();
            cmbMes.Text = oPontoM.Mes;
            cmbAno.Text = oPontoM.Ano.ToString();
        }
        protected override void Verificar()
        {
            Salvar();
        }

        public override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                oPontoM.CodPontoM = txtID.Text;
                oPontoM.ValorRecisao = Convert.ToInt32(txtRecisao.Text);
                oPontoM.TotalDistribuicao = Convert.ToInt32(txtTotal.Text);
                oPontoM.Mes = cmbMes.Text;
                int.TryParse(cmbAno.Text, out int ano);
                oPontoM.Ano = ano;


                aCTLPontosM.SalvarPontos(oPontoM);
                Close();
                return;
            }

        }
        protected override bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtRecisao.Text))
            {
                camposFaltantes.Add("Recisao");
            }
            if (string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                camposFaltantes.Add("Total");
            }
            if (camposFaltantes.Count > 0)
            {
                string camposFaltantesStr = string.Join(", ", camposFaltantes);
                MessageBox.Show("Os seguintes campos são obrigatórios e não foram preenchidos: " + camposFaltantesStr, "Campos em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
