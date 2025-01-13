using System;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using static test.Views.FrmLogin;
using test.Views.Consultas;
using System.Data.SqlClient;
using test.Model;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroFichas :FrmCadastro
    {
        private Fichas aFicha;
        private CTLClientes aCTLClientes;
        private FrmConsultaClientes oFormConsultaClientes;

        public FrmCadastroFichas()
        {
            InitializeComponent();
            aFicha = new Fichas();
            aCTLClientes = new CTLClientes();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Fichas ficha)
            {
                aFicha = ficha;
                CarregarCampos();
            }
        }

        public void SetConsultaClientes(FrmConsultaClientes consultaClientes)
        {
            oFormConsultaClientes = consultaClientes;
        }

        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtDescricao.Clear();
            txtUsuario.Clear();
            dtData.Value = DateTime.Now;
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Clear();  
            txtCodCliente.Enabled = false;
            txtCliente.Enabled = false;
            txtUsuario.Enabled = false;
            dtData.Enabled = false;
            btnPesquisarCliente.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = false;
            txtDescricao.Enabled = true;
            txtCodCliente.Enabled = true;
            txtUsuario.Enabled = true;
            dtData.Enabled = true;
            btnPesquisarCliente.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = aFicha.Id.ToString();
            txtDescricao.Text = aFicha.Descricao;
            txtCodCliente.Text = aFicha.Clientes.Id.ToString();
            txtCliente.Text = aFicha.Clientes.Nome;
            txtUsuario.Text = UserSession.User.Nome;
            txtCodUsuario.Text = UserSession.User.Id.ToString();
            dtData.Value = aFicha.DataCriacao ?? DateTime.Now;
        }

        public override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                base.Salvar();
                aFicha.Descricao = txtDescricao.Text;
                aFicha.DataCriacao = dtData.Value;
                if (int.TryParse(txtCodCliente.Text, out int codCliente) && codCliente > 0)
                {
                    aFicha.Clientes.Id = codCliente;
                }
                else
                {
                    MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");

                }
                if (int.TryParse(txtCodUsuario.Text, out int codUsuario))
                {
                    aFicha.Usuarios.Id = codUsuario;
                }
                // Use o controlador de fichas para salvar ou atualizar a ficha
                CTLFichas aCTLFichas = new CTLFichas();
                if (aFicha.Id == 0)
                {
                    aCTLFichas.AdicionarFicha(aFicha);
                }
                else
                {
                    aCTLFichas.AtualizarFicha(aFicha);
                }
                Close();
            }
        }

        protected override bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Campo Descrição não pode estar vazio.");
                txtDescricao.Focus();
                return false;
            }
            if (!int.TryParse(txtCodUsuario.Text, out _))
            {
                MessageBox.Show("Campo Código de Usuário inválido.");
                txtCodUsuario.Focus();
                return false;
            }
            if (!int.TryParse(txtCodCliente.Text, out _))
            {
                MessageBox.Show("Campo Código de Cliente inválido.");
                txtCodCliente.Focus();
                return false;
            }
            return true;
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            using (FrmConsultaClientes consultaClientes = new FrmConsultaClientes())
            {
                consultaClientes.btnSair.Text = "Selecionar";
                consultaClientes.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consultaClientes.IdSelecionado;
                string NomeSelecionado = consultaClientes.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodCliente.Text = IdSelecionado.ToString();
                txtCliente.Text = NomeSelecionado;
            }
        }



        private void FrmCadastroFichas_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = UserSession.User.Nome; 
            txtCodUsuario.Text = UserSession.User.Id.ToString();
        }
        protected override void Verificar()
        {
            if (string.IsNullOrEmpty(txtCodCliente.Text) || !int.TryParse(txtCodCliente.Text, out int codCliente) || codCliente <= 0)
            {
                MessageBox.Show("Por favor, insira um valor válido para o código do cliente.");
                return;
            }

            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta ficha?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirFicha();
                }
            }
        }

        private void ExcluirFicha()
        {
            if (aFicha != null)
            {
                try
                {
                    CTLFichas fichaController = new CTLFichas();
                    fichaController.ExcluirFicha(aFicha.Id);

                    // Feche o formulário após a exclusão
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o cliente devido a outros registros estarem vinclulados a esta ficha.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir a ficha. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCliente.Text))
            {
                // Se o campo txtCodCliente estiver vazio, limpe também o campo txtCliente
                txtCodCliente.Clear();
                txtCliente.Clear();
            }
            else if (int.TryParse(txtCodCliente.Text, out int codCliente) && codCliente > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtCliente
                Clientes Valida = aCTLClientes.BuscarClientePorId(codCliente);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodCliente.Clear();
                    txtCliente.Clear();
                    txtCodCliente.Focus();
                }
                else
                {
                    txtCliente.Text = Valida.Nome;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodCliente.Clear();
                txtCliente.Clear();
                txtCodCliente.Focus();
            }
        }


        private void ValidarValorKeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((TextBox)sender, e);
        }
    }
}
