using Controle.Controllers;
using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;

namespace Controle.Views.Consultas
{
    public partial class FrmConsultaLancamentos : test.Views.Consultas.FrmConsulta
    {
        private PontosM oPontoM;
        private CTLPontosM aCTLPontosM;
        private string AcessosLiberados = "LANÇAMENTO DE PONTOS";

        public FrmConsultaLancamentos()
        {
            InitializeComponent();
            LiberarAcessos(AcessosLiberados);
            oPontoM = new PontosM();
            aCTLPontosM = new CTLPontosM();
        }
        public override void DataGrid()
        {
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            dgv.Columns.AddRange(new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", DataPropertyName = "Id", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Data", HeaderText = "Data", DataPropertyName = "Data", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Descricao", HeaderText = "Descrição", DataPropertyName = "Descricao", Width = 200 },
                new DataGridViewTextBoxColumn { Name = "Valor", HeaderText = "Valor", DataPropertyName = "Valor", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "C" } },
                new DataGridViewTextBoxColumn { Name = "Tipo", HeaderText = "Tipo", DataPropertyName = "Tipo", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", DataPropertyName = "Categoria", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "Conta", HeaderText = "Conta", DataPropertyName = "Conta", Width = 100 }
                    });
        }

        private void PreencherDGV(IEnumerable<PontosM> pontos)
        {
            // Limpa as linhas existentes no DataGridView
            dgv.Rows.Clear();

            // Adiciona as linhas uma por uma
            foreach (var ponto in pontos)
            {
                dgv.Rows.Add(new object[]
                {
            ponto.CodPontoM,
            ponto.TaxaServico.ToString("C"), // Formata como moeda
            ponto.TotalDistribuicao.ToString("C"), // Formata como moeda
            ponto.Mes,
            ponto.Ano
                });
            }
        }


        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is PontosM)
            {
                oPontoM = (PontosM)obj;
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            var pontos = aCTLPontosM.ConsultaLista(null);
            PreencherDGV(pontos);
        }

        protected override void Atualizar()
        {
            base.Atualizar();
            CarregaLV();
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLPontosM.Incluir();
            CarregaLV();
        }

        protected override void Pesquisar()
        {
            var valorPesquisa = txtID.Text;

            if (!string.IsNullOrEmpty(valorPesquisa))
            {
                var resultados = aCTLPontosM.ConsultaLista(valorPesquisa);
                PreencherDGV(resultados);
            }
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }
    }
}
