using test.Classes;
using test.Model;

namespace Controle.Models
{
    public class Ramal : Pai
    {
        private string _numRamal;
        private string _linha;
        private Setores _setor;
        private string _nome;
        private string _fone;

        public string NumRamal
        {
            get { return _numRamal; }
            set { _numRamal = value; }
        }

        public string Linha
        {
            get { return _linha; }
            set { _linha = value; }
        }

        public Setores Setor
        {
            get { return _setor; }
            set { _setor = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Fone
        {
            get { return _fone; }
            set { _fone = value; }
        }

        public Ramal() : base()
        {
            _numRamal = "";
            _linha = "";
            _setor = new Setores();
            _nome = "";
            _fone = "";
        }

        public Ramal(int id, string numRamal, string linha, Setores setor, string nome, string fone) : base(id)
        {
            _numRamal = numRamal;
            _linha = linha;
            _setor = setor;
            _nome = nome;
            _fone = fone;
        }
    }
}
