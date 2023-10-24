using System;
using System.Windows.Forms;
using test.Controllers;
using test.Classes;
using test.Views.Cadastros;
using System.Collections.Generic;

namespace test.Views.Consultas
{
    public partial class FrmConsultaUsuarios : FrmConsulta
    {
        private UsuariosController usuariosController;
        private Usuarios oUser;
        private FrmCadastroUsuarios frmCadastro;
        

        public FrmConsultaUsuarios()
        {
            InitializeComponent();
            usuariosController = new UsuariosController();
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroUsuarios)
            {
                frmCadastro = (FrmCadastroUsuarios)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Usuarios)
            {
                oUser = (Usuarios)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            usuariosController.Incluir();
            CarregaLV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idUsuario = ObterIdSelecionado();
            if (idUsuario > 0)
            {
                Usuarios usuario = usuariosController.BuscarUsuarioPorId(idUsuario);
                if (usuario != null)
                {
                    usuariosController.Alterar(usuario);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idUsuario = ObterIdSelecionado();
            if (idUsuario > 0)
            {
                Usuarios usuario = usuariosController.BuscarUsuarioPorId(idUsuario);
                if (usuario != null)
                {
                    usuariosController.Excluir(usuario);
                    CarregaLV();
                }
            }
        }
        public override void Visualizar()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Usuarios usuario = selectedItem.Tag as Usuarios;

                if (usuario != null)
                {
                    usuariosController.Visualizar(usuario);
                }
            }
        }
        private void PreencherUsuariosListView(IEnumerable<Usuarios> usuarios)
        {
            listView1.Items.Clear();

            foreach (var usuario in usuarios)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(usuario.Id));
                item.SubItems.Add(usuario.Nome);
                item.SubItems.Add(usuario.Sobrenome);
                item.SubItems.Add(usuario.Email);
                item.SubItems.Add(usuario.Usuario);
                item.SubItems.Add(usuario.DataNascimento?.ToString() ?? "");
                item.SubItems.Add(usuario.Senha);
                item.SubItems.Add(usuario.Status);
                item.SubItems.Add(usuario.Perfil);
                item.SubItems.Add(usuario.DataCadastro?.ToString() ?? "");
                item.Tag = usuario; // Associe o objeto Usuarios ao item usando a propriedade Tag
                listView1.Items.Add(item);
            }
        }
        public override void CarregaLV()
        {
            base.CarregaLV();

            // Use o método de preenchimento para atualizar a ListView
            PreencherUsuariosListView(usuariosController.ListarUsuarios());
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = usuariosController.PesquisarUsuariosPorCriterio(criterioPesquisa, valorPesquisa);

                // Use o método de preenchimento para atualizar a ListView
                PreencherUsuariosListView(resultados);
            }
        }


        protected override void Atualizar()
        {
            base.Atualizar();
            CarregaLV();
        }

        private int ObterIdSelecionado()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                return int.Parse(listView1.SelectedItems[0].Text);
            }
            return 0;
        }
        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID"; // Pesquisar pelo ID
            }
            else if (rbNome.Checked)
            {
                return "Nome"; // Pesquisar pelo Nome
            }
            else if (rbEmail.Checked)
            {
                return "Email"; // Pesquisar pelos Emails
            }

            return string.Empty; // Nenhum critério selecionado
        }
    }
}
