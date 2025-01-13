using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaFichas : FrmConsulta
    {
        private CTLFichas aCTLFichas;
        private FrmCadastroFichas frmCadastro;
        private Fichas fichaSelecionada;
        private string AcessosLiberados = "FICHAS";

        public FrmConsultaFichas()
        {
            InitializeComponent();
            aCTLFichas = new CTLFichas();
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

            dgv.Columns.AddRange(new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Código", HeaderText = "Código", DataPropertyName = "Id", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Usuário", HeaderText = "Usuário", DataPropertyName = "Usuarios.Usuario", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Cliente", HeaderText = "Cliente", DataPropertyName = "Clientes.Nome", Width = 205 },
                new DataGridViewTextBoxColumn { Name = "Data de Criação", HeaderText = "Data de Criação", DataPropertyName = "DataCriacao", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Descrição", HeaderText = "Descrição", DataPropertyName = "Descricao", Width = 800 }
            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroFichas)
            {
                frmCadastro = (FrmCadastroFichas)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Fichas)
            {
                fichaSelecionada = (Fichas)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLFichas.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idFicha = ObterIdSelecionado();
            if (idFicha > 0)
            {
                Fichas ficha = aCTLFichas.BuscarFichaPorId(idFicha);
                if (ficha != null)
                {
                    aCTLFichas.Alterar(ficha);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idFicha = ObterIdSelecionado();
            if (idFicha > 0)
            {
                Fichas ficha = aCTLFichas.BuscarFichaPorId(idFicha);
                if (ficha != null)
                {
                    aCTLFichas.Excluir(ficha);
                    CarregaDGV();
                }
            }
        }

        public override void Visualizar()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Fichas ficha = aCTLFichas.BuscarFichaPorId((int)id);

                if (ficha != null)
                {
                    aCTLFichas.Visualizar(ficha);
                }
            }
        }

        private void PreencherFichasDataGridView(IEnumerable<Fichas> fichas)
        {
            // Limpa as linhas existentes no DataGridView
            dgv.Rows.Clear();

            // Adiciona as linhas uma por uma
            foreach (var ficha in fichas)
            {
                dgv.Rows.Add(new object[]
                {
                    ficha.Id,
                    ficha.Usuarios?.Usuario ?? "N/A",
                    ficha.Clientes?.Nome ?? "N/A",
                    ficha.DataCriacao.ToString(),
                    ficha.Descricao
                });
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            List<Fichas> fichas = aCTLFichas.ListarFichas();
            PreencherFichasDataGridView(fichas);
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLFichas.PesquisarFichasPorCriterio(criterioPesquisa, valorPesquisa);

                // Use o método de preenchimento para atualizar o DataGridView
                PreencherFichasDataGridView(resultados);
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
                return int.Parse(dgv.SelectedRows[0].Cells["Código"].Value.ToString());
            }
            return 0;
        }

        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID"; // Pesquisar pelo ID
            }
            else if (rbUsuario.Checked)
            {
                return "Usuario"; // Pesquisar pelo usuário
            }
            else if (rbCliente.Checked)
            {
                return "Clientes"; // Pesquisar pelos clientes
            }
            return string.Empty; // Nenhum critério selecionado
        }

        public override void Filtrar()
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

            List<Fichas> fichas = aCTLFichas.ListarFichas(dataInicio, dataFim);
            PreencherFichasDataGridView(fichas);
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void FrmConsultaFichas_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }
    }
}
