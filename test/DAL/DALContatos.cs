using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using test.Classes;
using test.Model;
using test.Data.Model;

namespace test.Data
{
    public class DALContatos
    {
        private Banco banco = new Banco();
        Operacao operacao = new Operacao();

        public void AdicionarContato(Contatos contato)
        {
            try
            {
                string sql = "INSERT INTO Contatos (Nome, Numero) VALUES (@Nome, @Numero)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", contato.Nome),
                    new SqlParameter("@Numero", contato.Numero)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar contato", ex);
            }
        }

        public void AtualizarContato(Contatos contato)
        {
            try
            {
                string sql = "UPDATE Contatos SET Nome = @Nome, Numero = @Numero WHERE Id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", contato.Nome),
                    new SqlParameter("@Numero", contato.Numero),
                    new SqlParameter("@Id", contato.Id)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar contato", ex);
            }
        }

        public bool ExcluirContato(int contatoId)
        {
            try
            {
                string sql = "DELETE FROM Contatos WHERE Id = @Id";
                SqlParameter parametro = new SqlParameter("@Id", contatoId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true; // Retorne true para indicar sucesso
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir contato", ex);
                return false; // Retorne false para indicar falha
            }
        }

        public Contatos BuscarContatoPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM Contatos WHERE Id = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateContatoFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar contato por ID", ex);
                return null;
            }
        }

        public List<Contatos> ListarContatos()
        {
            try
            {
                string sql = "SELECT * FROM Contatos Order By Id Desc";
                DataTable dataTable = banco.ExecutarConsulta(sql, null);
                return CreateContatosListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar contatos", ex);
                return new List<Contatos>();
            }
        }

        private Contatos CreateContatoFromDataRow(DataRow row)
        {
            return new Contatos
            {
                Id = Convert.ToInt32(row["Id"]),
                Nome = row["Nome"].ToString(),
                Numero = row["Numero"].ToString()
            };
        }

        private List<Contatos> CreateContatosListFromDataTable(DataTable dataTable)
        {
            List<Contatos> contatos = new List<Contatos>();
            foreach (DataRow row in dataTable.Rows)
            {
                contatos.Add(CreateContatoFromDataRow(row));
            }
            return contatos;
        }
        public List<Contatos> PesquisarContatosPorCriterio(string criterio, string valorPesquisa)
        {
            List<Contatos> contatosEncontrados = new List<Contatos>();

            try
            {
                string query = string.Empty;
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");

                // Verificando o critério de pesquisa
                if (criterio == "Nome")
                {
                    query = "SELECT * FROM Contatos WHERE Nome LIKE @ValorPesquisa";
                }
                else if (criterio == "Numero")
                {
                    query = "SELECT * FROM Contatos WHERE Numero LIKE @ValorPesquisa";
                }
                else if (criterio == "ID")
                {
                    query = "SELECT * FROM Contatos WHERE ID LIKE @ValorPesquisa";
                }
                // Outros critérios podem ser adicionados conforme necessário

                // Executar a consulta e preencher a lista de contatos encontrados
                if (!string.IsNullOrEmpty(query))
                {
                    DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Contatos contato = CreateContatoFromDataRow(row);
                        contatosEncontrados.Add(contato);
                    }
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar contato", ex);
                return null;
            }

            return contatosEncontrados;
        }
    }
}
