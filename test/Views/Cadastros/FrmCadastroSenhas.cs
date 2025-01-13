using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Consultas;
using static test.Views.FrmLogin;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroSenhas : test.Views.Cadastros.FrmCadastro
    {
        private Senhas aSenha;
        CTLSenhas aCTLSenhas;
        CTLCategorias aCTLCategorias;
        FrmConsultaCategoriaSenhas aConsultaCategoriaSenhas;
      
        public FrmCadastroSenhas()
        {
            InitializeComponent();
            aSenha = new Senhas();
            aConsultaCategoriaSenhas = new FrmConsultaCategoriaSenhas();
            aCTLCategorias = new CTLCategorias();         
            aCTLSenhas    = new CTLSenhas();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Senhas senha)
            {
                aSenha = senha;
                CarregarCampos();
            }
        }

        public void SetConsultaCategorias(FrmConsultaCategoriaSenhas consultaCatSenhas)
        {
            aConsultaCategoriaSenhas = consultaCatSenhas;
        }
        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtLink.Clear();
            txtCodCategoria.Clear();
            txtCategoria.Clear();
            txtDescricao.Clear();
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Clear();
            txtID.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            txtLink.Enabled = false;
            txtCodCategoria.Enabled = false;
            txtDescricao.Enabled = false;
            btnPesquisarCategoria.Enabled = false;

        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            txtLink.Enabled = true;
            txtCodCategoria.Enabled = true;
            txtDescricao.Enabled = true;
            btnPesquisarCategoria.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = aSenha.Id.ToString();
            txtLogin.Text = aSenha.Login;
            txtSenha.Text = aSenha.Senha;
            txtLink.Text = aSenha.Link;
            txtCodCategoria.Text = aSenha.Categoria.Id.ToString();
            txtCategoria.Text = aSenha.Categoria.Nome;
            txtDescricao.Text = aSenha.Descricao;
        }

        protected override bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Campo Descrição não pode estar vazio.");
                txtDescricao.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Campo Login não pode estar vazio.");
                txtLogin.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Campo Senha não pode estar vazio.");
                txtSenha.Focus();
                return false;
            }
            if (!int.TryParse(txtCodCategoria.Text, out _))
            {
                MessageBox.Show("Campo Código de Categoria inválido.");
                txtCodCategoria.Focus();
                return false;
            }

            return true;
        }
        protected override void Verificar()
        {
            if (string.IsNullOrEmpty(txtCodCategoria.Text) || !int.TryParse(txtCodCategoria.Text, out int codCliente) || codCliente <= 0)
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
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta senha?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Excluir();
                }
            }
        }
        public override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                base.Salvar();
                aSenha.Descricao = txtDescricao.Text;
                aSenha.Login = txtLogin.Text;
                aSenha.Senha = txtSenha.Text;
                aSenha.Link = txtLink.Text;
                if (int.TryParse(txtCodCategoria.Text, out int cod) && cod > 0)
                {
                    aSenha.Categoria.Id = cod;
                }
                else
                {
                    MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");

                }
                if (aSenha.Id == 0)
                {
                   aCTLSenhas.AdicionarSenha(aSenha);
                }
                else
                {
                    aCTLSenhas.AtualizarSenha(aSenha);
                }
                Close();
            }
        }
      
        private void Excluir()
        {
            if (aSenha != null)
            {
                try
                {
                    CTLSenhas senhaController = new CTLSenhas();
                    senhaController.ExcluirSenha(aSenha.Id);

                    // Feche o formulário após a exclusão
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o cliente devido a outros registros estarem vinclulados a esta ficha.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir a ficha. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }

        private void txtCodCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((TextBox)sender, e);
        }

        private void txtCodCategoria_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCategoria.Text))
            {
                // Se o campo txtCodCategoria estiver vazio, limpe também o campo txtCategoria
                txtCodCategoria.Clear();
                txtCategoria.Clear();
            }
            else if (int.TryParse(txtCodCategoria.Text, out int codCategoria) && codCategoria > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtCategoria
                Categoria Valida = aCTLCategorias.BuscarCategoriaPorIdDeSenha(codCategoria);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodCategoria.Clear();
                    txtCategoria.Clear();
                    txtCodCategoria.Focus();
                }
                else
                {
                    txtCategoria.Text = Valida.Nome;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodCategoria.Clear();
                txtCategoria.Clear();
                txtCodCategoria.Focus();
            }
        }

        private void btnPesquisarCategoria_Click(object sender, EventArgs e)
        {
            using (FrmConsultaCategoriaSenhas consultaCategoria = new FrmConsultaCategoriaSenhas())
            {
                consultaCategoria.btnSair.Text = "Selecionar";
                consultaCategoria.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consultaCategoria.IdSelecionado;
                string NomeSelecionado = consultaCategoria.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodCategoria.Text = IdSelecionado.ToString();
                txtCategoria.Text = NomeSelecionado;
            }
        }
    }
}
