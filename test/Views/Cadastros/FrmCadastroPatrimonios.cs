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
using System.Xml.Linq;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Views.Consultas;
using static test.Views.FrmLogin;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroPatrimonios :FrmCadastro
    {

        public string caminhoFoto = "";
        Patrimonios oPatrimonio;
        FrmConsultaSetores oFormConsultaSetores;
        FrmConsultaCategorias oFormConsultaCategorias;
        FrmConsultaSubCategorias oFormConsultaSubCategorias;
        CTLPatrimonios aCTLPatrimonios;
        CTLSetores aCTLSetores;
        CTLCategorias aCTLCategorias;
        CTLSubCategorias aCTLSubCategorias;
        CTLBaixasPatrimonios CTLBaixas;
        private Form fotoForm;
        public int ValorCategoria = 0;

        public FrmCadastroPatrimonios()
        {
            InitializeComponent();
            Instanciar();
        } //Metodos
        public void Instanciar()
        {
            oPatrimonio = new Patrimonios();
            aCTLSetores = new CTLSetores();
            aCTLCategorias = new CTLCategorias();
            aCTLSubCategorias = new CTLSubCategorias();
            aCTLPatrimonios = new CTLPatrimonios();
            CTLBaixas = new CTLBaixasPatrimonios();
        }

        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtPatrimonio.Clear();
            txtCodSetor.Clear();
            txtCodCategoria.Clear();
            txtCodSubCategoria.Clear();
            txtSetor.Clear();
            txtCategoria.Clear();
            txtSubCategoria.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtPatrimonio.Enabled = false;
            txtCodSetor.Enabled = false;
            txtCodCategoria.Enabled = false;
            txtCodSubCategoria.Enabled = false;
            txtSetor.Enabled = false;
            txtCategoria.Enabled = false;
            txtSubCategoria.Enabled = false; ;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            btnPesquisarSetor.Enabled = false;
            btnPesquisarCategoria.Enabled = false;
            btnPesquisarSubCategoria.Enabled = false;
            btnBaixa.Enabled = false;
            btnFoto.Enabled = false;
            btnSalvar.Enabled = false;

        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtPatrimonio.Enabled = true;
            txtCodSetor.Enabled = true;
            txtCodCategoria.Enabled = true;
            txtCodSubCategoria.Enabled = true;
            txtSetor.Enabled = true;
            txtCategoria.Enabled = true;
            txtSubCategoria.Enabled = true; ;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            btnPesquisarSetor.Enabled = true;
            btnPesquisarCategoria.Enabled = true;
            btnPesquisarSubCategoria.Enabled = true;
            btnBaixa.Enabled = true;
            btnFoto.Enabled = true;
            btnSalvar.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = oPatrimonio.Id.ToString();
            txtPatrimonio.Text = oPatrimonio.Patrimonio;
            txtCodSetor.Text = oPatrimonio.Setor.Id.ToString();
            txtCodCategoria.Text = oPatrimonio.Subcategoria.Categoria.Id.ToString();
            txtCodSubCategoria.Text = oPatrimonio.Subcategoria.Id.ToString();
            txtSetor.Text = oPatrimonio.Setor.Setor;
            txtCategoria.Text = oPatrimonio.Subcategoria.Categoria.Nome;
            txtSubCategoria.Text = oPatrimonio.Subcategoria.Nome;
            txtDescricao.Text = oPatrimonio.Descricao;
            CultureInfo cultura = CultureInfo.InvariantCulture;
            txtValor.Text = oPatrimonio.Valor.ToString("0.00", cultura);

            if (oPatrimonio.Foto != null && oPatrimonio.Foto.Length > 0)
            {
                pbFoto.BackgroundImage = null;
                using (MemoryStream ms = new MemoryStream(oPatrimonio.Foto))
                {
                    pbFoto.Image = Image.FromStream(ms);
                }
            }
        }


        protected override bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Campo Descrição não pode estar vazio.");
                txtDescricao.Focus();
                return false;
            }
            if (!int.TryParse(txtCodSetor.Text, out int codSetor) || codSetor <= 0)
            {
                MessageBox.Show("Campo de Setor é inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodSetor.Focus();
                return false;
            }

            if (!int.TryParse(txtCodSubCategoria.Text, out int codSubCategoria) || codSubCategoria <= 0)
            {
                MessageBox.Show("Campo Código de Sub Categoria é inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodSubCategoria.Focus();
                return false;
            }

            // O código continua se ambos os campos forem válidos e maiores que zero

            if (string.IsNullOrWhiteSpace(txtPatrimonio.Text))
            {
                MessageBox.Show("Campo de patrimônio é inválido ou vazio. Por favor, preencha o campo.");
                txtPatrimonio.Focus();
                return false;
            }
            if (!decimal.TryParse(txtValor.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Campo Valor é inválido.");
                txtValor.Focus();
                return false;
            }
            return true;
        }

        public void SetConsultaSetores(FrmConsultaSetores consulta)
        {
            oFormConsultaSetores = consulta;
        }
        public void SetConsultaCategorias(FrmConsultaCategorias consulta)
        {
            oFormConsultaCategorias = consulta;
        }
        public void SetConsultaSubCategorias(FrmConsultaSubCategorias consulta)
        {
            oFormConsultaSubCategorias = consulta;
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Patrimonios patrimonios)
            {
                oPatrimonio = patrimonios;
                CarregarCampos();
            }
        }
        private void CarregarFoto()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "arquivos de imagens jpg e png |*.jpeg; *.png";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
                caminhoFoto = openFile.FileName;

            if (caminhoFoto != "")
            {
                pbFoto.Load(caminhoFoto);
                pbFoto.BackgroundImage = null;
            }
        }
        private void ExcluirPatrimonio()
        {
            if (oPatrimonio != null)
            {
                try
                {
                    CTLPatrimonios patController = new CTLPatrimonios();
                    patController.ExcluirPatrimonio(oPatrimonio.Id);

                    Close();
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
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este patrimônio?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirPatrimonio();
                }
            }
        }
        public override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                base.Salvar();
                CultureInfo cultura = CultureInfo.InvariantCulture; // Usar a cultura atual do sistema
                oPatrimonio.Patrimonio = txtPatrimonio.Text;
                oPatrimonio.Descricao = txtDescricao.Text;
                oPatrimonio.Valor = decimal.Parse(txtValor.Text, cultura);
                oPatrimonio.CaminhoFoto = caminhoFoto;
                if (int.TryParse(txtCodSetor.Text, out int cod))
                {
                    oPatrimonio.Setor.Id = cod;
                }
                if (int.TryParse(txtCodSubCategoria.Text, out int codg2))
                {
                    oPatrimonio.Subcategoria.Id = codg2;
                }

                if (pbFoto.Image == null)// Verifica se a foto é nula.
                {

                    MessageBox.Show("Por favor, selecione uma foto antes de continuar.",
                                    "Foto não selecionada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }
                if (oPatrimonio.Id == 0)
                    // Adicione com foto usando o controlador
                    aCTLPatrimonios.AdicionarPatrimonio(oPatrimonio);
                else
                    // Atualize com foto usando o controlador
                    aCTLPatrimonios.AtualizarPatrimonio(oPatrimonio);


                Close();
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            CarregarFoto();
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

        private void btnPesquisarCategoria_Click(object sender, EventArgs e)
        {
            using (FrmConsultaCategorias consulta = new FrmConsultaCategorias())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodCategoria.Text = IdSelecionado.ToString();
                txtCategoria.Text = NomeSelecionado;
            }
        }

        private void btnPesquisarSubCategoria_Click(object sender, EventArgs e)
        {
            if (txtCodCategoria.Text != "")
            {
                int valor = Convert.ToInt32(txtCodCategoria.Text);
                ValorCategoria = Convert.ToInt32(txtCodCategoria.Text);
                using (FrmConsultaSubCategorias consulta = new FrmConsultaSubCategorias(valor))
                {
                    consulta.btnSair.Text = "Selecionar";
                    consulta.ShowDialog();

                    // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                    int IdSelecionado = consulta.IdSelecionado;
                    string NomeSelecionado2 = consulta.NomeSelecionado2;

                    // Agora, defina os valores nos campos do seu formulário de cadastro
                    txtCodSubCategoria.Text = IdSelecionado.ToString();
                    txtSubCategoria.Text = NomeSelecionado2;
                }
            }
            else
            {
                MessageBox.Show("Campo de categoria prescisa estár preenchido para selecionar uma sub categoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

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



        private void txtCodCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txtCodSubCategoria.Text.Length > 0)
            {
                txtCodSubCategoria.Clear();
            }
        }
        private void txtCodSetor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodSetor.Text))
            {
                // Se o campo txtCodSetor estiver vazio, limpe também o campo txtSetor
                txtCodSetor.Clear();
                txtSetor.Clear();
            }
            else if (int.TryParse(txtCodSetor.Text, out int codSetor) && codSetor > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtSetor
                Setores Valida = aCTLSetores.BuscarSetorPorId(codSetor);
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

        private void txtCodSubCategoria_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodSubCategoria.Text))
            {
                // Se o campo txtCodSubCategoria estiver vazio, limpe também o campo txtSubCategoria
                txtCodSubCategoria.Clear();
                txtSubCategoria.Clear();
            }
            else if (int.TryParse(txtCodSubCategoria.Text, out int codSubCategoria) && codSubCategoria > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtSubCategoria
                Subcategoria Valida = aCTLSubCategorias.BuscarSubcategoriaPorId(codSubCategoria);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodSubCategoria.Clear();
                    txtSubCategoria.Clear();
                }
                else
                {
                    txtSubCategoria.Text = Valida.Nome;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodSubCategoria.Clear();
                txtSubCategoria.Clear();
            }
        }


        private void btnBaixa_Click(object sender, EventArgs e)
        {
            string buttonText = btnBaixa.Text;
            Patrimonios oPatrimonio = new Patrimonios();
            oPatrimonio.Id = Convert.ToInt32(txtID.Text);

            switch (buttonText)
            {
                case "Recuperar Patrimônio":
                    if (string.IsNullOrEmpty(txtValor.Text))
                    {
                        MessageBox.Show("Para recuperar o patrimônio, o campo de valor não pode ser nulo.");
                        return;
                    }

                    if (!int.TryParse(txtValor.Text, out int valor) || valor <= 0)
                    {
                        MessageBox.Show("O valor deve ser um número inteiro maior que 0.");
                        return;
                    }

                    oPatrimonio.Valor = valor;
                    oPatrimonio.Baixa = "NAO";
                    CTLBaixas.DarBaixaPatrimonial(oPatrimonio);
                    MessageBox.Show("Patrimônio recuperado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    break;

                case "Baixa no Patrimônio":
                    DialogResult result = MessageBox.Show("Tem certeza que deseja dar baixa neste patrimônio?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        oPatrimonio.Valor = 0;
                        oPatrimonio.Baixa = "SIM";
                        CTLBaixas.DarBaixaPatrimonial(oPatrimonio);
                        MessageBox.Show("Baixa registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    break;

                default:
                    // Handle any other cases here or provide an error message for unknown buttonText values.
                    MessageBox.Show("Ação não reconhecida.");
                    break;
            }
        }

        private void pbFoto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (fotoForm == null || fotoForm.IsDisposed)
                {
                    fotoForm = Operacao.CriarFormFoto(pbFoto.Image);
                    fotoForm.Show();
                }
                else
                {
                    fotoForm.BringToFront();
                }
            }
        }
    }
}

