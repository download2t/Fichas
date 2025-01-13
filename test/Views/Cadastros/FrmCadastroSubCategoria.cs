using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Consultas;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroSubCategoria :FrmCadastro
    {
        FrmConsultaCategorias oFormConsultaCategoria;
        CTLSubCategorias CTLSubCategorias;
        CTLCategorias aCTLCategorias;
        Subcategoria aSubCategoria;
       
        public FrmCadastroSubCategoria()
        {
            InitializeComponent();
            CTLSubCategorias = new CTLSubCategorias();
            aSubCategoria = new Subcategoria();
            aCTLCategorias = new CTLCategorias();
        }
        public void SetConsultaCategoria(FrmConsultaCategorias consultaCategoria)
        {
            oFormConsultaCategoria = consultaCategoria;
        }
        //Metodos
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Subcategoria subCategoria)
            {
                aSubCategoria = subCategoria;
                CarregarCampos();
            }
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtCodCategoria.Enabled = false;
            txtCategoria.Enabled = false;
            txtSubCategoria.Enabled = false;
            btnBuscar.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtCodCategoria.Enabled = true;
            txtCategoria.Enabled = true;
            txtSubCategoria.Enabled = true;
            btnBuscar.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = aSubCategoria.Id.ToString();
            txtCodCategoria.Text = aSubCategoria.Categoria.Id.ToString();
            txtCategoria.Text = aSubCategoria.Categoria.Nome; 
            txtSubCategoria.Text = aSubCategoria.Nome;
        }

        public override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                aSubCategoria.Categoria.Id = Convert.ToInt32(txtCodCategoria.Text);
                aSubCategoria.Nome = txtSubCategoria.Text;

                if (aSubCategoria.Id == 0)
                    CTLSubCategorias.AdicionarSubcategoria(aSubCategoria);
                else
                    CTLSubCategorias.AtualizarSubcategoria(aSubCategoria);
                Close();
            }
         
        }
        protected override bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txtCodCategoria.Text))
            {
                MessageBox.Show("Campo de Código da categoria não pode estar vazio.");
                txtCategoria.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSubCategoria.Text))
            {
                MessageBox.Show("Campo de sub categoria não pode estar vazio.");
                txtCategoria.Focus();
                return false;
            }
            return true;
        }


        private void ExcluirSubCategoria()
        {
            if (aSubCategoria != null)
            {
                try
                {
                    CTLSubCategorias subaCTLCategorias = new CTLSubCategorias();
                    subaCTLCategorias.ExcluirSubcategoria(aSubCategoria.Id);
                    // Feche o formulário após a exclusão
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir a sub categoria devido a outros registros estarem vinclulados a esta sub categoria.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir a sub bategoria. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }
        //Buttons
        protected override void Verificar()
        {
            if (string.IsNullOrEmpty(txtCodCategoria.Text) || !int.TryParse(txtCodCategoria.Text, out int codCategoria) || codCategoria <= 0)
            {
                MessageBox.Show("Por favor, insira um valor válido para o código da categoria.");
                return;
            }

            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirSubCategoria();
                }
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            using (FrmConsultaCategorias consultaCategoria = new FrmConsultaCategorias())
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
                Categoria Valida = aCTLCategorias.BuscarCategoriaPorId(codCategoria);
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

        private void ValidarValorKeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((TextBox)sender, e);
        }
    }
}
