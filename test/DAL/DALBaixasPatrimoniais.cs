using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Data.Model;
using test.Data;

namespace test.DAL
{
    public class DALBaixasPatrimoniais
    {
        private Banco banco = new Banco();
        CTLSubCategorias subaCTLCategorias;
        CTLSetores aCTLSetores;
        Operacao operacao = new Operacao();
        public void DarBaixaNoPatrimonio(Patrimonios patrimonio)
        {
            try
            {
                string sql = "UPDATE Patrimonios SET Valor = @Valor,  Baixa = @Baixa " +
                             "WHERE Id = @Id";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Valor", patrimonio.Valor),
                    new SqlParameter("@Baixa", patrimonio.Baixa),
                    new SqlParameter("@Id", patrimonio.Id)
            };

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar patrimônio", ex);
            }
        }
        public void AtualizarBaixaPatrimonio(Patrimonios patrimonio)
        {
            DALPatrimonios aDALPatrimonios = new DALPatrimonios();
            byte[] foto = aDALPatrimonios.GetFoto(patrimonio.CaminhoFoto);
            try
            {
                string sql = "UPDATE Patrimonios " +
                             "SET Patrimonio = @Patrimonio, Descricao = @Descricao, Valor = @Valor, " +
                             "SetorId = @SetorId, SubcategoriaId = @SubcategoriaId, Foto = @Foto " +
                            "WHERE Id = @Id AND Baixa = 'SIM'";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Patrimonio", patrimonio.Patrimonio),
                    new SqlParameter("@Descricao", patrimonio.Descricao),
                    new SqlParameter("@Valor", patrimonio.Valor),
                    new SqlParameter("@SetorId", patrimonio.Setor.Id),
                    new SqlParameter("@SubcategoriaId", patrimonio.Subcategoria.Id),
                    new SqlParameter("@Id", patrimonio.Id)
                };

                if (foto != null)
                {
                    // Adicione o parâmetro @Foto apenas quando houver uma foto
                    SqlParameter paramFoto = new SqlParameter("@Foto", SqlDbType.Image, foto.Length);
                    paramFoto.Value = foto;
                    parametros = parametros.Concat(new[] { paramFoto }).ToArray();
                }

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar patrimônio", ex);
            }
        }
        public void AtualizarBaixaSemFoto(Patrimonios patrimonio)
        {
            try
            {
                string sql = "UPDATE Patrimonios " +
                             "SET Patrimonio = @Patrimonio, Descricao = @Descricao, Valor = @Valor, " +
                             "SetorId = @SetorId, SubcategoriaId = @SubcategoriaId " +
                              "WHERE Id = @Id AND Baixa = 'SIM'";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Patrimonio", patrimonio.Patrimonio),
                    new SqlParameter("@Descricao", patrimonio.Descricao),
                    new SqlParameter("@Valor", patrimonio.Valor),
                    new SqlParameter("@SetorId", patrimonio.Setor.Id),
                    new SqlParameter("@SubcategoriaId", patrimonio.Subcategoria.Id),
                    new SqlParameter("@Id", patrimonio.Id)
                };
                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar patrimônio", ex);
            }
        }
        public bool ExcluirPatrimonio(int patrimonioId)
        {
            try
            {
                string sql = "DELETE FROM Patrimonios WHERE Id = @Id";
                SqlParameter[] parametros = { new SqlParameter("@Id", patrimonioId) };
                banco.ExecutarComando(sql, parametros);
                return true; // Retorne true para indicar sucesso
            }
            catch (SqlException ex)
            {
                Operacao operacao = new Operacao();
                if (operacao.IsForeignKeyViolation(ex))
                {
                    // Trate a violação de chave estrangeira (se aplicável) ou outra exceção específica
                    MessageBox.Show("Não foi possível excluir o patrimônio selecionado devido a referências em outros registros.");
                }
                else
                {
                    // Trate outras exceções do SQL Server, se necessário
                    operacao.HandleException("Erro ao excluir patrimônio", ex);
                }
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                // Trate outras exceções genéricas, se aplicável
                operacao.HandleException("Erro ao excluir patrimônio", ex);
                return false; // Retorne false para indicar falha
            }
        }
        public Patrimonios BuscarBaixaPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM Patrimonios WHERE Id = @Id and Baixa = 'SIM'";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });
                aCTLSetores = new CTLSetores();
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];

                    int setorId = Convert.ToInt32(row["SetorId"]);
                    Setores setor = aCTLSetores.BuscarSetorPorId(setorId);

                    int subcategoriaId = Convert.ToInt32(row["SubcategoriaId"]);
                    Subcategoria subcategoria = subaCTLCategorias.BuscarSubcategoriaPorId(subcategoriaId);

                    byte[] foto = row["Foto"] as byte[]; // Trate possíveis valores nulos

                    return new Patrimonios
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Patrimonio = row["Patrimonio"].ToString(),
                        Descricao = row["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(row["Valor"]),
                        Setor = setor,
                        Subcategoria = subcategoria,
                        Foto = foto, // Atribua o valor tratado
                        Baixa = row["Baixa"].ToString(),
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar patrimônio por ID", ex);
                return null;
            }
        }
        public List<Patrimonios> ListarBaixasDePatrimonios()
        {
            try
            {
                string sql = "SELECT * FROM Patrimonios WHERE Baixa = 'SIM'";
                DataTable dataTable = banco.ExecutarConsulta(sql, null);
                aCTLSetores = new CTLSetores();
                subaCTLCategorias = new CTLSubCategorias();
                List<Patrimonios> patrimonios = new List<Patrimonios>();

                foreach (DataRow row in dataTable.Rows)
                {
                    int setorId = Convert.ToInt32(row["SetorId"]);
                    Setores setor = aCTLSetores.BuscarSetorPorId(setorId);

                    int subcategoriaId = Convert.ToInt32(row["SubcategoriaId"]);
                    Subcategoria subcategoria = subaCTLCategorias.BuscarSubcategoriaPorId(subcategoriaId);

                    byte[] fotoBytes = row["Foto"] as byte[]; // Obtém os bytes da foto

                    patrimonios.Add(new Patrimonios
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Patrimonio = row["Patrimonio"].ToString(),
                        Descricao = row["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(row["Valor"]),
                        Setor = setor,
                        Subcategoria = subcategoria,
                        Foto = fotoBytes,
                        Baixa = row["Baixa"].ToString(),
                    });
                }

                return patrimonios;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar patrimônios", ex);
                return new List<Patrimonios>();
            }
        }
        public List<Patrimonios> PesquisarBaixasPatrimoniosPorCriterio(string criterio, string valorPesquisa)
        {
            List<Patrimonios> patrimoniosEncontrados = new List<Patrimonios>();

            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    string query = string.Empty;
                    SqlCommand command = new SqlCommand();

                    if (criterio == "ID" && int.TryParse(valorPesquisa, out int id))
                    {
                        query = "SELECT * FROM Patrimonios WHERE Id = @ValorPesquisa AND Baixa = 'SIM'";
                        command.Parameters.AddWithValue("@ValorPesquisa", id);
                    }
                    else if (criterio == "Setor")
                    {
                        query = "SELECT * FROM Patrimonios WHERE SetorId IN (SELECT Id FROM Setores WHERE Setor LIKE @ValorPesquisa) AND Baixa = 'SIM'";
                        command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");
                    }
                    else if (criterio == "Categoria")
                    {
                        query = "SELECT * FROM Patrimonios WHERE SubcategoriaId IN (SELECT Id FROM SubCategoria WHERE CategoriaId IN (SELECT Id FROM Categorias WHERE Nome LIKE @ValorPesquisa)) AND Baixa = 'SIM'";
                        command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");
                    }
                    else if (criterio == "SubCategoria")
                    {
                        query = "SELECT * FROM Patrimonios WHERE SubcategoriaId IN (SELECT Id FROM SubCategoria WHERE Nome LIKE @ValorPesquisa) AND Baixa = 'SIM'";
                        command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");
                    }
                    else if (criterio == "Patrimonio")
                    {
                        query = "SELECT * FROM Patrimonios WHERE Patrimonio LIKE @ValorPesquisa AND Baixa = 'SIM'";
                        command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");
                    }

                    command.CommandText = query;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patrimonios patrimonio = new Patrimonios
                            {
                                Id = (int)reader["Id"],
                                Patrimonio = (string)reader["Patrimonio"],
                                Descricao = (string)reader["Descricao"],
                                Valor = (decimal)reader["Valor"],
                                Setor = aCTLSetores.BuscarSetorPorId((int)reader["SetorId"]),
                                Subcategoria = subaCTLCategorias.BuscarSubcategoriaPorId((int)reader["SubcategoriaId"]),
                                Foto = reader["Foto"] as byte[],
                                Baixa = (string)reader["Baixa"],
                            };
                            patrimoniosEncontrados.Add(patrimonio);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Pesquisar patrimônios por critério", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Pesquisar patrimônios por critério", ex);
            }

            return patrimoniosEncontrados;
        }



    }
}
