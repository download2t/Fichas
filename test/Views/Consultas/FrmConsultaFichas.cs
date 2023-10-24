using System;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using System.Collections.Generic;
using test.Views.Cadastros;

namespace test.Views.Consultas
{
    public partial class FrmConsultaFichas : FrmConsulta
    {
        private FichasController fichasController;
        private FrmCadastroFichas frmCadastro;
        private Fichas fichaSelecionada;

        public FrmConsultaFichas()
        {
            InitializeComponent();
            fichasController = new FichasController();
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroFichas)
            {
                frmCadastro = (FrmCadastroFichas)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Fichas)
            {
                fichaSelecionada = (Fichas)obj;
            }
        }

        public override void Incluir()
        {
            base.Incluir();
            fichasController.Incluir();
            CarregaLV();
        }

        public override void Alterar()
        {
            base.Alterar();
            int idFicha = ObterIdSelecionado();
            if (idFicha > 0)
            {
                Fichas ficha = fichasController.BuscarFichaPorId(idFicha);
                if (ficha != null)
                {
                    fichasController.Alterar(ficha);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idFicha = ObterIdSelecionado();
            if (idFicha > 0)
            {
                Fichas ficha = fichasController.BuscarFichaPorId(idFicha);
                if (ficha != null)
                {
                    fichasController.Excluir(ficha);
                    CarregaLV();
                }
            }
        }
        public override void Visualizar()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Fichas ficha = selectedItem.Tag as Fichas;

                if (ficha != null)
                {
                    fichasController.Visualizar(ficha);
                }
            }
        }
        private void PreencherFichasListView(IEnumerable<Fichas> fichas)
        {
            listView1.Items.Clear();

            foreach (var ficha in fichas)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(ficha.Id));
                item.SubItems.Add(ficha.Usuarios.Usuario);
                item.SubItems.Add(ficha.Clientes.Nome);
                item.SubItems.Add(ficha.DataCriacao.ToString());
                item.SubItems.Add(ficha.Descricao);
                item.Tag = ficha; // Associe o objeto Fichas ao item usando a propriedade Tag
                listView1.Items.Add(item);
            }
        }
        public override void CarregaLV()
        {
            base.CarregaLV();
            PreencherFichasListView(fichasController.ListarFichas());
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtID.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = fichasController.PesquisarFichasPorCriterio(criterioPesquisa, valorPesquisa);

                // Use o método de preenchimento para atualizar a ListView
                PreencherFichasListView(resultados);
            }
        }



        protected override void Atualizar()
        {
            base.Atualizar();
            CarregaLV();
        }

        private int ObterIdSelecionado()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                return int.Parse(listView1.SelectedItems[0].Text);
            }
            return 0;
        }
        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID"; // Pesquisar pelo ID
            }
            else if (rbUsuario.Checked)
            {
                return "Usuario"; // Pesquisar pelo usuário
            }
            else if (rbCliente.Checked)
            {
                return "Clientes"; // Pesquisar pelos clientes
            }

            return string.Empty; // Nenhum critério selecionado
        }

    }
}
