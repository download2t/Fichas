using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;

namespace Controle.Views.Consultas
{
    public partial class FrmConsultaFuncionarios : test.Views.Consultas.FrmConsulta
    {
        private CTLFuncionarios aCTLFuncionarios;
        private FrmCadastroFuncionarios frmCadastro;
        private Funcionario oFuncionario;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string AcessosLiberados = "FUNCIONÁRIOS";
        private string ativo = "Sim";

        public FrmConsultaFuncionarios()
        {
            InitializeComponent();
            aCTLFuncionarios = new CTLFuncionarios();
            LiberarAcessos(AcessosLiberados);
            this.Controls.Add(dgv);
            this.Resize += FrmConsulta_Resize; // Associa o evento de redimensionamento
            DataGrid();

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
                    NomeSelecionado = dgv.SelectedRows[0].Cells["Nome"].Value.ToString();
                }
                this.Close();
            }
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroFuncionarios)
            {
                frmCadastro = (FrmCadastroFuncionarios)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Funcionario)
            {
                oFuncionario = (Funcionario)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLFuncionarios.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idFunc = ObterIdSelecionado();
            if (idFunc > 0)
            {
                Funcionario funcionario = aCTLFuncionarios.BuscarFuncionarioPorId(idFunc);
                if (funcionario != null)
                {
                    aCTLFuncionarios.Alterar(funcionario);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idFunc = ObterIdSelecionado();
            if (idFunc > 0)
            {
                Funcionario funcionario = aCTLFuncionarios.BuscarFuncionarioPorId(idFunc);
                if (funcionario != null)
                {
                    aCTLFuncionarios.Excluir(funcionario);
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
                Funcionario funcionario = aCTLFuncionarios.BuscarFuncionarioPorId(id);

                if (funcionario != null)
                {
                    aCTLFuncionarios.Visualizar(funcionario);
                }
            }
        }

        private void PreencherDGV(IEnumerable<Funcionario> funcionarios)
        {
            // Limpa as linhas existentes no DataGridView
            dgv.Rows.Clear();

            // Adiciona as linhas uma por uma
            foreach (var func in funcionarios)
            {
                dgv.Rows.Add(new object[]
                {
                    func.Id,
                    func.Nome,
                    func.Setor.Setor,
                    func.Cargo.Funcao,
                    string.IsNullOrWhiteSpace(func.Cpf) ? "Não Cadastrado" : Operacao.FormatarDocumento(func.Cpf),
                    Operacao.FormatarTelefone(func.Telefone),
                    $"{func.SalBruto:C}",
                    func.Ativo == 'S' ? "SIM" : "NÃO"
                });
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            PreencherDGV(aCTLFuncionarios.ListarFuncionarios(ativo));
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = aCTLFuncionarios.PesquisarFuncionariosPorCriterio(criterioPesquisa, valorPesquisa);
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
                return "Nome"; // Pesquisar pelo nome da empresa
            }
            else if (rbCpf.Checked)
            {
                return "Cpf"; // Pesquisar pelo documento
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
                return int.Parse(dgv.SelectedRows[0].Cells["Código"].Value.ToString());
            }
            return 0;
        }

        private void cbAtivos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtivos.Checked)
            {
                ativo = "Sim";
            }
            else
            {
                ativo = "Não";
            }
            CarregaDGV();
            txtID.Clear();
        }

        public override void DataGrid()
        {
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            dgv.Columns.AddRange(new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Código", HeaderText = "Código", DataPropertyName = "Id", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", DataPropertyName = "Nome", Width = 280 },
                new DataGridViewTextBoxColumn { Name = "Setor", HeaderText = "Setor", DataPropertyName = "Setor.Setor", Width = 170 },
                new DataGridViewTextBoxColumn { Name = "Cargo", HeaderText = "Cargo", DataPropertyName = "Cargo.Funcao", Width = 170 },
                new DataGridViewTextBoxColumn { Name = "Cpf", HeaderText = "CPF", DataPropertyName = "Cpf", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "Telefone", HeaderText = "Telefone", DataPropertyName = "Telefone", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "Salário Bruto", HeaderText = "Salário Bruto", DataPropertyName = "SalBruto", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "Ativo", HeaderText = "Ativo", DataPropertyName = "Ativo", Width = 60 }
            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void FrmConsultaFuncionarios_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
