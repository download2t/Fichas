using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;

namespace Controle.Views.Consultas
{
    public partial class FrmConsultaControleGov : test.Views.Consultas.FrmConsulta
    {
        CTLControleGov aCTLControleGov;
        FrmCadastroControleGov frmCadastroControle;
        ControleGov oControleGov;
        private string AcessosLiberados = "GOVERNANÇA";
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaControleGov()
        {
            InitializeComponent();
            aCTLControleGov = new CTLControleGov();
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
                new DataGridViewTextBoxColumn { Name = "Código", HeaderText = "Código", DataPropertyName = "ID", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Data", HeaderText = "Data", DataPropertyName = "Data", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Permanece Entrada", HeaderText = "PERMANECE", DataPropertyName = "PermaneceEntrada", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Saídas Entrada", HeaderText = "SAÍDAS", DataPropertyName = "SaidasEntrada", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Reservadas Realizadas", HeaderText = "RSV", DataPropertyName = "ReservadasRealizadas", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Permanece Realizadas", HeaderText = "PERMANECE", DataPropertyName = "PermaneceRealizadas", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Saídas Realizadas", HeaderText = "SAÍDAS", DataPropertyName = "SaidasRealizadas", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Realizados", HeaderText = "REALIZADOS", DataPropertyName = "Realizados", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Porcentagem", HeaderText = "%", DataPropertyName = "Porcentagem", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Funcionário", HeaderText = "FUNCIONÁRIO", DataPropertyName = "Nome", Width = 221 }
            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroControleGov)
            {
                frmCadastroControle = (FrmCadastroControleGov)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is ControleGov)
            {
                oControleGov = (ControleGov)obj;
            }
        }

        private int ObterIdSelecionado()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                return int.Parse(dgv.SelectedRows[0].Cells["Código"].Value.ToString());
            }
            return 0;
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLControleGov.Incluir(oControleGov);
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idGov = ObterIdSelecionado();
            if (idGov > 0)
            {
                ControleGov os = aCTLControleGov.BuscarControleGovPorId(idGov);
                if (os != null)
                {
                    aCTLControleGov.Alterar(os);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idGov = ObterIdSelecionado();
            if (idGov > 0)
            {
                ControleGov os = aCTLControleGov.BuscarControleGovPorId(idGov);
                if (os != null)
                {
                    aCTLControleGov.Excluir(os);
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
                ControleGov gov = aCTLControleGov.BuscarControleGovPorId((int)id);

                if (gov != null)
                {
                    aCTLControleGov.Visualizar(gov);
                }
            }
        }

        private void PreencherDGV(IEnumerable<ControleGov> Cgov)
        {
            dgv.Rows.Clear();
            decimal totalRealizados = 0;
            decimal totalPorcentagens = 0;
            int count = 0;

            foreach (var gov in Cgov)
            {
                if (gov.Funcionarios.Id == oControleGov.Funcionarios.Id)
                {
                    dgv.Rows.Add(new object[]
                    {
                        gov.ID,
                        gov.Data,
                        gov.PermaneceEntrada,
                        gov.SaidasEntrada,
                        gov.ReservadasRealizadas,
                        gov.PermaneceRealizadas,
                        gov.SaidasRealizadas,
                        gov.Realizados,
                        gov.Porcentagem.ToString("0.00") + "%",
                        gov.Funcionarios.Nome
                    });

                    totalRealizados += gov.Realizados;
                    totalPorcentagens += gov.Porcentagem;
                    count++;
                }
            }

            decimal mediaPorcentagens = count > 0 ? totalPorcentagens / count : 0;
            int porcentagemInteira = (int)Math.Round(mediaPorcentagens);

            lblTotal.Text = $"{totalRealizados}";
            lblPorcentagem.Text = $"{porcentagemInteira}%";
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();

            if (oControleGov != null && oControleGov.Funcionarios.Id != 0)
            {
                string nome = oControleGov.Funcionarios.Nome;
                List<ControleGov> gov = aCTLControleGov.ListarControleGov(null, null, nome);
                PreencherDGV(gov);
            }
            else
            {
                List<ControleGov> gov = aCTLControleGov.ListarControleGov();
                PreencherDGV(gov);
            }
        }

        protected override void Atualizar()
        {
            CarregaDGV();
        }

        public override void Filtrar()
        {
            base.CarregaDGV();

            DateTime? dataInicio = null;
            DateTime? dataFim = null;
            string nome = txtID.Text;

            if (!string.IsNullOrEmpty(nome))
            {
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

                List<ControleGov> gov = aCTLControleGov.ListarControleGov(dataInicio, dataFim, nome);
                PreencherDGV(gov);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void cmbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void FrmConsultaControleGov_Load(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }
    }
}
