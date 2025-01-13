using Controle.Views.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Cadastros;
using test.Views.Consultas;

namespace Controle.Views.Cadastros
{
    public partial class FrmCadastroLavanderia : FrmCadastro
    {
        FrmConsultaItensLavanderia frmConsItensLavanderia;
        CTLLavanderia aCTLLavanderia;
        Lavanderia aLavanderia;
        public FrmCadastroLavanderia()
        {
            InitializeComponent();
            aCTLLavanderia = new CTLLavanderia();
            aLavanderia = new Lavanderia();
        }
        public void SetConsultaItensLavanderia(FrmConsultaItensLavanderia consulta)
        {
            frmConsItensLavanderia = consulta;
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Lavanderia lav)
            {
                aLavanderia = lav;
                CarregarCampos();
            }
        }
        public override void LimparCampos()
        {
            dtData.MaxDate = DateTime.Now;
            txtCodFuncionario.Clear();
            txtFuncionario.Clear();
            txtCodigoItem.Clear();
            txtItemLavanderia.Clear();
            txtPeso.Clear();
            cmbProcesso.SelectedIndex = -1;
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            dtData.Enabled = false;
            txtCodFuncionario.Enabled = false;
            txtFuncionario.Enabled = false;
            txtCodigoItem.Enabled = false;
            txtItemLavanderia.Enabled = false;
            txtPeso.Enabled = false;
            cmbProcesso.Enabled = false;

        }
        public override void DesbloquearCampos()
        {
            base.BloquearCampos();
            dtData.Enabled = true;
            txtCodFuncionario.Enabled = true;
            txtFuncionario.Enabled = true;
            txtCodigoItem.Enabled = true;
            txtItemLavanderia.Enabled = true;
            txtPeso.Enabled = true;
            cmbProcesso.Enabled = true;

        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            dtData.Value = aLavanderia.Data;
            txtCodFuncionario.Text = aLavanderia.Funcionario.Id.ToString();
            txtFuncionario.Text = aLavanderia.Funcionario.Nome.ToString();
            txtCodigoItem.Text = aLavanderia.ItensLavanderia.Id.ToString();
            txtItemLavanderia.Text = aLavanderia.ItensLavanderia.Nome.ToString();
            CultureInfo cultura = CultureInfo.InvariantCulture;
            txtPeso.Text = aLavanderia.Peso.ToString("0.00", cultura);
            cmbProcesso.Text = aLavanderia.Processo.ToString();
        }
        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
                Salvar();
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirLavanderia();
                }
            }
        }
        private void ExcluirLavanderia()
        {
            if (aLavanderia != null)
            {
                try
                {
                    bool result = aCTLLavanderia.ExcluirLavanderia(aLavanderia.Id);
                    if (result)
                    {
                        MessageBox.Show("lavanderia excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close(); // Fechar o formulário após a exclusão
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir a lavanderia.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();


            if (string.IsNullOrWhiteSpace(txtCodFuncionario.Text))
            {
                camposFaltantes.Add("Código de funcionário");
            }

            if (string.IsNullOrWhiteSpace(txtCodigoItem.Text))
            {
                camposFaltantes.Add("Código do item de lavanderia");
            }
            if (!decimal.TryParse(txtPeso.Text, out decimal valor) || valor <= 0)
            {
                camposFaltantes.Add("Peso");
            }
            if (string.IsNullOrWhiteSpace(cmbProcesso.Text))
            {
                camposFaltantes.Add("Processo");
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
                try
                {
                    CultureInfo cultura = CultureInfo.InvariantCulture; // Usar a cultura atual do sistema
                    aLavanderia.Data = dtData.Value.Date;
                    aLavanderia.Funcionario.Id = Convert.ToInt32(txtCodFuncionario.Text);
                    aLavanderia.ItensLavanderia.Id = Convert.ToInt32(txtCodigoItem.Text);
                    aLavanderia.Peso = decimal.Parse(txtPeso.Text, cultura);
                    aLavanderia.Processo = cmbProcesso.Text;

                    if (aLavanderia.Id == 0)
                    {
                        var result = aCTLLavanderia.AdicionarLavanderia(aLavanderia);
                        if (result)
                        {
                            MessageBox.Show("Lavanderia adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                            MessageBox.Show("Erro ao adicionar Lavanderia: " + result);
                    }
                    else
                    {
                        var result = aCTLLavanderia.AtualizarLavanderia(aLavanderia);
                        if (result)
                        {
                            MessageBox.Show("Lavanderia atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                         
                        else
                            MessageBox.Show("Erro ao atualizar Lavanderia: " + result);

                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Certifique-se de que os campos numéricos foram preenchidos corretamente." + ex.Message, "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado ao salvar funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtCodFuncionario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodFuncionario.Text))
            {
                LimparFunc();
            }
            else if (int.TryParse(txtCodFuncionario.Text, out int cod) && cod > 0)
            {
                CTLFuncionarios aCTLFuncionario = new CTLFuncionarios();
                Funcionario Valida = aCTLFuncionario.BuscarFuncionarioPorId(cod);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparFunc();
                }
                else
                {
                    txtFuncionario.Text = Valida.Nome;
                }
            }
            else
            {

                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparFunc();

            }
            this.AcceptButton = btnSalvar; // Restaura o botão "Salvar" como botão padrão
        }
        private void LimparFunc()
        {
            txtCodFuncionario.Clear();
            txtFuncionario.Clear();
            txtCodFuncionario.Focus();

        }

        private void txtCodFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        private void txtCodFuncionario_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "Salvar" como botão padrão
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            using (FrmConsultaFuncionarios frm = new FrmConsultaFuncionarios())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do func selecionado
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodFuncionario.Text = IdSelecionado.ToString();
                txtFuncionario.Text = NomeSelecionado;
                txtCodFuncionario_Leave(txtCodFuncionario, EventArgs.Empty);
            }
        }

        private void txtCodigoItem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoItem.Text))
            {
                LimparItem();
            }
            else if (int.TryParse(txtCodigoItem.Text, out int cod) && cod > 0)
            {
                CTLItensLavanderia aCTLItens = new CTLItensLavanderia();
                ItensLavanderia Valida = aCTLItens.BuscarItensLavanderiaPorId(cod);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparItem();
                }
                else
                {
                    txtItemLavanderia.Text = Valida.Nome;
                }
            }
            else
            {
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparItem();

            }
            this.AcceptButton = btnSalvar; // Restaura o botão "Salvar" como botão padrão
        }
        private void LimparItem()
        {
            txtCodigoItem.Clear();
            txtItemLavanderia.Clear();
            txtCodigoItem.Focus();

        }

        private void btnPesquisarItens_Click(object sender, EventArgs e)
        {
            using (FrmConsultaItensLavanderia frm = new FrmConsultaItensLavanderia())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                txtCodigoItem.Text = IdSelecionado.ToString();
                txtItemLavanderia.Text = NomeSelecionado;
                txtCodigoItem_Leave(txtCodigoItem, EventArgs.Empty);
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, um ponto decimal e teclas de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permite apenas um ponto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Bloqueia qualquer modificação com Ctrl
            if (Control.ModifierKeys == Keys.Control)
            {
                e.Handled = true;
            }
        }
    }
}
