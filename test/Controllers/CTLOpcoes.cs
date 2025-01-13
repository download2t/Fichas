using System.Collections.Generic;
using System.Windows.Forms;
using test.DAL;
using test.Model;

namespace test.Controllers
{
    public class CTLOpcoes
    {
        private DALOpcoes opcaoDAL = new DALOpcoes();
        public void SalvarMenu(HashSet<Opcoes> opcoes)
        {
            opcaoDAL.SalvarMenu(opcoes);
        }

        public HashSet<Opcoes> CriarMenu(MenuStrip menu)
        {
            return opcaoDAL.Criar(menu);
        }
        public List<Opcoes> ObterOpcoesDoMenu()
        {
            // Aqui você deve chamar o método da sua DAL para obter as opções do menu
            return opcaoDAL.ObterOpcoesDoMenuDoBanco(); // Método fictício para buscar do banco de dados
        }
    }
}
