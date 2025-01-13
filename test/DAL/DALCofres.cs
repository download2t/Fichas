using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using test.Classes;
using test.Data.Model;
using test.Model;

namespace test.Data
{
    internal class DALCofres
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();

        public void AdicionarCofre(Cofres cofre)
        {
            try
            {
                string sql = "INSERT INTO Cofres (CodChave, Quarto) VALUES (@CodChave, @Quarto)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@CodChave", cofre.CodChave),
                    new SqlParameter("@Quarto", cofre.Quarto)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar cofre", ex);
            }
        }

        public void AtualizarCofre(Cofres cofre)
        {
            try
            {
                string sql = "UPDATE Cofres SET CodChave = @CodChave, Quarto = @Quarto WHERE CodCofres = @CodCofres";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@CodChave", cofre.CodChave),
                    new SqlParameter("@Quarto", cofre.Quarto),
                    new SqlParameter("@CodCofres", cofre.CodCofres)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar cofre", ex);
            }
        }

        public void ExcluirCofre(int codCofres)
        {
            try
            {
                string sql = "DELETE FROM Cofres WHERE CodCofres = @CodCofres";
                SqlParameter parametro = new SqlParameter("@CodCofres", codCofres);
                banco.ExecutarComando(sql, new[] { parametro });
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir cofre", ex);
            }
        }

        public Cofres BuscarCofrePorId(int codCofres)
        {
            try
            {
                string query = "SELECT * FROM Cofres WHERE CodCofres = @CodCofres";
                SqlParameter parametro = new SqlParameter("@CodCofres", codCofres);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateCofreFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar cofre por ID", ex);
                return null;
            }
        }
        public List<Cofres> PesquisarCofres(string valor)
        {
            try
            {
                string sql = @"
                        SELECT * FROM Cofres 
                        WHERE CAST(codCofres AS NVARCHAR) LIKE @valor 
                        OR CodChave LIKE @valor 
                        OR Quarto LIKE @valor";

                SqlParameter[] parametros = new SqlParameter[]
                {
                        new SqlParameter("@valor", "%" + valor + "%")
                };

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);
                return CreateCofresListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao pesquisar cofres", ex);
                return new List<Cofres>();
            }
        }



        public List<Cofres> ListarCofres()
        {
            try
            {
                string sql = "SELECT * FROM Cofres";
                DataTable dataTable = banco.ExecutarConsulta(sql, null);
                return CreateCofresListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar cofres", ex);
                return new List<Cofres>();
            }
        }

        private Cofres CreateCofreFromDataRow(DataRow row)
        {
            return new Cofres
            {
                CodCofres = Convert.ToInt32(row["CodCofres"]),
                CodChave = Convert.ToInt32(row["CodChave"]),
                Quarto = Convert.ToInt32(row["Quarto"])
            };
        }

        private List<Cofres> CreateCofresListFromDataTable(DataTable dataTable)
        {
            List<Cofres> cofres = new List<Cofres>();
            foreach (DataRow row in dataTable.Rows)
            {
                cofres.Add(CreateCofreFromDataRow(row));
            }
            return cofres;
        }
    }
}
