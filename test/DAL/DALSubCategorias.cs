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
    public class DALSubCategorias
    {
        private Banco banco = new Banco();
        private CTLCategorias aCTLCategorias;
        private Operacao operacao = new Operacao();

        public DALSubCategorias()
        {
            aCTLCategorias = new CTLCategorias();
        }
        public void AdicionarSubcategoria(Subcategoria subcategoria)
        {
            try
            {
                string sql = "INSERT INTO Subcategoria (Nome, CategoriaId) " +
                             "VALUES (@Nome, @CategoriaId)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", subcategoria.Nome),
                    new SqlParameter("@CategoriaId", subcategoria.Categoria.Id)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (SqlException ex)
            {
                operacao.HandleException("adicionar a subcategoria", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("adicionar a subcategoria", ex);
            }
        }

        public void AtualizarSubcategoria(Subcategoria subcategoria)
        {
            try
            {
                string sql = "UPDATE Subcategoria SET Nome = @Nome, CategoriaId = @CategoriaId WHERE Id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", subcategoria.Nome),
                    new SqlParameter("@CategoriaId", subcategoria.Categoria.Id),
                    new SqlParameter("@Id", subcategoria.Id)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (SqlException ex)
            {
                operacao.HandleException("atualizar a subcategoria", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("atualizar a subcategoria", ex);
            }
        }

        public bool ExcluirSubcategoria(int subcategoriaId)
        {
            try
            {
                string sql = "DELETE FROM Subcategoria WHERE Id = @Id";
                SqlParameter[] parametros = { new SqlParameter("@Id", subcategoriaId) };
                banco.ExecutarComando(sql, parametros);
                return true; // Retorne true para indicar sucesso
            }
            catch (SqlException ex)
            {
                Operacao operacao = new Operacao();
                if (operacao.IsForeignKeyViolation(ex))
                {
                    // Trate a violação de chave estrangeira (se aplicável) ou outra exceção específica
                    MessageBox.Show("Não foi possível excluir a subcategoria selecionada devido a referências em outros registros.");
                }
                else
                {
                    // Trate outras exceções do SQL Server, se necessário
                    operacao.HandleException("Erro ao excluir a subcategoria", ex);
                }
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                // Trate outras exceções genéricas, se aplicável
                operacao.HandleException("Erro ao excluir a subcategoria", ex);
                return false; // Retorne false para indicar falha
            }
        }
        public List<Subcategoria> PesquisarSubcategoriasPorCriterio(string criterio, string valorPesquisa)
        {
            try
            {
                string query = "SELECT * FROM SubCategoria WHERE ";
                List<SqlParameter> parametros = new List<SqlParameter>();

                if (criterio == "ID" && int.TryParse(valorPesquisa, out int id))
                {
                    query += "Id = @ValorPesquisa";
                    parametros.Add(new SqlParameter("@ValorPesquisa", id));
                }
                else
                {
                    query += "Nome LIKE @ValorPesquisa";
                    parametros.Add(new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%"));
                }

                DataTable dataTable = banco.ExecutarConsulta(query, parametros.ToArray());

                List<Subcategoria> subcategorias = new List<Subcategoria>();
                foreach (DataRow row in dataTable.Rows)
                {
                    int categoriaId = Convert.ToInt32(row["CategoriaID"]);
                    Categoria categoria = aCTLCategorias.BuscarCategoriaPorId(categoriaId);

                    if (categoria != null)
                    {
                        subcategorias.Add(new Subcategoria
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Categoria = categoria,
                            Nome = row["Nome"].ToString()
                        });
                    }
                }

                return subcategorias;
            }
            catch (Exception ex)
            {
                operacao.HandleException($"Erro ao buscar subcategorias por {criterio.ToLower()}", ex);
                return new List<Subcategoria>();
            }
        }


        public Subcategoria BuscarSubcategoriaPorId(int id)
        {
            try
            {
                Subcategoria subcategoria = null;
                using (SqlConnection connection = banco.Abrir())
                {
                    string query = "SELECT sc.*, c.Nome as CategoriaNome FROM Subcategoria sc " +
                                   "INNER JOIN Categorias c ON sc.CategoriaId = c.Id " +
                                   "WHERE sc.Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            subcategoria = new Subcategoria
                            {
                                Id = (int)reader["Id"],
                                Nome = (string)reader["Nome"],
                                Categoria = new Categoria
                                {
                                    Id = (int)reader["CategoriaId"],
                                    Nome = (string)reader["CategoriaNome"]
                                }
                            };
                        }
                    }
                }

                return subcategoria;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("buscar a subcategoria por ID", ex);
                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("buscar a subcategoria por ID", ex);
                return null;
            }
        }
        public List<Subcategoria> ListarSubcategoriasPorIDCategoria(int? categoriaId)
        {
            try
            {
                List<Subcategoria> subcategorias = new List<Subcategoria>();
                using (SqlConnection connection = banco.Abrir())
                {
                    string sql = "SELECT * FROM Subcategoria";

                    if (categoriaId > 0)
                    {
                        sql += " WHERE CategoriaId = @CategoriaId";
                    }

                    SqlCommand command = new SqlCommand(sql, connection);

                    if (categoriaId > 0)
                    {
                        command.Parameters.AddWithValue("@CategoriaId", categoriaId);
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Subcategoria subcategoria = new Subcategoria
                        {
                            Id = (int)reader["Id"],
                            Categoria = aCTLCategorias.BuscarCategoriaPorId((int)reader["CategoriaId"]),
                            Nome = (string)reader["Nome"],
                        };
                        subcategorias.Add(subcategoria);
                    }
                }

                return subcategorias;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("listar as subcategorias", ex);
                return new List<Subcategoria>();
            }
            catch (Exception ex)
            {
                operacao.HandleException("listar as subcategorias", ex);
                return new List<Subcategoria>();
            }
        }
        public List<Subcategoria> ListarSubcategorias()
        {
            try
            {
                List<Subcategoria> subcategorias = new List<Subcategoria>();
                using (SqlConnection connection = banco.Abrir())
                {
                    string sql = "SELECT * FROM Subcategoria Order By Id Desc";

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Subcategoria subcategoria = new Subcategoria
                        {
                            Id = (int)reader["Id"],
                            Categoria = aCTLCategorias.BuscarCategoriaPorId((int)reader["CategoriaId"]),
                            Nome = (string)reader["Nome"],
                        };
                        subcategorias.Add(subcategoria);
                    }
                }

                return subcategorias;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("listar as subcategorias", ex);
                return new List<Subcategoria>();
            }
            catch (Exception ex)
            {
                operacao.HandleException("listar as subcategorias", ex);
                return new List<Subcategoria>();
            }
        }

    }
}
