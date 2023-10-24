using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Views.Cadastros;

namespace test.Controllers
{
    public class ClientesController
    {
        private ClientesDAO clientesDAO = new ClientesDAO();

        public void AdicionarCliente(Clientes cliente)
        {
            clientesDAO.AdicionarCliente(cliente);
        }

        public void AtualizarCliente(Clientes cliente)
        {
            clientesDAO.AtualizarCliente(cliente);
        }

        public void ExcluirCliente(int clienteId)
        {
            clientesDAO.ExcluirCliente(clienteId);
        }

        public Clientes BuscarClientePorId(int id)
        {
            return clientesDAO.BuscarClientePorId(id);
        }

        public List<Clientes> ListarClientes()
        {
            return clientesDAO.ListarClientes();
        }

        public void Incluir()
        {
            FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
            frmCadastroClientes.ShowDialog();
        }

        public void Alterar(Clientes cliente)
        {
            if (cliente != null)
            {
                FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
                frmCadastroClientes.ConhecaObj(cliente);
                frmCadastroClientes.CarregarCampos();
                frmCadastroClientes.ShowDialog();
            }
        }

        public void Excluir(Clientes cliente)
        {
            if (cliente != null)
            {
                FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
                frmCadastroClientes.ConhecaObj(cliente);
                frmCadastroClientes.CarregarCampos();
                frmCadastroClientes.BloquearCampos();
                frmCadastroClientes.btnSalvar.Text = "Excluir";
                frmCadastroClientes.ShowDialog();
            }
        }
        public void Visualizar(Clientes cliente)
        {
            if (cliente != null)
            {
                FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
                frmCadastroClientes.ConhecaObj(cliente);
                frmCadastroClientes.CarregarCampos();
                frmCadastroClientes.BloquearCampos();
                frmCadastroClientes.btnSalvar.Enabled = false;
                frmCadastroClientes.ShowDialog();
            }
        }
        public List<Clientes> PesquisarClientesPorCriterio(string criterio, string valorPesquisa)
        {
            List<Clientes> clientesEncontrados = new List<Clientes>();

            if (criterio == "ID")
            {
                // Pesquisar por ID
                if (int.TryParse(valorPesquisa, out int id))
                {
                    Clientes cliente = BuscarClientePorId(id);
                    if (cliente != null)
                    {
                        clientesEncontrados.Add(cliente);
                    }
                }
            }
            else if (criterio == "Nome")
            {
                // Pesquisar por Nome
                clientesEncontrados = clientesDAO.PesquisarClientesPorNome(valorPesquisa);
            }
            else if (criterio == "Documento")
            {
                // Pesquisar por Documento
                clientesEncontrados = clientesDAO.PesquisarClientesPorCPF(valorPesquisa);
            }

            return clientesEncontrados;
        }

    }

}
