using Controle.Views.Consultas;
using iTextSharp.text.pdf.codec.wmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Consultas;

namespace Controle.Views.Cadastros
{
    public partial class FrmCadastroControleGov : test.Views.Cadastros.FrmCadastro
    {
        FrmConsultaFuncionarios frmConsFuncionario;
        CTLControleGov aCTLControleGov;
        ControleGov oControleGov;
        public FrmCadastroControleGov()
        {
            InitializeComponent();
            aCTLControleGov = new CTLControleGov();
            oControleGov = new ControleGov();
        }
      
        public void SetConsultaFuncionariosGov(FrmConsultaFuncionarios consulta)
        {
            frmConsFuncionario = consulta;
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is ControleGov controle)
            {
                oControleGov = controle;
                CarregarCampos();
            }
        }

        public override void LimparCampos()
        {
            dtData.MaxDate = DateTime.Now;
            txtCodFuncionario.Clear();
            txtFuncionario.Clear();
            txtPermanece.Clear();
            txtSaidas.Clear();
            txtRsv.Clear();
            txtPermaneceRealizado.Clear();
            txtSaidasRealizado.Clear();
            txtRealizado.Clear();
            txtPorcentagem.Clear();

        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            dtData.Enabled = false;
            txtCodFuncionario.Enabled = false;
            txtFuncionario.Enabled = false;
            txtPermanece.Enabled = false;
            txtSaidas.Enabled = false;
            txtRsv.Enabled = false;
            txtPermaneceRealizado.Enabled = false;
            txtSaidasRealizado.Enabled = false;
            txtRealizado.Enabled = false;
            txtPorcentagem.Enabled = false;
            btnPesquisarFuncionario.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.BloquearCampos();
            dtData.Enabled = true;
            txtCodFuncionario.Enabled = true;
            txtFuncionario.Enabled = true;
            txtPermanece.Enabled = true;
            txtSaidas.Enabled = true;
            txtRsv.Enabled = true;
            txtPermaneceRealizado.Enabled = true;
            txtSaidasRealizado.Enabled = true;
            txtRealizado.Enabled = true;
            txtPorcentagem.Enabled = true;
            btnPesquisarFuncionario.Enabled=true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            dtData.Value = oControleGov.Data;
            txtCodFuncionario.Text = oControleGov.Funcionarios.Id.ToString();
            txtFuncionario.Text = oControleGov.Funcionarios.Nome.ToString();
            txtPermanece.Text = oControleGov.PermaneceEntrada.ToString();
            txtSaidas.Text = oControleGov.SaidasEntrada.ToString();
            txtRsv.Text = oControleGov.ReservadasRealizadas.ToString();
            txtPermaneceRealizado.Text = oControleGov.PermaneceRealizadas.ToString();
            txtSaidasRealizado.Text = oControleGov.PermaneceRealizadas.ToString();
            txtRealizado.Text = oControleGov.Realizados.ToString();
            CultureInfo cultura = CultureInfo.InvariantCulture;
            txtPorcentagem.Text = oControleGov.Porcentagem.ToString("0.00", cultura);
        }

        private void LimparSoma()
        {
            txtRealizado.Text = "";
            txtPorcentagem.Text = "";
        }

