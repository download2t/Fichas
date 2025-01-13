using Controle.Views.Cadastros;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;
using static test.Views.FrmLogin;

namespace Controle.Views.Consultas
{
    public partial class FrmConsultaOrdemDeServico : test.Views.Consultas.FrmConsulta
    {
        CTLOrdemDeServico aCTLOS;
        FrmCadastroOrdemDeServico frmCadastro;
        OrdemDeServico aOs;
        CTLUsuarios aCTLUser;
        Usuarios oUsuario;
        private string AcessosLiberados = "ORDEM DE SERVIÇO";

        public FrmConsultaOrdemDeServico()
        {
            InitializeComponent();
            aCTLOS = new CTLOrdemDeServico();
            aCTLUser = new CTLUsuarios();
            oUsuario = new Usuarios();
            oUsuario.CopyFrom(UserSession.User);
            aOs = new OrdemDeServico();
            LiberarAcessos(AcessosLiberados);
            DataGrid();
            this.Controls.Add(dgv);
            this.Resize += FrmConsulta_Resize; // Associa o evento de redimensionamento
        }

        public override void DataGrid()
        {
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            // Adiciona a coluna de edição como DataGridViewImageColumn
            DataGridViewImageColumn editColumn = new DataGridViewImageColumn();
            editColumn.Name = "EditColumn";
            editColumn.HeaderText = "EDIT";
            editColumn.Width = 60; // Largura da coluna
            editColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta o layout da imagem
            dgv.Columns.Add(editColumn);

            // Adiciona a coluna de exclusão como DataGridViewImageColumn
            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
            deleteColumn.Name = "DeleteColumn";
            deleteColumn.HeaderText = "Excluir";
            deleteColumn.Width = 60; // Largura da coluna
            deleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta o layout da imagem
            dgv.Columns.Add(deleteColumn);

            // Adiciona as outras colunas do DataGridView
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", DataPropertyName = "Id", Width = 50 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Usuario", HeaderText = "Usuário", DataPropertyName = "Usuario.Nome", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Titulo", HeaderText = "Título", DataPropertyName = "Titulo", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descricao", HeaderText = "Descrição", DataPropertyName = "Descricao", Width = 205 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "DataAbertura", HeaderText = "DT.Abertura", DataPropertyName = "DataAbertura", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "DataFechamento", HeaderText = "DT.Encerramento", DataPropertyName = "DataFechamento", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "Status", Width = 175 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ticket", HeaderText = "Ticket", DataPropertyName = "Ticket", Width = 100 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Prioridade", HeaderText = "Prioridade", DataPropertyName = "Prioridade", Width = 105 });

            // Ajusta a altura das linhas para acomodar as imagens
            dgv.RowTemplate.Height = 40; // Altura das linhas em pixels

