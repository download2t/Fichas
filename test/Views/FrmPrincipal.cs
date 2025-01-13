using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static test.Views.FrmLogin;
using test.Classes;
using test.Controllers;
using test.DAL;
using test.Views;
using test.Model;
//Teste
namespace Controle.Views
{
    public partial class FrmPrincipal : Form
    {
        private AuthContext authContext;
        private Interfaces aInter;
        CTLUsuarios aCTLUsuarios;
        CTLPermissaoMenu aCTLPermissaoMenu;
        int idUsuario = 0;
        private List<PermissaoMenu> permissoes;
        private HashSet<string> acessosPermitidos;
        private const string ApiKey = "647c698d4310199670c8432399aa75c8"; // Sua chave de API da OpenWeatherMap
        private const string City = "Foz do Iguacu"; // Nome da cidade desejada
        private double temperature = 0.0;
        private DateTime currentDateTime;
        public FrmPrincipal()
        {
            InitializeComponent();
            aInter = new Interfaces();
            aCTLUsuarios = new CTLUsuarios();
            aCTLPermissaoMenu = new CTLPermissaoMenu();
            CarregarPermissoes(); // Carrega permissões ao iniciar o formulário
            authContext = new AuthContext();
            Apresentar();
            // Iniciar um timer para atualizar a cada segundo
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += (sender, e) =>
            {
                AtualizarDadosClima();
                AtualizarLabels();
            };
            timer.Start();
        }
        private void AtualizarDadosClima()
        {
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={City}&appid={ApiKey}&units=metric";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    string json = webClient.DownloadString(apiUrl);
                    JObject jsonObject = JObject.Parse(json);

                    temperature = (double)jsonObject["main"]["temp"];
                    currentDateTime = DateTime.Now;
                }
            }
            catch (Exception)
            {
                // Lidar com exceções
                temperature = 0.0;
                currentDateTime = DateTime.Now;
            }
        }
        private void AtualizarLabels()
        {
            lblCity.Text = $"Cidade: {City}";
            lblTemperature.Text = $"Temperatura: {temperature:F1}°C";
            lblDateTime.Text = $"Data e Hora: {currentDateTime:dd/MM/yyyy HH:mm:ss}";
        }
        Dictionary<string, string> tagsPatrimonios = new Dictionary<string, string> // dicionario com o tag e text, também a foto do botão.
        {
            { "CATEGORIA", "Categorias" },//TAG + text / FOTO
            { "SUB CATEGORIA", "SubCategoria" },//TAG + text / FOTO
            { "SETORES", "Setores" }, //TAG + text / FOTO
            { "PATRIMÔNIOS", "Patrimonio" },//TAG + text / FOTO
            { "MANUTENÇÃO", "Manutencao" },//TAG + text / FOTO
            { "BAIXAS PATRIMÔNIAIS", "Baixa_Patrimonios" }//TAG + text / FOTO
        };
        Dictionary<string, string> TagsFichas = new Dictionary<string, string> // dicionario com o tag e text, também a foto do botão.
        {
            { "FICHAS", "Fichas" },//TAG + text / FOTO
            { "CLIENTES", "Clientes" },//TAG + text / FOTO
        };
        Dictionary<string, string> TagsOrdemDeServico = new Dictionary<string, string> // dicionario com o tag e text, também a foto do botão.
        {
            { "ORDEM DE SERVIÇO", "ordem-de-servico" },//TAG + text / FOTO
        };
        Dictionary<string, string> TagsOperacoes = new Dictionary<string, string> // dicionario com o tag e text, também a foto do botão.
        {
            { "COFRES", "Cofres" },//TAG + text / FOTO,
            { "CAMERAS", "Camera" },//TAG + text / FOTO
            { "RAMAIS", "Ramal" },//TAG + text / FOTO
        };
        Dictionary<string, string> TagsGov = new Dictionary<string, string> // dicionario com o tag e text, também a foto do botão.
        {
            { "GOVERNANÇA", "Gov" },//TAG + text / FOTO
            { "LAVANDERIA", "Lavanderia" },//TAG + text / FOTO
            { "ITENS LAVANDERIA", "Item_Lavanderia" },//TAG + text / FOTO
        };
        Dictionary<string, string> TagsAgenda = new Dictionary<string, string> // dicionario com o tag e text, também a foto do botão.
        {
            { "CONTATOS", "Contatos" },//TAG + text / FOTO
            { "MENSAGENS", "Mensagens" },//TAG + text / FOTO
        };
        Dictionary<string, string> TagsRelatorios = new Dictionary<string, string> // dicionario com o tag e text, também a foto do botão.
        {
            { "REL. PATRIMONIOS", "Patrimonio" },//TAG + text / FOTO
            { "REL. MANUTENÇÃO", "Manutencao" },//TAG + text / FOTO
            { "REL. FICHAS", "Fichas" },//TAG + text / FOTO
            { "REL. FUNCIONARIOS", "sanma_logo_color" },//TAG + text / FOTO
            { "REL. ORDEM DE SERVIÇO", "sanma_logo_color" },//TAG + text / FOTO
            { "REL. LAVANDERIA", "Lavanderia" },//TAG + text / FOTO

        };
        Dictionary<string, string> TagsSistema = new Dictionary<string, string> // dicionario com o tag e text, também a foto do botão.
        {
            { "ALTERAR SENHA", "Senhas" },//TAG + text / FOTO
            { "LOG OUT", "Logout" },//TAG + text / FOTO
            { "SAIR", "Sair" },//TAG + text / FOTO
        };
        Dictionary<string, string> TagsLideranca = new Dictionary<string, string> // dicionario com o tag e text, também a foto do botão.
        {
            { "FUNCIONÁRIOS", "Funcionarios" },//TAG + text / FOTO
            { "FUNÇÃO / CARGOS", "Cargos" },//TAG + text / FOTO
            { "USUARIOS DO SISTEMA", "Usuarios" },//TAG + text / FOTO
            { "CONFIGURAR MENU", "Config_Menu" },//TAG + text / FOTO
            { "SENHAS", "Senhas" },//TAG + text / FOTO
            { "CATEGORIA DE SENHAS", "Categorias_Senhas" },//TAG + text / FOTO
        };
        // EXIT
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void CarregarPermissoes()
        {
            try
            {
                idUsuario = UserSession.User.Id;
                if (idUsuario != 0)
                {
                    // Verifica se o usuário é administrador
                    bool isAdmin = aCTLUsuarios.VerificaAdmin(idUsuario);

                    if (isAdmin)
                    {
                        // Se o usuário for administrador, concede todas as permissões.
                        acessosPermitidos = new HashSet<string>(ObterTodasAsTags());
                    }
                    else
                    {
                        // Se o usuário não for administrador, carrega permissões específicas do usuário.
                        permissoes = aCTLPermissaoMenu.ObterPermissoesPorUsuario(idUsuario);
                        acessosPermitidos = new HashSet<string>(permissoes.Select(acesso => acesso.Opcao.Nome));
                    }
                }
               
            }
            catch (Exception ex)
            {
                // Trate o erro conforme necessário, por exemplo, logue o erro
                Console.WriteLine($"Erro ao carregar permissões: {ex.Message}");
            }
        }

        // Método para obter todas as tags possíveis
        private IEnumerable<string> ObterTodasAsTags()
        {
            return tagsPatrimonios.Keys
                .Concat(TagsFichas.Keys)
                .Concat(TagsOperacoes.Keys)
                .Concat(TagsGov.Keys)
                .Concat(TagsOrdemDeServico.Keys)
                .Concat(TagsAgenda.Keys)
                .Concat(TagsSistema.Keys)
                .Concat(TagsRelatorios.Keys)
                .Concat(TagsLideranca.Keys);
        }



        private void Apresentar()
        {
            // Apresenta o nome e sobrenome do usuário, se disponível
            if (UserSession.User != null)
            {
                lblNomeFuncionario.Text = $"{UserSession.User.Nome} {UserSession.User.Sobrenome}";
                lblLogin.Text  = $"{UserSession.User.Nome} {UserSession.User.Sobrenome}";
            }
        }
        private void DestacarMenu(Button btn)
        {
            DestacarBotao(btn, new List<Button>
            {
                btnPatrimonio, btnFichas, btnOrdemDeServico, btnSenhas, btnOperacoes, btnGov, btnAgenda, btnRelatorios, btnSistema,btnLideranca
            }, Color.FromArgb(135, 155, 183), Color.FromArgb(45, 65, 93), lblDesc);
        }
        private void DestacarBotao(Button btn, List<Button> botoes, Color corPadrao, Color corDestaque, Label lbl)
        {
            foreach (Button b in botoes)
            {
                b.BackColor = corPadrao;
                b.ForeColor = Color.Black; // Reseta a cor do texto dos outros botões para preto
            }
            btn.BackColor = corDestaque;
            btn.ForeColor = Color.White; // Altera a cor do texto do botão destacado para branco
            lbl.Text = btn.Text;
        }
        private void RemoverBotoesPorNome(string nomePadrao)
        {
            // Remove todos os botões cujo nome começa com o padrão especificado e libera recursos
            var botoesParaRemover = panelButtons.Controls.OfType<Button>()
                .Where(btn => btn.Name.StartsWith(nomePadrao))
                .ToList();

            foreach (var btn in botoesParaRemover)
            {
                panelButtons.Controls.Remove(btn);
                btn.Dispose(); // Libera os recursos do botão removido
            }
        }
        private void CriarLayoutBotoes(int qtd, Dictionary<string, string> tags, HashSet<string> acessosPermitidos)
        {
            // Limpa os botões existentes
            panelButtons.Controls.Clear();
            panelClima.Visible = false;
            int botaoWidth = 218;
            int botaoHeight = 162;
            int espacamento = 7; // Espaçamento entre botões
            int colunas = 4; // Número de colunas

            // Calcula o número de linhas necessárias
            int linhas = (int)Math.Ceiling((double)qtd / colunas);

            // Ajusta o tamanho do painel para acomodar todos os botões
            panelButtons.AutoScroll = true;
            panelButtons.HorizontalScroll.Enabled = false;
            panelButtons.VerticalScroll.Visible = true;
            panelButtons.VerticalScroll.Value = 0;
            panelButtons.VerticalScroll.Maximum = Math.Max(0, (linhas * botaoHeight) - panelButtons.ClientSize.Height);
            panelButtons.AutoScrollMinSize = new Size(botaoWidth * colunas, linhas * botaoHeight);

            int index = 0;

            foreach (var tag in tags)
            {
                if (index >= qtd) break;

                // Verifica se o botão deve ser habilitado com base nas permissões
                bool temAcesso = acessosPermitidos.Contains(tag.Key);

                Button btn = new Button
                {
                    Name = $"btn{index + 1}", // Nome do botão com base no índice
                    Text = tag.Key, // Define o texto do botão com base na tag
                    BackColor = Color.FromArgb(135, 155, 183),
                    Size = new Size(botaoWidth, botaoHeight),
                    TextAlign = ContentAlignment.BottomCenter,
                    TextImageRelation = TextImageRelation.Overlay,
                    FlatStyle = FlatStyle.Flat,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Cursor = Cursors.Hand,
                    FlatAppearance = { BorderSize = 0 },
                    Font = new Font("Microsoft Sans Serif", 12.75f, FontStyle.Bold),
                    Enabled = temAcesso, // Define se o botão está habilitado com base nas permissões
                    Tag = tag.Key // Define a tag do botão com o texto (tag.Key)
                };

                // Define a localização do botão
                int coluna = index % colunas;
                int linha = index / colunas;
                int x = coluna * (botaoWidth + espacamento);
                int y = linha * (botaoHeight + espacamento);

                btn.Location = new Point(x, y);

                // Define a imagem de fundo do botão com base na tag
                Image image = Properties.Resources.ResourceManager.GetObject(tag.Value) as Image;
                if (image != null)
                {
                    btn.BackgroundImage = image;
                }
                else
                {
                    btn.BackgroundImage = Properties.Resources.sem_foto1;
                }

                // Adiciona tooltip ao botão
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(btn, tag.Key); // Define o texto do tooltip com base na tag

                // Adiciona o manipulador de eventos para o clique do botão
                btn.Click += Btn_Click;

                // Adiciona o botão ao painel
                panelButtons.Controls.Add(btn);

                index++;
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tag = btn.Tag.ToString(); // Obtém a tag do botão como texto
            if (tag == "LOG OUT")
            {
                LOGOUT();
            }
            else if (tag == "CONFIGURAR MENU")
            {
                ConfigurarMenu();
            }
            else
                aInter.pecaForm(tag); // Chama o método com o texto correspondente
        }
        public void LOGOUT()
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja sair desta sessão?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                authContext.Logout();//desloga o usuario autenticado
                this.Hide();

                FrmLogin frm = new FrmLogin();
                frm.Show();
            }
            else { return; }
        }
        private void ConfigurarMenu()
        {
            DialogResult result = MessageBox.Show("Adicionar menus ao banco de dados?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DALOpcoes opcoesController = new DALOpcoes();
                List<Dictionary<string, string>> todosTags = new List<Dictionary<string, string>>
            {
                tagsPatrimonios,
                TagsFichas,
                TagsOrdemDeServico,
                TagsOperacoes,
                TagsGov,
                TagsAgenda,
                TagsSistema,
                TagsLideranca,
                TagsRelatorios

            };
                var opcoes = opcoesController.CriarOpcoes(todosTags);
                if (opcoesController.SalvarMenu(opcoes))
                {
                    MessageBox.Show("Menu salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao salvar o menu.");
                }
            }
        }
        private void btnPatrimonio_Click(object sender, EventArgs e)
        {
            DestacarMenu(btnPatrimonio); // Destaca o menu lateral
            RemoverBotoesPorNome("btn"); // Remove os botões gerados
            CriarLayoutBotoes(6, tagsPatrimonios, acessosPermitidos); // QTD Botões Criados + TAG dos botões + Permissões
        }

        private void btnFichas_Click(object sender, EventArgs e)
        {
            DestacarMenu(btnFichas); // Destaca o menu lateral
            RemoverBotoesPorNome("btn"); // Remove os botões gerados   
            CriarLayoutBotoes(2, TagsFichas, acessosPermitidos); // QTD Botões Criados + TAG dos botões + Permissões
        }

        private void btnOrdemDeServico_Click(object sender, EventArgs e)
        {
            DestacarMenu(btnOrdemDeServico); // Destaca o menu lateral
            RemoverBotoesPorNome("btn"); // Remove os botões gerados   
            CriarLayoutBotoes(1, TagsOrdemDeServico, acessosPermitidos); // QTD Botões Criados + TAG dos botões + Permissões
        }
        private void btnCofres_Click(object sender, EventArgs e)
        {
            DestacarMenu(btnOperacoes); // Destaca o menu lateral
            RemoverBotoesPorNome("btn"); // Remove os botões gerados   
            CriarLayoutBotoes(3, TagsOperacoes, acessosPermitidos); // QTD Botões Criados + TAG dos botões + Permissões
        }

        private void btnGov_Click(object sender, EventArgs e)
        {
            DestacarMenu(btnGov); // Destaca o menu lateral
            RemoverBotoesPorNome("btn"); // Remove os botões gerados   
            CriarLayoutBotoes(3, TagsGov, acessosPermitidos); // QTD Botões Criados + TAG dos botões + Permissões
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            DestacarMenu(btnAgenda); // Destaca o menu lateral
            RemoverBotoesPorNome("btn"); // Remove os botões gerados   
            CriarLayoutBotoes(2, TagsAgenda, acessosPermitidos); // QTD Botões Criados + TAG dos botões + Permissões
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            DestacarMenu(btnRelatorios); // Destaca o menu lateral
            RemoverBotoesPorNome("btn"); // Remove os botões gerados   
            CriarLayoutBotoes(6, TagsRelatorios, acessosPermitidos); // QTD Botões Criados + TAG dos botões + Permissões
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            DestacarMenu(btnSistema); // Destaca o menu lateral
            RemoverBotoesPorNome("btn"); // Remove os botões gerados   
            CriarLayoutBotoes(7, TagsSistema, acessosPermitidos); // QTD Botões Criados + TAG dos botões + Permissões
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            RemoverBotoesPorNome("btn"); // Remove os botões gerados
            panelClima.Visible = true;
        }

        private void btnLideranca_Click(object sender, EventArgs e)
        {
            DestacarMenu(btnLideranca); // Destaca o menu lateral
            RemoverBotoesPorNome("btn"); // Remove os botões gerados   
            CriarLayoutBotoes(6, TagsLideranca, acessosPermitidos); // QTD Botões Criados + TAG dos botões + Permissões
        }
    }
}