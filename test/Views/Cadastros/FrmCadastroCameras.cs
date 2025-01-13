using Controle.Controllers;
using Controle.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;

namespace Controle.Views.Cadastros
{
    public partial class FrmCadastroCameras : test.Views.Cadastros.FrmCadastro
    {
        Cameras aCamera;
        CTLCameras aCTLCamera;
        public FrmCadastroCameras()
        {
            InitializeComponent();
            aCTLCamera = new CTLCameras();
            aCamera = new Cameras();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Cameras camera)
            {
                aCamera = camera;
                CarregarCampos();
            }
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtIP.Enabled = false;
            cmbAudio.Enabled = false;
            cmbSituação.Enabled = false;
            txtLocalizacao.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtIP.Enabled = true;
            cmbAudio.Enabled = true;
            cmbSituação.Enabled = true;
            txtLocalizacao.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = aCamera.Id.ToString();
            txtIP.Text = aCamera.Ip;
            cmbAudio.Text = aCamera.Audio.ToString();
            cmbSituação.Text = aCamera.Situacao.ToString();
            txtLocalizacao.Text = aCamera.Local;
        }
        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                ExcluirCameras();
            }
        }
        protected override bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtIP.Text))
            {
                camposFaltantes.Add("IP");
            }

            if (string.IsNullOrWhiteSpace(cmbAudio.Text))
            {
                camposFaltantes.Add("Audio");
            }

            if (string.IsNullOrWhiteSpace(cmbSituação.Text))
            {
                camposFaltantes.Add("Situação");
            }
            if (string.IsNullOrWhiteSpace(txtLocalizacao.Text))
            {
                camposFaltantes.Add("Localização");
            }

            if (camposFaltantes.Count > 0)
            {
                string camposFaltantesStr = string.Join(", ", camposFaltantes);
                MessageBox.Show("Os seguintes campos são obrigatórios e não foram preenchidos: " + camposFaltantesStr, "Campos em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public override void Salvar()
        {

            if (VerificarCamposVazios())
            {
                aCamera.Situacao = cmbSituação.Text;
                aCamera.Local = txtLocalizacao.Text;
                aCamera.Audio = cmbAudio.Text;
                aCamera.Ip = txtIP.Text;

                if (aCamera.Id == 0)
                    aCTLCamera.AdicionarCamera(aCamera);
                else
                    aCTLCamera.AtualizarCamera(aCamera);

                Close();
            }
        }

        private void ExcluirCameras()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ExcluirCamera();
            }
        }


        private void ExcluirCamera()
        {
            if (aCamera != null)
            {
                try
                {
                    aCTLCamera.ExcluirCamera(aCamera.Id);
                    Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocorreu um erro ao excluir a categoria. Detalhes: " + ex.Message);
                }
            }
        }

        private void txtIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.V || e.KeyCode == Keys.C || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e pontos
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Não permite mais de três pontos
            if (e.KeyChar == '.' && txtIP.Text.Count(c => c == '.') >= 3)
            {
                e.Handled = true;
                return;
            }

            // Não permite pontos consecutivos
            if (e.KeyChar == '.' && txtIP.Text.EndsWith("."))
            {
                e.Handled = true;
                return;
            }

            // Permite pontos apenas após dois ou mais dígitos
            if (e.KeyChar == '.')
            {
                int lastDotIndex = txtIP.Text.LastIndexOf('.');
                int numCharsSinceLastDot = lastDotIndex == -1 ? txtIP.Text.Length : txtIP.Text.Length - lastDotIndex - 1;

                if (numCharsSinceLastDot < 1)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            // Remove o evento temporariamente para evitar loops infinitos
            txtIP.TextChanged -= txtIP_TextChanged;

            string input = txtIP.Text;
            string[] parts = input.Split('.');

            // Limpar partes inválidas que têm mais de 3 dígitos
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length > 3)
                {
                    parts[i] = parts[i].Substring(0, 3);
                }
            }

            txtIP.Text = string.Join(".", parts);
            txtIP.SelectionStart = txtIP.Text.Length;

            // Recoloca o evento
            txtIP.TextChanged += txtIP_TextChanged;
        }

    }
}
