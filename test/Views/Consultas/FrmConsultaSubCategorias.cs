using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Data;
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaSubCategorias : test.Views.Consultas.FrmConsulta
    {
        private FrmCadastroSubCategoria frmCadastro;
        private CTLSubCategorias CTLSubCategorias;
        private Subcategoria aSubCategoria;
        private int valor = 0;
        private string AcessosLiberados = "SUB CATEGORIA";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        public string NomeSelecionado2 { get; private set; }
        private DALSubCategorias subcategoriaDAL;

        public FrmConsultaSubCategorias(int valor)
        {
            InitializeComponent();
            CTLSubCategorias = new CTLSubCategorias();
            subcategoriaDAL = new DALSubCategorias();
            this.valor = valor;
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
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", DataPropertyName = "CategoriaNome", Width = 330 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "SubCategoria", HeaderText = "Subcategoria", DataPropertyName = "Nome", Width = 325 });

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroSubCategoria)
            {
                frmCadastro = (FrmCadastroSubCategoria)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Subcategoria)
            {
                aSubCategoria = (Subcategoria)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            CTLSubCategorias.Incluir();
             CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idSubCategoria = ObterIdSelecionado();
            if (idSubCategoria > 0)
            {
                Subcategoria subcategoria = CTLSubCategorias.BuscarSubcategoriaPorId(idSubCategoria);
                if (subcategoria != null)
                {
                    CTLSubCategorias.Alterar(subcategoria);
                     CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idSubCategoria = ObterIdSelecionado();
            if (idSubCategoria > 0)
            {
                Subcategoria subcategoria = CTLSubCategorias.BuscarSubcategoriaPorId(idSubCategoria);
                if (subcategoria != null)
                {
                    CTLSubCategorias.Excluir(subcategoria);
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
                Subcategoria subcategoria = CTLSubCategorias.BuscarSubcategoriaPorId((int)id);

                if (subcategoria != null)
                {
                    CTLSubCategorias.Visualizar(subcategoria);
                }
            }
        }

        private void PreencherSubcategoriasDataGridView(IEnumerable<Subcategoria> subcategorias)
        {
            dgv.Rows.Clear();

            foreach (var subcategoria in subcategorias)
            {
                dgv.Rows.Add(
                    subcategoria.Id,
                    subcategoria.Categoria.Nome,
                    subcategoria.Nome
                );
            }
        }

        public override void  CarregaDGV()
        {
            if (btnSair.Text == "Sair")
            {
                base. CarregaDGV();
                List<Subcategoria> subcategorias = CTLSubCategorias.ListarSubcategorias();
                PreencherSubcategoriasDataGridView(subcategorias);
            }
            else if (btnSair.Text == "Selecionar")
            {
                int valor = this.valor;
                if (valor != 0)
                {
                    base. CarregaDGV();
                    List<Subcategoria> subcategorias = CTLSubCategorias.ListarSubcategoriasPorIDCategoria(valor);
                    if (subcategorias != null && subcategorias.Count > 0)
                    {
                        PreencherSubcategoriasDataGridView(subcategorias);
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma subcategoria encontrada para o ID de categoria informado.");
                    }
                }
                else
                {
                    MessageBox.Show("O valor do campo de categoria não é um número válido.");
                }
            }
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = CTLSubCategorias.PesquisarSubcategoriasPorCriterio(criterioPesquisa, valorPesquisa);
                PreencherSubcategoriasDataGridView(resultados);
            }
        }

        protected override void Atualizar()
        {
            base.Atualizar();
             CarregaDGV();
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
            else if (rbCategoria.Checked)
            {
                return "Categoria";
            }
            else if (rbSubCategoria.Checked)
            {
                return "SubCategoria";
            }
            return string.Empty;
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
                    NomeSelecionado = dgv.SelectedRows[0].Cells["Categoria"].Value.ToString();
                    NomeSelecionado2 = dgv.SelectedRows[0].Cells["SubCategoria"].Value.ToString();
                }
                this.Close();
            }
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void FrmConsultaSubCategorias_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
