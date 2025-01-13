using System;
using System.Collections.Generic;
using test.Classes;
using test.Model;
using test.Data;
using test.Views.Painel;
using test.DAL;

namespace test.Controllers
{
    public class CTLPermissaoMenu
    {
        private DALPermissaoMenu permissaoMenuDAL = new DALPermissaoMenu();

        public void AdicionarPermissaoMenu(PermissaoMenu permissaoMenu)
        {
            permissaoMenuDAL.AdicionarPermissaoMenu(permissaoMenu);
        }
        public void SalvarUsuarioComPermissao(PermissaoMenu permissaoMenu, Usuarios usuario)
        {
            permissaoMenuDAL.SalvarUsuarioEPermissao(permissaoMenu, usuario);
        }
        public bool AdicionaPermissaoDoTipo(string tipo, int usuarioId)
        {
           return  permissaoMenuDAL.AdicionaPermissaoDoTipo(tipo, usuarioId);
        }
        public void AtualizarPermissaoMenu(PermissaoMenu permissaoMenu)
        {
            permissaoMenuDAL.AtualizarPermissaoMenu(permissaoMenu);
        }

        public void RemoverPermissaoMenu(int usuarioId, int menuOpcaoId)
        {
            permissaoMenuDAL.RemoverPermissaoMenu(usuarioId, menuOpcaoId);// Não utilizado.
        }

        public PermissaoMenu ObterPermissaoMenu(int usuarioId, int menuOpcaoId)
        {
            return permissaoMenuDAL.ObterPermissaoMenu(usuarioId, menuOpcaoId);
        }
        public List<Opcoes> ObterOpcoesMenuExceto(string tipo)
        {
            return permissaoMenuDAL.ObterOpcoesMenuExceto(tipo);
        }


        // Métodos adicionais conforme necessário para interagir com a view
        public void AbrirFormularioAdicionar()
        {
            FrmControleDeAcesso frmCadastroPermissaoMenu = new FrmControleDeAcesso();
            frmCadastroPermissaoMenu.ShowDialog();
        }


        public List<PermissaoMenu> ObterPermissoesPorUsuario(int usuarioId)
        {
            return permissaoMenuDAL.ObterPermissoesPorUsuario(usuarioId);
        }

        public bool OpcaoLiberadaAdicionar(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return permissaoMenuDAL.OpcaoLiberadaAdicionar(opcao, usuarioAcessos);
        }

        public bool OpcaoLiberadaAlterar(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return permissaoMenuDAL.OpcaoLiberadaAlterar(opcao, usuarioAcessos);
        }

        public bool OpcaoLiberadaExcluir(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return permissaoMenuDAL.OpcaoLiberadaExcluir(opcao, usuarioAcessos);
        }

        public bool OpcaoLiberadaConsultar(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return permissaoMenuDAL.OpcaoLiberadaConsultar(opcao, usuarioAcessos);
        }

    }
}
