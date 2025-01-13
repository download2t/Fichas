using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaCategoriaSenhas : test.Views.Consultas.FrmConsulta
    {
        private FrmCadastroCategoria frmCadastro;
        private CTLCategorias ctlCategorias;
        private Categoria categoriaSelecionada;
        private const string AcessosLiberados = "CATEGORIA DE SENHAS";

        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }

        public FrmConsultaCategoriaSenhas()
        {
            InitializeComponent();
            ctlCategorias = new CTLCategorias();
            LiberarAcessos(AcessosLiberados);
            CarregaDGV();
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
                new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", Width = 655 },

            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }
        public override void SetFrmCadastro(object obj)
        {
            frmCadastro = obj as FrmCadastroCategoria;
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Categoria categoria)
            {
                categoriaSelecionada = categoria;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            ctlCategorias.IncluirSenha();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idCategoria = ObterIdSelecionado();
            if (idCategoria > 0)
            {
                Categoria categoria = ctlCategorias.BuscarCategoriaPorIdDeSenha(idCategoria);
                if (categoria != null)
                {
                    ctlCategorias.AlterarSenha(categoria);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCategoria = ObterIdSelecionado();
            if (idCategoria > 0)
            {
                Categoria categoria = ctlCategorias.BuscarCategoriaPorIdDeSenha(idCategoria);
                if (categoria != null)
                {
                    ctlCategorias.Excluir(categoria);
                    CarregaDGV();
                }
            }
        }

        private int ObterIdSelecionado()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgv.SelectedRows[0].Cells["Código"].Value);
            }
            return 0;
        }
        public override void Visualizar()
        {
            if (btnSair.Text == "Selecionar")
            {
                btnSair.PerformClick();
            }
            else if (dgv.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada do DataGridView
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Busca a categoria pelo ID
                Categoria categoria = ctlCategorias.BuscarCategoriaPorIdDeSenhas(id);

                if (categoria != null)
                {
                    ctlCategorias.Visualizar(categoria);
                }
            }
        }

        private void PreencherDataGridView(IEnumerable<Categoria> categorias)
        {
            dgv.Rows.Clear();

            foreach (var categoria in categorias)
            {
                dgv.Rows.Add(categoria.Id, categoria.Nome);
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            DataGrid();
            List<Categoria> categorias = ctlCategorias.ListarCategoriasDeSenhas();
            PreencherDataGridView(categorias);
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCriterioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = ctlCategorias.PesquisarCategoriasPorCriterioDeSenhas(criterioPesquisa, valorPesquisa);
                PreencherDataGridView(resultados);
            }
        }

        protected override void Atualizar()
        {
            base.Atualizar();
            CarregaDGV();
        }

        private string ObterCriterioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID";
            }
            else if (rbCategoria.Checked)
            {
                return "Categoria";
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
                    IdSelecionado = Convert.ToInt32(dgv.SelectedRows[0].Cells["Código"].Value);
                    NomeSelecionado = dgv.SelectedRows[0].Cells["Categoria"].Value.ToString();
                }
                Close();
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

        private void FrmConsultaCategoriaSenhas_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
