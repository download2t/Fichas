using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Views.Cadastros;

namespace Controle.Views.Consultas
{
    public partial class FrmConsultaCargos : test.Views.Consultas.FrmConsulta
    {
        FrmCadastroCargos oFrmCadastroCargos;
        CTLCargos aCTLCargo;
        Cargo oCargo;
        private string AcessosLiberados = "FUNÇÃO / CARGOS";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        public FrmConsultaCargos()
        {
            InitializeComponent();
            aCTLCargo = new CTLCargos();
            oCargo = new Cargo();
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
                new DataGridViewTextBoxColumn { Name = "Cargo", HeaderText = "Cargo / Função", Width = 340 },
                new DataGridViewTextBoxColumn { Name = "Pontos", HeaderText = "Pontos", Width = 60 },

            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroCargos)
            {
                oFrmCadastroCargos = (FrmCadastroCargos)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Cargo)
            {
                oCargo = (Cargo)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLCargo.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idCargo = ObterIdSelecionado();
            if (idCargo > 0)
            {
                Cargo cargo = aCTLCargo.BuscarCargoPorId(idCargo);
                if (cargo != null)
                {
                    aCTLCargo.Alterar(cargo);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCargo = ObterIdSelecionado();
            if (idCargo > 0)
            {
                Cargo cargo = aCTLCargo.BuscarCargoPorId(idCargo);
                if (cargo != null)
                {
                    aCTLCargo.Excluir(cargo);
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
                Cargo cargo = aCTLCargo.BuscarCargoPorId(id);

                if (cargo != null)
                {
                    aCTLCargo.Visualizar(cargo);
                }
            }

        }
 
        private void PreencherDGV(IEnumerable<Cargo> cargos)
        {
            dgv.Rows.Clear();

            foreach (var cargo in cargos)
            {
                dgv.Rows.Add(new object[]
                {
                    cargo.Id,
                    cargo.Funcao,
                    cargo.Pontos
                });
            }
        }
        public override void CarregaDGV()
        {
            base.CarregaDGV();
            DataGrid();
            List<Cargo> cargo = aCTLCargo.ListarCargos();
            PreencherDGV(cargo);
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
               var resultados = aCTLCargo.PesquisarCargosPorCriterio(criterioPesquisa, valorPesquisa);

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
               if (rbPontos.Checked)
               {
                   return "Pontos"; // Pesquisar por pontos

               }
               else if (rbCargo.Checked)
               {
                   return "Cargos"; // Pesquisar pelo cargo
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
                    NomeSelecionado = selectedRow.Cells["Cargo"].Value.ToString();
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

        private void FrmConsultaCargos_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
