using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using test.Classes;
using test.Model;

namespace test.Data
{
    public class ClientesDAO
    {
        private Banco banco = new Banco();

        public void AdicionarCliente(Clientes cliente)
        {
            string sql = "INSERT INTO Clientes (Nome, Documento, Telefone, Email, Cep, Logradouro, Numero, Bairro, Cidade, UF) " +
                         "VALUES (@Nome, @Documento, @Telefone, @Email, @Cep, @Logradouro, @Numero, @Bairro, @Cidade, @UF)";
            SqlParameter[] parametros =
            {
                new SqlParameter("@Nome", cliente.Nome),
                new SqlParameter("@Documento", cliente.Documento),
                new SqlParameter("@Telefone", cliente.Telefone),
                new SqlParameter("@Email", cliente.Email),
                new SqlParameter("@Cep", cliente.Cep),
                new SqlParameter("@Logradouro", cliente.Logradouro),
                new SqlParameter("@Numero", cliente.Numero),
                new SqlParameter("@Bairro", cliente.Bairro),
                new SqlParameter("@Cidade", cliente.Cidade),
                new SqlParameter("@UF", cliente.UF)
            };
            banco.ExecutarComando(sql, parametros);
        }

        public void AtualizarCliente(Clientes cliente)
        {
            string sql = "UPDATE Clientes SET Nome = @Nome, Documento = @Documento, " +
                         "Telefone = @Telefone, Email = @Email, Cep = @Cep, " +
                         "Logradouro = @Logradouro, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, UF = @UF WHERE Id = @Id";
            SqlParameter[] parametros =
            {
                new SqlParameter("@Nome", cliente.Nome),
                new SqlParameter("@Documento", cliente.Documento),
                new SqlParameter("@Telefone", cliente.Telefone),
                new SqlParameter("@Email", cliente.Email),
                new SqlParameter("@Cep", cliente.Cep),
                new SqlParameter("@Logradouro", cliente.Logradouro),
                new SqlParameter("@Numero", cliente.Numero),
                new SqlParameter("@Bairro", cliente.Bairro),
                new SqlParameter("@Cidade", cliente.Cidade),
                new SqlParameter("@UF", cliente.UF),
                new SqlParameter("@Id", cliente.Id)
            };
            banco.ExecutarComando(sql, parametros);
        }

        public void ExcluirCliente(int clienteId)
        {
            string sql = "DELETE FROM Clientes WHERE Id = @Id";
            SqlParameter parametro = new SqlParameter("@Id", clienteId);
            banco.ExecutarComando(sql, new[] { parametro });
        }

        public Clientes BuscarClientePorId(int id)
        {
            string query = "SELECT * FROM Clientes WHERE Id = @Id";
            SqlParameter parametro = new SqlParameter("@Id", id);
            DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Clientes
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nome = row["Nome"].ToString(),
                    Documento = row["Documento"].ToString(),
                    Telefone = row["Telefone"].ToString(),
                    Email = row["Email"].ToString(),
                    Cep = row["Cep"].ToString(),
                    Cidade = row["Cidade"].ToString(),
                    Bairro = row["Bairro"].ToString(),
                    Logradouro = row["Logradouro"].ToString(),
                    Numero = Convert.ToInt32(row["Numero"]),               
                    UF = row["Uf"].ToString(),    
                };
            }

            return null;
        }

        public List<Clientes> ListarClientes()
        {
            List<Clientes> clientes = new List<Clientes>();
            string sql = "SELECT * FROM Clientes";
            DataTable dataTable = banco.ExecutarConsulta(sql, null);

            foreach (DataRow row in dataTable.Rows)
            {
                Clientes cliente = new Clientes
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nome = row["Nome"].ToString(),
                    Documento = row["Documento"].ToString(),
                    Telefone = row["Telefone"].ToString(),
                    Email = row["Email"].ToString(),
                    Cep = row["Cep"].ToString(),
                    Cidade = row["Cidade"].ToString(),
                    Bairro = row["Bairro"].ToString(),
                    Logradouro = row["Logradouro"].ToString(),
                    Numero = Convert.ToInt32(row["Numero"]),               
                    UF = row["Uf"].ToString(),    
                };
                clientes.Add(cliente);
            }

            return clientes;
        }
        public List<Clientes> PesquisarClientesPorNome(string valorPesquisa)
        {
            List<Clientes> clientesEncontrados = new List<Clientes>();
            using (SqlConnection connection = banco.Abrir())
            {
                string query = "SELECT * FROM Clientes WHERE Nome LIKE @ValorPesquisa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Clientes cliente = new Clientes
                        {
                            Id = (int)reader["Id"],
                            Nome = (string)reader["Nome"],
                            Documento = (string)reader["Documento"],
                            Telefone = (string)reader["Telefone"],
                            Email = (string)reader["Email"],
                            Cep = (string)reader["Cep"],
                            Cidade = (string)reader["Cidade"],
                            Bairro = (string)reader["Bairro"],
                            Logradouro = (string)reader["Logradouro"],
                            Numero = (int)reader["Numero"],
                            UF = (string)reader["Uf"],
                        };
                        clientesEncontrados.Add(cliente);
                    }
                }
            }
            return clientesEncontrados;
        }

        public List<Clientes> PesquisarClientesPorCPF(string valorPesquisa)
        {
            List<Clientes> clientesEncontrados = new List<Clientes>();
            using (SqlConnection connection = banco.Abrir())
            {
                string query = "SELECT * FROM Clientes WHERE Documento LIKE @ValorPesquisa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Clientes cliente = new Clientes
                        {
                            Id = (int)reader["Id"],
                            Nome = (string)reader["Nome"],
                            Documento = (string)reader["Documento"],
                            Telefone = (string)reader["Telefone"],
                            Email = (string)reader["Email"],
                            Cep = (string)reader["Cep"],
                            Cidade = (string)reader["Cidade"],
                            Bairro = (string)reader["Bairro"],
                            Logradouro = (string)reader["Logradouro"],
                            Numero = (int)reader["Numero"],
                            UF = (string)reader["Uf"],
                        };
                        clientesEncontrados.Add(cliente);
                    }
                }
            }
            return clientesEncontrados;
        }

    }
}
