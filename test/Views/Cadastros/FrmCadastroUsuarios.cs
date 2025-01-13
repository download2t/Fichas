using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Data;
using test.Model;
using test.Views.Consultas;
using static test.Views.FrmLogin;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroUsuarios :FrmCadastro
    {
        private Usuarios oUsuario;
        private CTLUsuarios aCTLUsuarios;
        private FrmConsultaUsuarios consultaUsuarios;

        public FrmCadastroUsuarios()
        {
            InitializeComponent();
            aCTLUsuarios = new CTLUsuarios();
            oUsuario = new Usuarios();
            
        }

        public void SetConsultaUsuarios(FrmConsultaUsuarios consultaUsuarios)
        {
            this.consultaUsuarios = consultaUsuarios;
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Usuarios usuario)
            {
                oUsuario = usuario;
                CarregarCampos();
            }
        }

        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtNome.Clear();
            txtSobrenome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirma.Clear();
            txtUsuario.Clear();
            txtCodSetor.Clear();
            txtSetor.Clear();
            cmbPerfil.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtNascimento.Value = DateTime.Now;
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtSobrenome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirma.Enabled = false;
            txtUsuario.Enabled = false;
            cmbPerfil.Enabled = false;
            cmbStatus.Enabled = false;
            txtSetor.Enabled = false;
            txtCodSetor.Enabled = false;
            dtNascimento.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = false;
            txtNome.Enabled = true;
            txtSobrenome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            txtConfirma.Enabled = true;
            txtUsuario.Enabled = true;
            cmbPerfil.Enabled = true;
            cmbStatus.Enabled = true;
            txtSetor.Enabled = true;
            txtCodSetor.Enabled= true;
            dtNascimento.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oUsuario.Id.ToString();
            txtNome.Text = oUsuario.Nome;
            txtSobrenome.Text = oUsuario.Sobrenome;
            txtEmail.Text = oUsuario.Email;        
            txtUsuario.Text = oUsuario.Usuario;
            cmbPerfil.SelectedItem = oUsuario.Perfil;
            cmbStatus.SelectedItem = oUsuario.Status;
            txtSetor.Text = oUsuario.Setor.Setor;
            txtCodSetor.Text = oUsuario.Setor.Id.ToString();
            dtNascimento.Value = oUsuario.DataNascimento ?? DateTime.Now;
        }

        public override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                oUsuario.Nome = txtNome.Text;
                oUsuario.Sobrenome = txtSobrenome.Text;
                oUsuario.Email = txtEmail.Text;
                oUsuario.Usuario = txtUsuario.Text;
                oUsuario.Perfil = cmbPerfil.SelectedItem?.ToString();
                oUsuario.Status = cmbStatus.SelectedItem?.ToString();
                DateTime DataCadastro = DateTime.Now;
                oUsuario.DataCadastro = DataCadastro;
                oUsuario.DataNascimento = dtNascimento.Value;
                oUsuario.Setor.Id = Convert.ToInt32(txtCodSetor.Text);

                string senha = txtSenha.Text;
                string confirmaSenha = txtConfirma.Text;

                if (oUsuario.Id == 0)
                {
                    if (!string.IsNullOrWhiteSpace(senha) || !string.IsNullOrWhiteSpace(confirmaSenha))
                    {
                        if (senha == confirmaSenha)
                        {
                            oUsuario.Senha = DALUsuarios.CriptografarSenha(senha); // Criptografa a senha
                            aCTLUsuarios.AdicionarUsuario(oUsuario);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("As senhas não correspondem. Por favor, verifique.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("A senha é obrigatória ao adicionar um novo usuário.");
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(senha) || !string.IsNullOrWhiteSpace(confirmaSenha))
                    {
                        if (senha == confirmaSenha)
                        {
                            oUsuario.Senha = DALUsuarios.CriptografarSenha(senha); // Criptografa a senha
                            aCTLUsuarios.AtualizarUsuario(oUsuario);
                            Close();
                        }
                        else
                            MessageBox.Show("As senhas não correspondem. Por favor, verifique.");
                        
                    }
                    else
                    {
                        aCTLUsuarios.AtualizarUsuarioSemSenha(oUsuario);
                        Close();
                    }
                }

            }
        }

        protected override bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                camposFaltantes.Add("Nome");
            }

            if (dtNascimento.Value == DateTime.Today)
            {
                camposFaltantes.Add("Data de nascimento");
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                camposFaltantes.Add("E-mail");
            }

            if (string.IsNullOrWhiteSpace(txtCodSetor.Text))
            {
                camposFaltantes.Add("Código da cidade");
            }
            else
            {
                if (!int.TryParse(txtCodSetor.Text, out int cod) || cod <= 0)
                {
                    camposFaltantes.Add("Código do setor (deve ser um número maior que zero)");
                }
            }

            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                camposFaltantes.Add("Status");
            }
            // Verificação da data de nascimento
            if (dtNascimento.Value > DateTime.Now)
            {
                camposFaltantes.Add("Data (não pode ser uma data futura)");
            }

            if (string.IsNullOrWhiteSpace(txtSobrenome.Text))
            {
                camposFaltantes.Add("Sobrenome");
            }
            // Verificação da data de nascimento
            if (dtNascimento.Value > DateTime.Now)
            {
                camposFaltantes.Add("Data (não pode ser uma data futura)");
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                camposFaltantes.Add("Usuario");
            }

            if ((cmbPerfil.Text == "Admin") && (UserSession.User.Perfil != "Admin"))
            {
                    MessageBox.Show("Usuário não tem direitos de administrador!");
                    txtNome.Focus();
                    return false;
            }
            if (camposFaltantes.Count > 0)
            {
                string camposFaltantesStr = string.Join(", ", camposFaltantes);
                MessageBox.Show("Os seguintes campos são obrigatórios e não foram preenchidos: " + camposFaltantesStr, "Campos em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

   
        private void ExcluirUsuarios()
        {
            if (oUsuario != null)
            {
                try
                {
                    CTLUsuarios CTLUsuarios = new CTLUsuarios();
                    CTLUsuarios.ExcluirUsuario(oUsuario.Id);

                    // Feche o formulário após a exclusão
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o cliente devido a outros registros estarem vinclulados a este usuário.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o usuário. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }
        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirUsuarios();
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (!string.IsNullOrEmpty(email) && !Operacao.IsEmail(email))
            {
                MessageBox.Show("E-mail inválido. Por favor, insira um endereço de e-mail válido.");
                txtEmail.Clear();
                txtEmail.Focus();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            if (!string.IsNullOrEmpty(usuario)) // Verifica se a string não está vazia
            {
                CTLUsuarios userController = new CTLUsuarios();
                Usuarios user = userController.BuscarUsuarioPorNome(usuario);

                if (user != null)
                {
                    MessageBox.Show("Usuário já cadastrado!");
                    txtUsuario.Clear();
                }
                else
                {
                    MessageBox.Show("Usuário Livre!!!");
                    txtUsuario.ForeColor = Color.Green;
                }
            }
            else
            {
                MessageBox.Show("Digite um nome de usuário válido.");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.ForeColor= Color.Black;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text != string.Empty)
                 btnVerificar.PerformClick();
        }

        private void btnPesquisarSetor_Click(object sender, EventArgs e)
        {
            using (FrmConsultaSetores consulta = new FrmConsultaSetores())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodSetor.Text = IdSelecionado.ToString();
                txtSetor.Text = NomeSelecionado;
            }
        }

        private void txtCodSetor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((TextBox)sender, e);
        }

        private void txtCodSetor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodSetor.Text))
            {
                // Se o campo txtCodCliente estiver vazio, limpe também o campo txtCliente
                txtCodSetor.Clear();
                txtSetor.Clear();
            }
            else if (int.TryParse(txtCodSetor.Text, out int codSetor) && codSetor > 0)
            {
                CTLSetores aCTLSetor = new CTLSetores();
                Setores Valida = aCTLSetor.BuscarSetorPorId(codSetor);
               
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimpraSetor();

                }
                else
                {
                    txtSetor.Text = Valida.Setor;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimpraSetor();
            }
        }
        private void LimpraSetor()
        {
            txtCodSetor.Clear();
            txtSetor.Clear();
            txtCodSetor.Focus();
        }
    }
}
