using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;

namespace Controle.Views.Consultas
{
    public partial class FrmConsultaItensLavanderia : test.Views.Consultas.FrmConsulta
    {
        FrmCadastroItensLavanderia oFrmCadastroItensLavanderia;
        CTLItensLavanderia aCTLItensLavanderia;
        ItensLavanderia oItemLavanderia;
        private string AcessosLiberados = "ITENS_LAVANDERIA";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaItensLavanderia()
        {
            InitializeComponent();
            aCTLItensLavanderia = new CTLItensLavanderia();
            oItemLavanderia = new ItensLavanderia();
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

            dgv.Columns.AddRange(new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID", DataPropertyName = "Id", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", DataPropertyName = "Nome", Width = 355 }
            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroItensLavanderia)
            {
                oFrmCadastroItensLavanderia = (FrmCadastroItensLavanderia)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is ItensLavanderia)
            {
                oItemLavanderia = (ItensLavanderia)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLItensLavanderia.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idItemLavanderia = ObterIdSelecionado();
            if (idItemLavanderia > 0)
            {
                ItensLavanderia itemLavanderia = aCTLItensLavanderia.BuscarItensLavanderiaPorId(idItemLavanderia);
                if (itemLavanderia != null)
                {
                    aCTLItensLavanderia.Alterar(itemLavanderia);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idItemLavanderia = ObterIdSelecionado();
            if (idItemLavanderia > 0)
            {
                ItensLavanderia itemLavanderia = aCTLItensLavanderia.BuscarItensLavanderiaPorId(idItemLavanderia);
                if (itemLavanderia != null)
                {
                    aCTLItensLavanderia.Excluir(itemLavanderia);
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
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                ItensLavanderia itemLavanderia = aCTLItensLavanderia.BuscarItensLavanderiaPorId(id);

                if (itemLavanderia != null)
                {
                    aCTLItensLavanderia.Visualizar(itemLavanderia);
                }
            }
        }

        private void PreencherDGV(IEnumerable<ItensLavanderia> itensLavanderia)
        {
            dgv.Rows.Clear();

            foreach (var item in itensLavanderia)
            {
                dgv.Rows.Add(new object[]
                {
                    item.Id,
                    item.Nome
                });
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            PreencherDGV(aCTLItensLavanderia.ListarItensLavanderia());
        }

        protected override void Pesquisar()
        {

            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLItensLavanderia.PesquisarItensLavanderiaPorCriterio(criterioPesquisa, valorPesquisa);
                PreencherDGV(resultados);
            }
        }
        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID"; // Pesquisar pelo ID
            }
            else if (rbNome.Checked)
            {
                return "NOME"; // Pesquisar pelo nome
            }

            return string.Empty; // Nenhum critério selecionado
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
                return int.Parse(dgv.SelectedRows[0].Cells["ID"].Value.ToString());
            }
            return 0;
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
                    IdSelecionado = int.Parse(selectedRow.Cells["ID"].Value.ToString());
                    NomeSelecionado = selectedRow.Cells["Nome"].Value.ToString();
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

        private void FrmConsultaItensLavanderia_Load(object sender, EventArgs e)
        {

        }
    }
}
