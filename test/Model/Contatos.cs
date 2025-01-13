using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Classes;

namespace test.Model
{
    public class Contatos:Pai
    {

        public string _nome;
        public string _numero;

        public Contatos()
        {
            Id = 0;
            _nome = "";
            _numero = "";
        }
        public Contatos(int id, string nome, string numero):base(id)
        {
            Id =id;
            _nome = nome;
            _numero = numero;
        }
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public string Numero
        {
            get => _numero;
            set => _numero = value;
        }
    }
}
