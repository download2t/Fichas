using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Data.Model;

namespace test.Data
{
    public class DALFichas
    {
        private Banco banco = new Banco();
        private CTLClientes aCTLClientes;
        private CTLUsuarios CTLUsuarios;
        private Operacao operacao;

        public DALFichas()
        {
            aCTLClientes = new CTLClientes();
            CTLUsuarios = new CTLUsuarios();
            operacao = new Operacao();
        }
        public void AdicionarFicha(Fichas ficha)
        {
            try
            {
                string sql = "INSERT INTO Fichas (Descricao, ClienteId, UsuarioId, DataCriacao) " +
                             "VALUES (@Descricao, @CodCliente, @CodUsuario, @DataCriacao)";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Descricao", ficha.Descricao),
                    new SqlParameter("@CodCliente", ficha.Clientes.Id),
                    new SqlParameter("@CodUsuario", ficha.Usuarios.Id),
                    new SqlParameter("@DataCriacao", ficha.DataCriacao)
                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (SqlException ex)
            {
                operacao.HandleException("adicionar a ficha", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("adicionar a ficha", ex);
            }
        }

        public void AtualizarFicha(Fichas ficha)
        {
            try
            {
                string sql = "UPDATE Fichas SET Descricao = @Descricao, ClienteId = @CodCliente, " +
                             "UsuarioId = @CodUsuario, DataCriacao = @DataCriacao WHERE Id = @Id";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Descricao", ficha.Descricao),
                    new SqlParameter("@CodCliente", ficha.Clientes.Id),
                    new SqlParameter("@CodUsuario", ficha.Usuarios.Id),
                    new SqlParameter("@DataCriacao", ficha.DataCriacao),
                    new SqlParameter("@Id", ficha.Id)
                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (SqlException ex)
            {
                operacao.HandleException("atualizar a ficha", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("atualizar a ficha", ex);
            }
        }

        public bool ExcluirFicha(int fichaId)
        {
            try
            {
                string sql = "DELETE FROM Fichas WHERE Id = @Id";
                SqlParameter[] parametros = { new SqlParameter("@Id", fichaId) };
                banco.ExecutarComando(sql, parametros);
                return true; // Retorne true para indicar sucesso
            }
            catch (SqlException ex)
            {
                Operacao operacao = new Operacao();
                if (operacao.IsForeignKeyViolation(ex))
                {
                    MessageBox.Show("Não foi possível excluir a ficha selecionada, pois ela está sendo utilizada em outros registros." +
                                    " Por favor, remova todas as referências desta ficha em outros registros antes de tentar excluí-la novamente.");
                }
                else
                {
                    // Trate outras exceções do SQL Server, se necessário
                    operacao.HandleException("Erro ao excluir a ficha", ex);
                }
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                // Trate outras exceções genéricas, se aplicável
                operacao.HandleException("Erro ao excluir a ficha", ex);
                return false; // Retorne false para indicar falha
            }
        }


        public Fichas BuscarFichaPorId(int id)
        {
            try
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
                                Usuarios = CTLUsuarios.BuscarUsuarioPorId((int)reader["UsuarioId"]),
                                Clientes = aCTLClientes.BuscarClientePorId((int)reader["ClienteId"]),
                                DataCriacao = (DateTime)reader["DataCriacao"],
                                Descricao = (string)reader["Descricao"],
                            };
                        }
                    }
                }

                return ficha;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("buscar a ficha por ID", ex);
                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("buscar a ficha por ID", ex);
                return null;
            }
        }

        public List<Fichas> ListarFichas(DateTime? dataInicio = null, DateTime? dataFim = null, int mes = 0, int ano = 0)
        {
            try
            {
                List<Fichas> fichas = new List<Fichas>();
                using (SqlConnection connection = banco.Abrir())
                {
                    string sql = "SELECT * FROM Fichas WHERE 1=1";

                    if (dataInicio != null && dataFim != null)
                    {
                        sql += " AND DataCriacao >= @DataInicio AND DataCriacao <= @DataFim";
                    }
                    else if (mes != 0 && ano != 0)
                    {
                        sql += " AND MONTH(DataCriacao) = @Mes AND YEAR(DataCriacao) = @Ano";
                    }

                    // Adicione a cláusula ORDER BY para ordenar por ID em ordem decrescente
                    sql += " ORDER BY ID DESC";

                    SqlCommand command = new SqlCommand(sql, connection);

                    if (dataInicio != null && dataFim != null)
                    {
                        command.Parameters.AddWithValue("@DataInicio", dataInicio);
                        command.Parameters.AddWithValue("@DataFim", dataFim);
                    }
                    else if (mes != 0 && ano != 0)
                    {
                        command.Parameters.AddWithValue("@Mes", mes);
                        command.Parameters.AddWithValue("@Ano", ano);
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Fichas ficha = new Fichas
                        {
                            Id = (int)reader["Id"],
                            Usuarios = CTLUsuarios.BuscarUsuarioPorId((int)reader["UsuarioId"]),
                            Clientes = aCTLClientes.BuscarClientePorId((int)reader["ClienteId"]),
                            DataCriacao = (DateTime)reader["DataCriacao"],
                            Descricao = (string)reader["Descricao"],
                        };
                        fichas.Add(ficha);
                    }
                }

                return fichas;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("listar as fichas", ex);
                return new List<Fichas>();
            }
            catch (Exception ex)
            {
                operacao.HandleException("listar as fichas", ex);
                return new List<Fichas>();
            }
        }

