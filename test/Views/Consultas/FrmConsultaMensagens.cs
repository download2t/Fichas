using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Data;
using test.Model;
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaMensagens : test.Views.Consultas.FrmConsulta
    {
        private string AcessosLiberados = "MENSAGENS";
        private Mensagens aMensagem;
        private CTLMensagens aCTLMensagens;
        private FrmCadastroMensagens oFrmCadMensagem;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string criterioLista; // Verifica se é Agendado, Enviado, Falhas
        private string criterioPesquisa; // Verifica se pesquisa por ID ou Contato.

        public FrmConsultaMensagens()
        {
            InitializeComponent();
            LiberarAcessos(AcessosLiberados);
            aMensagem = new Mensagens();
            aCTLMensagens = new CTLMensagens();
            this.Controls.Add(dgv);
            this.Resize += FrmConsulta_Resize; // Associa o evento de redimensionamento
            DataGrid();
        }

        public override void DataGrid()
        {
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;

            // Adiciona as colunas ao DataGridView
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", DataPropertyName = "Id", Width = 50 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Contato", DataPropertyName = "Nome", Width = 250 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Telefone", HeaderText = "Telefone", DataPropertyName = "Telefone", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "DataEnvio", HeaderText = "Data de Envio", DataPropertyName = "DataEnvio", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "Status", Width = 80 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Mensagem", HeaderText = "Mensagem", DataPropertyName = "Mensagem", Width = 605 });


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
        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroMensagens)
            {
                oFrmCadMensagem = (FrmCadastroMensagens)obj;
            }
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Mensagens)
            {
                aMensagem = (Mensagens)obj;
            }
        }
        public override void Incluir()
        {
            base.Incluir();
            aCTLMensagens.Incluir();
            CarregaDGV();
        }
        public override void Alterar()
        {
            base.Alterar();
            int id = ObterIdSelecionado();
            if (id > 0)
            {
                Mensagens msg = aCTLMensagens.BuscarMensagemPorId(id);
                if (msg != null)
                {
                    aCTLMensagens.Alterar(msg);
                    CarregaDGV();
                }
            }
        }
        public override void Excluir()
        {
            base.Excluir();
            int id = ObterIdSelecionado();
            if (id > 0)
            {
                Mensagens msg = aCTLMensagens.BuscarMensagemPorId(id);
                if (msg != null)
                {
                    aCTLMensagens.Excluir(msg);
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
                Mensagens msg = aCTLMensagens.BuscarMensagemPorId((int)id);

                if (msg != null)
                {
                    aCTLMensagens.Visualizar(msg);
                }
            }
        }
        private void PreencherDataGridView(IEnumerable<Mensagens> mensagens)
        {
            dgv.Rows.Clear();

            foreach (Mensagens msg in mensagens)
            {
                dgv.Rows.Add(
                    msg.Id,
                    msg.OContato.Nome,
                    Operacao.FormatarTelefone(msg.Telefone),
                    msg._dataEnvio.ToString(),
                    Operacao.FormatStatus(msg.Status),
                    msg.Mensagem
                );
            }
        }
        public override void CarregaDGV()
        {
            base.CarregaDGV();
            criterioLista = ObterCriterioLista();
            criterioPesquisa = ObterCritérioPesquisa();
            string valorPesquisa = txtID.Text;
            PreencherDataGridView(aCTLMensagens.ListarMensagens(criterioLista, criterioPesquisa, valorPesquisa));
        }
        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();
            criterioLista = ObterCriterioLista();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = aCTLMensagens.ListarMensagens(criterioLista, criterioPesquisa, valorPesquisa);
                PreencherDataGridView(resultados);
            }
        }
        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID"; // Pesquisar pelo ID
            }
            else if (rbContato.Checked)
            {
                return "Contato"; // Pesquisar pelo nome do contato
            }
            return string.Empty;
        }
        private string ObterCriterioLista()
        {
            if (rbAgendadas.Checked)
            {
                return "Agendados"; // Mensagens agendadas
            }
            else if (rbEnviadas.Checked)
            {
                return "Enviados"; // Mensagens enviadas
            }
            else if (rbFalhas.Checked)
            {
                return "NaoEnviadas"; // Mensagens não enviadas
            }

            return string.Empty; // Nenhum critério selecionado
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
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            base.CarregaDGV();

            DateTime? dataInicio = null;
            DateTime? dataFim = null;

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

            criterioLista = ObterCriterioLista();
            criterioPesquisa = ObterCritérioPesquisa();
            string valorPesquisa = txtID.Text;
            List<Mensagens> msg = aCTLMensagens.ListarMensagens(criterioLista, criterioPesquisa, valorPesquisa, dataInicio, dataFim);

            PreencherDataGridView(msg);
        }
        private void rbAgendadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAgendadas.Checked)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else if (rbEnviadas.Checked)
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = false;
            }
            CarregaDGV();
        }
        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }
    }
}
