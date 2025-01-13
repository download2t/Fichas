using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Data.Model;

namespace test.Data
{
    public class DALMensagens
    {
        private Banco banco = new Banco();
        Operacao operacao = new Operacao();
        CTLContatos aCTLContatos = new CTLContatos();

        public string AdicionarMensagem(Mensagens mensagem)
        {
            string ok = "OK";

            try
            {
                string sql = "INSERT INTO Mensagens (ContatoId, DataEnvio, Mensagem, Status) " +
                             "VALUES (@IdContato, @DataEnvio, @Mensagem, @Status)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@IdContato", mensagem.OContato.Id),
                    new SqlParameter("@DataEnvio", mensagem.DataEnvio ?? (object)DBNull.Value),
                    new SqlParameter("@Mensagem", mensagem.Mensagem),
                    new SqlParameter("@Status",mensagem.Status)
                };
                banco.ExecutarComando(sql, parametros);
                return ok;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar mensagem", ex);
                return "Erro";
            }
        }
        public List<string> AdicionarEmLote(List<Mensagens> mensagens)
        {
            string sql = "INSERT INTO Mensagens (ContatoId, DataEnvio, Mensagem, Status) " +
                              "VALUES (@IdContato, @DataEnvio, @Mensagem, @Status)";

            List<string> erros = new List<string>();

            try
            {
                foreach (var mensagem in mensagens)
                {
                    SqlParameter[] parametros =
                    {
                        new SqlParameter("@IdContato", mensagem.OContato.Id),
                        new SqlParameter("@DataEnvio", mensagem.DataEnvio ?? (object)DBNull.Value),
                        new SqlParameter("@Mensagem", mensagem.Mensagem),
                        new SqlParameter("@Status",mensagem.Status)
                    };

                    try
                    {
                        banco.ExecutarComando(sql, parametros);
                    }
                    catch (Exception ex)
                    {
                        erros.Add($"Erro ao agendar mensagem para ContatoID: {mensagem.OContato.Id}, DataEnvio: {mensagem.DataEnvio}, Mensagem: {mensagem.Mensagem}. Erro: {ex.Message}");
                    }
                }

                return erros;
            }
            catch (Exception ex)
            {
                erros.Add("Erro ao agendar mensagens: " + ex.Message);
                return erros;
            }
        }
        public bool ExcluirTodasPorId(int contatoId)
        {
            string sql = "DELETE FROM Mensagens WHERE ContatoId = @IdContato AND Status <> 'S'";
            List<string> erros = new List<string>();

            try
            {
                SqlParameter[] parametros =
                {
            new SqlParameter("@IdContato", contatoId)
        };

                banco.ExecutarComando(sql, parametros);
                return true; // Se chegou até aqui, a exclusão foi bem-sucedida
            }
            catch (Exception ex)
            {
                erros.Add("Erro ao excluir mensagens do ContatoID: " + contatoId + ". Erro: " + ex.Message);
                return false;
            }
        }


        public string AtualizarMensagem(Mensagens mensagem)
        {
            string ok = "OK";
            try
            {
                string sql = "UPDATE Mensagens SET ContatoId = @IdContato, DataEnvio = @DataEnvio, " +
                             "Mensagem = @Mensagem WHERE Id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@IdContato", mensagem.OContato.Id),
                    new SqlParameter("@DataEnvio", mensagem.DataEnvio ?? (object)DBNull.Value),
                    new SqlParameter("@Mensagem", mensagem.Mensagem),
                    new SqlParameter("@Id", mensagem.Id)
                };
                banco.ExecutarComando(sql, parametros);
                return ok;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar mensagem", ex);
                return "Erro";
            }
        }

        public bool ExcluirMensagem(int mensagemId)
        {
            try
            {
                // Verificar o status da mensagem antes de tentar excluí-la
                string sqlVerificarStatus = "SELECT Status FROM Mensagens WHERE Id = @Id";
                SqlParameter parametroVerificar = new SqlParameter("@Id", mensagemId);
                string status = banco.ExecutarConsultaScalar(sqlVerificarStatus, new[] { parametroVerificar }).ToString();

                if (status == "S")
                {
                    throw new InvalidOperationException("A mensagem já foi enviada e não pode ser excluída.");
                }

                // Se o status não for 'S', proceder com a exclusão
                string sqlExcluir = "DELETE FROM Mensagens WHERE Id = @Id";
                SqlParameter parametroExcluir = new SqlParameter("@Id", mensagemId);
                banco.ExecutarComando(sqlExcluir, new[] { parametroExcluir });
                return true; // Retorne true para indicar sucesso
            }
            catch (InvalidOperationException ex)
            {
                operacao.HandleException("Erro ao excluir mensagem: " + ex.Message, ex);
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir mensagem", ex);
                return false; // Retorne false para indicar falha
            }
        }


        public Mensagens BuscarMensagemPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM Mensagens WHERE Id = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateMensagemFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar mensagem por ID", ex);
                return null;
            }
        }

        public List<Mensagens> ListarMensagens2()
        {
            try
            {
                string sql = "SELECT * FROM Mensagens Order By Id Desc";
                DataTable dataTable = banco.ExecutarConsulta(sql, null);
                return CreateMensagensListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar mensagens", ex);
                return new List<Mensagens>();
            }
        }

        private Mensagens CreateMensagemFromDataRow(DataRow row)
        {
            int contatoId = Convert.ToInt32(row["ContatoId"]);

            // Supondo que você tenha um método para buscar o contato pelo ID e obter seu telefone
            Contatos contato = aCTLContatos.BuscarContatoPorId(contatoId);

            // Obtém o telefone do contato
            string telefoneContato = contato?.Numero ?? "Telefone não encontrado"; // Supondo que o telefone esteja armazenado na propriedade Telefone de Contatos

            return new Mensagens
            {
                Id = Convert.ToInt32(row["Id"]),
                OContato = contato,
                DataEnvio = row["DataEnvio"] != DBNull.Value ? Convert.ToDateTime(row["DataEnvio"]) : (DateTime?)null,
                Mensagem = row["Mensagem"].ToString(),
                Telefone = telefoneContato
            };
        }
        private List<Mensagens> CreateMensagensListFromDataTable(DataTable dataTable)
        {
            List<Mensagens> mensagens = new List<Mensagens>();
            foreach (DataRow row in dataTable.Rows)
            {
                mensagens.Add(CreateMensagemFromDataRow(row));
            }
            return mensagens;
        }
        public List<Mensagens> ListarMensagens(string criterioLista, string criterioPesquisa, string valorPesquisa, DateTime? dataInicio = null, DateTime? dataFim = null)
        {
            List<Mensagens> mensagensEncontradas = new List<Mensagens>();

            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    string sql = "SELECT * FROM Mensagens ";

                    bool hasWhereClause = false;

                    if (!string.IsNullOrEmpty(criterioPesquisa) && !string.IsNullOrEmpty(valorPesquisa))
                    {
                        switch (criterioPesquisa)
                        {
                            case "ID" when int.TryParse(valorPesquisa, out int id):
                                sql += "WHERE ContatoId = @ValorPesquisa ";
                                hasWhereClause = true;
                                break;

                            case "Contato":
                                sql += "WHERE ContatoId IN (SELECT Id FROM Contatos WHERE Nome LIKE @ValorPesquisa) ";
                                hasWhereClause = true;
                                break;

                            default:
                                // Trate aqui o caso em que o critério não é reconhecido.
                                // Pode ser lançada uma exceção ou tratado de outra forma apropriada.
                                break;
                        }
                    }

                    if (!string.IsNullOrEmpty(criterioLista))
                    {
                        if (!hasWhereClause)
                        {
                            sql += "WHERE ";
                            hasWhereClause = true;
                        }
                        else
                        {
                            sql += "AND ";
                        }

                        switch (criterioLista)
                        {
                            case "Enviados":
                                sql += "Status = 'S' ";
                                break;
                            case "Agendados":
                                sql += "Status = 'A' ";
                                break;
                            case "NaoEnviadas":
                                sql += "Status = 'N' ";
                                break;
                            default:
                                // Trate aqui o caso em que o critério de lista não é reconhecido.
                                // Pode ser lançada uma exceção ou tratado de outra forma apropriada.
                                break;
                        }
                    }

                    if (dataInicio != null && dataFim != null)
                    {
                        if (!hasWhereClause)
                        {
                            sql += "WHERE ";
                        }
                        else
                        {
                            sql += "AND ";
                        }
                        sql += "CAST(DataEnvio AS DATE) >= CAST(@DataInicio AS DATE) AND CAST(DataEnvio AS DATE) <= CAST(@DataFim AS DATE) ";
                    }

                    sql += "ORDER BY Id DESC";

                    SqlCommand command = new SqlCommand(sql, connection);

                    if (dataInicio != null && dataFim != null)
                    {
                        command.Parameters.AddWithValue("@DataInicio", dataInicio.Value.Date);
                        command.Parameters.AddWithValue("@DataFim", dataFim.Value.Date);
                    }

                    if (!string.IsNullOrEmpty(criterioPesquisa) && !string.IsNullOrEmpty(valorPesquisa))
                    {
                        if (criterioPesquisa == "ID" && int.TryParse(valorPesquisa, out int id))
                        {
                            command.Parameters.AddWithValue("@ValorPesquisa", id);
                        }
                        else if (criterioPesquisa == "Contato")
                        {
                            command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");
                        }
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Mensagens mensagem = CreateList(reader);
                        mensagensEncontradas.Add(mensagem);
                    }
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException($"Erro ao buscar mensagens por {criterioPesquisa.ToLower()}", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException($"Erro ao buscar mensagens por {criterioPesquisa.ToLower()}", ex);
            }

            return mensagensEncontradas;
        }


        private Mensagens CreateList(SqlDataReader reader)
        {
            int contatoId = (int)reader["ContatoId"];
            Contatos contato = aCTLContatos.BuscarContatoPorId(contatoId);
            string telefoneContato = contato?.Numero ?? "Telefone não encontrado";

            return new Mensagens
            {
                Id = (int)reader["Id"],
                OContato = contato,
                DataEnvio = reader["DataEnvio"] != DBNull.Value ? Convert.ToDateTime(reader["DataEnvio"]) : (DateTime?)null,
                Telefone = telefoneContato,
                Status = reader["Status"] != DBNull.Value ? Convert.ToChar(reader["Status"]) : '\0',
                Mensagem = reader["Mensagem"].ToString(),

            };
        }



    }
}
