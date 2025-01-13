using Controle.Controllers;
using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;

namespace Controle.Views.Consultas
{
    public partial class FrmConsultaFolhaTaxa : test.Views.Consultas.FrmConsulta
    {
        private string AcessosLiberados = "TAXA DE SERVIÇO";
        private string mesFiltro = null;
        private int anoFiltro = 0;
        private Pontos oPonto;
        private CTLPontos aCTLPontos;
        private CTLPontosM aCTLPontosM;
        private FrmCadastroFolhaTaxa oFormCadFolha;

        public FrmConsultaFolhaTaxa()
        {
            InitializeComponent();
            LiberarAcessos(AcessosLiberados);
            PreencherComboBoxes();
            aCTLPontos = new CTLPontos();
            aCTLPontosM = new CTLPontosM();
            oFormCadFolha = new FrmCadastroFolhaTaxa();
            DataGrid();
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

        public override void DataGrid()
        {
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            dgv.Columns.AddRange(new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Código", HeaderText = "Código", DataPropertyName = "CodPontoM", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Funcionário", HeaderText = "Funcionário", DataPropertyName = "Funcionarios.Nome", Width = 200 },
                new DataGridViewTextBoxColumn { Name = "Salário Base", HeaderText = "Salário Base", DataPropertyName = "SalarioBase", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Valor dos Pontos", HeaderText = "Valor dos Pontos", DataPropertyName = "VrPontos", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Número de Pontos", HeaderText = "Número de Pontos", DataPropertyName = "NPontos", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Valor Total dos Pontos", HeaderText = "Valor Total dos Pontos", DataPropertyName = "ValorPontoTotal", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Salário Total", HeaderText = "Salário Total", DataPropertyName = "SalarioTotal", Width = 100 }
            });
        }

        private void PreencherDataGridView(IEnumerable<Pontos> pontos)
        {
            // Limpa as linhas existentes no DataGridView
            dgv.Rows.Clear();

            // Adiciona as linhas uma por uma
            foreach (var ponto in pontos)
            {
                dgv.Rows.Add(new object[]
                {
                    ponto.CodPontoM,
                    ponto.Funcionarios?.Nome ?? "N/A",
                    ponto.SalarioBase.ToString("C"), // Formata como moeda
                    ponto.VrPontos.ToString("C"), // Formata como moeda
                    ponto.NPontos,
                    ponto.ValorPontoTotal.ToString("C"), // Formata como moeda
                    ponto.SalarioTotal.ToString("C") // Formata como moeda
                });
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            mesFiltro = cmbMes.Text;
            anoFiltro = Convert.ToInt32(cmbAno.Text);
            var pontos = aCTLPontos.ConsultaLista(txtID.Text, mesFiltro, anoFiltro);
            PreencherDataGridView(pontos);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroFolhaTaxa)
            {
                oFormCadFolha = (FrmCadastroFolhaTaxa)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Pontos)
            {
                oPonto = (Pontos)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            FrmCadastroFolhaTaxa frm = new FrmCadastroFolhaTaxa();
            frm.ShowDialog();
            CarregaLV();
        }

        private void btnOperacoes_Click(object sender, EventArgs e)
        {
            FrmOperacoesFolha frm = new FrmOperacoesFolha();
            frm.ShowDialog();
            CarregaLV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }
    }
}
