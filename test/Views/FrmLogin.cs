using System;
using System.Windows.Forms;
using test.Controllers;
using test.Classes;
using test.Data;
using System.Reflection;
using System.util;
using Controle.Views.Cadastros;
using Controle.Views;

namespace test.Views
{
    public partial class FrmLogin : Form
    {
        private CTLUsuarios CTLUsuarios;
        private DALUsuarios userDAL = new DALUsuarios();
        private bool senhaVisivel = false;
        public static class UserSession
        {
            public static Usuarios User { get; set; }
        }
        public FrmLogin()
        {
            InitializeComponent();
            CTLUsuarios = new CTLUsuarios();
        } 

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                string senhaCriptografada = DALUsuarios.CriptografarSenha(senhaDigitada); // Criptografa a senha digitada

                Usuarios usuarioAutenticado = CTLUsuarios.AutenticarUsuario(username, senhaCriptografada);

                if (usuarioAutenticado != null)
                {
                    UserSession.User = usuarioAutenticado;

                    FrmPrincipal mainForm = new FrmPrincipal();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    Usuarios usuarioEncontrado = CTLUsuarios.BuscarUsuarioPorNome(username);

                    if (usuarioEncontrado != null)
                    {
                        MessageBox.Show("Senha incorreta. Tente novamente.", "Login Falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário não encontrado.", "Login Falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtSenha.Clear();
                    txtSenha.Focus();
                }
            }
        }



        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Obtém a versão do Assembly
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            // Define o texto da Label com a versão
            lblVersao.Text += version;
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            senhaVisivel = !senhaVisivel;
            txtSenha.UseSystemPasswordChar = !senhaVisivel;

            AtualizarImagemOlho();
        }
        private void AtualizarImagemOlho()
        {
            if (senhaVisivel)
            {
                pbOlhoFechado.Visible = true; // Se a senha estiver visível, mostra o botão de olho fechado
                pbOlhoAberto.Visible = false; // Esconde o botão de olho aberto
            }
            else
            {
                pbOlhoFechado.Visible = false; // Esconde o botão de olho fechado
                pbOlhoAberto.Visible = true; // Se a senha estiver oculta, mostra o botão de olho aberto
            }
        }

        private void pbOlhoFechado_Click(object sender, EventArgs e)
        {
            pbOlhoFechado.Visible = false;
            pbOlhoAberto.Visible = true;
            txtSenha.UseSystemPasswordChar = false; // Mostra a senha
        }

        private void pbOlhoAberto_Click(object sender, EventArgs e)
        {
            pbOlhoFechado.Visible = true;
            pbOlhoAberto.Visible = false;
            txtSenha.UseSystemPasswordChar = true; // Esconde a senha
        }

    }
}
