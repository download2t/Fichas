using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using test.Classes;
using test.Controllers;
using test.Model;

namespace test.Data
{
    public class FichasDAO
    {
        private Banco banco = new Banco();
        ClientesController clientesController;
        UsuariosController usuariosController;
        public FichasDAO()
        {
            clientesController = new ClientesController();
            usuariosController = new UsuariosController();
        }

        public void AdicionarFicha(Fichas ficha)
        {
            using (SqlConnection connection = banco.Abrir())
            {
                string sql = "INSERT INTO Fichas (Descricao, ClienteId, UsuarioId, DataCriacao) " +
                             "VALUES (@Descricao, @CodCliente, @CodUsuario, @DataCriacao)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Descricao", ficha.Descricao);
                command.Parameters.AddWithValue("@CodCliente", ficha.Clientes.Id);
                command.Parameters.AddWithValue("@CodUsuario", ficha.Usuarios.Id);
                command.Parameters.AddWithValue("@DataCriacao", ficha.DataCriacao);
                command.ExecuteNonQuery();
            }
        }

        public void AtualizarFicha(Fichas ficha)
        {
            using (SqlConnection connection = banco.Abrir())
            {
                string sql = "UPDATE Fichas SET Descricao = @Descricao, ClienteId = @ClienteId, " +
                             "UsuarioId = @UsuarioId, DataCriacao = @DataCriacao WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Descricao", ficha.Descricao);
                command.Parameters.AddWithValue("@ClienteId", ficha.Clientes.Id); // Corrigido para @ClienteId
                command.Parameters.AddWithValue("@UsuarioId", ficha.Usuarios.Id); // Corrigido para @UsuarioId
                command.Parameters.AddWithValue("@DataCriacao", ficha.DataCriacao);
                command.Parameters.AddWithValue("@Id", ficha.Id);
                command.ExecuteNonQuery();
            }
        }


        public void ExcluirFicha(int fichaId)
        {
            using (SqlConnection connection = banco.Abrir())
            {
                string sql = "DELETE FROM Fichas WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", fichaId);
                command.ExecuteNonQuery();
            }
        }

        public Fichas BuscarFichaPorId(int id)
        {
            Fichas ficha = null;
            using (SqlConnection connection = banco.Abrir())
            {
                string query = "SELECT * FROM Fichas WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ficha = new Fichas
                        {

                            Id = (int)reader["Id"],
                            Usuarios = usuariosController.BuscarUsuarioPorId((int)reader["UsuarioId"]),
                            Clientes = clientesController.BuscarClientePorId((int)reader["ClienteId"]),
                            DataCriacao = (DateTime)reader["DataCriacao"],
                            Descricao = (string)reader["Descricao"],
                        };
                    }
                }
            }

            return ficha;
        }

        public List<Fichas> ListarFichas()
        {
            List<Fichas> fichas = new List<Fichas>();
            using (SqlConnection connection = banco.Abrir())
            {
                string sql = "SELECT * FROM Fichas";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Fichas ficha = new Fichas
                    {
                        Id = (int)reader["Id"],
                        Usuarios = usuariosController.BuscarUsuarioPorId((int)reader["UsuarioId"]),
                        Clientes = clientesController.BuscarClientePorId((int)reader["ClienteId"]),
                        DataCriacao = (DateTime)reader["DataCriacao"],
                        Descricao = (string)reader["Descricao"],
                    };
                    fichas.Add(ficha);
                }
            }
            return fichas;
        }
        public List<Fichas> PesquisarFichasPorClientes(string valorPesquisa)
        {
            List<Fichas> fichasEncontradas = new List<Fichas>();
            using (SqlConnection connection = banco.Abrir())
            {
                string query = "SELECT * FROM Fichas " +
                               "INNER JOIN Clientes ON Fichas.ClienteId = Clientes.Id " +
                               "WHERE Clientes.Nome LIKE @ValorPesquisa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fichas ficha = new Fichas
                        {
                            Id = (int)reader["Id"],
                            Usuarios = usuariosController.BuscarUsuarioPorId((int)reader["UsuarioId"]),
                            Clientes = clientesController.BuscarClientePorId((int)reader["ClienteId"]),
                            DataCriacao = (DateTime)reader["DataCriacao"],
                            Descricao = (string)reader["Descricao"],
                        };
                        fichasEncontradas.Add(ficha);
                    }
                }
            }
            return fichasEncontradas;
        }

        public List<Fichas> PesquisarFichasPorUsuario(string valorPesquisa)
        {
            List<Fichas> fichasEncontradas = new List<Fichas>();
            using (SqlConnection connection = banco.Abrir())
            {
                string query = "SELECT * FROM Fichas " +
                               "INNER JOIN Usuarios ON Fichas.UsuarioId = Usuarios.Id " +
                               "WHERE Usuarios.Usuario LIKE @ValorPesquisa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Fichas ficha = new Fichas
                        {
                            Id = (int)reader["Id"],
                            Usuarios = usuariosController.BuscarUsuarioPorId((int)reader["UsuarioId"]),
                            Clientes = clientesController.BuscarClientePorId((int)reader["ClienteId"]),
                            DataCriacao = (DateTime)reader["DataCriacao"],
                            Descricao = (string)reader["Descricao"],
                        };
                        fichasEncontradas.Add(ficha);
                    }
                }
            }
            return fichasEncontradas;
        }


    }
}
