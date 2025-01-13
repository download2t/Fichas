using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Classes;
using test.Model;
using test.Data.Model;

namespace test.Data
{
    public class DALCategoria
    {
        private Banco banco = new Banco();
        Operacao operacao = new Operacao();

        public void AdicionarCategoria(Categoria categoria)
        {
            try
            {
                string sql = "INSERT INTO Categorias (Nome) VALUES (@Nome)";
                SqlParameter[] parametros = { new SqlParameter("@Nome", categoria.Nome) };
                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar categoria", ex);
            }

        }
        public void AtualizarCategoria(Categoria categoria)
        {
            try
            {
                string sql = "UPDATE Categorias SET Nome = @Nome WHERE Id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", categoria.Nome),
                    new SqlParameter("@Id", categoria.Id)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar categoria", ex);
            }
        }
        public Categoria BuscarCategoriaPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM Categorias WHERE Id = @Id AND Senha IS NULL";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new Categoria
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Nome = row["Nome"].ToString()
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar categoria por ID", ex);
                return null;
            }
        }
        public Categoria BuscarCategoriaPorIdDeSenhas(int id)
        {
            try
            {
                string query = "SELECT * FROM Categorias WHERE Id = @Id AND Senha <> ''";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new Categoria
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Nome = row["Nome"].ToString()
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar categoria por ID", ex);
                return null;
            }
        }
        public List<Categoria> BuscarCategoriaPorNome(string valorPesquisa)
        {
            try
            {
                string query = "SELECT * FROM Categorias WHERE Nome LIKE @ValorPesquisa AND Senha IS NULL";
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                List<Categoria> categorias = new List<Categoria>();
                foreach (DataRow row in dataTable.Rows)
                {
                    categorias.Add(new Categoria
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Nome = row["Nome"].ToString()
                    });
                }

                return categorias;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar categorias por nome", ex);
                return new List<Categoria>();
            }
        }
        public List<Categoria> ListarCategorias()
        {
            try
            {
                string sql = "SELECT * FROM Categorias WHERE Senha IS NULL ORDER BY Id DESC";
                DataTable dataTable = banco.ExecutarConsulta(sql, null);

                List<Categoria> categorias = new List<Categoria>();
                foreach (DataRow row in dataTable.Rows)
                {
                    categorias.Add(new Categoria
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Nome = row["Nome"].ToString()
                    });
                }

                return categorias;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar categorias", ex);
                return new List<Categoria>();
            }
        }


        public bool ExcluirCategoria(int categoriaId)
        {
            try
            {
                string sql = "DELETE FROM Categorias WHERE Id = @Id";
                SqlParameter[] parametros = { new SqlParameter("@Id", categoriaId) };
                banco.ExecutarComando(sql, parametros);
                return true;
            }
            catch (SqlException ex)
            {

                if (operacao.IsForeignKeyViolation(ex))
                {
                    MessageBox.Show("Não foi possível excluir a categoria selecionada, pois ela está sendo utilizada em outros registros." +
                        " Por favor, remova todas as referências desta categoria em outros registros antes de tentar excluí-la novamente.");
                }
                else
                {
                    // Outro tratamento de exceção, se necessário
                    operacao.HandleException("Erro ao excluir categoria", ex);
                }
                return false;
            }
        }


        public void AdicionarCategoriaDeSenhas(Categoria categoria)
        {
            try
            {
                string sql = "INSERT INTO Categorias (Nome, Senha) VALUES (@Nome, @Senha)";

                // Definição correta dos parâmetros
                SqlParameter[] parametros = {
            new SqlParameter("@Nome", categoria.Nome),
            new SqlParameter("@Senha",categoria.Senha) // Convertendo para DBNull se categoria.Senha for nulo
        };

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar categoria", ex);
            }
        }
        public void AtualizarCategoriaDeSenha(Categoria categoria)
        {
            try
            {
                string sql = "UPDATE Categorias SET Nome = @Nome, Senha = @Senha WHERE Id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", categoria.Nome),
                    new SqlParameter("@Senha",categoria.Senha),
                    new SqlParameter("@Id", categoria.Id)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar categoria", ex);
            }
        }
        public List<Categoria> BuscarCategoriaPorNomeDeSenhas(string valorPesquisa)
        {
            try
            {
                string query = "SELECT * FROM Categorias WHERE Nome LIKE @ValorPesquisa AND Senha <> ''";
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                List<Categoria> categorias = new List<Categoria>();
                foreach (DataRow row in dataTable.Rows)
                {
                    categorias.Add(new Categoria
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Nome = row["Nome"].ToString()
                    });
                }

                return categorias;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar categorias por nome", ex);
                return new List<Categoria>();
            }
        }
        public List<Categoria> ListarCategoriasDeSenhas()
        {
            try
            {
                string sql = "SELECT * FROM Categorias WHERE Senha IS NOT NULL AND Senha <> '' ORDER BY Id DESC";
                DataTable dataTable = banco.ExecutarConsulta(sql, null);

                List<Categoria> categorias = new List<Categoria>();
                foreach (DataRow row in dataTable.Rows)
                {
                    categorias.Add(new Categoria
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Nome = row["Nome"].ToString()
                    });
                }

                return categorias;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar categorias com senha", ex);
                return new List<Categoria>();
            }
        }
       
 



    }
}
