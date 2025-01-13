using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Classes;

namespace test.Model
{
    public class Opcoes : Pai
    {

        public string _nome;
        public string _descricao;
        public byte _nivel;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public byte Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }
        public Opcoes() : base()
        {
            Id = 0;
            Nome = "";
            Descricao = "";
            Nivel = 0;
        }

        public Opcoes(int id, string nome, string descricao, byte nivel):base(id) 
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Nivel = nivel;
        }
        public Opcoes( string nome, string descricao, byte nivel) : base()
        {
            Nome = nome;
            Descricao = descricao;
            Nivel = nivel;
        }
        public Opcoes(string nome, string descricao) : base()
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}