        public List<Fichas> PesquisarFichasPorCriterio(string criterio, string valorPesquisa)
        {
            List<Fichas> fichasEncontradas = new List<Fichas>();

            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    string query = "SELECT * FROM Fichas " +
                                   "INNER JOIN ";

                    if (criterio == "Clientes")
                    {
                        query += "Clientes ON Fichas.ClienteId = Clientes.Id " +
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
                                    Usuarios = CTLUsuarios.BuscarUsuarioPorId((int)reader["UsuarioId"]),
                                    Clientes = aCTLClientes.BuscarClientePorId((int)reader["ClienteId"]),
                                    DataCriacao = (DateTime)reader["DataCriacao"],
                                    Descricao = (string)reader["Descricao"],
                                };
                                fichasEncontradas.Add(ficha);
                            }
                        }
                    }
                    else if (criterio == "Usuario")
                    {
                        query += "Usuarios ON Fichas.UsuarioId = Usuarios.Id " +
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
                                    Usuarios = CTLUsuarios.BuscarUsuarioPorId((int)reader["UsuarioId"]),
                                    Clientes = aCTLClientes.BuscarClientePorId((int)reader["ClienteId"]),
                                    DataCriacao = (DateTime)reader["DataCriacao"],
                                    Descricao = (string)reader["Descricao"],
                                };
                                fichasEncontradas.Add(ficha);
                            }
                        }
                    }
                    else if (criterio == "ID" && int.TryParse(valorPesquisa, out int id))
                    {
                        query += "Clientes ON Fichas.ClienteId = Clientes.Id " +
                                 "WHERE Clientes.Id = @ValorPesquisa";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ValorPesquisa", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Fichas ficha = new Fichas
                                {
                                    Id = (int)reader["Id"],
                                    Usuarios = CTLUsuarios.BuscarUsuarioPorId((int)reader["UsuarioId"]),
                                    Clientes = aCTLClientes.BuscarClientePorId((int)reader["ClienteId"]),
                                    DataCriacao = (DateTime)reader["DataCriacao"],
                                    Descricao = (string)reader["Descricao"],
                                };
                                fichasEncontradas.Add(ficha);
                            }
                        }
                    }
                    else
                    {
                        // Trate aqui o caso em que o critério não é reconhecido.
                        // Pode ser lançada uma exceção ou tratado de outra forma apropriada.
                    }
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException($"Erro ao buscar fichas por {criterio.ToLower()}", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException($"Erro ao buscar fichas por {criterio.ToLower()}", ex);
            }

            return fichasEncontradas;
        }
        public DataTable RelatorioFichas(int? idUsuario = null, int? idCliente = null, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            try
            {
                string sql = @"SELECT U.Nome AS Usuarios,
                      C.Nome AS Clientes,
                      F.DataCriacao as DataCadastro,
                      F.Descricao
                      FROM Fichas F
                      INNER JOIN Usuarios U ON U.Id = F.UsuarioId
                      INNER JOIN Clientes C ON C.Id = F.ClienteId
                      WHERE 1 = 1";


                var whereConditions = new List<string>();
                var parameters = new List<SqlParameter>();

                if (idUsuario.HasValue)
                {
                    whereConditions.Add("F.UsuarioId = @idUsuario");
                    parameters.Add(new SqlParameter("@idUsuario", idUsuario.Value));
                }
                if (idCliente.HasValue)
                {
                    whereConditions.Add("F.ClienteId = @idCliente");
                    parameters.Add(new SqlParameter("@idCliente", idCliente.Value));
                }

                if (dataInicial.HasValue)
                {
                    // Adicione um segundo ao final da data para incluir registros do dia final
                    dataFinal = dataFinal?.AddDays(1).AddSeconds(-1);

                    whereConditions.Add("F.DataCriacao >= @dataInicial");
                    parameters.Add(new SqlParameter("@dataInicial", dataInicial.Value.Date));
                }

                if (dataFinal.HasValue)
                {
                    whereConditions.Add("F.DataCriacao <= @dataFinal");
                    parameters.Add(new SqlParameter("@dataFinal", dataFinal.Value.Date));
                }

                if (whereConditions.Count > 0)
                {
                    sql += " AND " + string.Join(" AND ", whereConditions);
                }

                sql += " ORDER BY F.DataCriacao DESC";

                return banco.ExecutarConsulta(sql, parameters.ToArray());
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar relatório de fichas", ex);
                return new DataTable();
            }
        }


    }
}
