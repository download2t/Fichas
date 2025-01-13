using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaSetores : test.Views.Consultas.FrmConsulta
    {
        private FrmCadastroSetores frmCadastro;
        private CTLSetores aCTLSetores;
        private Setores oSetor;
        private string AcessosLiberados = "SETORES";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }

        public FrmConsultaSetores()
        {
            InitializeComponent();
            aCTLSetores = new CTLSetores();
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
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Setor", HeaderText = "Setor", DataPropertyName = "Setor", Width = 655 });          
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroSetores)
            {
                frmCadastro = (FrmCadastroSetores)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Setores)
            {
                oSetor = (Setores)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLSetores.Incluir();
             CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idSetor = ObterIdSelecionado();
            if (idSetor > 0)
            {
                Setores setor = aCTLSetores.BuscarSetorPorId(idSetor);
                if (setor != null)
                {
                    aCTLSetores.Alterar(setor);
                     CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idSetor = ObterIdSelecionado();
            if (idSetor > 0)
            {
                Setores setor = aCTLSetores.BuscarSetorPorId(idSetor);
                if (setor != null)
                {
                    aCTLSetores.Excluir(setor);
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
                Setores setor =aCTLSetores.BuscarSetorPorId(id);

                if (setor != null)
                {
                    aCTLSetores.Visualizar(setor);
                }
            }
        }

        private void PreencherSetoresDataGridView(IEnumerable<Setores> setores)
        {
            dgv.Rows.Clear();

            foreach (var setor in setores)
            {
                dgv.Rows.Add(
                    setor.Id,
                    setor.Setor
                );
            }
        }

        public override void  CarregaDGV()
        {
            base. CarregaDGV();
            List<Setores> setores = aCTLSetores.ListarSetores();
            PreencherSetoresDataGridView(setores);
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = aCTLSetores.PesquisarSetorPorCriterio(criterioPesquisa, valorPesquisa);
                PreencherSetoresDataGridView(resultados);
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
            else if (rbSetor.Checked)
            {
                return "Setor";
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
                    NomeSelecionado = dgv.SelectedRows[0].Cells["Setor"].Value.ToString();
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

        private void FrmConsultaSetores_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
