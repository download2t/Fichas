using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Views.Cadastros;

namespace test.Controllers
{
    public class UsuariosController
      
    {
        private UsuariosDAO usuariosDAO = new UsuariosDAO();

        public void AdicionarUsuario(Usuarios usuario)
        {
            usuariosDAO.AdicionarUsuario(usuario);
        }

        public void AtualizarUsuario(Usuarios usuario)
        {
            usuariosDAO.AtualizarUsuario(usuario);
        }
        public void AtualizarUsuarioSemSenha(Usuarios usuario)
        {
            usuariosDAO.AtualizarUsuario(usuario);
        }

        public void ExcluirUsuario(int usuarioId)
        {
            usuariosDAO.ExcluirUsuario(usuarioId);
        }

        public Usuarios BuscarUsuarioPorId(int id)
        {
            return usuariosDAO.BuscarUsuarioPorId(id);
        }
        public bool AlterarSenha(Usuarios usuario)
        {
            return usuariosDAO.AlterarSenha(usuario);
        }

        public List<Usuarios> ListarUsuarios()
        {
            return usuariosDAO.ListarUsuarios();
        }
        public Usuarios AutenticarUsuario(string username, string password)
        {
            return usuariosDAO.AutenticarUsuario(username, password);
        }
        public void Incluir()
        {
            FrmCadastroUsuarios frmCadastroUsuarios = new FrmCadastroUsuarios();
            frmCadastroUsuarios.ShowDialog();
        }

        public void Alterar(Usuarios usuario)
        {
            if (usuario != null)
            {
                FrmCadastroUsuarios frmCadastroUsuarios = new FrmCadastroUsuarios();
                frmCadastroUsuarios.ConhecaObj(usuario);
                frmCadastroUsuarios.CarregarCampos();
                frmCadastroUsuarios.ShowDialog();
            }
        }

        public void Excluir(Usuarios usuario)
        {
            if (usuario != null)
            {
                FrmCadastroUsuarios frmCadastroUsuarios = new FrmCadastroUsuarios();
                frmCadastroUsuarios.ConhecaObj(usuario);
                frmCadastroUsuarios.CarregarCampos();
                frmCadastroUsuarios.BloquearCampos();
                frmCadastroUsuarios.btnSalvar.Text = "Excluir";
                frmCadastroUsuarios.ShowDialog();
            }
        }
        public void Visualizar(Usuarios usuario)
        {
            if (usuario != null)
            {
                FrmCadastroUsuarios frmCadastroUsuarios = new FrmCadastroUsuarios();
                frmCadastroUsuarios.ConhecaObj(usuario);
                frmCadastroUsuarios.CarregarCampos();
                frmCadastroUsuarios.BloquearCampos();
                frmCadastroUsuarios.btnSalvar.Enabled = false;
                frmCadastroUsuarios.ShowDialog();
            }
        }
        public List<Usuarios> PesquisarUsuariosPorCriterio(string criterio, string valorPesquisa)
        {
            List<Usuarios> usuariosEncontrados = new List<Usuarios>();

            if (criterio == "ID")
            {
                // Pesquisar por ID
                if (int.TryParse(valorPesquisa, out int id))
                {
                    Usuarios usuario = BuscarUsuarioPorId(id);
                    if (usuario != null)
                    {
                        usuariosEncontrados.Add(usuario);
                    }
                }
            }
            else if (criterio == "Nome")
            {
                // Pesquisar por Nome
                usuariosEncontrados = usuariosDAO.PesquisarUsuariosPorNome(valorPesquisa);
            }
            else if (criterio == "Email")
            {
                // Pesquisar por Email
                usuariosEncontrados = usuariosDAO.PesquisarUsuariosPorEmail(valorPesquisa);
            }

            return usuariosEncontrados;
        }
    }
}
