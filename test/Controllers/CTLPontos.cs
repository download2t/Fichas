using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Data;
using test.Model;
using test.Views.Cadastros;

namespace Controle.Controllers
{
    internal class CTLPontos
    {

        private DALPontos dalPontos;

        public CTLPontos()
        {
            dalPontos = new DALPontos();
        }

        public List<Pontos> ConsultaLista(string procurar = "", string mesFiltro = null, int? anoFiltro = null)
        {
            return dalPontos.ConsultaLista(procurar, mesFiltro, anoFiltro);
        }
        public bool GerarMes()
        {
            return dalPontos.GerarMes();
        }
        public bool ExcluirMensal(string codPontoM)
        {
            return dalPontos.ExcluirMensal(codPontoM);
        }
        public List<Pontos> GetLista()
        {
            return dalPontos.GetLista();
        }

    }
}