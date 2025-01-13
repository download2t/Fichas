using System;
using System.Collections.Generic;
using test.Classes;
using test.Data;
using test.Views.Cadastros; // Lembre-se de ajustar o namespace conforme sua estrutura de pastas

namespace test.Controllers
{
    public class CTLSubCategorias
    {
        private DALSubCategorias subcategoriaDAL = new DALSubCategorias();

        public void AdicionarSubcategoria(Subcategoria subcategoria)
        {
            subcategoriaDAL.AdicionarSubcategoria(subcategoria);
        }

        public void AtualizarSubcategoria(Subcategoria subcategoria)
        {
            subcategoriaDAL.AtualizarSubcategoria(subcategoria);
        }

        public void ExcluirSubcategoria(int subcategoriaId)
        {
            subcategoriaDAL.ExcluirSubcategoria(subcategoriaId);
        }

        public Subcategoria BuscarSubcategoriaPorId(int id)
        {
            return subcategoriaDAL.BuscarSubcategoriaPorId(id);
        }

        public List<Subcategoria> ListarSubcategorias()
        {
            return subcategoriaDAL.ListarSubcategorias();
        }
        public List<Subcategoria> ListarSubcategoriasPorIDCategoria(int id)
        {
            return subcategoriaDAL.ListarSubcategoriasPorIDCategoria(id);
        }
        public void Incluir()
        {
            FrmCadastroSubCategoria frmCadastroSubcategorias = new FrmCadastroSubCategoria();
            frmCadastroSubcategorias.Text = "Incluir Categoria";
            frmCadastroSubcategorias.ShowDialog();
        }

        public void Alterar(Subcategoria subcategoria)
        {
            if (subcategoria != null)
            {
                FrmCadastroSubCategoria frmCadastroSubcategorias = new FrmCadastroSubCategoria();
                frmCadastroSubcategorias.ConhecaObj(subcategoria);
                frmCadastroSubcategorias.Text = "Alterar Categoria";
                frmCadastroSubcategorias.CarregarCampos();
                frmCadastroSubcategorias.ShowDialog();
            }
        }

        public void Excluir(Subcategoria subcategoria)
        {
            if (subcategoria != null)
            {
                FrmCadastroSubCategoria frmCadastroSubcategorias = new FrmCadastroSubCategoria();
                frmCadastroSubcategorias.ConhecaObj(subcategoria);
                frmCadastroSubcategorias.Text = "Excluir Categoria";
                frmCadastroSubcategorias.CarregarCampos();
                frmCadastroSubcategorias.BloquearCampos();
                frmCadastroSubcategorias.btnSalvar.Text = "Excluir";
                frmCadastroSubcategorias.ShowDialog();
            }
        }

        public void Visualizar(Subcategoria subcategoria)
        {
            if (subcategoria != null)
            {
                FrmCadastroSubCategoria frmCadastroSubcategorias = new FrmCadastroSubCategoria();
                frmCadastroSubcategorias.ConhecaObj(subcategoria);
                frmCadastroSubcategorias.Text = "Consultar Categoria";
                frmCadastroSubcategorias.CarregarCampos();
                frmCadastroSubcategorias.BloquearCampos();
                frmCadastroSubcategorias.btnSalvar.Enabled = false;
                frmCadastroSubcategorias.ShowDialog();
            }
        }

        public List<Subcategoria> PesquisarSubcategoriasPorCriterio(string criterio, string valorPesquisa)
        {
            return subcategoriaDAL.PesquisarSubcategoriasPorCriterio(criterio, valorPesquisa);
        }
    }
}
