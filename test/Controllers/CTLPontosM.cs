using Controle.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Data;
using test.Data.Model;
using test.Model;
using test.Views.Cadastros;

namespace Controle.Controllers
{
    public class CTLPontosM
    {
        private DALPontosM dalPontosM;

        public CTLPontosM()
        {
            dalPontosM = new DALPontosM();
        }

        public bool GerarMes()
        {
            return dalPontosM.GerarMes();
        }

        public bool ExcluirMensal(string codPontoM)
        {
            return dalPontosM.ExcluirMensal(codPontoM);
        }

        public List<PontosM> ConsultaLista(string procurar = "")
        {
            return dalPontosM.ConsultaLista(procurar);
        }

        public List<PontosM> GetLista()
        {
            return dalPontosM.GetLista();
        }
        public string SalvarPontos(PontosM pontosM)
        {
            return dalPontosM.Salvar(pontosM);
        }
        public void Incluir()
        {
            FrmOperacoesFolha frm = new FrmOperacoesFolha();
            frm.ShowDialog();
        }
    }
}
