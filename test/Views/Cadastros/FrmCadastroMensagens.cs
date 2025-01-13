using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using test.Controllers;
using test.Data;
using test.Model;
using test.Views.Consultas;

namespace test.Views.Cadastros
{
    public partial class FrmCadastroMensagens : FrmCadastro
    {
        Mensagens aMensagem;
        CTLMensagens aCTLMensagens;
        FrmConsultaContatos oFrmConsultaContatos;

        public FrmCadastroMensagens()
        {
            InitializeComponent();
            Timer();
            Cursor = Cursors.Default;
            aMensagem = new Mensagens();
            aCTLMensagens = new CTLMensagens();
        }
        private void Timer()
        {
            // timer que é um relógio apenas
            timerRelógio.Interval = 1000; // 1 Segundo
            timerRelógio.Tick += timerRelógio_Tick;
            timerRelógio.Start();
        }
        private void timerRelógio_Tick(object sender, EventArgs e)
        {
            DateTime horariostart = DateTime.Now;
            lblHorario.Text = horariostart.ToString("HH:mm:ss");
            lblHorario2.Text = horariostart.ToString("HH:mm:ss");
        }
        public void SetConsultaContatos(FrmConsultaContatos consulta)
        {
            oFrmConsultaContatos = consulta;
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Mensagens mensagem)
            {
                aMensagem = mensagem;
                CarregarCampos();
            }
        }
        public override void LimparCampos()
        {
            base.LimparCampos();
            txtID.Clear();
            txtCodContato.Clear();
            txtContato.Clear();
            txtExcluir.Clear();
            txtCodExcluir.Clear();
            cmbAno.Text = string.Empty;
            cmbMes.Text = string.Empty;
            cbHora.Text = string.Empty;

        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtID.Enabled = false;
            txtCodContato.Enabled = false;
            txtContato.Enabled = false;
            btnInserirContato.Enabled = false;
            txtExcluir.Enabled = false;
            txtCodExcluir.Enabled = false;
            cmbAno.Enabled = false;
            cmbMes.Enabled = false;
            cbHora.Enabled = false;
            btnBuscarContatos.Enabled = false;
            btnExcluir.Enabled = false;
            dtEnvio.Enabled = false;
            cbTodos.Enabled = false;
            cbSegunda.Enabled = false;
            cbTerca.Enabled = false;
            cbQuarta.Enabled = false;
            cbQuinta.Enabled = false;
            cbSexta.Enabled = false;
            cbSabado.Enabled = false;
            cbDomingo.Enabled = false;
            cbAnoTodo.Enabled = false;
            tabControl1.Enabled = false;
            txtMsg.Enabled = false;
            btnRemover.Enabled = false;
            txtMsg2.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtID.Enabled = true;
            txtCodContato.Enabled = true;
            txtContato.Enabled = true;
            btnInserirContato.Enabled = true;
            txtExcluir.Enabled = true;
            txtCodExcluir.Enabled = true;
            cmbAno.Enabled = true;
            cmbMes.Enabled = true;
            cbHora.Enabled = true;
            btnBuscarContatos.Enabled = true;
            btnExcluir.Enabled = true;
            dtEnvio.Enabled = true;
            cbTodos.Enabled = true;
            cbSegunda.Enabled = true;
            cbTerca.Enabled = true;
            cbQuarta.Enabled = true;
            cbQuinta.Enabled = true;
            cbSexta.Enabled = true;
            cbSabado.Enabled = true;
            cbDomingo.Enabled = true;
            cbAnoTodo.Enabled = true;
            tabControl1.Enabled = true;
            txtMsg.Enabled = true;
            btnRemover.Enabled = true;
            txtMsg2.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtID.Text = aMensagem.Id.ToString();
            txtContato.Text = aMensagem.OContato.Nome;
            txtCodContato.Text = aMensagem.OContato.Id.ToString();
            txtMsg.Text = aMensagem.Mensagem;
        }
        private bool AgendarEmMassa()
        {
            try
            {
                string problemas = "";

                if (string.IsNullOrWhiteSpace(txtMsg2.Text))
                {
                    problemas += "O campo Mensagem está vazio.\n";
                }

                if (string.IsNullOrWhiteSpace(cbHora2.Text))
                {
                    problemas += "O campo Horário está vazio.\n";
                }

                if (listView1.Items.Count == 0)
                {
                    problemas += "Não há contatos selecionados.\n";
                }

                if (!string.IsNullOrEmpty(problemas))
                {
                    MessageBox.Show(problemas, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                DateTime dataHoraAtual = DateTime.Now;
                int ano = Convert.ToInt32(cmbAno.SelectedItem);
                int horas = Convert.ToInt32(cbHora2.Text.Split(':')[0]);
                int minutos = Convert.ToInt32(cbHora2.Text.Split(':')[1]);

                List<Mensagens> mensagensParaAgendar = new List<Mensagens>();

                List<DayOfWeek> diasSelecionados = GetSelectedDaysOfWeek();

                for (int mes = 1; mes <= 12; mes++)
                {
                    if (cbAnoTodo.Checked || mes == cmbMes.SelectedIndex + 1)
                    {
                        foreach (ListViewItem item in listView1.Items)
                        {
                            string contatoId = item.SubItems[0].Text; // Obtém o ID do contato

                            foreach (DayOfWeek diaSemana in diasSelecionados)
                            {
                                int daysInMonth = DateTime.DaysInMonth(ano, mes);
                                int countDaysOfWeek = CountSpecificDaysInMonth(ano, mes, diaSemana);

                                for (int i = 0; i < countDaysOfWeek; i++)
                                {
                                    DateTime firstDayOfMonth = new DateTime(ano, mes, 1);
                                    int daysToAdd = ((int)diaSemana - (int)firstDayOfMonth.DayOfWeek + 7) % 7 + i * 7;
                                    DateTime dataEnvio = firstDayOfMonth.AddDays(daysToAdd).Date.AddHours(horas).AddMinutes(minutos);

                                    if (dataEnvio <= dataHoraAtual)
                                    {
                                        continue;
                                    }

                                    Mensagens mensagem = new Mensagens
                                    {
                                        OContato = new Contatos { Id = Convert.ToInt32(contatoId) },
                                        DataEnvio = dataEnvio,
                                        Mensagem = txtMsg2.Text,
                                        Status = 'A'

                                    };

                                    mensagensParaAgendar.Add(mensagem);
                                }
                            }
                        }
                    }
                }

                if (mensagensParaAgendar.Count > 0)
                {
                    List<string> erros = aCTLMensagens.AdicionarEmLote(mensagensParaAgendar);

                    if (erros.Count > 0)
                    {
                        string mensagemErro = string.Join("\n", erros);
                        MessageBox.Show($"Erro ao agendar as seguintes mensagens:\n{mensagemErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Mensagens agendadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Não há mensagens para agendar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao agendar as mensagens: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta mensagem?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Excluir();
                }
            }

        }
        private void MensagemUnica()
        {
            if (string.IsNullOrWhiteSpace(txtMsg.Text) || string.IsNullOrWhiteSpace(cbHora.Text) || string.IsNullOrWhiteSpace(txtCodContato.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCodContato.Text.Length > 0)
            {
                try
                {
                    DateTime dataHoraAtual = DateTime.Now;
                    DateTime dataHoraEnvio = Convert.ToDateTime(dtEnvio.Text).Date.Add(TimeSpan.Parse(cbHora.Text));

                    if (dataHoraEnvio <= dataHoraAtual)
                    {
                        MessageBox.Show("A data e hora de envio devem ser maiores do que a data e hora atual.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrEmpty(txtCodContato.Text))
                    {
                        MessageBox.Show("Selecione um Contato antes de prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cbHora_Leave(cbHora, EventArgs.Empty);
                    CarregarDados();

                    if (!string.IsNullOrEmpty(txtID.Text)) // Verifica se o campo txtID tem um valor para decidir entre inserir ou atualizar
                    {
                        // Se txtID tiver um valor, será um update
                        var result = aCTLMensagens.AtualizarMensagem(aMensagem);
                        if (result == "OK")
                        {
                            MessageBox.Show("Mensagem atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar a mensagem");
                        }
                    }
                    else
                    {
                        // Se txtID estiver vazio, será um insert
                        var result = aCTLMensagens.AdicionarMensagem(aMensagem);
                        if (result == "OK")
                        {
                            MessageBox.Show("Mensagem agendada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao agendar a mensagem");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao agendar/atualizar a mensagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            int Aba = AbaSelecionada();
            if (Aba == 0)// ABA DE CADASTRAR MENSAGEM ÚNICA.
            {
                MensagemUnica();
            }
            else if (Aba == 1)// ABA DE CADASTRAR MENSAGEM Em Massa
            {
                var result = AgendarEmMassa();
                if (result)
                    Close();
            }

        }
        private void PreencherComboBoxes()
        {
            // Preencher combobox de mês
            string[] nomesMeses = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            cmbMes.DataSource = nomesMeses.Take(12).ToList(); // Leva apenas os primeiros 12 meses

            // Preencher combobox de ano
            int anoAtual = DateTime.Now.Year;
            List<int> anos = Enumerable.Range(anoAtual, 10).ToList(); // Preenche 10 anos a partir do ano atual
            cmbAno.DataSource = anos;
        }
        private int CountSpecificDaysInMonth(int year, int month, DayOfWeek dayOfWeek)
        {
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int count = 0;

            for (int day = 1; day <= DateTime.DaysInMonth(year, month); day++)
            {
                DateTime currentDate = new DateTime(year, month, day);

                if (currentDate.DayOfWeek == dayOfWeek)
                    count++;
            }

            return count;
        }
        private List<DayOfWeek> GetSelectedDaysOfWeek()
        {
            List<DayOfWeek> selectedDays = new List<DayOfWeek>();

            if (cbDomingo.Checked)
                selectedDays.Add(DayOfWeek.Sunday);

            if (cbSegunda.Checked)
                selectedDays.Add(DayOfWeek.Monday);

            if (cbTerca.Checked)
                selectedDays.Add(DayOfWeek.Tuesday);

            if (cbQuarta.Checked)
                selectedDays.Add(DayOfWeek.Wednesday);

            if (cbQuinta.Checked)
                selectedDays.Add(DayOfWeek.Thursday);

            if (cbSexta.Checked)
                selectedDays.Add(DayOfWeek.Friday);

            if (cbSabado.Checked)
                selectedDays.Add(DayOfWeek.Saturday);

            return selectedDays;
        }
        private void Excluir()
        {
            if (aMensagem != null)
            {
                try
                {
                    var result = aCTLMensagens.ExcluirMensagem(aMensagem.Id);
                    if (result)
                    {
                        MessageBox.Show("Sucesso Mensagens Excluidas.");
                    }
                    Close();
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }

        }
        private void CarregarDados()
        {
            if (!string.IsNullOrEmpty(txtCodContato.Text) && int.TryParse(txtCodContato.Text, out int id) && id > 0)
            {
                int horas = int.Parse(cbHora.Text.Split(':')[0]);
                int minutos = int.Parse(cbHora.Text.Split(':')[1]);

                DateTime dataEnvioCompleta = Convert.ToDateTime(dtEnvio.Text).Date.AddHours(horas).AddMinutes(minutos);
                aMensagem.Status = 'A';
                aMensagem.OContato.Id = id;
                aMensagem.DataEnvio = dataEnvioCompleta;
                aMensagem.Mensagem = txtMsg.Text;
            }
            else
            {
                MessageBox.Show("Erro ao carregar os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void cbHora_Leave(object sender, EventArgs e)
        {
          
        }
        private void cbHora_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void btnBuscarContatos_Click(object sender, EventArgs e)
        {
            using (FrmConsultaContatos consulta = new FrmConsultaContatos())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodContato.Text = IdSelecionado.ToString();
                txtContato.Text = NomeSelecionado;
            }
        }
        private void txtCodContato_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodContato.Text))
            {
                txtCodContato.Clear();
                txtContato.Clear();
            }
            else if (int.TryParse(txtCodContato.Text, out int codContato) && codContato > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtPatrimonio
                CTLContatos aCTLContatos = new CTLContatos();
                Contatos Valida = aCTLContatos.BuscarContatoPorId(codContato);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodContato.Clear();
                    txtContato.Clear();
                    txtContato.Focus();
                }
                else
                {
                    txtContato.Text = Valida.Nome;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodContato.Clear();
                txtContato.Clear();
                txtContato.Focus();
            }
        }
        private void btnInserirContato_Click(object sender, EventArgs e)
        {
            using (FrmConsultaContatos consulta = new FrmConsultaContatos())
            {
                consulta.btnSair.Text = "Selecionar";
                consulta.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consulta.IdSelecionado;
                string NomeSelecionado = consulta.NomeSelecionado;

                // Verifica se o ID selecionado é diferente de zero antes de adicionar ao ListView
                if (IdSelecionado != 0)
                {
                    bool contatoExistente = false;

                    // Verifica se o contato já existe na lista
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[0].Text == IdSelecionado.ToString())
                        {
                            contatoExistente = true;
                            break;
                        }
                    }

                    if (!contatoExistente)
                    {
                        // Adiciona os valores ao ListView existente
                        ListViewItem item = new ListViewItem(IdSelecionado.ToString());
                        item.SubItems.Add(NomeSelecionado);
                        listView1.Items.Add(item); // Substitua 'listView1' pelo nome do seu ListView
                    }
                    else
                    {
                        MessageBox.Show("Este contato já foi adicionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Remove o item selecionado do ListView
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }
        private void btnBuscarContatos_Click_1(object sender, EventArgs e)
        {

            using (FrmConsultaContatos consultaContato = new FrmConsultaContatos())
            {
                consultaContato.btnSair.Text = "Selecionar";
                consultaContato.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consultaContato.IdSelecionado;
                string NomeSelecionado = consultaContato.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                int valor = AbaSelecionada();
                if (valor == 0)
                {
                    txtCodContato.Text = IdSelecionado.ToString();
                    txtContato.Text = NomeSelecionado;
                }
                else if (valor == 2)
                {
                    txtCodExcluir.Text = IdSelecionado.ToString();
                    txtExcluir.Text = NomeSelecionado;
                }

            }
        }
        private int AbaSelecionada()
        {
            int indiceAbaSelecionada = tabControl1.SelectedIndex;

            if (indiceAbaSelecionada == 0)
                return 0;// Cadastrar uma unica mensagem
            else if (indiceAbaSelecionada == 1)
                return 1;// Cadastrar multiplas mensagens
            else
                return 2;// Excluir todas as mensagens para o contato x.
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja Excluir todas as mensagens do contato", txtExcluir.Text + "confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int idParaExcluir = Convert.ToInt32(txtCodExcluir.Text);
                    bool excluidoComSucesso = aCTLMensagens.ExcluirTodasMensagensPorContato(idParaExcluir);
                    if (excluidoComSucesso)
                    {
                        MessageBox.Show("Mensagens excluídas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Fecha o formulário após a exclusão bem-sucedida
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir as mensagens. Verifique se o contato existe ou se houve algum problema na exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {


                    ///
                }
            }
            catch (Exception ex)
            {
                // Trate outras exceções gerais, se necessário
                MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
            }


        }
        private void cbAnoTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnoTodo.Checked)
            {
                cmbMes.Enabled = false;
            }
            else
            {
                cmbMes.Enabled = true;
            }
        }
        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodos.Checked)
            {
                cbDomingo.Checked = true;
                cbSegunda.Checked = true;
                cbTerca.Checked = true;
                cbQuarta.Checked = true;
                cbQuinta.Checked = true;
                cbSexta.Checked = true;
                cbSexta.Checked = true;
                cbSabado.Checked = true;
            }
            else
            {
                cbDomingo.Checked = false;
                cbSegunda.Checked = false;
                cbTerca.Checked = false;
                cbQuarta.Checked = false;
                cbQuinta.Checked = false;
                cbSexta.Checked = false;
                cbSexta.Checked = false;
                cbSabado.Checked = false;
            }
        }
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            PreencherComboBoxes();
        }
        private void txtCodContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((TextBox)sender, e);
        }

        private void Hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado não é um número nem o caractere ":"
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true; // Impede a entrada do caractere no ComboBox
            }
        }

        private void Hora_Leave(object sender, EventArgs e)
        {
            string input = cbHora.Text;

            if (!input.Contains(":") && input.Length == 4)
            {
                cbHora.Text = $"{input.Substring(0, 2)}:{input.Substring(2, 2)}";
            }
        }

        private void pbAjuda_Click(object sender, EventArgs e)
        {
            // Construindo o aviso com as informações das prioridades
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine("TODAS AS MENSAGENS DO USUÁRIO SERÃO EXCLUIDAS");
            mensagem.AppendLine("EXCETO AS MENSAGENS JÁ ENVIADAS");

            // Mostrando o aviso em uma MessageBox sem ícone e sem som
            MessageBox.Show(mensagem.ToString(), "Informações de Exclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1, 0, false);
        }
    }
}