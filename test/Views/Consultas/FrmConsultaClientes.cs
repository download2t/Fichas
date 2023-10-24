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
        private ClientesController clientesController = new ClientesController();
        FrmCadastroClientes oFormCadClientes;
        Clientes oCliente;
        public int ClienteIdSelecionado { get; private set; }
        public string ClienteNomeSelecionado { get; private set; }

        public FrmConsultaClientes()
        {
            InitializeComponent();
        }

        public override void Sair()
        {
            if (btnSair.Text == "Sair")
            {
                base.Sair();
            }
            else if (btnSair.Text == "Selecionar")
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ClienteIdSelecionado = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                    ClienteNomeSelecionado = listView1.SelectedItems[0].SubItems[1].Text;
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
            clientesController.Incluir();
            CarregaLV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idCliente = ObterIdSelecionado();
            if (idCliente > 0)
            {
                Clientes cliente = clientesController.BuscarClientePorId(idCliente);
                if (cliente != null)
                {
                    clientesController.Alterar(cliente);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCliente = ObterIdSelecionado();
            if (idCliente > 0)
            {
                Clientes cliente = clientesController.BuscarClientePorId(idCliente);
                if (cliente != null)
                {
                    clientesController.Excluir(cliente);
                    CarregaLV();
                }
            }
        }

        public override void Visualizar()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Clientes cliente = selectedItem.Tag as Clientes;

                if (cliente != null)
                {
                    clientesController.Visualizar(cliente);
                }
            }
        }
        private void PreencherListView(IEnumerable<Clientes> clientes)
        {
            listView1.Items.Clear();

            foreach (Clientes cliente in clientes)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(cliente.Id));
                item.SubItems.Add(cliente.Nome);
                item.SubItems.Add(Operacao.FormatarDocumento(cliente.Documento));
                item.SubItems.Add(Operacao.FormatarTelefone(cliente.Telefone));
                item.SubItems.Add(cliente.Email);
                item.SubItems.Add(Operacao.FormatarCep(cliente.Cep));
                item.SubItems.Add(cliente.Cidade);
                item.SubItems.Add(cliente.Bairro);
                item.SubItems.Add(cliente.Logradouro);
                item.SubItems.Add(cliente.Numero.ToString());
                item.SubItems.Add(cliente.UF);
                item.Tag = cliente;
                listView1.Items.Add(item);
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            PreencherListView(clientesController.ListarClientes());
        }
        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = clientesController.PesquisarClientesPorCriterio(criterioPesquisa, valorPesquisa);

                // Use o método de preenchimento para atualizar a ListView
                PreencherListView(resultados);
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

            return string.Empty; // Nenhum critério selecionado
        }

        protected override void Atualizar()
        {
            base.Atualizar();
            CarregaLV();
        }

        private int ObterIdSelecionado()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                return int.Parse(listView1.SelectedItems[0].Text);
            }
            return 0;
        }
    }
}
