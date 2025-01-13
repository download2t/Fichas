using Controle.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Classes;
using test.Data;

namespace test.Controllers
{
    public class CTLFotos
    {
        private DALFotos fotosDAL = new DALFotos();

        public List<string> ProcessarFotosEAdicionarNaLista(List<Fotos> fotos)
        {
           fotosDAL.AdicionarFotosNaLista(fotos);
            // Retorna uma lista vazia de erros, já que não estamos interagindo diretamente com o banco de dados aqui
            return new List<string>();
        }

        public void AdicionarFoto(List<Fotos> foto)
        {
            fotosDAL.AdicionarFotos(foto);
        }

        public void ExcluirFoto(int fotoId)
        {
            fotosDAL.ExcluirFoto(fotoId);
        }

        public Fotos BuscarFotoPorId(int id)
        {
            return fotosDAL.BuscarFotoPorId(id);
        }

        public List<Fotos> ListarFotos()
        {
            return fotosDAL.ListarFotos();
        }
        public List<Fotos> ListarFotosDaOrdemDeServico(int ordemDeServicoId)
    {
        return fotosDAL.ListarFotosDaOrdemDeServico(ordemDeServicoId);
    }
    }
}
