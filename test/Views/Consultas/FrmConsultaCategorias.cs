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
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaCategorias : test.Views.Consultas.FrmConsulta
    {
        FrmCadastroCategoria frmCadastro;
        CTLCategorias aCTLCategorias;
        Categoria aCategoria;
        private string AcessosLiberados = "CATEGORIA";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        public FrmConsultaCategorias()
        {
            InitializeComponent();
            aCTLCategorias = new CTLCategorias();
            LiberarAcessos(AcessosLiberados);
            this.Controls.Add(dgv);
            this.Resize += FrmConsulta_Resize; // Associa o evento de redimensionamento
            DataGrid();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroCategoria)
            {
                frmCadastro = (FrmCadastroCategoria)obj;
            }
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

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Categoria)
            {
                aCategoria = (Categoria)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLCategorias.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idCategoria = ObterIdSelecionado();
            if (idCategoria > 0)
            {
                Categoria categoria = aCTLCategorias.BuscarCategoriaPorId(idCategoria);
                if (categoria != null)
                {
                    aCTLCategorias.Alterar(categoria);
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
                Categoria categoria = aCTLCategorias.BuscarCategoriaPorId(idCategoria);
                if (categoria != null)
                {
                    aCTLCategorias.Excluir(categoria);
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
                // Obtém a linha selecionada do DataGridView
                DataGridViewRow selectedRow = dgv.SelectedRows[0];

                // Obtém o valor do ID da primeira célula da linha selecionada
                int categoriaId = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Busca a categoria pelo ID
                var categoria = aCTLCategorias.BuscarCategoriaPorId(categoriaId);

                if (categoria != null)
                {
                    aCTLCategorias.Visualizar(categoria);
                }
            }
        }


        private void PreencherDGV(IEnumerable<Categoria> categorias)
        {
            // Limpa as linhas existentes no DataGridView
            dgv.Rows.Clear();

            // Adiciona as linhas uma por uma
            foreach (var categoria in categorias)
            {
                dgv.Rows.Add(new object[]
                {
                    categoria.Id,
                    categoria.Nome,

                });
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            DataGrid();
            List<Categoria> categoria = aCTLCategorias.ListarCategorias();
            PreencherDGV(categoria);
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLCategorias.PesquisarCategoriasPorCriterio(criterioPesquisa, valorPesquisa);

                // Use o método de preenchimento para atualizar a ListView
                PreencherDGV(resultados);
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
            else if (rbCategoria.Checked)
            {
                return "Categoria"; // Pesquisar pelo usuário
            }
            return string.Empty; // Nenhum critério selecionado

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
                    DataGridViewRow selectedRow = dgv.SelectedRows[0];
                    IdSelecionado = int.Parse(selectedRow.Cells["Código"].Value.ToString());
                    NomeSelecionado = selectedRow.Cells["Categoria"].Value.ToString();
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

        private void FrmConsultaCategorias_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
