using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Classes;
using test.Data.Model;
using test.Model;

namespace test.Data
{
    public class DALItensLavanderia
    {
        private Banco banco = new Banco();
        Operacao operacao = new Operacao();

        public void AdicionarItemLavanderia(ItensLavanderia item)
        {
            try
            {
                string sql = "INSERT INTO ItensLavanderia (Nome) VALUES (@Nome)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", item.Nome)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar item de lavanderia", ex);
            }
        }

        public void AtualizarItemLavanderia(ItensLavanderia item)
        {
            try
            {
                string sql = "UPDATE ItensLavanderia SET Nome = @Nome WHERE Id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", item.Nome),
                    new SqlParameter("@Id", item.Id)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar item de lavanderia", ex);
            }
        }

        public bool ExcluirItemLavanderia(int itemId)
        {
            try
            {
                string sql = "DELETE FROM ItensLavanderia WHERE Id = @Id";
                SqlParameter parametro = new SqlParameter("@Id", itemId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true; // Retorne true para indicar sucesso
            }
            catch (SqlException ex)
            {
                if (operacao.IsForeignKeyViolation(ex))
                {
                    MessageBox.Show("Não foi possível excluir o item de lavanderia selecionado, pois ele está sendo utilizado em outros registros." +
                                    " Por favor, remova todas as referências deste item em outros registros antes de tentar excluí-lo novamente.");
                }
                else
                {
                    operacao.HandleException("Erro ao excluir item de lavanderia", ex);
                }
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir item de lavanderia", ex);
                return false; // Retorne false para indicar falha
            }
        }

        public ItensLavanderia BuscarItemLavanderiaPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM ItensLavanderia WHERE Id = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateItemLavanderiaFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar item de lavanderia por ID", ex);
                return null;
            }
        }

        public List<ItensLavanderia> ListarItensLavanderia()
        {
            try
            {
                string sql = "SELECT * FROM ItensLavanderia ORDER BY Id DESC";
                DataTable dataTable = banco.ExecutarConsulta(sql,null);

                List<ItensLavanderia> itensLavanderia = new List<ItensLavanderia>();

                foreach (DataRow row in dataTable.Rows)
                {
                    ItensLavanderia item = CreateItemLavanderiaFromDataRow(row);
                    itensLavanderia.Add(item);
                }

                return itensLavanderia;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar itens de lavanderia", ex);
                return new List<ItensLavanderia>();
            }
        }

        private ItensLavanderia CreateItemLavanderiaFromDataRow(DataRow row)
        {
            return new ItensLavanderia
            {
                Id = Convert.ToInt32(row["Id"]),
                Nome = row["Nome"].ToString()
            };
        }

        private List<ItensLavanderia> CreateItensLavanderiaListFromDataTable(DataTable dataTable)
        {
            List<ItensLavanderia> itensLavanderia = new List<ItensLavanderia>();
            foreach (DataRow row in dataTable.Rows)
            {
                itensLavanderia.Add(CreateItemLavanderiaFromDataRow(row));
            }
            return itensLavanderia;
        }

        public List<ItensLavanderia> PesquisarItensLavanderiaPorCriterio(string criterio, string valorPesquisa)
        {
            try
            {
                string query = string.Empty;
                SqlParameter parametro;

                if (criterio == "ID" && int.TryParse(valorPesquisa, out int id))
                {
                    query = "SELECT * FROM ItensLavanderia WHERE Id = @Id";
                    parametro = new SqlParameter("@Id", id);
                }
                else if (criterio == "NOME")
                {
                    query = "SELECT * FROM ItensLavanderia WHERE Nome LIKE @ValorPesquisa";
                    parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
                }
                else
                {
                    return new List<ItensLavanderia>();
                }

                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });
                return CreateItensLavanderiaListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException($"Erro ao pesquisar itens de lavanderia por {criterio.ToLower()}", ex);
                return new List<ItensLavanderia>();
            }
        }
    }
}
