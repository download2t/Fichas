using System;
using System.Windows.Forms;

namespace test.Views.Consultas
{
    public partial class FrmConsulta : FrmPai
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        public virtual void SetFrmCadastro(object obj)
        {
            // Implemente a lógica necessária nas classes derivadas
        }

        protected virtual void Atualizar()
        {
            txtID.Text = "";
            CarregaLV();
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

        public virtual void CarregaLV()
        {
            // Implemente o carregamento do ListView nas classes derivadas
        }
        public virtual void Visualizar()
        {
            // Implemente o duplo clique do ListView nas classes derivadas
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
            CarregaLV();
        }

        protected void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visualizar();
        }
    }
}