        private void CalcularPorcentagem()
        {
            if (string.IsNullOrEmpty(txtPermanece.Text) || string.IsNullOrEmpty(txtSaidas.Text))
            {
                LimparSoma();
                return;
            }

            if (!double.TryParse(txtPermanece.Text, out double permanece) || !double.TryParse(txtSaidas.Text, out double saida))
            {
                LimparSoma();
                return;
            }

            double metaTotal = permanece + saida;

            if (metaTotal <= 0)
            {
                LimparSoma();
                return;
            }

            if (!double.TryParse(txtPermaneceRealizado.Text, out double permaneceRealizado) || !double.TryParse(txtSaidasRealizado.Text, out double saidasRealizado))
            {
                LimparSoma();
                return;
            }

            double totalRealizado = permaneceRealizado + saidasRealizado;
            txtRealizado.Text = totalRealizado.ToString();

            double porcentagem = (totalRealizado / metaTotal) * 100;
            txtPorcentagem.Text = porcentagem.ToString("0");
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
                    ExcluirControleGov();
                }
            }
        }
        private void ExcluirControleGov()
        {
            if (oControleGov != null)
            {
                try
                {
                    bool result = aCTLControleGov.ExcluirControleGov(oControleGov.ID);
                    if (result)
                    {
                        MessageBox.Show("Controle excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close(); // Fechar o formulário após a exclusão
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o Controle.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Violacao de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o Controle devido a outros registros estarem vinculados a este controle.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir o controle. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (string.IsNullOrWhiteSpace(txtSaidas.Text))
            {
                camposFaltantes.Add("Saidas");
            }
            if (string.IsNullOrWhiteSpace(txtPermanece.Text))
            {
                camposFaltantes.Add("PERMANECE");
            }
            if (string.IsNullOrWhiteSpace(txtRsv.Text))
            {
                camposFaltantes.Add("RSV");
            }
            if (string.IsNullOrWhiteSpace(txtSaidasRealizado.Text))
            {
                camposFaltantes.Add("Saidas Realizado");
            }

            if (string.IsNullOrWhiteSpace(txtPermaneceRealizado.Text))
            {
                camposFaltantes.Add("Permanece Realizado");
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
                    oControleGov.Data = dtData.Value.Date;
                    oControleGov.PermaneceEntrada = Convert.ToInt32(txtPermanece.Text);
                    oControleGov.PermaneceRealizadas = Convert.ToInt32(txtPermaneceRealizado.Text);
                    oControleGov.SaidasEntrada = Convert.ToInt32(txtSaidas.Text);
                    oControleGov.SaidasRealizadas = Convert.ToInt32(txtSaidasRealizado.Text);
                    oControleGov.ReservadasRealizadas = Convert.ToInt32(txtRsv.Text);
                    oControleGov.Realizados = Convert.ToInt32(txtRealizado.Text);
                    oControleGov.Porcentagem = decimal.Parse(txtPorcentagem.Text, cultura);
                    oControleGov.Funcionarios.Id = Convert.ToInt32(txtCodFuncionario.Text);

                    if(Convert.ToInt32(txtPorcentagem.Text) > 100)
                    {
                        MessageBox.Show("Erro, Porcentagem maior do que o máximo de 100%.");
                        return;
                    }

                    if (oControleGov.ID == 0)
                    {
                        var result = aCTLControleGov.AdicionarControleGov(oControleGov);
                        if (result == "OK")
                            Close();
                        else
                            MessageBox.Show("Erro ao adicionar funcionário: " + result);
                    }
                    else
                    {
                        var result = aCTLControleGov.AtualizarControleGov(oControleGov);
                        if (result == "OK")
                            Close();
                        else
                            MessageBox.Show("Erro ao adicionar funcionário: " + result);

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



        private void txtCodUsuario_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "Salvar" como botão padrão
        }

        private void txtCodUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        public void txtCodUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodFuncionario.Text))
            {
                Limpar();
            }
            else if (int.TryParse(txtCodFuncionario.Text, out int cod) && cod > 0)
            {
                CTLFuncionarios aCTLFuncionario = new CTLFuncionarios();
                Funcionario Valida = aCTLFuncionario.BuscarFuncionarioPorId(cod);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    Limpar();
                }
                else
                {
                    txtFuncionario.Text = Valida.Nome;
                }
            }
            else
            {

                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                Limpar();

            }
            this.AcceptButton = btnSalvar; // Restaura o botão "Salvar" como botão padrão
        }
        private void Limpar()
        {
            txtCodFuncionario.Clear();
            txtFuncionario.Clear();
            txtCodFuncionario.Focus();

        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            using (FrmConsultaFuncionarios frm = new FrmConsultaFuncionarios())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodFuncionario.Text = IdSelecionado.ToString();
                txtFuncionario.Text = NomeSelecionado;
                txtCodUsuario_Leave(txtCodFuncionario, EventArgs.Empty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularPorcentagem();
        }

        private void txtSaidasRealizado_Leave(object sender, EventArgs e)
        {
            CalcularPorcentagem();
        }
    }
}

