using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;

namespace test.Views.Painel
{
    public partial class FrmControleDeAcesso : test.Views.Cadastros.FrmCadastro
    {
        Usuarios oUsuario;
        private CTLPermissaoMenu permissaoMenuController;
        CTLOpcoes opcoesController;
        CTLUsuarios CTLUsuarios;
        string perfilAtual = "";
        public FrmControleDeAcesso()
        {
            InitializeComponent();
            oUsuario = new Usuarios();
            permissaoMenuController = new CTLPermissaoMenu();
            opcoesController = new CTLOpcoes();
            CTLUsuarios = new CTLUsuarios();
           
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Usuarios)
            {
                oUsuario = (Usuarios)obj;
            }
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oUsuario.Id.ToString();
            lblNome.Text = oUsuario.Nome;
            lblEmail.Text = oUsuario.Email;
            lblAdmin.Text = oUsuario.Status;
            lblPerfil.Text = oUsuario.Perfil;
            lblUser.Text = oUsuario.Usuario;
            perfilAtual = oUsuario.Perfil;// pega o valor do perfil.
            CarregaDGV();
        }
        public void CarregaDGV()
        {
            try
            {
                // Carregar as opções de menu
                List<Opcoes> opcoesMenu = opcoesController.ObterOpcoesDoMenu();

                // Limpar as colunas e definir a configuração do DataGridView
                dgv.Columns.Clear();
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
                dgv.DefaultCellStyle.Font = new Font("Arial", 14);

                // Adicionar a coluna de descrição
                DataGridViewTextBoxColumn colunaDescricao = new DataGridViewTextBoxColumn();
                colunaDescricao.Name = "descricao";
                colunaDescricao.HeaderText = "Descrição";
                colunaDescricao.Width = 813;
                dgv.Columns.Add(colunaDescricao);

                // Adicionar as colunas de CheckBox para cada opção de menu
                DataGridViewCheckBoxColumn checkBoxAdicionar = new DataGridViewCheckBoxColumn();
                checkBoxAdicionar.Name = "acessoAdicionar";
                checkBoxAdicionar.HeaderText = "ADD";
                checkBoxAdicionar.Width = 50;
                dgv.Columns.Add(checkBoxAdicionar);

                DataGridViewCheckBoxColumn checkBoxAlterar = new DataGridViewCheckBoxColumn();
                checkBoxAlterar.Name = "acessoAlterar";
                checkBoxAlterar.HeaderText = "ALT";
                checkBoxAlterar.Width = 50;
                dgv.Columns.Add(checkBoxAlterar);

                DataGridViewCheckBoxColumn checkBoxExcluir = new DataGridViewCheckBoxColumn();
                checkBoxExcluir.Name = "acessoExcluir";
                checkBoxExcluir.HeaderText = "EXC";
                checkBoxExcluir.Width = 50;
                dgv.Columns.Add(checkBoxExcluir);

                DataGridViewCheckBoxColumn checkBoxConsultar = new DataGridViewCheckBoxColumn();
                checkBoxConsultar.Name = "acessoConsultar";
                checkBoxConsultar.HeaderText = "CON";
                checkBoxConsultar.Width = 51;
                dgv.Columns.Add(checkBoxConsultar);

                // Adicionar as opções de menu ao DataGridView e definir os valores dos CheckBoxes com base nas permissões do usuário
                foreach (var opcao in opcoesMenu)
                {
                    // Verificar se o usuário possui permissões para esta opção
                    PermissaoMenu permissao = permissaoMenuController.ObterPermissaoMenu(oUsuario.Id, opcao.Id);

                    int index = dgv.Rows.Add(opcao.Descricao);

                    // Define os valores dos CheckBoxes com base nas permissões do usuário
                    if (permissao != null)
                    {
                        dgv.Rows[index].Cells["acessoAdicionar"].Value = permissao.PodeAdicionar;
                        dgv.Rows[index].Cells["acessoAlterar"].Value = permissao.PodeAlterar;
                        dgv.Rows[index].Cells["acessoExcluir"].Value = permissao.PodeExcluir;
                        dgv.Rows[index].Cells["acessoConsultar"].Value = permissao.PodeConsultar;
                    }
                    else
                    {
                        dgv.Rows[index].Cells["acessoAdicionar"].Value = false;
                        dgv.Rows[index].Cells["acessoAlterar"].Value = false;
                        dgv.Rows[index].Cells["acessoExcluir"].Value = false;
                        dgv.Rows[index].Cells["acessoConsultar"].Value = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as opções de menu: " + ex.Message);
            }
        }
        public override void Salvar()
        {
            try
            {
                List<Opcoes> opcoesMenu = opcoesController.ObterOpcoesDoMenu();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    int opcaoIndex = row.Index;

                    // Verifica se o índice está dentro dos limites da lista de opções
                    if (opcaoIndex >= 0 && opcaoIndex < opcoesMenu.Count)
                    {
                        bool podeAdicionar = Convert.ToBoolean(row.Cells["acessoAdicionar"].Value);
                        bool podeAlterar = Convert.ToBoolean(row.Cells["acessoAlterar"].Value);
                        bool podeExcluir = Convert.ToBoolean(row.Cells["acessoExcluir"].Value);
                        bool podeConsultar = Convert.ToBoolean(row.Cells["acessoConsultar"].Value);

                        Opcoes opcao = opcoesMenu[opcaoIndex]; // Obter a opção de menu correspondente

                        // Verificar se já existe uma permissão para a opção de menu e usuário especificados
                        PermissaoMenu permissaoExistente = permissaoMenuController.ObterPermissaoMenu(oUsuario.Id, opcao.Id);

                        if (permissaoExistente != null)
                        {
                            // Se a permissão já existir, atualiza seus valores
                            permissaoExistente.PodeAdicionar = podeAdicionar;
                            permissaoExistente.PodeAlterar = podeAlterar;
                            permissaoExistente.PodeExcluir = podeExcluir;
                            permissaoExistente.PodeConsultar = podeConsultar;

                            // Atualizar a permissão existente no banco de dados
                            permissaoMenuController.SalvarUsuarioComPermissao(permissaoExistente, oUsuario);
                        }
                        else
                        {
                            // Se a permissão não existir, cria uma nova e a salva no banco de dados
                            PermissaoMenu novaPermissao = new PermissaoMenu(oUsuario, opcao, podeAdicionar, podeAlterar, podeExcluir, podeConsultar);
                            permissaoMenuController.SalvarUsuarioComPermissao(novaPermissao, oUsuario);
                          //  CTLUsuarios.AtualizarUsuario(oUsuario);
                        }
                    }
                    else
                    {
                        // Trate o caso em que o índice está fora dos limites da lista
                        // Pode exibir uma mensagem de erro ou fazer outra ação necessária
                    }
                }

                MessageBox.Show("Permissões salvas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar as permissões: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTornarADM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Alterar o status de administrador do usuário?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                CTLUsuarios oUserControl = new CTLUsuarios();
                string perfil = oUsuario.Perfil;

                if (perfil == "Admin")
                {
                    DialogResult result2 = MessageBox.Show("O usuário já é um administrador. Deseja revogar seus privilégios?", "Confirmação", MessageBoxButtons.YesNo);

                    if (result2 == DialogResult.Yes)
                    {
                        oUsuario.Perfil = "Usuário";
                        oUserControl.AtualizarUsuario(oUsuario);
                        MessageBox.Show("Direitos revogados com sucesso !");
                        Close();
                    }
                    // Se o usuário optar por não revogar os privilégios, apenas fecha o diálogo
                }
                else
                {
                    oUsuario.Perfil = "Admin";
                    oUserControl.AtualizarUsuario(oUsuario);
                    MessageBox.Show("Sucesso, O usuário agora é um administrador!");
                    Close();
                }
            }
            // Se o usuário optar por não alterar o status, apenas fecha o diálogo
        }
        protected override void Verificar()
        {
            Salvar();
        }
        private void AlterarValorColuna(string nomeColuna, bool novoValor)
        {
            bool allCellsChecked = true;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[nomeColuna] as DataGridViewCheckBoxCell;

                if (cell.Value == null || !(bool)cell.Value)
                {
                    allCellsChecked = false;
                    break;
                }
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[nomeColuna] as DataGridViewCheckBoxCell;

                cell.Value = allCellsChecked ? false : true;
            }
        }
        private void LimparPreencherCheckBoxes(bool preencher)
        {
            lblPerfil.Text = perfilAtual;
            oUsuario.Perfil = perfilAtual;
            string[] acessos = { "AcessoAdicionar", "AcessoAlterar", "AcessoExcluir", "AcessoConsultar" };

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (string acesso in acessos)
                {
                    DataGridViewCheckBoxCell cell = row.Cells[acesso] as DataGridViewCheckBoxCell;
                    cell.Value = preencher;
                }
            }
        }
       public void ChefeCB()
        {
            CTLUsuarios oUserControl = new CTLUsuarios();
            oUsuario.Perfil = "Chefe";
            lblPerfil.Text = "Chefe";
            string[] colunasAlvo = { "AcessoAdicionar", "AcessoAlterar", "AcessoExcluir", "AcessoConsultar" };
            string colunaExclusaoNome = "Descricao";// VAI ADICIONAR TODOS EXCETO O QUE EU SELECIONAR A BAIXO
            string[] valoresExclusao = { "CONFIGURAR MENU", "USUARIOS DO SISTEMA", "SENHAS", "CATEGORIA DE SENHAS" };

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (string colunaAlvoNome in colunasAlvo)
                {
                    DataGridViewCheckBoxCell cell = row.Cells[colunaAlvoNome] as DataGridViewCheckBoxCell;
                    DataGridViewCell colunaExclusaoCell = row.Cells[colunaExclusaoNome];

                    string valorExclusao = colunaExclusaoCell.Value?.ToString();

                    if (valorExclusao == null || !valoresExclusao.Contains(valorExclusao))
                    {
                        cell.Value = true;
                    }
                    else
                    {
                        cell.Value = false;
                    }
                }
               
            }
         
        }
        private void UserCBAdicionar()
        {
            oUsuario.Perfil = "Usuário";
            lblPerfil.Text = "Usuário";
            string[] colunasAlvo = { "AcessoAdicionar", "AcessoAlterar", "AcessoConsultar" };
            string colunaExclusaoNome = "Descricao"; // VAI ADICIONAR TODOS EXCETO O QUE EU SELECIONAR A BAIXO
            string[] valoresExclusao = { "CONFIGURAR MENU", "USUARIOS DO SISTEMA", "SENHAS", "CATEGORIA DE SENHAS", "FUNCIONÁRIOS" };


            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (string colunaAlvoNome in colunasAlvo)
                {
                    DataGridViewCheckBoxCell cell = row.Cells[colunaAlvoNome] as DataGridViewCheckBoxCell;
                    DataGridViewCell colunaExclusaoCell = row.Cells[colunaExclusaoNome];

                    string valorExclusao = colunaExclusaoCell.Value?.ToString();

                    if (valorExclusao == null || !valoresExclusao.Contains(valorExclusao))
                    {
                        cell.Value = true;
                    }
                    else
                    {
                        cell.Value = false;
                    }
                }
            }

        }
        private void VisualizaCB()
        {
            oUsuario.Perfil = "Visualisação";
            lblPerfil.Text = "Visualisação";
            string[] colunasAlvo2 = { "AcessoConsultar" };
            string colunaExclusaoNome2 = "Descricao";// VAI ADICIONAR TODOS EXCETO O QUE EU SELECIONAR A BAIXO
            string[] valoresExclusao2 = { "CONFIGURAR MENU", "USUARIOS DO SISTEMA", "SENHAS" , "CATEGORIA DE SENHAS", "FUNCIONÁRIOS" };

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (string colunaAlvoNome2 in colunasAlvo2)
                {
                    DataGridViewCheckBoxCell cell = row.Cells[colunaAlvoNome2] as DataGridViewCheckBoxCell;
                    DataGridViewCell colunaExclusaoCell2 = row.Cells[colunaExclusaoNome2];

                    string valorExclusao2 = colunaExclusaoCell2.Value?.ToString();

                    if (valorExclusao2 == null || !valoresExclusao2.Contains(valorExclusao2))
                    {
                        cell.Value = true;
                    }
                    else
                    {
                        cell.Value = false;
                    }
                }
            }
        }
        private void AdicionarCB()
        {
            AlterarValorColuna("AcessoAdicionar", chkAdd.Checked);
        }
        private void AlterarCB()
        {
            AlterarValorColuna("AcessoAlterar", chkAlt.Checked);
        }
        private void ExcluirCB()
        {
            AlterarValorColuna("AcessoExcluir", chkExc.Checked);
        }
        private void ConsultarCB()
        {
            AlterarValorColuna("AcessoConsultar", chkCons.Checked);
        }
        private void chkAdd_CheckedChanged(object sender, EventArgs e)
        {
            AdicionarCB();
        }
        private void chkAlt_CheckedChanged(object sender, EventArgs e)
        {
            AlterarCB();
        }
        private void chkExc_CheckedChanged(object sender, EventArgs e)
        {
            ExcluirCB();
        }
        private void chkCons_CheckedChanged(object sender, EventArgs e)
        {
            ConsultarCB();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }
        private void btnTodos_Click(object sender, EventArgs e)
        {
            LimparPreencherCheckBoxes(true);
        }
        private void btnChefe_Click(object sender, EventArgs e)
        {
            LimparPreencherCheckBoxes(false);
            ChefeCB();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            LimparPreencherCheckBoxes(false);
            UserCBAdicionar();
        }
        private void btnVisualiza_Click(object sender, EventArgs e)
        {
            LimparPreencherCheckBoxes(false);
            VisualizaCB();
        }
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            LimparPreencherCheckBoxes(false);
        }
    }
}
