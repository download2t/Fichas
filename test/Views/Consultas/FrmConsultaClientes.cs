using System;
using System.Windows.Forms;
using test.Controllers;
using test.Classes;
using test.Views.Cadastros;
using System.Collections.Generic;
using test.Model;

namespace test.Views.Consultas
{
    public partial class FrmConsultaClientes : FrmConsulta
    {
        private CTLClientes aCTLClientes = new CTLClientes();
        FrmCadastroClientes oFormCadClientes;
        Clientes oCliente;
        private string AcessosLiberados = "CLIENTES";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaClientes()
        {
            InitializeComponent();
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
                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", DataPropertyName = "Nome", Width = 200 },
                new DataGridViewTextBoxColumn { Name = "Documento", HeaderText = "Documento", DataPropertyName = "Documento", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Telefone", HeaderText = "Telefone", DataPropertyName = "Telefone", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Email", HeaderText = "Email", DataPropertyName = "Email", Width = 175 },
                new DataGridViewTextBoxColumn { Name = "Cep", HeaderText = "CEP", DataPropertyName = "Cep", Width = 80 },
                new DataGridViewTextBoxColumn { Name = "Cidade", HeaderText = "Cidade", DataPropertyName = "Cidade", Width = 130 },
                new DataGridViewTextBoxColumn { Name = "Bairro", HeaderText = "Bairro", DataPropertyName = "Bairro", Width = 130 },
                new DataGridViewTextBoxColumn { Name = "Logradouro", HeaderText = "Logradouro", DataPropertyName = "Logradouro", Width = 200 },
                new DataGridViewTextBoxColumn { Name = "Numero", HeaderText = "Número", DataPropertyName = "Numero", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "UF", HeaderText = "UF", DataPropertyName = "UF", Width = 40 }
            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
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


        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroClientes)
            {
                oFormCadClientes = (FrmCadastroClientes)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Clientes)
            {
                oCliente = (Clientes)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLClientes.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idCliente = ObterIdSelecionado();
            if (idCliente > 0)
            {
                Clientes cliente = aCTLClientes.BuscarClientePorId(idCliente);
                if (cliente != null)
                {
                    aCTLClientes.Alterar(cliente);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCliente = ObterIdSelecionado();
            if (idCliente > 0)
            {
                Clientes cliente = aCTLClientes.BuscarClientePorId(idCliente);
                if (cliente != null)
                {
                    aCTLClientes.Excluir(cliente);
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
                Clientes cliente = aCTLClientes.BuscarClientePorId((int)id);

                if (cliente != null)
                {
                    aCTLClientes.Visualizar(cliente);
                }
            }
        }
        private void PreencherDGV(IEnumerable<Clientes> clientes)
        {
            // Limpa as linhas existentes no DataGridView
            dgv.Rows.Clear();

            // Adiciona as linhas uma por uma
            foreach (var cliente in clientes)
            {
                dgv.Rows.Add(new object[]
                {
            cliente.Id,
            cliente.Nome,
            string.IsNullOrWhiteSpace(cliente.Documento) ? "Não Cadastrado" : Operacao.FormatarDocumento(cliente.Documento),
            Operacao.FormatarTelefone(cliente.Telefone),
            cliente.Email,
            Operacao.FormatarCep(cliente.Cep),
            cliente.Cidade,
            cliente.Bairro,
            cliente.Logradouro,
            cliente.Numero.ToString(),
            cliente.UF
                });
            }
        }



        public override void CarregaDGV()
        {
            base.CarregaDGV();
            PreencherDGV(aCTLClientes.ListarClientes());
        }
        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLClientes.PesquisarClientesPorCriterio(criterioPesquisa, valorPesquisa);

                // Use o método de preenchimento para atualizar a ListView
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
            else if (rbDocumento.Checked)
            {
                return "Documento"; // Pesquisar pelo documento
            }
            else if (rbEmail.Checked)
            {
                return "Email"; // Pesquisar pelo Email
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

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void FrmConsultaClientes_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
