using Controle.Model;
using System;

namespace test.Classes
{
    public class Lavanderia : Pai
    {
        private int _id;
        private DateTime _data;
        private decimal _peso;
        private string _processo;
        private Funcionario _funcionario;
        private ItensLavanderia _itensLavanderia;


        public Lavanderia() : base()
        {
            _id = 0;
            _data = DateTime.MinValue;
            _peso = 0;
            _processo = "";
            _funcionario = new Funcionario();
            _itensLavanderia = new ItensLavanderia();

        }

        public Lavanderia(int id, DateTime data, decimal peso, string processo, Funcionario funcionario, ItensLavanderia itensLavanderia) : base(id)
        {
            _id = id;
            _data = data;
            _peso = peso;
            _processo = processo;
            _funcionario = funcionario;
            _itensLavanderia = itensLavanderia;

        }


        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public decimal Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public string Processo
        {
            get { return _processo; }
            set { _processo = value; }
        }

        public Funcionario Funcionario
        {
            get { return _funcionario; }
            set { _funcionario = value; }
        }

        public ItensLavanderia ItensLavanderia
        {
            get { return _itensLavanderia; }
            set { _itensLavanderia = value; }
        }
    }
}
