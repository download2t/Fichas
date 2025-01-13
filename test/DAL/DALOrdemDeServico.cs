using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Classes;
using test.Model;
using test.Controllers;
using test.Data.Model;
using Controle.Model;
using System.Linq;
using Controle.Controller;

namespace test.Data
{
    public class DALOrdemDeServico
    {
        private Banco banco = new Banco();
        Operacao operacao = new Operacao();
        private CTLUsuarios aCTLUsuarios = new CTLUsuarios();

        private CTLApiWhatsApp ctlApiWhatsApp = new CTLApiWhatsApp();
        private ApiWhatsApp api = new ApiWhatsApp("554598601143@c.us", "sanma", "http://172.16.10.169:3000/client/sendMessage/sanma");
        public void AdicionarOrdemDeServico(OrdemDeServico ordemDeServico, List<Fotos> fotosParaAdicionar)
        {
            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    // Inicia uma transação
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Define o comando SQL para inserir a ordem de serviço
                        string sqlOrdemServico = "INSERT INTO OrdemDeServico (UsuarioID, Titulo, Descricao, DataAbertura, Prioridade, Ticket, Status) " +
                                                  "VALUES (@UsuarioID, @Titulo, @Descricao, @DataAbertura, @Prioridade, @Ticket, @Status);" +
                                                  "SELECT SCOPE_IDENTITY();"; // Obtém o ID da ordem de serviço inserida

                        // Cria o comando e associa à transação
                        SqlCommand command = new SqlCommand(sqlOrdemServico, connection, transaction);
                        command.Parameters.AddWithValue("@UsuarioID", ordemDeServico.Usuario.Id);
                        command.Parameters.AddWithValue("@Titulo", ordemDeServico.Titulo);
                        command.Parameters.AddWithValue("@Descricao", ordemDeServico.Descricao);
                        command.Parameters.AddWithValue("@DataAbertura", ordemDeServico.DataAbertura);
                        command.Parameters.AddWithValue("@Prioridade", ordemDeServico.Prioridade);
                        command.Parameters.AddWithValue("@Ticket", ordemDeServico.Ticket);
                        command.Parameters.AddWithValue("@Status", ordemDeServico.Status);

                        // Executa o comando para adicionar a ordem de serviço e obter seu ID
                        int ordemDeServicoId = Convert.ToInt32(command.ExecuteScalar());

                        // Se houver fotos para adicionar, adiciona as fotos associadas à ordem de serviço
                        if (fotosParaAdicionar != null && fotosParaAdicionar.Count > 0)
                        {
                            foreach (var foto in fotosParaAdicionar)
                            {
                                string sqlFoto = "INSERT INTO Fotos (OrdemDeServicoId, Foto, Descricao) " +
                                                 "VALUES (@OrdemDeServicoId, @Foto, @Descricao)";

                                SqlCommand commandFoto = new SqlCommand(sqlFoto, connection, transaction);
                                commandFoto.Parameters.AddWithValue("@OrdemDeServicoId", ordemDeServicoId);
                                commandFoto.Parameters.AddWithValue("@Foto", foto.Foto);
                                commandFoto.Parameters.AddWithValue("@Descricao", foto.Descricao);

                                commandFoto.ExecuteNonQuery();
                            }
                        }

                        // Comita a transação se todas as operações foram bem-sucedidas
                        transaction.Commit();

                        // Envia mensagem via API do WhatsApp
                        var user = aCTLUsuarios.BuscarUsuarioPorId(ordemDeServico.Usuario.Id);
                        string mensagem = $"Uma nova ordem de serviço foi aberta por {user.Nome}, com o título: '{ordemDeServico.Titulo}'. Em: {DateTime.Now:dd/MM/yyyy HH:mm}.";
                        _ = ctlApiWhatsApp.EnviarMensagem(api, mensagem); // Ignorando o await para não bloquear o fluxo principal 


                    }
                    catch (Exception ex)
                    {
                        // Em caso de erro, realiza o rollback para desfazer as operações realizadas na transação
                        transaction.Rollback();
                        MessageBox.Show("Erro ao adicionar ordem de serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir conexão com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizarOrdemDeServico(OrdemDeServico ordemDeServico, List<Fotos> fotosParaAdicionar = null, List<int> fotosParaExcluir = null)
        {
            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    // Inicia uma transação
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Define o comando SQL para atualizar a ordem de serviço
                        string sql = "UPDATE OrdemDeServico SET Titulo = @Titulo, Descricao = @Descricao, Prioridade = @Prioridade, Ticket = @Ticket, Status = @Status WHERE Id = @Id";

                        // Cria o comando e associa à transação
                        SqlCommand command = new SqlCommand(sql, connection, transaction);
                        command.Parameters.AddWithValue("@Titulo", ordemDeServico.Titulo);
                        command.Parameters.AddWithValue("@Descricao", ordemDeServico.Descricao);
                        command.Parameters.AddWithValue("@Prioridade", ordemDeServico.Prioridade);
                        command.Parameters.AddWithValue("@Ticket", ordemDeServico.Ticket);
                        command.Parameters.AddWithValue("@Status", ordemDeServico.Status);
                        command.Parameters.AddWithValue("@Id", ordemDeServico.Id);

                        // Executa o comando de atualização da ordem de serviço
                        command.ExecuteNonQuery();

                        // Se houver fotos para excluir
                        if (fotosParaExcluir != null && fotosParaExcluir.Any())
                        {
                            // Deleta as fotos associadas à ordem de serviço
                            foreach (int fotoId in fotosParaExcluir)
                            {
                                string sqlDeleteFoto = "DELETE FROM Fotos WHERE FotoId = @FotoId";
                                SqlCommand commandDeleteFoto = new SqlCommand(sqlDeleteFoto, connection, transaction);
                                commandDeleteFoto.Parameters.AddWithValue("@FotoId", fotoId);
                                commandDeleteFoto.ExecuteNonQuery();
                            }
                        }

                        // Se houver novas fotos para adicionar
                        if (fotosParaAdicionar != null && fotosParaAdicionar.Any())
                        {
                            // Adiciona as novas fotos associadas à ordem de serviço
                            foreach (var foto in fotosParaAdicionar)
                            {
                                string sqlFoto = "INSERT INTO Fotos (OrdemDeServicoId, Foto, Descricao) " +
                                                 "VALUES (@OrdemDeServicoId, @Foto, @Descricao)";

                                SqlCommand commandFoto = new SqlCommand(sqlFoto, connection, transaction);
                                commandFoto.Parameters.AddWithValue("@OrdemDeServicoId", ordemDeServico.Id);
                                commandFoto.Parameters.AddWithValue("@Foto", foto.Foto);
                                commandFoto.Parameters.AddWithValue("@Descricao", foto.Descricao);

                                commandFoto.ExecuteNonQuery();
                            }
                        }

                        // Comita a transação se todas as operações foram bem-sucedidas
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Em caso de erro, realiza o rollback para desfazer as operações realizadas na transação
                        transaction.Rollback();
                        MessageBox.Show("Erro ao atualizar ordem de serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir conexão com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void FecharOS(OrdemDeServico ordemDeServico)
        {
            try
            {
                string sql = "UPDATE OrdemDeServico SET DataFechamento = @DataFechamento, Status = @Status WHERE Id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@DataFechamento", SqlDbType.DateTime) { Value = ordemDeServico.DataFechamento },
                    new SqlParameter("@Status", SqlDbType.NVarChar) { Value = ordemDeServico.Status },
                    new SqlParameter("@Id", SqlDbType.Int) { Value = ordemDeServico.Id }

                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Fechar OS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReabrirOS(OrdemDeServico ordemDeServico)
        {
            try
            {
                string sql = "UPDATE OrdemDeServico SET DataReabertura = @DataReabertura, Status = @Status WHERE Id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@DataReabertura", SqlDbType.DateTime) { Value = ordemDeServico.DataReabertura },
                    new SqlParameter("@Status", SqlDbType.NVarChar) { Value = ordemDeServico.Status },
                    new SqlParameter("@Id", SqlDbType.Int) { Value = ordemDeServico.Id }

                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Fechar OS: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool ExcluirOrdemDeServico(int ordemDeServicoId)
        {
            try
            {
                string sql = "DELETE FROM OrdemDeServico WHERE ID = @ID";
                SqlParameter parametro = new SqlParameter("@ID", ordemDeServicoId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir ordem de serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public OrdemDeServico BuscarOrdemDeServicoPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM OrdemDeServico WHERE ID = @ID";
                SqlParameter parametro = new SqlParameter("@ID", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateOrdemDeServicoFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar ordem de serviço por ID: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<OrdemDeServico> ListarOrdensDeServico(DateTime? dataInicio = null, DateTime? dataFim = null, string status = null)
        {
            try
            {
                // Inicializa a consulta
                string query = "SELECT * FROM OrdemDeServico WHERE 1 = 1";

                // Adiciona as cláusulas WHERE conforme os parâmetros fornecidos
                if (dataInicio != null)
                    query += " AND DataAbertura >= @DataInicio";

                if (dataFim != null)
                {
                    // Adiciona 1 dia à data final para incluir todas as datas até o final do dia
                    dataFim = dataFim.Value.AddDays(1);
                    query += " AND DataAbertura < @DataFim";
                }

                // Verifica o status e adiciona a cláusula WHERE adequada
                if (!string.IsNullOrEmpty(status))
                {
                    if (status == "Todos")
                    {
                        // Não adiciona restrição de status
                    }
                    else if (status == "Encaminhado" || status == "Aberto")
                    {
                        // Filtra todos os status exceto "Encerrado"
                        query += " AND Status NOT IN ('Encerrado')";
                    }
                    else
                    {
                        // Filtra pelo status exato fornecido
                        query += " AND Status = @Status";
                    }
                }

                // Adiciona a cláusula ORDER BY para ordenar os resultados por prioridade e data de abertura
                query += " ORDER BY CASE WHEN Prioridade = 'Urgente' THEN 1"
                       + "               WHEN Prioridade = 'Alta' THEN 2"
                       + "               WHEN Prioridade = 'Média' THEN 3"
                       + "               WHEN Prioridade = 'Baixa' THEN 4"
                       + "               ELSE 5 END, DataAbertura ASC";

                // Executa a consulta
                SqlParameter[] parametros =
                {
                    new SqlParameter("@DataInicio", SqlDbType.DateTime) { Value = (object)dataInicio ?? DBNull.Value },
                    new SqlParameter("@DataFim", SqlDbType.DateTime) { Value = (object)dataFim ?? DBNull.Value },
                    new SqlParameter("@Status", SqlDbType.VarChar, 50) { Value = (object)status ?? DBNull.Value }
                };

                DataTable dataTable = banco.ExecutarConsulta(query, parametros);

                // Processa os resultados da consulta e cria objetos OrdemDeServico
                List<OrdemDeServico> ordensDeServico = new List<OrdemDeServico>();
                foreach (DataRow row in dataTable.Rows)
                {
                    OrdemDeServico ordemDeServico = CreateOrdemDeServicoFromDataRow(row);
                    ordensDeServico.Add(ordemDeServico);
                }

                return ordensDeServico;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar ordens de serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<OrdemDeServico>();
            }
        }

        public List<OrdemDeServico> ListarOrdensDeServicoPorSetor(DateTime? dataInicio = null, DateTime? dataFim = null,string status = null, int? idSetor = null, int? idUsuario = null)
        {
            try
            {
                // Inicializa a consulta
                string query = @"
                    SELECT os.*
                    FROM OrdemDeServico os
                    INNER JOIN Usuarios u ON os.UsuarioID = u.Id
                    WHERE (u.SetorID = @SetorID OR os.UsuarioID = @IdUsuario)"; // Filtra pelo setor do usuário que cadastrou a OS ou pelo ID do usuário que criou a OS

                // Adiciona as cláusulas WHERE conforme os parâmetros fornecidos
                if (dataInicio != null)
                    query += " AND os.DataAbertura >= @DataInicio";

                if (dataFim != null)
                {
                    // Adiciona 1 dia à data final para incluir todas as datas até o final do dia
                    dataFim = dataFim.Value.AddDays(1);
                    query += " AND os.DataAbertura < @DataFim";
                }

                // Verifica o status e adiciona a cláusula WHERE adequada
                if (!string.IsNullOrEmpty(status))
                {
                    if (status == "Todos")
                    {
                        // Não adiciona restrição de status
                    }
                    else if (status == "Encaminhado a TOTVS" || status == "Em andamento" || status == "Aberto")
                    {
                        query += " AND os.Status IN ('Encaminhado a TOTVS', 'Em andamento', 'Aberto')";
                    }
                    else
                    {
                        query += " AND os.Status = @Status";
                    }
                }

                // Adiciona a cláusula ORDER BY para ordenar os resultados por prioridade e data de abertura
                query += " ORDER BY CASE WHEN os.Prioridade = 'Urgente' THEN 1"
                       + "               WHEN os.Prioridade = 'Alta' THEN 2"
                       + "               WHEN os.Prioridade = 'Média' THEN 3"
                       + "               WHEN os.Prioridade = 'Baixa' THEN 4"
                       + "               ELSE 5 END, os.DataAbertura ASC";

                // Define os parâmetros da consulta
                SqlParameter[] parametros =
                {
                    new SqlParameter("@SetorID", SqlDbType.Int) { Value = (object)idSetor ?? DBNull.Value },
                    new SqlParameter("@IdUsuario", SqlDbType.Int) { Value = (object)idUsuario ?? DBNull.Value },
                    new SqlParameter("@DataInicio", SqlDbType.DateTime) { Value = (object)dataInicio ?? DBNull.Value },
                    new SqlParameter("@DataFim", SqlDbType.DateTime) { Value = (object)dataFim ?? DBNull.Value },
                    new SqlParameter("@Status", SqlDbType.VarChar, 50) { Value = (object)status ?? DBNull.Value }
                };

                // Executa a consulta
                DataTable dataTable = banco.ExecutarConsulta(query, parametros);

                // Processa os resultados da consulta e cria objetos OrdemDeServico
                List<OrdemDeServico> ordensDeServico = new List<OrdemDeServico>();
                foreach (DataRow row in dataTable.Rows)
                {
                    OrdemDeServico ordemDeServico = CreateOrdemDeServicoFromDataRow(row);
                    ordensDeServico.Add(ordemDeServico);
                }

                return ordensDeServico;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar ordens de serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<OrdemDeServico>();
            }
        }
        public List<OrdemDeServico> PesquisarOsPorCriterioPorSetor(string criterio,string valorPesquisa, int? setor,int? idUser)
        {
            List<OrdemDeServico> osEncontradas = new List<OrdemDeServico>();

            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    // Inicializa a consulta
                    string query = "SELECT os.* FROM OrdemDeServico os ";

                    // Adiciona JOIN com a tabela Usuarios se precisar filtrar pelo setor ou usuário
                    if (setor != null || idUser != null)
                    {
                        query += "INNER JOIN Usuarios u ON os.UsuarioID = u.Id ";
                    }

                    // Adiciona as condições de filtro de setor e usuário
                    if (setor != null)
                    {
                        query += "WHERE u.SetorID = @SetorID ";
                    }
                    if (idUser != null)
                    {
                        if (setor != null)
                        {
                            query += "AND (os.UsuarioID = @IdUsuario OR u.SetorID = @SetorID) ";
                        }
                        else
                        {
                            query += "WHERE os.UsuarioID = @IdUsuario ";
                        }
                    }

                    // Adiciona condições de pesquisa com base no critério fornecido
                    if (criterio == "ID")
                    {
                        query += "AND os.Id = @ValorPesquisa";
                    }
                    else if (criterio == "Usuario")
                    {
                        // Ajuste para permitir pesquisa por nome e sobrenome
                        query += "AND (u.Nome + ' ' + u.Sobrenome) LIKE @ValorPesquisa";
                    }
                    else if (criterio == "Ticket")
                    {
                        query += "AND os.Ticket LIKE @ValorPesquisa";
                    }
                    else
                    {
                        // Trata o caso em que o critério não é reconhecido
                        throw new ArgumentException("Critério de pesquisa inválido.");
                    }

                    SqlCommand command = new SqlCommand(query, connection);

                    // Adiciona os parâmetros da consulta
                    if (setor != null)
                    {
                        command.Parameters.AddWithValue("@SetorID", setor.Value);
                    }
                    if (idUser != null)
                    {
                        command.Parameters.AddWithValue("@IdUsuario", idUser.Value);
                    }

                    // Ajuste para tratar ID como int e outras pesquisas como string
                    if (criterio == "ID")
                    {
                        command.Parameters.AddWithValue("@ValorPesquisa", Convert.ToInt32(valorPesquisa));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");
                    }

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return CreateOrdemDeServicoListFromDataTable(dataTable);
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException($"Erro ao buscar ordens de serviço por {criterio.ToLower()}", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException($"Erro ao buscar ordens de serviço por {criterio.ToLower()}", ex);
            }

            return osEncontradas;
        }
        public List<OrdemDeServico> PesquisarOsPorCriterio(string criterio, string valorPesquisa)
        {
            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    string query = "SELECT os.* FROM OrdemDeServico os ";

                    // Adiciona JOIN com a tabela Usuarios se for o critério de pesquisa
                    if (criterio == "Usuario")
                    {
                        query += "INNER JOIN Usuarios u ON os.UsuarioID = u.Id ";
                    }

                    // Adiciona as condições de filtro com base no critério fornecido
                    if (criterio == "ID")
                    {
                        query += "WHERE os.Id = @ValorPesquisa";
                    }
                    else if (criterio == "Usuario")
                    {
                        query += "WHERE (u.Nome + ' ' + u.Sobrenome) LIKE @ValorPesquisa";
                    }
                    else if (criterio == "Ticket")
                    {
                        query += "WHERE os.Ticket LIKE @ValorPesquisa";
                    }
                    else
                    {
                        // Trata o caso em que o critério não é reconhecido
                        throw new ArgumentException("Critério de pesquisa inválido.");
                    }

                    SqlCommand command = new SqlCommand(query, connection);

                    // Ajusta o parâmetro de pesquisa com base no critério
                    if (criterio == "ID")
                    {
                        command.Parameters.AddWithValue("@ValorPesquisa", Convert.ToInt32(valorPesquisa));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");
                    }

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return CreateOrdemDeServicoListFromDataTable(dataTable);
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException($"Erro ao buscar ordens de serviço por {criterio.ToLower()}", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException($"Erro ao buscar ordens de serviço por {criterio.ToLower()}", ex);
            }

            return new List<OrdemDeServico>();  // Retorna uma lista vazia em caso de erro
        }
        private OrdemDeServico CreateOrdemDeServicoFromDataRow(DataRow row)
        {
            int usuarioId = Convert.ToInt32(row["UsuarioID"]);

            // Supondo que você tenha um método para buscar o usuário pelo ID
            Usuarios usuario = aCTLUsuarios.BuscarUsuarioPorId(usuarioId);

            return new OrdemDeServico
            {
                Id = Convert.ToInt32(row["ID"]),
                Usuario = usuario,
                Titulo = row["Titulo"].ToString(),
                Descricao = row["Descricao"].ToString(),
                DataAbertura = Convert.ToDateTime(row["DataAbertura"]),
                DataFechamento = row["DataFechamento"] != DBNull.Value ? Convert.ToDateTime(row["DataFechamento"]) : (DateTime?)null,
                DataReabertura = row["DataReabertura"] != DBNull.Value ? Convert.ToDateTime(row["DataReabertura"]) : (DateTime?)null,
                Prioridade = row["Prioridade"].ToString(),
                Ticket = row["Ticket"].ToString(),
                Status = row["Status"].ToString()
            };
        }
        private List<OrdemDeServico> CreateOrdemDeServicoListFromDataTable(DataTable dataTable)
        {
            List<OrdemDeServico> ordensDeServico = new List<OrdemDeServico>();
            foreach (DataRow row in dataTable.Rows)
            {
                ordensDeServico.Add(CreateOrdemDeServicoFromDataRow(row));
            }
            return ordensDeServico;
        }


    }
}
