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
    public partial class FrmConsultaCofres : test.Views.Consultas.FrmConsulta
    {
        FrmCadastroCofres oFrmCadastroCofres;
        CTLCofres aCTLCofre;
        Cofres oCofre;
        private string AcessosLiberados = "COFRES";
        public int IdSelecionado { get; private set; }
        public int CodigoChaveSelecionado { get; private set; }
        public int NumeroQuartoSelecionado { get; private set; }

        public FrmConsultaCofres()
        {
            InitializeComponent();
            aCTLCofre = new CTLCofres();
            oCofre = new Cofres();
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
                new DataGridViewTextBoxColumn { Name = "Código", HeaderText = "Código", DataPropertyName = "CodCofres", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "CodigoChave", HeaderText = "Código Chave", DataPropertyName = "CodChave", Width = 171 },
                new DataGridViewTextBoxColumn { Name = "NumeroQuarto", HeaderText = "Número do Quarto", DataPropertyName = "Quarto", Width = 171 }
            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroCofres)
            {
                oFrmCadastroCofres = (FrmCadastroCofres)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Cofres)
            {
                oCofre = (Cofres)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLCofre.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idCofre = ObterIdSelecionado();
            if (idCofre > 0)
            {
                Cofres cofre = aCTLCofre.BuscarCofrePorId(idCofre);
                if (cofre != null)
                {
                    aCTLCofre.Alterar(cofre);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCofre = ObterIdSelecionado();
            if (idCofre > 0)
            {
                Cofres cofre = aCTLCofre.BuscarCofrePorId(idCofre);
                if (cofre != null)
                {
                    aCTLCofre.Excluir(cofre);
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
                Cofres cofre = aCTLCofre.BuscarCofrePorId(id);

                if (cofre != null)
                {
                    aCTLCofre.Visualizar(cofre);
                }
            }
        }

        private void PreencherDGV(IEnumerable<Cofres> cofres)
        {
            dgv.Rows.Clear();

            foreach (var cofre in cofres)
            {
                dgv.Rows.Add(new object[]
                {
                    cofre.CodCofres,
                    cofre.CodChave,
                    cofre.Quarto
                });
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            PreencherDGV(aCTLCofre.ListarCofres());
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;

            if (!string.IsNullOrEmpty(valorPesquisa))
            {
                var resultados = aCTLCofre.PesquisarCofres(valorPesquisa);
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
                    CodigoChaveSelecionado = int.Parse(selectedRow.Cells["CodigoChave"].Value.ToString());
                    NumeroQuartoSelecionado = int.Parse(selectedRow.Cells["NumeroQuarto"].Value.ToString());
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

        private void FrmConsultaCofres_Load(object sender, EventArgs e)
        {

        }
    }
}
