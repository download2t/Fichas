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
    public partial class FrmConsultaLavanderia : test.Views.Consultas.FrmConsulta
    {
        FrmCadastroLavanderia oFrmCadastroLavanderia;
        CTLLavanderia aCTLLavanderia;
        Lavanderia oLavanderia;
        private string AcessosLiberados = "LAVANDERIA";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaLavanderia()
        {
            InitializeComponent();
            aCTLLavanderia = new CTLLavanderia();
            oLavanderia = new Lavanderia();
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
                 new DataGridViewTextBoxColumn { Name = "ITEM", HeaderText = "ITEM", DataPropertyName = "ITEM", Width = 200 },
                new DataGridViewTextBoxColumn { Name = "Data", HeaderText = "Data", DataPropertyName = "Data", Width = 130 },
                new DataGridViewTextBoxColumn { Name = "Peso", HeaderText = "Peso", DataPropertyName = "Peso", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "Processo", HeaderText = "Processo", DataPropertyName = "Processo", Width = 300 },
                new DataGridViewTextBoxColumn { Name = "Funcionario", HeaderText = "Funcionario", DataPropertyName = "Funcionario", Width = 250 }
            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroLavanderia)
            {
                oFrmCadastroLavanderia = (FrmCadastroLavanderia)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Lavanderia)
            {
                oLavanderia = (Lavanderia)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLLavanderia.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idLavanderia = ObterIdSelecionado();
            if (idLavanderia > 0)
            {
                Lavanderia lavanderia = aCTLLavanderia.BuscarLavanderiaPorId(idLavanderia);
                if (lavanderia != null)
                {
                    aCTLLavanderia.Alterar(lavanderia);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idLavanderia = ObterIdSelecionado();
            if (idLavanderia > 0)
            {
                Lavanderia lavanderia = aCTLLavanderia.BuscarLavanderiaPorId(idLavanderia);
                if (lavanderia != null)
                {
                    aCTLLavanderia.Excluir(lavanderia);
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
                Lavanderia lavanderia = aCTLLavanderia.BuscarLavanderiaPorId(id);

                if (lavanderia != null)
                {
                    aCTLLavanderia.Visualizar(lavanderia);
                }
            }
        }


        private void PreencherDGV(IEnumerable<Lavanderia> lavanderias)
        {
            dgv.Rows.Clear();

            foreach (var lavanderia in lavanderias)
            {
                dgv.Rows.Add(new object[]
                {
                    lavanderia.Id,
                    lavanderia.ItensLavanderia.Nome,
                    lavanderia.Data.ToString("dd/MM/yyyy"),
                    lavanderia.Peso.ToString("0.00"),
                    lavanderia.Processo,
                    lavanderia.Funcionario.Nome // Assume que Funcionario possui uma propriedade Nome
                });
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            PreencherDGV(aCTLLavanderia.ListarLavanderias());
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLLavanderia.PesquisarLavanderiasPorCriterio(criterioPesquisa, valorPesquisa);
                PreencherDGV(resultados);
            }
        }

        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID"; // Pesquisar pelo ID
            }
            else if (rbProcesso.Checked)
            {
                return "Processo"; // Pesquisar pelo processo
            }
            else if (rbItem.Checked)
            {
                return "Item"; // Pesquisar pelo Item
            }
            else if (rbFuncionario.Checked)
            {
                return "Funcionario"; // Pesquisar pelo nome do funcionário
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
                    NomeSelecionado = selectedRow.Cells["ITEM"].Value.ToString();
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

        private void FrmConsultaLavanderia_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
        public override void Filtrar()
        {
            base.CarregaDGV();

            DateTime? dataInicio = null;
            DateTime? dataFim = null;
            string nome = txtID.Text;

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

            List<Lavanderia> lv = aCTLLavanderia.ListarLavanderias(dataInicio, dataFim);
            PreencherDGV(lv);
        }

    }
}
