using Controle.Controllers;
using Controle.Models;
using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;

namespace Controle.Views.Consultas
{
    public partial class FrmConsultaRamal : test.Views.Consultas.FrmConsulta
    {
        FrmCadastroRamais frmCadRamais;
        Ramal oRamal;
        CTLRamais aCTLRamal;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string AcessosLiberados = "RAMAIS";

        public FrmConsultaRamal()
        {
            InitializeComponent();
            LiberarAcessos(AcessosLiberados);
            DataGrid();
            oRamal = new Ramal();
            aCTLRamal = new CTLRamais();
        }

        public override void DataGrid()
        {
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", DataPropertyName = "Id", Width = 60 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "NumRamal", HeaderText = "RAMAL", DataPropertyName = "NumRamal", Width = 60 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Linha", HeaderText = "LINHA", DataPropertyName = "Linha", Width = 90 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Setor", HeaderText = "SETOR", DataPropertyName = "Setor", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "NOME", DataPropertyName = "Nome", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Fone", HeaderText = "TELEFONE", DataPropertyName = "Fone", Width = 140 });

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroRamais)
            {
                frmCadRamais = (FrmCadastroRamais)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Ramal)
            {
                oRamal = (Ramal)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLRamal.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int id = ObterIdSelecionado();
            if (id > 0)
            {
                Ramal ram = aCTLRamal.BuscarRamalPorId(id);
                if (ram != null)
                {
                    aCTLRamal.Alterar(ram);
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
                Ramal ram = aCTLRamal.BuscarRamalPorId(id);
                if (ram != null)
                {
                    aCTLRamal.Excluir(ram);
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

                Ramal ram = aCTLRamal.BuscarRamalPorId(id);

                if (ram != null)
                {
                    aCTLRamal.Visualizar(ram);
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
                    NomeSelecionado = dgv.SelectedRows[0].Cells["Nome"].Value.ToString();
                }
                this.Close();
            }
        }

        private void PreencherRamalDataGridView(IEnumerable<Ramal> ramais)
        {
            dgv.Rows.Clear();

            foreach (var ramal in ramais)
            {
                dgv.Rows.Add(
                    ramal.Id,
                    ramal.NumRamal,
                    Operacao.FormatarTelefone(ramal.Linha),
                    ramal.Setor.Setor,
                    ramal.Nome,
                    Operacao.FormatarTelefone2(ramal.Fone)
                );
            }
        }


        public override void CarregaDGV()
        {
            base.CarregaDGV();
            List<Ramal> ramais = aCTLRamal.ListarRamais();
            PreencherRamalDataGridView(ramais);
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;

            if (!string.IsNullOrEmpty(valorPesquisa))
            {
                var resultados = aCTLRamal.PesquisarRamal(valorPesquisa);
                PreencherRamalDataGridView(resultados);
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

        protected override void Atualizar()
        {
            base.Atualizar();
            CarregaDGV();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }
    }
}
