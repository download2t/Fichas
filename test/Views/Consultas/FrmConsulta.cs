using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Windows.Forms;
using test.Controllers;
using static test.Views.FrmLogin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using test.Classes;

namespace test.Views.Consultas
{
    public partial class FrmConsulta : FrmPai
    {
        CTLUsuarios CTLUsuarios;
        private const int tamanhoFonteMinimo = 10;
        private const int tamanhoFonteMaximo = 20;
        protected Dictionary<string, double> _colunasProporcao = new Dictionary<string, double>();

        public virtual void DataGrid()
        {
            // Implementação específica nas classes derivadas
        }
        public FrmConsulta()
        {
            InitializeComponent();
            CTLUsuarios = new CTLUsuarios();
        }
        protected void CalcularProporcoesColunas(DataGridView dgv)
        {
            _colunasProporcao.Clear();
            double larguraTotal = dgv.Width;

            foreach (DataGridViewColumn coluna in dgv.Columns)
            {
                if (coluna.Visible)
                {
                    _colunasProporcao[coluna.Name] = (double)coluna.Width / larguraTotal;
                }
            }
        }
        // Método para redimensionar as colunas
        protected void RedimensionarColunas(DataGridView dgv)
        {
            double larguraTotal = dgv.Width;

            foreach (DataGridViewColumn coluna in dgv.Columns)
            {
                if (coluna.Visible && _colunasProporcao.ContainsKey(coluna.Name))
                {
                    coluna.Width = (int)(_colunasProporcao[coluna.Name] * larguraTotal);
                }
            }
        }

        // Evento de redimensionamento do formulário
        protected void FrmConsulta_Resize(object sender, EventArgs e)
        {
            // Verifique se há um DataGridView e redimensione as colunas
            if (this.Controls.OfType<DataGridView>().Any())
            {
                DataGridView dgv = this.Controls.OfType<DataGridView>().First();
                RedimensionarColunas(dgv);
            }
        }
    

     
        protected virtual void LiberarAcessos(string AcessosLiberados)
        {
            int idUsuario = UserSession.User.Id; // Obtém o ID do usuário
            bool isAdmin = CTLUsuarios.VerificaAdmin(idUsuario); // Verifica se o usuário é um administrador

            if (!isAdmin)
            {
                CTLPermissaoMenu permissaoMenuController = new CTLPermissaoMenu();
                var usuarioAcessos = permissaoMenuController.ObterPermissoesPorUsuario(idUsuario);

                // LIBERAR ACESSOS
                if (!permissaoMenuController.OpcaoLiberadaAdicionar(AcessosLiberados, usuarioAcessos))
                    btnIncluir.Enabled = false;
                if (!permissaoMenuController.OpcaoLiberadaAlterar(AcessosLiberados, usuarioAcessos))
                    btnAlterar.Enabled = false;
                if (!permissaoMenuController.OpcaoLiberadaExcluir(AcessosLiberados, usuarioAcessos))
                    btnExcluir.Enabled = false;
            }
        }
        public virtual void SetFrmCadastro(object obj)
        {
            // Implemente a lógica necessária nas classes derivadas
        }
        protected virtual void Atualizar()
        {
            txtID.Text = "";
            CarregaDGV();
        }
        public virtual void Incluir()
        {
            // Implemente a lógica de inclusão nas classes derivadas
        }
        public virtual void Alterar()
        {
            // Implemente a lógica de alteração nas classes derivadas
        }
        public virtual void Excluir()
        {
            // Implemente a lógica de exclusão nas classes derivadas
        }
        public virtual void CarregaDGV()
        {
            // Implemente o carregamento do ListView nas classes derivadas
        }
        public virtual void Visualizar()
        {
            // Implemente o duplo clique do ListView nas classes derivadas
        }
        public virtual void Filtrar()
        {


        }
        protected virtual void Pesquisar()
        {
            // Implemente a lógica de pesquisa nas classes derivadas
        }

        // BOTÕES

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        protected void txtID_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }
        protected void FrmConsulta_Load(object sender, EventArgs e)
        {
          //  CarregaDGV();
        }
        public void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visualizar();
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
   
    }
}
