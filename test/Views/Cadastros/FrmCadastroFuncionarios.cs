using Controle.Views.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Consultas;
using static test.Views.FrmLogin;

namespace Controle.Views.Cadastros
{
    public partial class FrmCadastroFuncionarios : test.Views.Cadastros.FrmCadastro
    {
        FrmConsultaFuncionarios oFormConsultaFuncionarios;
        CTLCargos oCtlCargos;
        CTLSetores oCtlSetor;
        CTLFuncionarios aCTLFuncionarios;
        Funcionario oFuncionario;
        public FrmCadastroFuncionarios()
        {
            InitializeComponent();
            oCtlCargos = new CTLCargos();
            oCtlSetor = new CTLSetores();
            aCTLFuncionarios = new CTLFuncionarios();
            oFuncionario = new Funcionario();
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Funcionario funcionario)
            {
                oFuncionario = funcionario;
                CarregarCampos();
            }
        }

        public void SetConsultaClientes(FrmConsultaFuncionarios consulta)
        {
            oFormConsultaFuncionarios = consulta;
        }

        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtCodFuncao.Clear();
            txtCodSetor.Clear();
            txtSetor.Clear();
            txtFuncao.Clear();
            txtValor.Clear();
            cmbAtivo.SelectedIndex = -1;
            txtTelefone.Clear();

        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false; 
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtCodFuncao.Enabled = false;
            txtFuncao.Enabled = false;
            txtCodSetor.Enabled = false;
            txtSetor.Enabled = false;
            txtValor.Enabled = false;
            cmbAtivo.Enabled = false;
            txtTelefone.Enabled = false;
            btnPesquisarFuncao.Enabled = false;
            btnPesquisarSetor.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtCodFuncao.Enabled = true;
            txtFuncao.Enabled = true;
            txtCodSetor.Enabled = true;
            txtSetor.Enabled = true;
            txtValor.Enabled = true;
            cmbAtivo.Enabled = true;
            txtTelefone.Enabled = true;
            btnPesquisarFuncao.Enabled = true;
            btnPesquisarSetor.Enabled= true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oFuncionario.Id.ToString();
            txtNome.Text = oFuncionario.Nome;
            txtCpf.Text = oFuncionario.Cpf;
            txtCodFuncao.Text = oFuncionario.Cargo.Id.ToString();
            txtFuncao.Text = oFuncionario.Cargo.Funcao;
            txtCodSetor.Text = oFuncionario.Setor.Id.ToString();
            txtSetor.Text = oFuncionario.Setor.Setor.ToString();
            CultureInfo cultura = CultureInfo.InvariantCulture;
            txtValor.Text = oFuncionario.SalBruto.ToString("0.00", cultura);
            cmbAtivo.Text = oFuncionario.Ativo.ToString();
            txtTelefone.Text = oFuncionario.Telefone;
        }


        public override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                base.Salvar();
                CultureInfo cultura = CultureInfo.InvariantCulture; // Usar a cultura atual do sistema
                oFuncionario.Nome = txtNome.Text;
                oFuncionario.Cpf = txtCpf.Text;
                oFuncionario.Cargo.Id = Convert.ToInt32(txtCodFuncao.Text);
                oFuncionario.Setor.Id = Convert.ToInt32(txtCodSetor.Text);
                oFuncionario.SalBruto = decimal.Parse(txtValor.Text,cultura);
                oFuncionario.Ativo = cmbAtivo.Text[0]; ;
                oFuncionario.Telefone = txtTelefone.Text;
                if (int.TryParse(txtCodFuncao.Text, out int cod) && cod > 0)
                {
                    oFuncionario.Cargo.Id = cod;
                }
                else
                {
                    MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");

                }
                if (int.TryParse(txtCodSetor.Text, out int cod2) && cod2 > 0)
                {
                    oFuncionario.Setor.Id = cod2;
                }
                else
                {
                    MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");

                }
                // Use o controlador de fichas para salvar ou atualizar a ficha
                if (oFuncionario.Id == 0)
                {
                    aCTLFuncionarios.AdicionarFuncionario(oFuncionario);
                }
                else
                {
                    aCTLFuncionarios.AtualizarFuncionario(oFuncionario);
                }
                Close();
            }
        }

        protected override bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Campo Nome não pode estar vazio.");
                txtNome.Focus();
                return false;
            }
          /* if (string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("Campo Cpf não pode estar vazio.");
                txtCpf.Focus();
                return false;
            }*/
            if (string.IsNullOrWhiteSpace(cmbAtivo.Text))
            {
                MessageBox.Show("Campo Funcionário ativo não pode estar vazio.");
                cmbAtivo.Focus();
                return false;
            }
            if (!int.TryParse(txtCodFuncao.Text, out _))
            {
                MessageBox.Show("Campo Código inválido.");
                txtCodFuncao.Focus();
                return false;
            }
            if (!int.TryParse(txtCodSetor.Text, out _))
            {
                MessageBox.Show("Campo Código é  inválido.");
                txtCodSetor.Focus();
                return false;
            }
            if (!decimal.TryParse(txtValor.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Campo de salário é inválido.");
                txtCodSetor.Focus();
                return false;
            }
            return true;
        }

        protected override void Verificar()
        {
            if (string.IsNullOrEmpty(txtCodFuncao.Text) || !int.TryParse(txtCodSetor.Text, out int codCliente) || codCliente <= 0)
            {
                MessageBox.Show("Por favor, insira um valor válido para o código do cliente.");
                return;
            }

            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este funcionário?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirFuncionario();
                }
            }
        }

        private void ExcluirFuncionario()
        {
            if (oFuncionario != null)
            {
                try
                {
                    aCTLFuncionarios.ExcluirFuncionario(oFuncionario.Id);

                    // Feche o formulário após a exclusão
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o funcionário devido a outros registros estarem vinclulados ao mesmo.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir funcionário. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }

        #region  LAYOYT BUTTONS E  EVENTOS
        private void txtCpf_Leave(object sender, EventArgs e)
        {
            string documento = txtCpf.Text.Trim();

            if (!string.IsNullOrEmpty(documento))
            {
                bool isValid = Operacao.IsCpf(documento) || Operacao.IsCnpj(documento);

                if (!isValid)
                {
                    MessageBox.Show("CPF ou CNPJ inválido. Por favor, insira um documento válido.");
                    txtCpf.Focus();
                }
            }
        }

        private void txtCodFuncao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((TextBox)sender, e);
        }

        private void txtCodFuncao_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodFuncao.Text))
            {
                // Se o campo txtCodCliente estiver vazio, limpe também o campo txtCliente
                txtCodFuncao.Clear();
                txtFuncao.Clear();
            }
            else if (int.TryParse(txtCodFuncao.Text, out int codCargo) && codCargo > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtCliente
                Cargo Valida = oCtlCargos.BuscarCargoPorId(codCargo);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodFuncao.Clear();
                    txtFuncao.Clear();
                    txtCodFuncao.Focus();
                }
                else
                {
                    txtFuncao.Text = Valida.Funcao;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodFuncao.Clear();
                txtFuncao.Clear();
                txtCodFuncao.Focus();

            }
        }

        private void txtCodSetor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodSetor.Text))
            {
                // Se o campo txtCodCliente estiver vazio, limpe também o campo txtCliente
                txtCodSetor.Clear();
                txtSetor.Clear();
            }
            else if (int.TryParse(txtCodSetor.Text, out int codSetor) && codSetor > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtCliente
                Setores Valida = oCtlSetor.BuscarSetorPorId(codSetor);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodSetor.Clear();
                    txtSetor.Clear();
                    txtCodSetor.Focus();
                }
                else
                {
                    txtSetor.Text = Valida.Setor;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodSetor.Clear();
                txtSetor.Clear();
                txtCodSetor.Focus();
            }
        }
        private ControleGov CreateControleGovFromDataRow(DataRow row)
        {
            Funcionario func = aCTLFuncionarios.BuscarFuncionarioPorId(Convert.ToInt32(row["FuncionarioID"]));
            return new ControleGov
            {
                ID = Convert.ToInt32(row["ID"]),
                Data = Convert.ToDateTime(row["Data"]),
                PermaneceEntrada = Convert.ToInt32(row["PermaneceEntrada"]),
                SaidasEntrada = Convert.ToInt32(row["SaidasEntrada"]),
                ReservadasRealizadas = Convert.ToInt32(row["ReservadasRealizadas"]),
                PermaneceRealizadas = Convert.ToInt32(row["PermaneceRealizadas"]),
                SaidasRealizadas = Convert.ToInt32(row["SaidasRealizadas"]),
                Realizados = Convert.ToInt32(row["Realizados"]),
                Porcentagem = Convert.ToDecimal(row["Porcentagem"]),
                Funcionarios = func
            };
        }

        private void btnPesquisarFuncao_Click(object sender, EventArgs e)
        {
            using (FrmConsultaCargos consulta = new FrmConsultaCargos())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodFuncao.Text = IdSelecionado.ToString();
                txtFuncao.Text = NomeSelecionado;
            }
        }

        private void btnPesquisarSetor_Click(object sender, EventArgs e)
        {
            using (FrmConsultaSetores consulta = new FrmConsultaSetores())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodSetor.Text = IdSelecionado.ToString();
                txtSetor.Text = NomeSelecionado;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion


    }
}
