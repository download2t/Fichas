using System;
using System.Windows.Forms;
using test.Controllers;
using test.Classes;
using test.Data;

namespace test.Views
{
    public partial class FrmLogin : Form
    {
        private UsuariosController usuariosController;
        private UsuariosDAO userDAO = new UsuariosDAO();
        public static class UserSession
        {
            public static Usuarios User { get; set; }
        }
        public FrmLogin()
        {
            InitializeComponent();
            usuariosController = new UsuariosController();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string senhaDigitada = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(senhaDigitada))
            {
                MessageBox.Show("Por favor, preencha ambos os campos de nome de usuário e senha.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string senhaCriptografada = UsuariosDAO.CriptografarSenha(senhaDigitada); // Criptografa a senha digitada

                Usuarios usuarioAutenticado = usuariosController.AutenticarUsuario(username, senhaCriptografada);

                if (usuarioAutenticado != null)
                {
                    UserSession.User = usuarioAutenticado;

                    FrmPrincipal mainForm = new FrmPrincipal();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nome de usuário ou senha incorretos. Tente novamente.", "Login Falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtSenha.Clear();
                    txtSenha.Focus();
                }
            }
        }

    }
}