            // Assina o evento CellFormatting
            dgv.CellFormatting += dgv_CellFormattingColuna;

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }
        private void dgv_CellFormattingColuna(object sender, DataGridViewCellFormattingEventArgs e) // este metodo formata apenas a cor da celula
        {
            // Verifica se a célula está na coluna "Prioridade"
            if (e.ColumnIndex == dgv.Columns["Prioridade"].Index && e.RowIndex >= 0)
            {
                // Obtém o valor da célula
                string prioridade = e.Value as string;

                // Define a cor de fundo e a cor da fonte com base na prioridade
                switch (prioridade)
                {
                    case "Urgente":
                        e.CellStyle.BackColor = Color.FromArgb(255, 99, 71); // Tomato
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case "Alta":
                        e.CellStyle.BackColor = Color.Orange;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case "Média":
                        e.CellStyle.BackColor = Color.Yellow;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case "Baixa":
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    default:
                        e.CellStyle.BackColor = Color.White;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }
        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) // este metodo formata toda a coluna.
        {
            // Verifica se a célula está na coluna "Prioridade"
            if (e.ColumnIndex == dgv.Columns["Prioridade"].Index && e.RowIndex >= 0)
            {
                // Obtém o valor da célula
                string prioridade = e.Value as string;

                // Define a cor de fundo e a cor da fonte com base na prioridade
                Color backColor;
                Color foreColor = Color.Black; // Default text color

                switch (prioridade)
                {
                    case "Urgente":
                        backColor = Color.FromArgb(255, 99, 71); // Tomato
                        foreColor = Color.White;
                        break;
                    case "Alta":
                        backColor = Color.Orange;
                        break;
                    case "Média":
                        backColor = Color.Yellow;
                        break;
                    case "Baixa":
                        backColor = Color.LightGreen;
                        break;
                    default:
                        backColor = Color.White;
                        break;
                }

                // Aplica o estilo a toda a linha
                foreach (DataGridViewCell cell in dgv.Rows[e.RowIndex].Cells)
                {
                    cell.Style.BackColor = backColor;
                    cell.Style.ForeColor = foreColor;
                }
            }
        }


        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroOrdemDeServico)
            {
                frmCadastro = (FrmCadastroOrdemDeServico)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is OrdemDeServico)
            {
                aOs = (OrdemDeServico)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLOS.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idOS = ObterIdSelecionado();
            if (idOS > 0)
            {
                OrdemDeServico os = aCTLOS.BuscarOrdemDeServicoPorId(idOS);
                if (os != null)
                {
                    oUsuario = aCTLUser.BuscarUsuarioPorId(UserSession.User.Id);
                    aOs = aCTLOS.BuscarOrdemDeServicoPorId(idOS);
                    if (oUsuario.Perfil == "Chefe" || oUsuario.Perfil == "Admin" || oUsuario.Id == aOs.Usuario.Id)
                    {
                        aCTLOS.Alterar(os);
                        if (txtID.Text == "")
                            CarregaDGV(); // Carrega o DataGridView após a alteração
                    }
                    else
                    {
                        MessageBox.Show("Usuário não autorizado para alteração");
                    }
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idOs = ObterIdSelecionado();
            if (idOs > 0)
            {
                OrdemDeServico os = aCTLOS.BuscarOrdemDeServicoPorId(idOs);
                if (os != null)
                {
                    oUsuario = aCTLUser.BuscarUsuarioPorId(UserSession.User.Id);
                    if ((oUsuario.Perfil == "Chefe" || oUsuario.Perfil == "Admin" || oUsuario.Id == os.Usuario.Id))
                    {
                        aCTLOS.Excluir(os);
                        CarregaDGV();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não autorizado para exclusão");
                    }
                }
            }
        }

        public override void Visualizar()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[2].Value);
                OrdemDeServico os = aCTLOS.BuscarOrdemDeServicoPorId(id);
                oUsuario = aCTLUser.BuscarUsuarioPorId(UserSession.User.Id);
                // Verifica permissões
                if (oUsuario.Perfil == "Chefe" || oUsuario.Perfil == "Admin" || oUsuario.Id == os.Usuario.Id)
                {
                    aCTLOS.Visualizar(os); // Usa a ordem de serviço que foi carregada
                }
                else
                {
                    MessageBox.Show("Usuário não autorizado!");
                }
            }
        }

        private int ObterIdSelecionado()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);
            }
            return 0;
        }

        private void PreencherDataGridView(IEnumerable<OrdemDeServico> ordens)
        {
            dgv.Rows.Clear();

            foreach (var os in ordens)
            {
                dgv.Rows.Add(
                    Properties.Resources.Editar_32,
                    Properties.Resources.Lixeira_x32,
                    os.Id,
                    os.Usuario.Nome + " " + os.Usuario.Sobrenome,
                    os.Titulo,
                    os.Descricao,
                    os.DataAbertura.ToString("dd/MM/yyyy"),
                    os.DataFechamento?.ToString("dd/MM/yyyy"),
                    os.Status,
                    os.Ticket,
                    os.Prioridade
                );
            }
        }

        public override void CarregaDGV()
        {
            if (oUsuario.Perfil == "Admin" || oUsuario.Perfil == "Chefe")
            {
                if (cmbStatus2.Text == "")
                {
                    List<OrdemDeServico> ordens2 = aCTLOS.ListarOrdensDeServico(null, null, "Aberto");
                    PreencherDataGridView(ordens2);
                }
                else
                {
                    List<OrdemDeServico> ordens = aCTLOS.ListarOrdensDeServico(null, null, cmbStatus2.Text);
                    PreencherDataGridView(ordens);
                }
            }
            else// Usado para não adminstradores nem chefe, setorizado.
            {
                int setor = oUsuario.Setor.Id;
                int idUser = oUsuario.Id;
                lblSetor.Visible = true;
                if (cmbStatus2.Text == "")
                {
                    List<OrdemDeServico> ordens2 = aCTLOS.ListarOrdensDeServicoPorSetor(null, null, "Aberto", setor,idUser);
                    PreencherDataGridView(ordens2);

                }
                else
                {
                    List<OrdemDeServico> ordens = aCTLOS.ListarOrdensDeServicoPorSetor(null, null, cmbStatus2.Text, setor, idUser);
                    PreencherDataGridView(ordens);
                }
                lblSetor.Text = "RESULTADOS PARA O SETOR: " + oUsuario.Setor.Setor;
            }

        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();
            if (oUsuario.Perfil == "Admin" || oUsuario.Perfil == "Chefe")
            {
                if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
                {
                    var resultados = aCTLOS.PesquisarOrdemDeServicoPorCriterio(criterioPesquisa, valorPesquisa);
                    PreencherDataGridView(resultados);
                }
            }
            else
            {
                int setor = oUsuario.Setor.Id;
                int idUser = oUsuario.Id;
                if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
                {
                    var resultados = aCTLOS.PesquisarOrdemDeServicoPorCriterioPorSetor(criterioPesquisa, valorPesquisa,setor, idUser);
                    PreencherDataGridView(resultados);
                }
            }
       
        }

        protected override void Atualizar()
        {
            if (cmbStatus2.Text != string.Empty)
            {
                base.Atualizar();
            }
            else
                MessageBox.Show("O campo 'Status' está vazio. Por favor, preencha este campo antes de atualizar.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID";
            }
            else if (rbUser.Checked)
            {
                return "Usuario";
            }
            else if (rbTicket.Checked)
            {
                return "Ticket";
            }
            CarregaDGV();
            return string.Empty;
        }

        public override void Filtrar()
        {
            base.CarregaDGV();

            DateTime? dataInicio = null;
            DateTime? dataFim = null;
            string status = "";
            if (cmbStatus.Text != "")
                status = cmbStatus.Text;

            if (dtData1.Value.Date > DateTime.MinValue.Date)
            {
                if (dtData2.Value.Date > DateTime.MinValue.Date)
                {
                    if (dtData1.Value.Date <= dtData2.Value.Date)
                    {
                        dataInicio = dtData1.Value.Date;
                        dataFim = dtData2.Value.Date;
                    }
                    else
                    {
                        MessageBox.Show("A data de início deve ser anterior à data de término.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma data de término.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (dtData2.Value.Date > DateTime.MinValue.Date)
            {
                MessageBox.Show("Selecione uma data de início.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbTodos.Checked)
            {
                dataInicio = null;
                dataFim = null;
            }

            if (oUsuario.Perfil == "Admin" || oUsuario.Perfil == "Chefe"  ) // mostra uma lista para todos os setores. e 
            {
                List<OrdemDeServico> ordens = aCTLOS.ListarOrdensDeServico(dataInicio, dataFim, status);
                PreencherDataGridView(ordens);
            }
            else // retorna a listra filtrada para o setor do usuário.
            {
                int setor = oUsuario.Setor.Id;
                int idUser = oUsuario.Id;
                lblSetor.Visible = true;
                List<OrdemDeServico> ordens = aCTLOS.ListarOrdensDeServicoPorSetor(dataInicio, dataFim, cmbStatus.Text, setor, idUser);
                PreencherDataGridView(ordens);
                lblSetor.Text = "RESULTADOS PARA O SETOR: " + oUsuario.Setor.Setor;
            }
               
        }

        //Buttons
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "")
            {
                MessageBox.Show("Selecione o Status");
            }
            else
            {
                Filtrar();
            }
        }

        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodos.Checked)
            {
                dtData1.Enabled = false;
                dtData2.Enabled = false;
            }
            else
            {
                dtData1.Enabled = true;
                dtData2.Enabled = true;
            }
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                Excluir();
            }
            if (e.ColumnIndex == dgv.Columns["EditColumn"].Index && e.RowIndex >= 0)
            {
                Alterar();
            }
            dgv.EndEdit();
        }

        private void FrmConsultaOrdemDeServico_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
