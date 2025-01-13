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
    public partial class FrmConsultaControleGovFunc : test.Views.Consultas.FrmConsulta
    {
        CTLFuncionarios aCTLFuncionarios;
        FrmCadastroFuncionarios frmCadastro;
        Funcionario oFuncionario;
        private string ativo = "Sim";
        private string AcessosLiberados = "GOVERNANÇA";

        public FrmConsultaControleGovFunc()
        {
            InitializeComponent();
            aCTLFuncionarios = new CTLFuncionarios();
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
                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", DataPropertyName = "Nome", Width = 660
                }
            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
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

        private int ObterIdSelecionado()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                return int.Parse(dgv.SelectedRows[0].Cells["Código"].Value.ToString());
            }
            return 0;
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
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Funcionario funcionario = aCTLFuncionarios.BuscarFuncionarioPorId(id);
                if (funcionario != null)
                {
                    aCTLFuncionarios.SelecionarControle(funcionario);
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
                    func.Nome
                });
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();

            // Filtra e carrega apenas os funcionários do setor 7
            List<Funcionario> funcionariosSetor7 = aCTLFuncionarios.ListarFuncionarios(ativo)
                .Where(func => func.Setor.Id == 7)
                .ToList();

            PreencherDGV(funcionariosSetor7);
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCriterioPesquisa();

            // Verifica se o campo de pesquisa está vazio
            if (string.IsNullOrEmpty(valorPesquisa))
            {
                // Se estiver vazio, pesquisa sem filtro
                CarregaDGV();
                return;
            }

            // Verifica se o critério de pesquisa também está vazio
            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLFuncionarios.PesquisarFuncionariosPorCriterioSetor7(criterioPesquisa, valorPesquisa);

                // Use o método de preenchimento para atualizar a DataGridView
                PreencherDGV(resultados);
            }
        }

        private string ObterCriterioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID"; // Pesquisar pelo ID
            }
            else if (rbNome.Checked)
            {
                return "Nome"; // Pesquisar pelo nome
            }
            else if (rbCpf.Checked)
            {
                return "Cpf"; // Pesquisar pelo CPF
            }

            return string.Empty; // Nenhum critério selecionado
        }

        protected override void Atualizar()
        {
            base.Atualizar();
            CarregaDGV();
        }

        private void cbAtivos_CheckedChanged(object sender, EventArgs e)
        {
            ativo = cbAtivos.Checked ? "Sim" : "Não";
            CarregaDGV();
            txtID.Clear();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }

        private void FrmConsultaControleGovFunc_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }
    }
}
