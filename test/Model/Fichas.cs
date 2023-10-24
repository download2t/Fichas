using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Classes
{
    public class Fichas : Pai
    {
        private int _id;
        private string _descricao;
        private DateTime? _dataCriacao;
        private Clientes _clientes;
        private Usuarios _usuarios;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public DateTime? DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }

        public Clientes Clientes
        {
            get { return _clientes; }
            set { _clientes = value; }
        }

        public Usuarios Usuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }

        public Fichas() : base()
        {
            _id = 0;
            _descricao = "";
            _dataCriacao = null;
            _clientes = new Clientes();
            _usuarios = new Usuarios();
        }

        public Fichas(int id, string descricao, DateTime? datacriacao, Clientes cliente, Usuarios usuario) : base(id)
        {
            _id = id;
            _descricao = descricao;
            _dataCriacao = datacriacao;
            _clientes = cliente;
            _usuarios = usuario;
        }
    }
}
