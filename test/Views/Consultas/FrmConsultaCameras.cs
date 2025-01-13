using Controle.Controllers;
using Controle.Model;
using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Model;
using test.Views.Cadastros;

namespace Controle.Views.Consultas
{
    public partial class FrmConsultaCameras : test.Views.Consultas.FrmConsulta
    {
        FrmCadastroCameras frmCadCamera;
        CTLCameras aCTLCamera;
        Cameras aCamera;
        private string AcessosLiberados = "CAMERAS";
        public FrmConsultaCameras()
        {
            InitializeComponent();
            aCamera = new Cameras();
            aCTLCamera = new CTLCameras();
            LiberarAcessos(AcessosLiberados);
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
                new DataGridViewTextBoxColumn { Name = "Código", HeaderText = "Código", DataPropertyName = "CodCamera", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Ip", HeaderText = "IP", DataPropertyName = "Ip", Width = 115 },
                new DataGridViewTextBoxColumn { Name = "Local", HeaderText = "Local", DataPropertyName = "Local", Width = 190 },
                new DataGridViewTextBoxColumn { Name = "Audio", HeaderText = "Audio", DataPropertyName = "Audio", Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Situacao", HeaderText = "Situação", DataPropertyName = "Situacao", Width = 100 }
            });

            // Calcula as proporções das colunas
            CalcularProporcoesColunas(dgv);
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroCameras)
            {
                frmCadCamera = (FrmCadastroCameras)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Cameras)
            {
                aCamera = (Cameras)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            aCTLCamera.Incluir();
            CarregaDGV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idCamera = ObterIdSelecionado();
            if (idCamera > 0)
            {
                Cameras camera = aCTLCamera.BuscarCameraPorId(idCamera);
                if (camera != null)
                {
                    aCTLCamera.Alterar(camera);
                    CarregaDGV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCamera = ObterIdSelecionado();
            if (idCamera > 0)
            {
                Cameras camera = aCTLCamera.BuscarCameraPorId(idCamera);
                if (camera != null)
                {
                    aCTLCamera.Excluir(camera);
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
                Cameras camera = aCTLCamera.BuscarCameraPorId(id);

                if (camera != null)
                {
                    aCTLCamera.Visualizar(camera);
                }
            }
        }

        private void PreencherDGV(IEnumerable<Cameras> cameras)
        {
            dgv.Rows.Clear();

            foreach (var camera in cameras)
            {
                dgv.Rows.Add(new object[]
                {
                    camera.Id,
                    camera.Ip,
                    camera.Local,
                    camera.Audio,
                    camera.Situacao
                });
            }
        }

        public override void CarregaDGV()
        {
            base.CarregaDGV();
            PreencherDGV(aCTLCamera.ListarCameras());
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;

            if (!string.IsNullOrEmpty(valorPesquisa))
            {
                var resultados = aCTLCamera.PesquisarCameras(valorPesquisa);
                PreencherDGV(resultados);
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.EndEdit();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }
    }
}
