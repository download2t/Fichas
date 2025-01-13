using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Views.Cadastros;

namespace test.Controllers
{
    public class CTLClientes
    {
        private DALClientes clientesDAL = new DALClientes();

        public void AdicionarCliente(Clientes cliente)
        {
            clientesDAL.AdicionarCliente(cliente);
        }

        public void AtualizarCliente(Clientes cliente)
        {
            clientesDAL.AtualizarCliente(cliente);
        }

        public void ExcluirCliente(int clienteId)
        {
            clientesDAL.ExcluirCliente(clienteId);
        }

        public Clientes BuscarClientePorId(int id)
        {
            return clientesDAL.BuscarClientePorId(id);
        }

        public List<Clientes> ListarClientes()
        {
            return clientesDAL.ListarClientes();
        }

        public void Incluir()
        {
            FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
            frmCadastroClientes.Text = "Incluir Cliente";
            frmCadastroClientes.ShowDialog();
        }

        public void Alterar(Clientes cliente)
        {
            if (cliente != null)
            {
                FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
                frmCadastroClientes.ConhecaObj(cliente);
                frmCadastroClientes.Text = "Alterar Cliente";
                frmCadastroClientes.CarregarCampos();
                if (cliente.Documento == "")
                {
                    frmCadastroClientes.rbDoc.Checked = true;
                }
                frmCadastroClientes.ShowDialog();
              
            }
        }

        public void Excluir(Clientes cliente)
        {
            if (cliente != null)
            {
                FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
                frmCadastroClientes.ConhecaObj(cliente);
                frmCadastroClientes.Text = "Excluir Cliente";
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
                frmCadastroClientes.Text = "Consultar Cliente";
                frmCadastroClientes.CarregarCampos();
                frmCadastroClientes.BloquearCampos();
                frmCadastroClientes.btnSalvar.Enabled = false;
                frmCadastroClientes.ShowDialog();
            }
        }
        public List<Clientes> PesquisarClientesPorCriterio(string criterio, string valorPesquisa)
        {
            List<Clientes> clientesEncontrados = clientesDAL.PesquisarClientesPorCriterio(criterio, valorPesquisa);
            return clientesEncontrados;
        }

    }

}
