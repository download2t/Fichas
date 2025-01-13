using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaManutencao : FrmConsulta
    {
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        FrmCadastroManutencao frmCadastro;
        CTLManutencao aCTLManutencao;
        Manutencao aManu;
        private string AcessosLiberados = "MANUTENÇÃO";

        public FrmConsultaManutencao()
        {
            InitializeComponent();
            frmCadastro = new FrmCadastroManutencao();
            aCTLManutencao = new CTLManutencao();
            aManu = new Manutencao();
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
                new DataGridViewTextBoxColumn { Name = "Código", HeaderText = "Código", DataPropertyName = "Id", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Patrimonio", HeaderText = "Patrimônio", DataPropertyName = "Patrimonio", Width = 300 },
                new DataGridViewTextBoxColumn { Name = "DataReparo", HeaderText = "Data do Reparo", DataPropertyName = "DataReparo", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Descricao", HeaderText = "Descrição", DataPropertyName = "Descricao", Width = 400 },
                new DataGridViewTextBoxColumn { Name = "Profissional", HeaderText = "Profissional", DataPropertyName = "Profissional", Width = 150 },
                new DataGridViewTextBoxColumn { Name = "Telefone", HeaderText = "Telefone", DataPropertyName = "Telefone", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "ValorConserto", HeaderText = "Valor do Conserto", DataPropertyName = "ValorConserto", Width = 100 }

            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroManutencao)
            {
                frmCadastro = (FrmCadastroManutencao)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Manutencao)
            {
                aManu = (Manutencao)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLManutencao.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idManu = ObterIdSelecionado();
            if (idManu > 0)
            {
                Manutencao manu = aCTLManutencao.BuscarManutencaoPorId(idManu);
                if (manu != null)
                {
                    aCTLManutencao.Alterar(manu);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idManu = ObterIdSelecionado();
            if (idManu > 0)
            {
                Manutencao manu = aCTLManutencao.BuscarManutencaoPorId(idManu);
                if (manu != null)
                {
                    aCTLManutencao.Excluir(manu);
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
                Manutencao manu = aCTLManutencao.BuscarManutencaoPorId((int)id);

                if (manu != null)
                {
                    aCTLManutencao.Visualizar(manu);
                }
            }
        }

        private void PreencherDGV(IEnumerable<Manutencao> manutencao)
        {
            dgv.Rows.Clear();

            foreach (var manu in manutencao)
            {
                dgv.Rows.Add(new object[]
                {
                    manu.Id,
                    manu.Patrimonio.Patrimonio,
                    manu.DataReparo.ToString(),
                    manu.Descricao,
                    manu.Profissional,
                    manu.Telefone,
                    manu.ValorConserto.ToString("C")
                });
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            var manutencao = aCTLManutencao.ListarManutencoes();
            PreencherDGV(manutencao);
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = aCTLManutencao.PesquisarManutencaoPorCriterio(criterioPesquisa, valorPesquisa);
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
                return "ID";
            }
            else if (rbPatrimonio.Checked)
            {
                return "Patrimonio";
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
                    IdSelecionado = int.Parse(dgv.SelectedRows[0].Cells["Código"].Value.ToString());
                    NomeSelecionado = dgv.SelectedRows[0].Cells["Patrimonio"].Value.ToString();
                }
                this.Close();
            }
        }

        public override void Filtrar()
        {
            base.CarregaDGV();

            DateTime? dataInicio = null;
            DateTime? dataFim = null;

            if (dtData1.Value.Date > DateTime.MinValue.Date)
            {
                if (dtData2.Value.Date > DateTime.MinValue.Date)
                {
                    if (dtData1.Value.Date <= dtData2.Value.Date)
                    {
                        dataInicio = dtData1.Value.Date;
                        dataFim = dtData2.Value.Date;
                    }
                    else
                    {
                        MessageBox.Show("A data de início deve ser anterior à data de término.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma data de término.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (dtData2.Value.Date > DateTime.MinValue.Date)
            {
                MessageBox.Show("Selecione uma data de início.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Manutencao> manutencao = aCTLManutencao.ListarManutencoes(dataInicio, dataFim);
            PreencherDGV(manutencao);
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void FrmConsultaManutencao_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
