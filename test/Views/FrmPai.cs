using System;
using System.Windows.Forms;

namespace test.Views
{
    public partial class FrmPai : Form
    {
        public FrmPai()
        {
            InitializeComponent();
        }

        // Métodos
        public virtual void Sair()
        {
            Close();
        }

        public virtual void LimparCampos()
        {
            // Limpe os campos necessários nas classes derivadas
        }

        public virtual void BloquearCampos()
        {
            // Bloqueie os campos necessários nas classes derivadas
        }

        public virtual void DesbloquearCampos()
        {
            // Desbloqueie os campos necessários nas classes derivadas
        }

        public virtual void CarregarCampos()
        {
            // Carregue os campos necessários nas classes derivadas
        }

        public virtual void Salvar()
        {
            // Implemente a lógica de salvar nas classes derivadas
        }

        protected virtual bool VerificarCamposVazios()
        {
            // Implemente a verificação de campos vazios nas classes derivadas
            return true;
        }

        public virtual void ConhecaObj(object obj)
        {
            // Implemente a lógica de conhecer o objeto nas classes derivadas
        }

        // Botões
        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}
