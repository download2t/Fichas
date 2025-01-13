using System;
using test.Model;

namespace test.Classes
{
    public class ControleGov
    {
        private int _id;
        private DateTime _data;
        private int _permaneceEntrada;
        private int _saidasEntrada;
        private int _reservadasRealizadas;
        private int _permaneceRealizadas;
        private int _saidasRealizadas;
        private int _realizados;
        private decimal _porcentagem;
        private Funcionario _funcionarioId;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public int PermaneceEntrada
        {
            get { return _permaneceEntrada; }
            set { _permaneceEntrada = value; }
        }

        public int SaidasEntrada
        {
            get { return _saidasEntrada; }
            set { _saidasEntrada = value; }
        }

        public int ReservadasRealizadas
        {
            get { return _reservadasRealizadas; }
            set { _reservadasRealizadas = value; }
        }

        public int PermaneceRealizadas
        {
            get { return _permaneceRealizadas; }
            set { _permaneceRealizadas = value; }
        }

        public int SaidasRealizadas
        {
            get { return _saidasRealizadas; }
            set { _saidasRealizadas = value; }
        }

        public int Realizados
        {
            get { return _realizados; }
            set { _realizados = value; }
        }

        public decimal Porcentagem
        {
            get { return _porcentagem; }
            set { _porcentagem = value; }
        }

        public Funcionario Funcionarios
        {
            get { return _funcionarioId;; }
            set { _funcionarioId = value; }
        }

        public ControleGov()
        {
            _id = 0;
            _data = DateTime.MinValue;
            _permaneceEntrada = 0;
            _saidasEntrada = 0;
            _reservadasRealizadas = 0;
            _permaneceRealizadas = 0;
            _saidasRealizadas = 0;
            _realizados = 0;
            _porcentagem = 0m;
            _funcionarioId = new Funcionario();
        }

        public ControleGov(int id, DateTime data, int permaneceEntrada, int saidasEntrada, int reservadasRealizadas, int permaneceRealizadas, int saidasRealizadas, int realizados, decimal porcentagem, Funcionario funcionarioId)
        {
            _id = id;
            _data = data;
            _permaneceEntrada = permaneceEntrada;
            _saidasEntrada = saidasEntrada;
            _reservadasRealizadas = reservadasRealizadas;
            _permaneceRealizadas = permaneceRealizadas;
            _saidasRealizadas = saidasRealizadas;
            _realizados = realizados;
            _porcentagem = porcentagem;
            _funcionarioId = funcionarioId;
        }
    }
}
