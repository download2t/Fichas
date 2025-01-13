using System;
using System.Collections.Generic;
using test.Classes;
using test.Data;
using test.Views.Cadastros; // Lembre-se de ajustar o namespace conforme sua estrutura de pastas

namespace test.Controllers
{
    public class CTLCategorias
    {
        private DALCategoria categoriaDAL = new DALCategoria();

        public void AdicionarCategoria(Categoria categoria)
        {
            categoriaDAL.AdicionarCategoria(categoria);
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            categoriaDAL.AtualizarCategoria(categoria);
        }

        public void ExcluirCategoria(int categoriaId)
        {
            categoriaDAL.ExcluirCategoria(categoriaId);
        }

        public Categoria BuscarCategoriaPorId(int id)
        {
            return categoriaDAL.BuscarCategoriaPorId(id);
        }
        public Categoria BuscarCategoriaPorIdDeSenhas(int id)
        {
            return categoriaDAL.BuscarCategoriaPorIdDeSenhas(id);
        }
        public List<Categoria> ListarCategorias()
        {
            return categoriaDAL.ListarCategorias();
        }

        public void Incluir()
        {
            FrmCadastroCategoria frmCadastroCategorias = new FrmCadastroCategoria();
            frmCadastroCategorias.Text = "Incluir Categoria";
            frmCadastroCategorias.ShowDialog();
        }

        public void Alterar(Categoria categoria)
        {
            if (categoria != null)
            {
                FrmCadastroCategoria frmCadastroCategorias = new FrmCadastroCategoria();
                frmCadastroCategorias.ConhecaObj(categoria);
                frmCadastroCategorias.Text = "Alterar Categoria";
                frmCadastroCategorias.CarregarCampos();
                frmCadastroCategorias.ShowDialog();
            }
        }

        public void Excluir(Categoria categoria)
        {
            if (categoria != null)
            {
                FrmCadastroCategoria frmCadastroCategorias = new FrmCadastroCategoria();
                frmCadastroCategorias.ConhecaObj(categoria);
                frmCadastroCategorias.Text = "Excluir Categoria";
                frmCadastroCategorias.CarregarCampos();
                frmCadastroCategorias.BloquearCampos();
                frmCadastroCategorias.btnSalvar.Text = "Excluir";
                frmCadastroCategorias.ShowDialog();
            }
        }

        public void Visualizar(Categoria categoria)
        {
            if (categoria != null)
            {
                FrmCadastroCategoria frmCadastroCategorias = new FrmCadastroCategoria();
                frmCadastroCategorias.ConhecaObj(categoria);
                frmCadastroCategorias.Text = "Consultar Categoria";
                frmCadastroCategorias.CarregarCampos();
                frmCadastroCategorias.BloquearCampos();
                frmCadastroCategorias.btnSalvar.Enabled = false;
                frmCadastroCategorias.ShowDialog();
            }
        }

        public List<Categoria> PesquisarCategoriasPorCriterio(string criterio, string valorPesquisa)
        {
            List<Categoria> categoriasEncontradas = new List<Categoria>();

            if (criterio == "ID")
            {
                // Pesquisar por ID
                if (int.TryParse(valorPesquisa, out int id))
                {
                    Categoria categoria = BuscarCategoriaPorId(id);
                    if (categoria != null)
                    {
                        categoriasEncontradas.Add(categoria);
                    }
                }
            }
            else if (criterio == "Categoria")
            {
                
                categoriasEncontradas = categoriaDAL.BuscarCategoriaPorNome(valorPesquisa);
            }

            return categoriasEncontradas;
        }



        // PARTE DE SENHAS A BAIXO.


        public void AdicionarCategoriaDeSenhas(Categoria categoria)
        {
            categoriaDAL.AdicionarCategoriaDeSenhas(categoria);
        }
        public void AtualizarCategoriaDeSenhas(Categoria categoria)
        {
            categoriaDAL.AtualizarCategoriaDeSenha(categoria);
        }
        public Categoria BuscarCategoriaPorIdDeSenha(int id)
        {
            return categoriaDAL.BuscarCategoriaPorIdDeSenhas(id);
        }
        public List<Categoria> ListarCategoriasDeSenhas()
        {
            return categoriaDAL.ListarCategoriasDeSenhas();
        }
        public List<Categoria> PesquisarCategoriasPorCriterioDeSenhas(string criterio, string valorPesquisa)
        {
            List<Categoria> categoriasEncontradas = new List<Categoria>();

            if (criterio == "ID")
            {
                // Pesquisar por ID
                if (int.TryParse(valorPesquisa, out int id))
                {
                    Categoria categoria = BuscarCategoriaPorIdDeSenha(id);
                    if (categoria != null)
                    {
                        categoriasEncontradas.Add(categoria);
                    }
                }
            }
            else if (criterio == "Categoria")
            {

                categoriasEncontradas = categoriaDAL.BuscarCategoriaPorNomeDeSenhas(valorPesquisa);
            }

            return categoriasEncontradas;
        }

        public void IncluirSenha()
        {
            FrmCadastroCategoria frmCadastroCategorias = new FrmCadastroCategoria();
            frmCadastroCategorias.cbSenha.Checked = true;
            frmCadastroCategorias.ShowDialog();
        }

        public void AlterarSenha(Categoria categoria)
        {
            if (categoria != null)
            {
                FrmCadastroCategoria frmCadastroCategorias = new FrmCadastroCategoria();
                frmCadastroCategorias.ConhecaObj(categoria);
                frmCadastroCategorias.CarregarCampos();
                frmCadastroCategorias.cbSenha.Checked = true;
                frmCadastroCategorias.ShowDialog();
            }
        }

    }
}
