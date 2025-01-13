using Controle.Views.Relatorios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaPatrimonios : test.Views.Consultas.FrmConsulta
    {
        private FrmCadastroPatrimonios frmCadastro;
        CTLPatrimonios aCTLPatrimonios;
        private Patrimonios oPatrimonio;
        private string AcessosLiberados = "PATRIMÔNIOS";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }

        public FrmConsultaPatrimonios()
        {
            InitializeComponent();
            aCTLPatrimonios = new CTLPatrimonios();
            LiberarAcessos(AcessosLiberados);
            this.Controls.Add(dgv);
            this.Resize += FrmConsulta_Resize; // Associa o evento de redimensionamento
            DataGrid();
        }

        public override void DataGrid()
        {
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", DataPropertyName = "Id", Width = 60 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Patrimonio", HeaderText = "Patrimônio", DataPropertyName = "Patrimonio", Width = 350 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Setor", HeaderText = "Setor", DataPropertyName = "Setor.Setor", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", DataPropertyName = "Subcategoria.Categoria.Nome", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "SubCategoria", HeaderText = "Subcategoria", DataPropertyName = "Subcategoria.Nome", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descricao", HeaderText = "Descrição", DataPropertyName = "Descricao", Width = 470 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Valor", HeaderText = "Valor", DataPropertyName = "Valor", Width = 110 });

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroPatrimonios)
            {
                frmCadastro = (FrmCadastroPatrimonios)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Patrimonios)
            {
                oPatrimonio = (Patrimonios)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLPatrimonios.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int id = ObterIdSelecionado();
            if (id > 0)
            {
                Patrimonios patri = aCTLPatrimonios.BuscarPatrimonioPorId(id);
                if (patri != null)
                {
                    aCTLPatrimonios.Alterar(patri);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int id = ObterIdSelecionado();
            if (id > 0)
            {
                Patrimonios patri = aCTLPatrimonios.BuscarPatrimonioPorId(id);
                if (patri != null)
                {
                    aCTLPatrimonios.Excluir(patri);
                    CarregaDGV();
                }
            }
        }

        public override void Visualizar()
        {
            if (btnSair.Text == "Selecionar")
            {
                btnSair.PerformClick();
            }
            else if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Patrimonios patri = aCTLPatrimonios.BuscarPatrimonioPorId(id);

                if (patri != null)
                {
                    aCTLPatrimonios.Visualizar(patri);
                }
            }
        }

        public override void Sair()
        {
            if (btnSair.Text == "Sair")
            {
                base.Sair();
            }
            else if (btnSair.Text == "Selecionar")
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    IdSelecionado = int.Parse(dgv.SelectedRows[0].Cells["Id"].Value.ToString());
                    NomeSelecionado = dgv.SelectedRows[0].Cells["Patrimonio"].Value.ToString();
                }
                this.Close();
            }
        }

        private void PreencherFichasDataGridView(IEnumerable<Patrimonios> patri)
        {
            dgv.Rows.Clear();

            foreach (var patrimonio in patri)
            {
                dgv.Rows.Add(
                    patrimonio.Id,
                    patrimonio.Patrimonio,
                    patrimonio.Setor.Setor,
                    patrimonio.Subcategoria.Categoria.Nome,
                    patrimonio.Subcategoria.Nome,
                    patrimonio.Descricao,
                    patrimonio.Valor.ToString("C")
                );
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            List<Patrimonios> patri = aCTLPatrimonios.ListarPatrimonios();
            PreencherFichasDataGridView(patri);
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = aCTLPatrimonios.PesquisarPatrimoniosPorCriterio(criterioPesquisa, valorPesquisa);
                PreencherFichasDataGridView(resultados);
            }
        }

        private int ObterIdSelecionado()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                return int.Parse(dgv.SelectedRows[0].Cells["Id"].Value.ToString());
            }
            return 0;
        }

        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID";
            }
            else if (rbSetor.Checked)
            {
                return "Setor";
            }
            else if (rbCategoria.Checked)
            {
                return "Categoria";
            }
            else if (rbSubCategoria.Checked)
            {
                return "SubCategoria";
            }
            else if (rbPatrimonio.Checked)
            {
                return "Patrimonio";
            }

            CarregaDGV();
            return string.Empty;
        }

        protected override void Atualizar()
        {
            base.Atualizar();
            CarregaDGV();
        }

        public override void Filtrar() // desativado
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Patrimonio");
            dataTable.Columns.Add("Setor");
            dataTable.Columns.Add("SubCategoria");
            dataTable.Columns.Add("Descricao");
            dataTable.Columns.Add("Valor");

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["Patrimonio"] = row.Cells["Patrimonio"].Value.ToString();
                    dataRow["Setor"] = row.Cells["Setor"].Value.ToString();
                    dataRow["SubCategoria"] = row.Cells["SubCategoria"].Value.ToString();
                    dataRow["Descricao"] = row.Cells["Descricao"].Value.ToString();
                    dataRow["Valor"] = row.Cells["Valor"].Value.ToString();
                    dataTable.Rows.Add(dataRow);
                }
            }

            FrmRelatorio frmRelatorio = new FrmRelatorio();
            frmRelatorio.reportViewer1.LocalReport.ReportEmbeddedResource = "Controle.Views.Relatorios.RDLC.Rel_Patrimonios.rdlc";
            frmRelatorio.reportViewer1.LocalReport.DataSources.Clear();
            frmRelatorio.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataTable));
            frmRelatorio.reportViewer1.RefreshReport();
            frmRelatorio.Show();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void FrmConsultaPatrimonios_Load(object sender, EventArgs e)
        {

        }
    }
}
