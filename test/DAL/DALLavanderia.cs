using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Data.Model;
using test.Model;

namespace test.Data
{
    public class DALLavanderia
    {
        private Banco banco = new Banco();
        Operacao operacao = new Operacao();
        CTLFuncionarios aCTLFuncionarios = new CTLFuncionarios();
        CTLItensLavanderia aCTlItensLavanderia = new CTLItensLavanderia();

        public bool AdicionarLavanderia(Lavanderia lavanderia)
        {
            try
            {
                string sql = "INSERT INTO Lavanderia (Data, Peso, Processo, FuncionarioId, ItensLavanderiaId) " +
                             "VALUES (@Data, @Peso, @Processo, @FuncionarioId, @ItensLavanderiaId)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Data", lavanderia.Data),
                    new SqlParameter("@Peso", lavanderia.Peso),
                    new SqlParameter("@Processo", lavanderia.Processo),
                    new SqlParameter("@FuncionarioId", lavanderia.Funcionario.Id),
                    new SqlParameter("@ItensLavanderiaId", lavanderia.ItensLavanderia.Id)
                };
                banco.ExecutarComando(sql, parametros);
                return true;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar lavanderia", ex);
                return false;
            }
        }

        public bool AtualizarLavanderia(Lavanderia lavanderia)
        {
            try
            {
                string sql = "UPDATE Lavanderia SET Data = @Data, Peso = @Peso, Processo = @Processo, " +
                             "FuncionarioId = @FuncionarioId, ItensLavanderiaId = @ItensLavanderiaId WHERE Id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Data", lavanderia.Data),
                    new SqlParameter("@Peso", lavanderia.Peso),
                    new SqlParameter("@Processo", lavanderia.Processo),
                    new SqlParameter("@FuncionarioId", lavanderia.Funcionario.Id),
                    new SqlParameter("@ItensLavanderiaId", lavanderia.ItensLavanderia.Id),
                    new SqlParameter("@Id", lavanderia.Id)
                };
                banco.ExecutarComando(sql, parametros);
                return true;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar lavanderia", ex);
                return false;
            }
        }

        public bool ExcluirLavanderia(int lavanderiaId)
        {
            try
            {
                string sql = "DELETE FROM Lavanderia WHERE Id = @Id";
                SqlParameter parametro = new SqlParameter("@Id", lavanderiaId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true; // Retorne true para indicar sucesso
            }
            catch (SqlException ex)
            {
                if (operacao.IsForeignKeyViolation(ex))
                {
                    MessageBox.Show("Não foi possível excluir a lavanderia selecionada, pois ela está sendo utilizada em outros registros." +
                                    " Por favor, remova todas as referências desta lavanderia em outros registros antes de tentar excluí-la novamente.");
                }
                else
                {
                    operacao.HandleException("Erro ao excluir lavanderia", ex);
                }
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir lavanderia", ex);
                return false; // Retorne false para indicar falha
            }
        }
        public DataTable RelatorioLavanderia(DateTime? dataInicial = null, DateTime? dataFinal = null, int? codFuncionarios = null, int? codItem = null, string processo = null)
        {
            try
            {
                string sql = @"SELECT 
                I.Nome AS ItensLavanderia,
                L.Data,
                L.Processo,
                F.Nome AS Funcionario,
                L.Peso
                FROM Lavanderia L
                INNER JOIN Funcionarios F ON F.Id = L.FuncionarioID
                INNER JOIN ItensLavanderia I ON I.ID = L.ItensLavanderiaID
                WHERE 1 = 1";

                var whereConditions = new List<string>();
                var parameters = new List<SqlParameter>();

                if (dataInicial.HasValue)
                {
                    whereConditions.Add("L.Data >= @dataInicial");
                    parameters.Add(new SqlParameter("@dataInicial", dataInicial.Value.Date));
                }

                if (dataFinal.HasValue)
                {
                    dataFinal = dataFinal?.AddDays(1).AddSeconds(-1);
                    whereConditions.Add("L.Data <= @dataFinal");
                    parameters.Add(new SqlParameter("@dataFinal", dataFinal.Value.Date));
                }

                if (codFuncionarios.HasValue)
                {
                    whereConditions.Add("L.FuncionarioID = @codFuncionarios");
                    parameters.Add(new SqlParameter("@codFuncionarios", codFuncionarios.Value));
                }

                if (codItem.HasValue)
                {
                    whereConditions.Add("L.ItensLavanderiaID = @codItem");
                    parameters.Add(new SqlParameter("@codItem", codItem.Value));
                }

                if (!string.IsNullOrEmpty(processo))
                {
                    whereConditions.Add("L.Processo LIKE @processo");
                    parameters.Add(new SqlParameter("@processo", "%" + processo + "%"));
                }

                if (whereConditions.Count > 0)
                {
                    sql += " AND " + string.Join(" AND ", whereConditions);
                }

                sql += " ORDER BY L.Data DESC";

                DataTable dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand(sql, banco.Abrir()))
                {
                    command.Parameters.AddRange(parameters.ToArray());
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar relatório de lavanderia", ex);
                return new DataTable();
            }
        }

        public DataTable RelatorioLavanderia2(DateTime? dataInicial = null, DateTime? dataFinal = null, int? codFuncionarios = null, int? codItem = null, string processo = null)
        {
            try
            {
                string sql = @"SELECT 
                        I.Nome AS ItemLavanderia,
                        L.Data,
                        L.Processo,
                        F.Nome AS Funcionario,
                        L.Peso
                        FROM Lavanderia L
                        INNER JOIN Funcionarios F ON F.Id = L.FuncionarioID
                        INNER JOIN ItensLavanderia I ON I.ID = L.ItensLavanderiaID
                        WHERE 1 = 1";

                var whereConditions = new List<string>();
                var parameters = new List<SqlParameter>();

                if (dataInicial.HasValue)
                {
                    whereConditions.Add("L.Data >= @dataInicial");
                    parameters.Add(new SqlParameter("@dataInicial", dataInicial.Value.Date));
                }

                if (dataFinal.HasValue)
                {
                    dataFinal = dataFinal?.AddDays(1).AddSeconds(-1);
                    whereConditions.Add("L.Data <= @dataFinal");
                    parameters.Add(new SqlParameter("@dataFinal", dataFinal.Value.Date));
                }

                if (codFuncionarios.HasValue)
                {
                    whereConditions.Add("L.FuncionarioID = @codFuncionarios");
                    parameters.Add(new SqlParameter("@codFuncionarios", codFuncionarios.Value));
                }

                if (codItem.HasValue)
                {
                    whereConditions.Add("L.ItensLavanderiaID = @codItem");
                    parameters.Add(new SqlParameter("@codItem", codItem.Value));
                }

                if (!string.IsNullOrEmpty(processo))
                {
                    whereConditions.Add("L.Processo LIKE @processo");
                    parameters.Add(new SqlParameter("@processo", "%" + processo + "%"));
                }

                if (whereConditions.Count > 0)
                {
                    sql += " AND " + string.Join(" AND ", whereConditions);
                }

                sql += " ORDER BY L.Data DESC";

                return banco.ExecutarConsulta(sql, parameters.ToArray());
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar relatório de lavanderia", ex);
                return new DataTable();
            }
        }

        public Lavanderia BuscarLavanderiaPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM Lavanderia WHERE Id = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateLavanderiaFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar lavanderia por ID", ex);
                return null;
            }
        }

        public List<Lavanderia> ListarLavanderias(DateTime? dataEntrada = null, DateTime? dataSaida = null)
        {
            try
            {
                // Definindo a data inicial padrão para os últimos 31 dias, caso não seja especificada
                if (dataEntrada == null || dataSaida == null)
                {
                    dataEntrada = DateTime.Now.AddDays(-31).Date; // Considera apenas a data, sem o horário
                    dataSaida = DateTime.Now.Date; // Considera apenas a data, sem o horário
                }

                string sql = "SELECT Lavanderia.*, Funcionarios.Nome AS FuncionarioNome " +
                             "FROM Lavanderia " +
                             "INNER JOIN Funcionarios ON Lavanderia.FuncionarioID = Funcionarios.Id " +
                             "WHERE 1=1 ";

                // Adicionando a condição de data, se fornecida
                if (dataEntrada != null && dataSaida != null)
                {
                    sql += "AND Lavanderia.Data >= @DataEntrada AND Lavanderia.Data < DATEADD(day, 1, @DataSaida) ";
                }

                sql += "ORDER BY Lavanderia.Id DESC";

                SqlCommand command = new SqlCommand(sql, banco.Abrir());

                // Definindo os parâmetros de data, se fornecidos
                if (dataEntrada != null && dataSaida != null)
                {
                    command.Parameters.AddWithValue("@DataEntrada", dataEntrada);
                    command.Parameters.AddWithValue("@DataSaida", dataSaida);
                }

                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                return CreateLavanderiasListFromDataTable(dataTable);
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao listar lavanderias", ex);
                return new List<Lavanderia>();
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar lavanderias", ex);
                return new List<Lavanderia>();
            }
        }

        private Lavanderia CreateLavanderiaFromDataRow(DataRow row)
        {
            int funcionarioId = Convert.ToInt32(row["FuncionarioId"]);
            Funcionario funcionario = aCTLFuncionarios.BuscarFuncionarioPorId(funcionarioId);

            int itensLavanderiaId = Convert.ToInt32(row["ItensLavanderiaId"]);
            ItensLavanderia itensLavanderia = aCTlItensLavanderia.BuscarItensLavanderiaPorId(itensLavanderiaId);

            return new Lavanderia
            {
                Id = Convert.ToInt32(row["Id"]),
                Data = Convert.ToDateTime(row["Data"]),
                Peso = Convert.ToDecimal(row["Peso"]),
                Processo = row["Processo"].ToString(),
                Funcionario = funcionario,
                ItensLavanderia = itensLavanderia,
            };
        }

        private List<Lavanderia> CreateLavanderiasListFromDataTable(DataTable dataTable)
        {
            List<Lavanderia> lavanderias = new List<Lavanderia>();
            foreach (DataRow row in dataTable.Rows)
            {
                lavanderias.Add(CreateLavanderiaFromDataRow(row));
            }
            return lavanderias;
        }
        public List<Lavanderia> PesquisarLavanderiasPorCriterio(string criterio, string valorPesquisa)
        {
            try
            {
                string query;
                SqlParameter parametro;

                var criterios = new Dictionary<string, string>
                {
                    { "ID", "SELECT Lavanderia.*, Funcionarios.Nome AS FuncionarioNome, ItensLavanderia.Nome AS ItemNome FROM Lavanderia INNER JOIN Funcionarios ON Lavanderia.FuncionarioID = Funcionarios.Id INNER JOIN ItensLavanderia ON Lavanderia.ItensLavanderiaID = ItensLavanderia.ID WHERE Lavanderia.Id = @Id" },
                    { "Processo", "SELECT Lavanderia.*, Funcionarios.Nome AS FuncionarioNome, ItensLavanderia.Nome AS ItemNome FROM Lavanderia INNER JOIN Funcionarios ON Lavanderia.FuncionarioID = Funcionarios.Id INNER JOIN ItensLavanderia ON Lavanderia.ItensLavanderiaID = ItensLavanderia.ID WHERE Lavanderia.Processo LIKE @ValorPesquisa" },
                    { "Item", "SELECT Lavanderia.*, Funcionarios.Nome AS FuncionarioNome, ItensLavanderia.Nome AS ItemNome FROM Lavanderia INNER JOIN Funcionarios ON Lavanderia.FuncionarioID = Funcionarios.Id INNER JOIN ItensLavanderia ON Lavanderia.ItensLavanderiaID = ItensLavanderia.ID WHERE ItensLavanderia.Nome LIKE @ValorPesquisa" },
                    { "Funcionario", "SELECT Lavanderia.*, Funcionarios.Nome AS FuncionarioNome, ItensLavanderia.Nome AS ItemNome FROM Lavanderia INNER JOIN Funcionarios ON Lavanderia.FuncionarioID = Funcionarios.Id INNER JOIN ItensLavanderia ON Lavanderia.ItensLavanderiaID = ItensLavanderia.ID WHERE Funcionarios.Nome LIKE @ValorPesquisa" }
                };

                if (criterio == "ID" && int.TryParse(valorPesquisa, out int id))
                {
                    query = criterios["ID"];
                    parametro = new SqlParameter("@Id", id);
                }
                else if (criterios.ContainsKey(criterio))
                {
                    query = criterios[criterio];
                    parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
                }
                else
                {
                    return new List<Lavanderia>();
                }

                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });
                return CreateLavanderiasListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException($"Erro ao pesquisar lavanderias por {criterio.ToLower()}", ex);
                return new List<Lavanderia>();
            }
        }
    }
}
