using System;

namespace test.Classes
{
    public class ItensLavanderia : Pai
    {

        private string _nome;

        public ItensLavanderia() : base()
        {
            _nome = "";
        }

        public ItensLavanderia(int id, string nome) : base(id)
        {
            _nome = nome;
        }


        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
