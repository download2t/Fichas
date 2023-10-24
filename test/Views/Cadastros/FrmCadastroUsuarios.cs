using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Data;
using test.Views.Consultas;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroUsuarios : FrmPai
    {
        private Usuarios oUsuario;
        private UsuariosController usuariosController;
        private FrmConsultaUsuarios consultaUsuarios;
        UsuariosDAO userDao = new UsuariosDAO();

        public FrmCadastroUsuarios()
        {
            InitializeComponent();
            usuariosController = new UsuariosController();
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
            cmbPerfil.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtCadastro.Value = DateTime.Now;
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
            dtCadastro.Enabled = false;
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
            dtCadastro.Enabled = true;
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
            dtCadastro.Value = oUsuario.DataCadastro ?? DateTime.Now;
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
                oUsuario.DataCadastro = dtCadastro.Value;
                oUsuario.DataNascimento = dtNascimento.Value;

                string senha = txtSenha.Text;
                string confirmaSenha = txtConfirma.Text;

                if (oUsuario.Id == 0)
                {
                    if (!string.IsNullOrWhiteSpace(senha) || !string.IsNullOrWhiteSpace(confirmaSenha))
                    {
                        if (senha == confirmaSenha)
                        {
                            oUsuario.Senha = UsuariosDAO.CriptografarSenha(senha); // Criptografa a senha
                            usuariosController.AdicionarUsuario(oUsuario);
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
                            oUsuario.Senha = UsuariosDAO.CriptografarSenha(senha); // Criptografa a senha
                            usuariosController.AtualizarUsuario(oUsuario);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("As senhas não correspondem. Por favor, verifique.");
                        }
                    }
                    else
                    {
                        usuariosController.AtualizarUsuarioSemSenha(oUsuario);
                        Close();
                    }
                }

            }
        }




        protected override bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Campo Nome não pode estar vazio.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSobrenome.Text))
            {
                MessageBox.Show("Campo Sobrenome não pode estar vazio.");
                txtSobrenome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Campo Email não pode estar vazio.");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Campo Usuário não pode estar vazio.");
                txtUsuario.Focus();
                return false;
            }

            return true;
        }
        private bool VerificaSenha()
        {
            string senha = txtSenha.Text;
            string confirmaSenha = txtConfirma.Text;

            if (string.IsNullOrWhiteSpace(senha) || senha != confirmaSenha)
            {
                return false;
            }

            return true;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
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
        private void ExcluirUsuarios()
        {
            if (oUsuario != null)
            {
                try
                {
                    UsuariosController usuariosController = new UsuariosController();
                    usuariosController.ExcluirUsuario(oUsuario.Id);

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



    }
}
