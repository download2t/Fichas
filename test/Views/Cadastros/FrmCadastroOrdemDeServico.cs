using Controle.Model;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using static test.Views.FrmLogin;

namespace Controle.Views.Cadastros
{
    public partial class FrmCadastroOrdemDeServico : test.Views.Cadastros.FrmCadastro
    {
        OrdemDeServico aOS;
        CTLOrdemDeServico aCTLOs;
        CTLFotos aCTLFotos;
        Fotos aFoto;

        private Form fotoForm;
        private int proximoIdProvisorio = -1; // Inicializa o próximo ID provisório como -1
        List<Fotos> fotosParaAdicionar = new List<Fotos>();
        List<int> fotosParaExcluir = new List<int>();
        public FrmCadastroOrdemDeServico()
        {
            InitializeComponent();
            aOS = new OrdemDeServico();
            aCTLOs = new CTLOrdemDeServico();

            aCTLFotos = new CTLFotos();
            aFoto = new Fotos();
            pbFoto.MouseDoubleClick += pbFoto_MouseDoubleClick;
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is OrdemDeServico os)
            {
                aOS = os;
                CarregarCampos();
            }
        }
        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtTitulo.Clear();
            cmbPrioridade.SelectedIndex = -1;
            txtDescricao.Clear();
            txtTicket.Clear();
            txtStatus.SelectedIndex = -1;
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtTitulo.Enabled = false;
            cmbPrioridade.Enabled = false;
            txtDescricao.Enabled = false;
            btnFoto.Enabled = false;
            btnRemover.Enabled = false;
            btnRemover.Enabled = false;
            btnReabrir.Enabled = false;
            txtTicket.Enabled = false;
            txtStatus.Enabled = false;

        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtTitulo.Enabled = true;
            cmbPrioridade.Enabled = true;
            txtDescricao.Enabled = true;
            btnFoto.Enabled = true;
            btnRemover.Enabled = true;
            btnRemover.Enabled = true;
            btnReabrir.Enabled = true;
            txtTicket.Enabled = true;
            txtStatus.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = aOS.Id.ToString();
            txtTitulo.Text = aOS.Titulo;
            txtDescricao.Text = aOS.Descricao;
            cmbPrioridade.Text = aOS.Prioridade.ToString();
            txtTicket.Text = aOS.Ticket;
            CarregarLVFoto();
            txtStatus.Text = aOS.Status.ToString();
            if (txtStatus.Text == "Encerrado")
                btnEncerrarOS.Visible = false;

        }
        private void CarregarLVFoto()
        {
            List<Fotos> fotosAlteracao = aCTLFotos.ListarFotosDaOrdemDeServico(aOS.Id);
            PreencherListView(fotosAlteracao);
        }
        private void PreencherListView(IEnumerable<Fotos> fotos)
        {
            listView1.Items.Clear();
            foreach (var f in fotos)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(f.Id));
                item.SubItems.Add(f.Descricao);
                item.Tag = f; // Associe o objeto Parametros ao item usando a propriedade Tag
                listView1.Items.Add(item);
            }
        }
        public override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                int idUser = UserSession.User.Id;
                aOS.Titulo = txtTitulo.Text;
                aOS.Descricao = txtDescricao.Text;
                aOS.Prioridade = string.IsNullOrEmpty(cmbPrioridade.Text) ? "Baixa" : cmbPrioridade.Text;
                aOS.Ticket = txtTicket.Text;

                if (aOS.Id == 0)  // Cria uma nova ordem de serviço se o ID for 0
                {
                    aOS.DataAbertura = DateTime.Now;
                    aOS.Usuario.Id = idUser;
                    aOS.Status = "Aberto";
                    aCTLOs.AdicionarOrdemDeServico(aOS, fotosParaAdicionar);
                    Close();
                }
                else
                {
                    aOS.Status = txtStatus.Text;
                    aCTLOs.AtualizarOrdemDeServico(aOS, fotosParaAdicionar, fotosParaExcluir);
                    Close();
                }
            }
        }

        protected override bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                camposFaltantes.Add("Assunto");
            }

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                camposFaltantes.Add("Descrição");
            }

            if (string.IsNullOrWhiteSpace(cmbPrioridade.Text))
            {
                camposFaltantes.Add("Prioridade");
            }


            if (camposFaltantes.Count > 0)
            {
                string camposFaltantesStr = string.Join(", ", camposFaltantes);
                MessageBox.Show("Os seguintes campos são obrigatórios e não foram preenchidos: " + camposFaltantesStr, "Campos em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        protected override void Verificar()
        {
            if (btnSalvar.Text == "Salvar")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta OS?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirOS();
                }
            }
        }
        private void ExcluirOS()
        {
            if (aOS != null)
            {
                try
                {

                    aCTLOs.ExcluirOrdemDeServico(aOS.Id);

                    // Feche o formulário após a exclusão
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir a Ordem de Serviço devido a outros registros estarem vinclulados a este cliente.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o cliente. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int id = Convert.ToInt32(selectedItem.SubItems[0].Text);

                if (id > 0)
                {
                    // Remove o ID da lista de fotos a serem excluídas
                    fotosParaExcluir.Add(id);
                }
                else if (id < 0)
                {
                    // Remove a foto da lista de fotos a serem adicionadas
                    var fotoParaAdicionar = fotosParaAdicionar.FirstOrDefault(f => f.Id == id);
                    if (fotoParaAdicionar != null)
                    {
                        fotosParaAdicionar.Remove(fotoParaAdicionar);
                    }
                }

                // Remove o item selecionado do ListView
                listView1.Items.Remove(selectedItem);
            }
        }


        private void btnEncerrarOS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja encerrar esta Ordem de Serviço (OS)? Isso resultará no fechamento da OS e quaisquer alterações não serão salvas.",
                                           "Confirmação de Encerramento", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                aOS.DataFechamento = DateTime.Now;
                aOS.Status = "Encerrado";
                aCTLOs.FecharOS(aOS);
                Close();
            }
            else { }
        }
        private void txtTicket_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void btnReabrir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja abrir novamente esta OS?", "confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                aOS.DataReabertura = DateTime.Now;
                aOS.Status = "Aberto";
                aCTLOs.ReabrirOS(aOS);
                txtStatus.Text = aOS.Status.ToString();
                btnEncerrarOS.Visible = true;
                MessageBox.Show("OS Aberta!!");
            }
            else { }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = true; // Permitir seleção de múltiplos arquivos

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string caminhoDaImagem in openFileDialog.FileNames)
                {
                    byte[] fotoBytes = CarregarImagemComoByteArray(caminhoDaImagem);

                    if (fotoBytes != null)
                    {
                        // Obtenha o nome do arquivo da imagem
                        string nomeDoArquivo = Path.GetFileName(caminhoDaImagem);

                        // Crie um objeto Fotos e atribua os valores
                        aFoto = new Fotos
                        {
                            Os = aOS,
                            Id = proximoIdProvisorio--, // Decrementa o ID provisório para que seja autoincrementado
                            Descricao = nomeDoArquivo, // Agora a descrição é o nome do arquivo
                            Foto = fotoBytes
                        };

                        // Adicione a foto à lista de fotos selecionadas
                        fotosParaAdicionar.Add(aFoto);

                        // Adicione a descrição da foto ao ListView
                        ListViewItem item = new ListViewItem(new[] { aFoto.Id.ToString(), nomeDoArquivo });
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private byte[] CarregarImagemComoByteArray(string caminhoDaImagem)
        {
            try
            {
                // Carrega a imagem do arquivo
                Image imagem = Image.FromFile(caminhoDaImagem);

                // Converte a imagem em um array de bytes
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    imagem.Save(memoryStream, imagem.RawFormat);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        // Método para converter byte array para imagem
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string codigo = selectedItem.SubItems[0].Text;

                if (!string.IsNullOrEmpty(codigo))
                {
                    int id = Convert.ToInt32(codigo);
                    var ft = aCTLFotos.BuscarFotoPorId(id);

                    if (ft != null && ft.Foto != null)
                    {
                        using (MemoryStream ms = new MemoryStream(ft.Foto))
                        {
                            pbFoto.Image = Image.FromStream(ms);
                            pbFoto.BackgroundImage = null;
                        }
                    }
                    else
                    {
                        // Verifica se a foto está na lista de fotos a serem adicionadas
                        var fotoParaAdicionar = fotosParaAdicionar.FirstOrDefault(f => f.Id == id);
                        if (fotoParaAdicionar != null)
                        {
                            // Converte o array de bytes em imagem e exibe
                            pbFoto.Image = ByteArrayToImage(fotoParaAdicionar.Foto);
                            pbFoto.BackgroundImage = null;
                        }
                        else
                        {
                            fotoPadrao();
                        }
                    }
                }
            }
            else
            {
                fotoPadrao();
            }
        }


        public void fotoPadrao()
        {
            pbFoto.Image = null;
            pbFoto.BackgroundImage = Properties.Resources.sem_foto1;
        }

        private void pbFoto_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "Salvar" como botão padrão
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btnSalvar; // Restaura o botão "Salvar" como botão padrão
        }

        private void pbAjuda_Click(object sender, EventArgs e)
        {
            // Construindo o aviso com as informações das prioridades
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine("Prioridades das Ordens de Serviço:");
            mensagem.AppendLine();
            mensagem.AppendLine("- URGENTE: Problemas que exigem resolução imediata para evitar impactos significativos.");
            mensagem.AppendLine("- ALTA: Questões que devem ser tratadas rapidamente para evitar desconforto.");
            mensagem.AppendLine("- MÉDIA: Problemas que devem ser resolvidos em um prazo razoável.");
            mensagem.AppendLine("- BAIXA: Questões que podem esperar, não impactando diretamente a experiência dos hóspedes.");

            // Mostrando o aviso em uma MessageBox sem ícone e sem som
            MessageBox.Show(mensagem.ToString(), "Informações de Prioridade",
                            MessageBoxButtons.OK, MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1, 0, false);
        }

    }
}
