using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaBaixaPatrimonios : test.Views.Consultas.FrmConsulta
    {
        private FrmCadastroPatrimonios frmCadastro;
        CTLBaixasPatrimonios aCTLBaixas;
        private Patrimonios oPatrimonio;
        private  string AcessosLiberados = "BAIXAS PATRIMÔNIAIS";
        public FrmConsultaBaixaPatrimonios()
        {
            InitializeComponent();
            aCTLBaixas = new CTLBaixasPatrimonios();
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
            // Adiciona as colunas com os tamanhos especificados
            dgv.Columns.AddRange(new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Código", HeaderText = "Código", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Patrimônio", HeaderText = "Patrimônio", Width = 260 },
                new DataGridViewTextBoxColumn { Name = "Setor", HeaderText = "Setor", Width = 129 },
                new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "SubCategoria", HeaderText = "Sub Categoria", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "Descrição", HeaderText = "Descrição", Width = 585 },
                new DataGridViewTextBoxColumn { Name = "Valor", HeaderText = "Valor", Width = 111 },
                new DataGridViewTextBoxColumn { Name = "Baixa", HeaderText = "Baixa", Width = 60 },
            });

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

        public override void Alterar()
        {
            base.Alterar();
            int id = ObterIdSelecionado();
            if (id > 0)
            {
                Patrimonios patri = aCTLBaixas.BuscarBaixasPorId(id);
                if (patri != null)
                {
                    aCTLBaixas.AlterarBaixas(patri);
                    CarregaDGV();
                }
            }
        }

        public override void Visualizar()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Patrimonios patri = aCTLBaixas.BuscarBaixasPorId((int)id);

                if (patri != null)
                {
                    aCTLBaixas.Visualizar(patri);
                }
            }
        }

        private void PreencherDGV(IEnumerable<Patrimonios> patri)
        {
            // Limpa as linhas existentes no DataGridView
            dgv.Rows.Clear();

            // Adiciona as linhas uma por uma
            foreach (var patrimonio in patri)
            {
                dgv.Rows.Add(new object[]
                {
                    patrimonio.Id,
                    patrimonio.Patrimonio,
                    patrimonio.Setor.Setor,
                    patrimonio.Subcategoria.Categoria.Nome,
                    patrimonio.Subcategoria.Nome,
                    patrimonio.Descricao,
                    patrimonio.Valor.ToString("C"),
                    patrimonio.Baixa
                });
            }
        }
    
        public override void CarregaDGV()
        {
            base.CarregaDGV();
            DataGrid();
            List<Patrimonios> patri = aCTLBaixas.ListarBaixasPatrimonios();
            PreencherDGV(patri);
        }
        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = aCTLBaixas.PesquisarBaixaPorCriterio(criterioPesquisa, valorPesquisa);
                PreencherDGV(resultados);
            }
        }

        private int ObterIdSelecionado()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                return int.Parse(dgv.SelectedRows[0].Cells["Código"].Value.ToString());
            }
            return 0;
        }

        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID"; // Pesquisar pelo ID
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

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void FrmConsultaBaixaPatrimonios_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
