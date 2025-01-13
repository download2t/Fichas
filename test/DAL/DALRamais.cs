using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Controle.Models;
using test.Controllers;
using test.Data.Model;
using test.Model;

namespace Controle.DAL
{
    internal class DALRamais
    {
        private Banco banco = new Banco();
        private Operacao operacao;

        public DALRamais()
        {
            operacao = new Operacao();
        }

        public bool AdicionarRamal(Ramal ramal)
        {
            try
            {
                string sql = "INSERT INTO Ramais (Ramal, Linha, CodSetor, Nome, Fone) VALUES (@Ramal, @Linha, @CodSetor, @Nome, @Fone)";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Ramal", ramal.NumRamal),
                    new SqlParameter("@Linha", ramal.Linha),
                    new SqlParameter("@CodSetor", ramal.Setor.Id),
                    new SqlParameter("@Nome", ramal.Nome),
                    new SqlParameter("@Fone", ramal.Fone)
                };

                banco.ExecutarComando(sql, parametros);
                return true;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("adicionar o ramal", ex);
                return false;
            }
            catch (Exception ex)
            {
                operacao.HandleException("adicionar o ramal", ex);
                return false;
            }
        }

        public bool AtualizarRamal(Ramal ramal)
        {
            try
            {
                string sql = "UPDATE Ramais SET Ramal = @Ramal, Linha = @Linha, CodSetor = @CodSetor, Nome = @Nome, Fone = @Fone WHERE CodRamal = @CodRamal";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Ramal", ramal.NumRamal),
                    new SqlParameter("@Linha", ramal.Linha),
                    new SqlParameter("@CodSetor", ramal.Setor.Id),
                    new SqlParameter("@Nome", ramal.Nome ?? (object)DBNull.Value),
                    new SqlParameter("@Fone", ramal.Fone ?? (object)DBNull.Value),
                    new SqlParameter("@CodRamal", ramal.Id)
                };

                banco.ExecutarComando(sql, parametros);
                return true;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("atualizar o ramal", ex);
                return false;
            }
            catch (Exception ex)
            {
                operacao.HandleException("atualizar o ramal", ex);
                return false;
            }
        }

        public bool ExcluirRamal(int ramalId)
        {
            try
            {
                string sql = "DELETE FROM Ramais WHERE CodRamal = @CodRamal";
                SqlParameter[] parametros = { new SqlParameter("@CodRamal", ramalId) };
                banco.ExecutarComando(sql, parametros);
                return true;
            }
            catch (SqlException ex)
            {
                if (operacao.IsForeignKeyViolation(ex))
                {
                    MessageBox.Show("Não foi possível excluir o ramal selecionado, pois ele está sendo utilizado em outros registros. " +
                                    "Por favor, remova todas as referências deste ramal em outros registros antes de tentar excluí-lo novamente.");
                }
                else
                {
                    operacao.HandleException("Erro ao excluir o ramal", ex);
                }
                return false;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir o ramal", ex);
                return false;
            }
        }

        public Ramal BuscarRamalPorId(int id)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = banco.Abrir())
                {
                    string query = "SELECT * FROM Ramais WHERE CodRamal = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                if (dataTable.Rows.Count == 0)
                {
                    return null;
                }

                DataRow row = dataTable.Rows[0];
                return CreateRamalFromDataRow(row);
            }
            catch (SqlException ex)
            {
                operacao.HandleException("buscar o ramal por ID", ex);
                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("buscar o ramal por ID", ex);
                return null;
            }
        }

        public List<Ramal> ListarRamais(string pesquisa)
        {
            try
            {
                List<Ramal> ramais = new List<Ramal>();
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = banco.Abrir())
                {
                    string sql = "SELECT * FROM Ramais ORDER BY CodRamal DESC";
                    SqlCommand command = new SqlCommand(sql, connection);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Ramal ramal = CreateRamalFromDataRow(row);
                    ramais.Add(ramal);
                }

                return ramais;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("listar os ramais", ex);
                return new List<Ramal>();
            }
            catch (Exception ex)
            {
                operacao.HandleException("listar os ramais", ex);
                return new List<Ramal>();
            }
        }
        public List<Ramal> PesquisarRamal(string pesquisa)
        {
            try
            {
                List<Ramal> ramais = new List<Ramal>();
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = banco.Abrir())
                {
                    // Prepara a consulta SQL com parâmetros
                    string sql = "SELECT r.*, s.Setor " +
                                 "FROM Ramais r " +
                                 "JOIN Setores s ON r.CodSetor = s.Id " +
                                 "WHERE (r.CodRamal LIKE @Pesquisa OR " +
                                 "r.Nome LIKE @Pesquisa OR " +
                                 "r.Linha LIKE @Pesquisa OR " +
                                 "r.Ramal LIKE @Pesquisa OR " +
                                 "s.Setor LIKE @Pesquisa) " +
                                 "ORDER BY r.CodRamal DESC";

                    SqlCommand command = new SqlCommand(sql, connection);

                    // Usa LIKE para permitir a pesquisa por qualquer parte da string
                    command.Parameters.AddWithValue("@Pesquisa", $"%{pesquisa}%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Ramal ramal = CreateRamalFromDataRow(row);
                    ramais.Add(ramal);
                }

                return ramais;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("listar os ramais", ex);
                return new List<Ramal>();
            }
            catch (Exception ex)
            {
                operacao.HandleException("listar os ramais", ex);
                return new List<Ramal>();
            }
        }


        public List<Ramal> ListarRamais()
        {
            try
            {
                List<Ramal> ramais = new List<Ramal>();
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = banco.Abrir())
                {
                    string sql = "SELECT * FROM Ramais ORDER BY CodRamal DESC";
                    SqlCommand command = new SqlCommand(sql, connection);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Ramal ramal = CreateRamalFromDataRow(row);
                    ramais.Add(ramal);
                }

                return ramais;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("listar os ramais", ex);
                return new List<Ramal>();
            }
            catch (Exception ex)
            {
                operacao.HandleException("listar os ramais", ex);
                return new List<Ramal>();
            }
        }
        private Ramal CreateRamalFromDataRow(DataRow row)
        {
            int setorId = Convert.ToInt32(row["CodSetor"]);
            CTLSetores aCTLSetor = new CTLSetores();
            Setores setor = aCTLSetor.BuscarSetorPorId(setorId); // Supondo que você tenha um método para buscar o setor pelo ID

            return new Ramal
            {
                Id = Convert.ToInt32(row["CodRamal"]),
                NumRamal = row["Ramal"].ToString(),
                Linha = row["Linha"].ToString(),
                Setor = setor,
                Nome = row["Nome"].ToString(),
                Fone = row["Fone"].ToString()
            };
        }
    }
}
