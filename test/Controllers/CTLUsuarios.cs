using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Data;
using test.Model;
using test.Views.Cadastros;
using test.Views.Painel;

namespace test.Controllers
{
    public class CTLUsuarios

    {
        private DALUsuarios usuariosDAL = new DALUsuarios();

        public bool AdicionarUsuario(Usuarios usuario)
        {
            return usuariosDAL.AdicionarUsuario(usuario);
        }

        public void AtualizarUsuario(Usuarios usuario)
        {
            // Verificar se o ID é 5 (Administrador Geral)
            if (usuario.Id == 5)
            {
                // Garantir que o perfil seja sempre "Admin"
                usuario.Perfil = "Admin";
            }

            // Atualizar o usuário no banco de dados
            usuariosDAL.AtualizarUsuario(usuario);
        }

        public void AtualizarUsuarioSemSenha(Usuarios usuario)
        {
            // Verificar se o ID é 5 (Administrador Geral)
            if (usuario.Id == 5)
            {
                // Garantir que o perfil seja sempre "Admin"
                usuario.Perfil = "Admin";
            }
            usuariosDAL.AtualizarUsuario(usuario);
        }

        public void ExcluirUsuario(int usuarioId)
        {
            if (usuarioId != 5)// Verificar se o ID é 5 (Administrador Geral)
            {
                usuariosDAL.ExcluirUsuario(usuarioId);
            }
            else
                MessageBox.Show("IMPOSSIVEL EXCLUIR ESTE USUÁRIO!");
        }

        public Usuarios BuscarUsuarioPorId(int id)
        {
            return usuariosDAL.BuscarUsuarioPorId(id);
        }
        public bool VerificaAdmin(int id)
        {
            return usuariosDAL.VerificarAdministrador(id);
        }
        public Usuarios BuscarUsuarioPorNome(string nome)
        {
            return usuariosDAL.BuscarUsuarioPorNome(nome);
        }
        public bool AlterarSenha(Usuarios usuario)
        {
            return usuariosDAL.AlterarSenha(usuario);
        }

        public List<Usuarios> ListarUsuarios()
        {
            return usuariosDAL.ListarUsuarios();
        }
        public Usuarios AutenticarUsuario(string username, string password)
        {
            return usuariosDAL.AutenticarUsuario(username, password);
        }

        public void Acessos(Usuarios usuario)
        {
            if (usuario != null)
            {
                FrmControleDeAcesso frmControle = new FrmControleDeAcesso();
                frmControle.ConhecaObj(usuario);
                frmControle.CarregarCampos();
                frmControle.ShowDialog();
            }
        }
        public void Incluir()
        {
            FrmCadastroUsuarios frmCadastroUsuarios = new FrmCadastroUsuarios();
            frmCadastroUsuarios.Text = "Incluir Usuario";
            frmCadastroUsuarios.cmbStatus.Text = "Ativo";
            frmCadastroUsuarios.cmbStatus.Enabled = false;
            frmCadastroUsuarios.ShowDialog();
        }

        public void Alterar(Usuarios usuario)
        {
            if (usuario != null)
            {
                FrmCadastroUsuarios frmCadastroUsuarios = new FrmCadastroUsuarios();
                frmCadastroUsuarios.ConhecaObj(usuario);
                frmCadastroUsuarios.Text = "Alterar Usuario";
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
                frmCadastroUsuarios.Text = "Excluir Usuario";
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
                frmCadastroUsuarios.Text = "Consultar Usuario";
                frmCadastroUsuarios.CarregarCampos();
                frmCadastroUsuarios.BloquearCampos();
                frmCadastroUsuarios.btnSalvar.Enabled = false;
                frmCadastroUsuarios.ShowDialog();
            }
        }
        public List<Usuarios> PesquisarUsuariosPorCriterio(string criterio, string valorPesquisa)
        {
            List<Usuarios> usuariosEncontrados = usuariosDAL.PesquisarUsuariosPorCriterio(criterio, valorPesquisa);
            return usuariosEncontrados;
        }

    }
}
