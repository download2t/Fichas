using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaSenhas : FrmConsulta
    {
        private FrmCadastroSenhas frmCadastro;
        private CTLSenhas aCTLSenha;
        private Senhas aSenha;
        private string AcessosLiberados = "SENHAS";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }

        public FrmConsultaSenhas()
        {
            InitializeComponent();
            LiberarAcessos(AcessosLiberados);
            frmCadastro = new FrmCadastroSenhas();
            aCTLSenha = new CTLSenhas();
            aSenha = new Senhas();
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
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Login", HeaderText = "Login", DataPropertyName = "Login", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Senha", HeaderText = "Senha", DataPropertyName = "Senha", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", DataPropertyName = "Categoria.Nome", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descricao", HeaderText = "Descrição", DataPropertyName = "Descricao", Width = 375 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Link", HeaderText = "Link", DataPropertyName = "Link", Width = 200 });
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroSenhas)
            {
                frmCadastro = (FrmCadastroSenhas)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Senhas)
            {
                aSenha = (Senhas)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLSenha.Incluir();
             CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int id = ObterIdSelecionado();
            if (id > 0)
            {
                Senhas senha = aCTLSenha.BuscarSenhaPorId(id);
                if (senha != null)
                {
                    aCTLSenha.Alterar(senha);
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
                Senhas senha = aCTLSenha.BuscarSenhaPorId(id);
                if (senha != null)
                {
                    aCTLSenha.Excluir(senha);
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
                Senhas senha = aCTLSenha.BuscarSenhaPorId((int)id);

                if (senha != null)
                {
                    aCTLSenha.Visualizar(senha);
                }
            }
        }

        private void PreencherSenhasDataGridView(IEnumerable<Senhas> senhas)
        {
            dgv.Rows.Clear();

            foreach (var senha in senhas)
            {
                dgv.Rows.Add(
                    senha.Id,
                    senha.Login,
                    senha.Senha,
                    senha.Categoria.Nome,
                    senha.Descricao,
                    senha.Link
                );
            }
        }

        public override void  CarregaDGV()
        {
            base. CarregaDGV();
            List<Senhas> senhas = aCTLSenha.ListarSenhas();
            PreencherSenhasDataGridView(senhas);
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = aCTLSenha.PesquisarSenhasPorCriterio(criterioPesquisa, valorPesquisa);
                PreencherSenhasDataGridView(resultados);
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
            else if (rbCategoria.Checked)
            {
                return "Categoria";
            }
            else if (rbLogin.Checked)
            {
                return "Login";
            }
            else if (rbSenha.Checked)
            {
                return "Senha";
            }
            else if (rbContem.Checked)
            {
                return "Contem";
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
                    NomeSelecionado = dgv.SelectedRows[0].Cells["Login"].Value.ToString();
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

        private void FrmConsultaSenhas_Load(object sender, EventArgs e)
        {

        }
    }
}
