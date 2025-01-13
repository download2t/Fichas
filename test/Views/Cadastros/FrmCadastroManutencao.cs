using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Consultas;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroManutencao : FrmCadastro
    {
        Manutencao aManutencao;
        FrmConsultaPatrimonios frmConsultaPatrimonios;
        CTLPatrimonios  aCTLPatrimonios;
        CTLManutencao aCTLManutencao;
        public FrmCadastroManutencao()
        {
            InitializeComponent();
            aManutencao = new Manutencao();
            frmConsultaPatrimonios = new FrmConsultaPatrimonios();
            aCTLPatrimonios = new CTLPatrimonios();
            aCTLManutencao = new CTLManutencao();
        }
        public void SetConsultaPatrimonios(FrmConsultaPatrimonios consulta)
        {
            frmConsultaPatrimonios = consulta;
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Manutencao manutencao)
            {
                aManutencao = manutencao;
                CarregarCampos();
            }
        }
        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtCodPatrimonio.Clear();
            txtPatrimonio.Clear();
            dtData.Value = DateTime.Now;
            txtValor.Clear();
            txtProfissional.Clear();
            txtTelefone.Clear();
            txtDescricao.Clear();

        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtCodPatrimonio.Enabled = false;
            txtPatrimonio.Enabled = false;
            dtData.Enabled = false;
            txtValor.Enabled = false;
            txtProfissional.Enabled = false;
            txtTelefone.Enabled = false;
            txtDescricao.Enabled = false;
            btnPesquisarCliente.Enabled = false;

        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtCodPatrimonio.Enabled = true;
            txtPatrimonio.Enabled = true;
            dtData.Enabled = true;
            txtValor.Enabled = true;
            txtProfissional.Enabled = true;
            txtTelefone.Enabled = true;
            txtDescricao.Enabled = true;
            btnPesquisarCliente.Enabled = true;

        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = aManutencao.Id.ToString();
            txtCodPatrimonio.Text = aManutencao.Patrimonio.Id.ToString();
            txtPatrimonio.Text = aManutencao.Patrimonio.Patrimonio;
            dtData.Value = aManutencao.DataReparo ?? DateTime.Now;
            CultureInfo cultura = CultureInfo.InvariantCulture;
            txtValor.Text = aManutencao.ValorConserto.ToString("0.00", cultura);
            txtProfissional.Text = aManutencao.Profissional;
            txtTelefone.Text = aManutencao.Telefone;
            txtDescricao.Text = aManutencao.Descricao;
        }


        protected override bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Campo Descrição não pode estar vazio.");
                txtDescricao.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodPatrimonio.Text))
            {
                MessageBox.Show("Campo Código de patrimônio é inválido ou vazio. Por favor, preencha o campo.");
                txtCodPatrimonio.Focus();
                return false;
            }

            return true;
        }






        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            string fone = txtTelefone.Text.Trim();

            if (!string.IsNullOrEmpty(fone) && !Operacao.IsTelefone(fone))
            {
                MessageBox.Show("Número de telefone inválido. Por favor, insira um Número válido.");
                txtTelefone.Focus();
            }
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifique se o caractere digitado não é um dígito numérico (0-9) e não é Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Impede a entrada do caractere não numérico
            }
        }
        private void ValidarValorKeyPress(object sender, KeyPressEventArgs e)
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


        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            using (FrmConsultaPatrimonios consulta = new FrmConsultaPatrimonios())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodPatrimonio.Text = IdSelecionado.ToString();
                txtPatrimonio.Text = NomeSelecionado;
            }
         //   frmConsultaPatrimonios.ShowDialog();
        }

        private void txtCodPatrimonio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodPatrimonio.Text))
            {
                // Se o campo txtCodPatrimonio estiver vazio, limpe também o campo txtPatrimonio
                txtCodPatrimonio.Clear();
                txtPatrimonio.Clear();
            }
            else if (int.TryParse(txtCodPatrimonio.Text, out int codPatrimonio) && codPatrimonio > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtPatrimonio
                Patrimonios Valida = aCTLPatrimonios.BuscarPatrimonioPorId(codPatrimonio);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodPatrimonio.Clear();
                    txtPatrimonio.Clear();
                    txtCodPatrimonio.Focus();
                }
                else
                {
                    txtPatrimonio.Text = Valida.Patrimonio;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodPatrimonio.Clear();
                txtPatrimonio.Clear();
                txtCodPatrimonio.Focus();
            }
        }
        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta Manutenção?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirManutencao();
                }
            }
        }
        private void ExcluirManutencao()
        {
            if (aManutencao != null)
            {
                try
                {
                    CTLManutencao manutController = new CTLManutencao();
                    manutController.ExcluirManutencao(aManutencao.Id);

                    Close();
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }

        }
        public override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                base.Salvar();
                CultureInfo cultura = CultureInfo.InvariantCulture; // Usar a cultura atual do sistema
                aManutencao.Patrimonio.Id = Convert.ToInt32(txtCodPatrimonio.Text);
                aManutencao.DataReparo = dtData.Value;
                aManutencao.Descricao = txtDescricao.Text;
                aManutencao.Profissional = txtProfissional.Text;
                aManutencao.Telefone = txtTelefone.Text;
                aManutencao.Descricao = txtDescricao.Text;
                aManutencao.ValorConserto = decimal.Parse(txtValor.Text, cultura);
                
                if (int.TryParse(txtCodPatrimonio.Text, out int codPatrimonio) && codPatrimonio > 0)
                {
                    aManutencao.Patrimonio.Id = codPatrimonio;
                }
                else
                {
                    MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");

                }

                // Use o controlador de fichas para salvar ou atualizar a ficha
                CTLManutencao aCTLFichas = new CTLManutencao();
                if (aManutencao.Id == 0)
                {
                    aCTLManutencao.AdicionarManutencao(aManutencao);
                }
                else
                {
                    aCTLManutencao.AtualizarManutencao(aManutencao);
                }
                Close();
            }
        }


    }
}
