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
    public partial class FrmConsultaContatos : test.Views.Consultas.FrmConsulta
    {
        private string AcessosLiberados = "CONTATOS";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        FrmCadastroContatos oFormCadContatos;
        CTLContatos aCTLContatos;
        Contatos oContato;
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaContatos()
        {
            InitializeComponent();
            LiberarAcessos(AcessosLiberados);
            aCTLContatos = new CTLContatos();
            oContato = new Contatos();
            this.Controls.Add(dgv);
            this.Resize += FrmConsulta_Resize; // Associa o evento de redimensionamento
            DataGrid();
        }

        public override void DataGrid()
        {
            dgv.AutoGenerateColumns = false;
            dgv.RowHeadersVisible = false;
            dgv.Columns.Clear();

            dgv.Columns.AddRange(new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Código", HeaderText = "Código", DataPropertyName = "Id", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", DataPropertyName = "Nome", Width = 455 },
                new DataGridViewTextBoxColumn { Name = "Numero", HeaderText = "Número", DataPropertyName = "Numero", Width = 200 }
            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroContatos)
            {
                oFormCadContatos = (FrmCadastroContatos)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Contatos)
            {
                oContato = (Contatos)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLContatos.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int id = ObterIdSelecionado();
            if (id > 0)
            {
                Contatos contato = aCTLContatos.BuscarContatoPorId(id);
                if (contato != null)
                {
                    aCTLContatos.Alterar(contato);
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
                Contatos contato = aCTLContatos.BuscarContatoPorId(id);
                if (contato != null)
                {
                    aCTLContatos.Excluir(contato);
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
                Contatos contato = aCTLContatos.BuscarContatoPorId(id);

                if (contato != null)
                {
                    aCTLContatos.Visualizar(contato);
                }
            }
        }

        private void PreencherDGV(IEnumerable<Contatos> contatos)
        {
            dgv.Rows.Clear();

            foreach (var contato in contatos)
            {
                dgv.Rows.Add(new object[]
                {
                    contato.Id,
                    contato.Nome,
                    Operacao.FormatarTelefone(contato.Numero)
                });
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            PreencherDGV(aCTLContatos.ListarContatos());
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = aCTLContatos.PesquisarContatosPorCriterio(criterioPesquisa, valorPesquisa);
                PreencherDGV(resultados);
            }
        }

        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID";
            }
            else if (rbNome.Checked)
            {
                return "Nome";
            }
            else if (rbNumero.Checked)
            {
                return "Numero";
            }

            return string.Empty;
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
                    NomeSelecionado = selectedRow.Cells["Nome"].Value.ToString();
                }
                this.Close();
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void FrmConsultaContatos_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }
    }
}
