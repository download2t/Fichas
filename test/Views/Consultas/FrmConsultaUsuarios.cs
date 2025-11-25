using System;
using System.Windows.Forms;
using test.Controllers;
using test.Classes;
using test.Views.Cadastros;
using System.Collections.Generic;
using static test.Views.FrmLogin;

namespace test.Views.Consultas
{
    public partial class FrmConsultaUsuarios : FrmConsulta
    {
        private CTLUsuarios CTLUsuarios;
        private Usuarios oUser;
        private FrmCadastroUsuarios frmCadastro;
        private string AcessosLiberados = "USUARIOS DO SISTEMA";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        int setorUser = 0; //  armazena o id do setor dentro do codigo, para poder mostrar os campos devidos.


        public FrmConsultaUsuarios()
        {
            InitializeComponent();
            oUser = new Usuarios();
            CTLUsuarios = new CTLUsuarios();
            LiberarAcessos(AcessosLiberados);
            this.Controls.Add(dgv);
            this.Resize += FrmConsulta_Resize; // Associa o evento de redimensionamento
            DataGrid();
        }

        public override void DataGrid()
        {
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", DataPropertyName = "Id", Width = 60 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", DataPropertyName = "Nome", Width = 135 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Sobrenome", HeaderText = "Sobrenome", DataPropertyName = "Sobrenome", Width = 190 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", HeaderText = "Email", DataPropertyName = "Email", Width = 200 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Usuario", HeaderText = "Usuário", DataPropertyName = "Usuario", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "DataNascimento", HeaderText = "Data Nascimento", DataPropertyName = "DataNascimento", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "SetorId", HeaderText = "Setor", DataPropertyName = "SetorId", Width = 140 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "Status", Width = 60 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Perfil", HeaderText = "Perfil", DataPropertyName = "Perfil", Width = 100 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "DataCadastro", HeaderText = "Data Cadastro", DataPropertyName = "DataCadastro", Width = 150 });

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }


        public override void Sair()
        {
            if (btnSair.Text == "Sair")
            {
                base.Sair();
            }
            else if (btnSair.Text == "Selecionar")
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgv.SelectedRows[0];
                    IdSelecionado = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    NomeSelecionado = Convert.ToString(selectedRow.Cells["Nome"].Value);
                }
                this.Close();
            }
        }

        protected override void LiberarAcessos(string AcessosLiberados)
        {
            oUser.CopyFrom(UserSession.User);
            bool isAdmin = CTLUsuarios.VerificaAdmin(oUser.Id); // Verifica se o usuário é um administrador

            if (!isAdmin)
            {
                CTLPermissaoMenu permissaoMenuController = new CTLPermissaoMenu();
                var usuarioAcessos = permissaoMenuController.ObterPermissoesPorUsuario(oUser.Id);

                // LIBERAR ACESSOS
                if (!permissaoMenuController.OpcaoLiberadaAdicionar(AcessosLiberados, usuarioAcessos))
                    btnIncluir.Enabled = false;
                if (!permissaoMenuController.OpcaoLiberadaAlterar(AcessosLiberados, usuarioAcessos))
                    btnAlterar.Enabled = false;
                if (!permissaoMenuController.OpcaoLiberadaExcluir(AcessosLiberados, usuarioAcessos))
                    btnExcluir.Enabled = false;
                btnAcessos.Enabled = false;
            }
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
            CTLUsuarios.Incluir();
            CarregaDGV();
        }

        private void Acessos()
        {
            int idUsuario = ObterIdSelecionado();
            if (idUsuario > 0)
            {
                Usuarios usuario = CTLUsuarios.BuscarUsuarioPorId(idUsuario);
                if (usuario != null)
                {
                    CTLUsuarios.Acessos(usuario);
                    CarregaDGV();
                }
            }
        }

        public override void Alterar()
        {
            base.Alterar();
            int idUsuario = ObterIdSelecionado();
            if (idUsuario > 0)
            {
                Usuarios usuario = CTLUsuarios.BuscarUsuarioPorId(idUsuario);
                if (usuario != null)
                {
                    CTLUsuarios.Alterar(usuario);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idUsuario = ObterIdSelecionado();
            if (idUsuario > 0)
            {
                Usuarios usuario = CTLUsuarios.BuscarUsuarioPorId(idUsuario);
                if (usuario != null)
                {
                    CTLUsuarios.Excluir(usuario);
                    CarregaDGV();
                }
            }
        }

        public override void Visualizar()
        {
            if (btnSair.Text == "Selecionar")
            {
                btnSair.PerformClick();
            }
            else if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Usuarios usuario = CTLUsuarios.BuscarUsuarioPorId(id);

                if (usuario != null)
                {
                    CTLUsuarios.Visualizar(usuario);
                }
            }
        }

        private void PreencherUsuariosDataGridView(IEnumerable<Usuarios> usuarios)
        {   
            dgv.Rows.Clear();

            foreach (var usuario in usuarios)
            {
                // Protege contra propriedades nulas (ex.: usuario.Setor pode ser null)
                string setorNome = usuario?.Setor?.Setor ?? "";
                string dataNasc = usuario?.DataNascimento?.ToString() ?? "";
                string dataCad = usuario?.DataCadastro?.ToString() ?? "";

                dgv.Rows.Add(
                    usuario?.Id ?? 0,
                    usuario?.Nome ?? "",
                    usuario?.Sobrenome ?? "",
                    usuario?.Email ?? "",
                    usuario?.Usuario ?? "",
                    dataNasc,
                    setorNome,
                    usuario?.Status ?? "",
                    usuario?.Perfil ?? "",
                    dataCad
                );
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();

            // Use o método de preenchimento para atualizar o DataGridView
            PreencherUsuariosDataGridView(CTLUsuarios.ListarUsuarios());
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = CTLUsuarios.PesquisarUsuariosPorCriterio(criterioPesquisa, valorPesquisa);

                // Use o método de preenchimento para atualizar o DataGridView
                PreencherUsuariosDataGridView(resultados);
            }
        }

        protected override void Atualizar()
        {
            base.Atualizar();
            CarregaDGV();
        }

        private int ObterIdSelecionado()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);
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

        private void btnAcessos_Click(object sender, EventArgs e)
        {
            Acessos();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void FrmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
