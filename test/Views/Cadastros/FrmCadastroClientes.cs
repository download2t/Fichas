using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq; // Certifique-se de adicionar a referência Newtonsoft.Json ao seu projeto
using test.Classes;
using test.Controllers;
using System.Xml.Linq;
using System.Data.SqlClient;
using test.Model;
using System.Linq;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroClientes : FrmPai
    {
        private Clientes oCliente;
        private ClientesController clientesController;
        private bool numeroTelefoneValido = true; // Variável de controle

        public FrmCadastroClientes()
        {
            InitializeComponent();
            oCliente = new Clientes();
            clientesController = new ClientesController();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Clientes cliente)
            {
                oCliente = cliente;
                CarregarCampos();
            }
        }

        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtNome.Clear();
            txtDocumento.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtCEP.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtDocumento.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtCEP.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = false;
            txtNome.Enabled = true;
            txtDocumento.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            txtCEP.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oCliente.Id.ToString();
            txtNome.Text = oCliente.Nome;
            txtDocumento.Text = oCliente.Documento;
            txtTelefone.Text = oCliente.Telefone;
            txtEmail.Text = oCliente.Email;
            txtCEP.Text = oCliente.Cep;
            txtLogradouro.Text = oCliente.Logradouro;
            txtNumero.Text = oCliente.Numero.ToString();
            txtBairro.Text = oCliente.Bairro;
            txtCidade.Text = oCliente.Cidade;
            txtUF.Text = oCliente.UF;
        }

        public override void Salvar()
        {
            if (SalvarCliente())
            {
                Close(); // Fecha o formulário após salvar
            }
        }

        private bool SalvarCliente()
        {
            if (!VerificarCamposVazios())
            {
                return false;
            }

            oCliente.Nome = txtNome.Text;
            oCliente.Documento = txtDocumento.Text;
            oCliente.Telefone = txtTelefone.Text;
            oCliente.Email = txtEmail.Text;
            oCliente.Cep = txtCEP.Text;
            oCliente.Logradouro = txtLogradouro.Text;
            oCliente.Bairro = txtBairro.Text;
            oCliente.Cidade = txtCidade.Text;
            oCliente.UF = txtUF.Text;

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                oCliente.Numero = numero;
            }
            else
            {
                MessageBox.Show("Número inválido.");
                return false;
            }

            if (oCliente.Id == 0)
            {
                clientesController.AdicionarCliente(oCliente);
            }
            else
            {
                clientesController.AtualizarCliente(oCliente);
            }

            return true;
        }

        protected override bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Campo Nome não pode estar vazio.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Campo Documento não pode estar vazio.");
                txtDocumento.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Campo Email não pode estar vazio.");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Salvar") 
            {
                txtDocumento_Leave(txtDocumento, EventArgs.Empty);
                txtTelefone_Leave(txtTelefone, EventArgs.Empty);
                txtEmail_Leave(txtEmail, EventArgs.Empty);
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirCliente();
                }
            }
        }



        private void ExcluirCliente()
        {
            if (oCliente != null)
            {
                try
                {
                    ClientesController clientesController = new ClientesController();
                    clientesController.ExcluirCliente(oCliente.Id);

                    // Feche o formulário após a exclusão
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o cliente devido a outros registros estarem vinclulados a este cliente.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o cliente. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }
        private async void txtCEP_Leave(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim(); // Obtém o CEP digitado no campo

            if (!string.IsNullOrEmpty(cep))
            {
                // Realiza a consulta do CEP
                string resultado = await Operacao.ConsultarCepAsync(cep);

                if (resultado != null)
                {
                    // Divida a string de resultado em campos individuais
                    string[] campos = resultado.Split(','); // THANKS GPT kkk
                    
                    //Vc podia colocar um tipo DE RETORNO LOGRADOURO BAIRRO UF CIDADE 

                    // Encontre os valores específicos para cada campo
                    string logradouro = campos.FirstOrDefault(c => c.Contains("Logradouro:"))?.Replace("Logradouro:", "").Trim();
                    string bairro = campos.FirstOrDefault(c => c.Contains("Bairro:"))?.Replace("Bairro:", "").Trim();
                    string uf = campos.FirstOrDefault(c => c.Contains("UF:"))?.Replace("UF:", "").Trim();
                    string cidade = campos.FirstOrDefault(c => c.Contains("Cidade:"))?.Replace("Cidade:", "").Trim();

                    txtLogradouro.Text = logradouro;
                    txtBairro.Text = bairro;
                    txtUF.Text = uf;
                    txtCidade.Text = cidade;


                    txtNumero.Focus();
                    txtNumero.Select();
                }
                else
                {
                    // Lida com erros ou CEP inválido
                    Console.WriteLine("Erro na consulta de CEP ou CEP inválido.");
                }
            }
        }
        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text.Trim();

            if (!string.IsNullOrEmpty(documento))
            {
                bool isValid = Operacao.IsCpf(documento) || Operacao.IsCnpj(documento);

                if (!isValid)
                {
                    MessageBox.Show("CPF ou CNPJ inválido. Por favor, insira um documento válido.");
                    txtDocumento.Focus();
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (!string.IsNullOrEmpty(email) && !Operacao.IsEmail(email))
            {
                MessageBox.Show("E-mail inválido. Por favor, insira um endereço de e-mail válido.");
                txtEmail.Focus();
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            string fone = txtTelefone.Text.Trim();

            if (!string.IsNullOrEmpty(fone) && !Operacao.IsTelefone(fone))
            {
                MessageBox.Show("Número de telefone inválido. Por favor, insira um Número válido.");
                txtTelefone.Focus();
            }
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifique se o caractere digitado não é um dígito numérico (0-9) e não é Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Impede a entrada do caractere não numérico
            }
        }

    }
}
