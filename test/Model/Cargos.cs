using System;

namespace test.Classes
{
    public class Cargo : Pai
    {
        private string _funcao;
        private int _pontos;

        public string Funcao
        {
            get { return _funcao; }
            set { _funcao = value; }
        }

        public int Pontos
        {
            get { return _pontos; }
            set { _pontos = value; }
        }

        public Cargo() : base()
        {
            _funcao = "";
            _pontos = 0;
        }

        public Cargo(int id, string funcao, int pontos) : base(id)
        {
            _funcao = funcao;
            _pontos = pontos;
        }
    }
}
