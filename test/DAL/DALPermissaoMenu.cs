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
    public class DALPermissaoMenu
    {
        private Banco banco = new Banco();
        Operacao operacao = new Operacao();
        CTLUsuarios usuarioController = new CTLUsuarios();

        public void SalvarUsuarioEPermissao(PermissaoMenu permissaoMenu, Usuarios usuario)
        {
            using (SqlConnection connection = banco.Abrir())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string verificarExistenciaSql = "SELECT COUNT(*) FROM PermissaoMenu WHERE UsuarioId = @UsuarioId AND MenuOpcaoId = @MenuOpcaoId";
                    SqlParameter[] verificarExistenciaParametros =
                    {
                        new SqlParameter("@UsuarioId", permissaoMenu.Usuario.Id),
                        new SqlParameter("@MenuOpcaoId", permissaoMenu.Opcao.Id)
                    };

                    int count = (int)banco.ExecutarConsulta(verificarExistenciaSql, verificarExistenciaParametros).Rows[0][0];

                    if (count > 0)
                    {
                        // Atualizar permissão de menu
                        string permissaoSql = "UPDATE PermissaoMenu " +
                                              "SET PodeAdicionar = @PodeAdicionar, PodeAlterar = @PodeAlterar, " +
                                              "PodeExcluir = @PodeExcluir, PodeConsultar = @PodeConsultar " +
                                              "WHERE UsuarioId = @UsuarioId AND MenuOpcaoId = @MenuOpcaoId";

                        SqlParameter[] permissaoParametros =
                        {
                            new SqlParameter("@PodeAdicionar", permissaoMenu.PodeAdicionar),
                            new SqlParameter("@PodeAlterar", permissaoMenu.PodeAlterar),
                            new SqlParameter("@PodeExcluir", permissaoMenu.PodeExcluir),
                            new SqlParameter("@PodeConsultar", permissaoMenu.PodeConsultar),
                            new SqlParameter("@UsuarioId", permissaoMenu.Usuario.Id),
                            new SqlParameter("@MenuOpcaoId", permissaoMenu.Opcao.Id)
                        };

                        banco.ExecutarComando(permissaoSql, permissaoParametros);
                    }
                    else
                    {
                        // Inserir nova permissão de menu
                        string novaPermissaoSql = "INSERT INTO PermissaoMenu (UsuarioId, MenuOpcaoId, PodeAdicionar, PodeAlterar, PodeExcluir, PodeConsultar) " +
                                                  "VALUES (@UsuarioId, @MenuOpcaoId, @PodeAdicionar, @PodeAlterar, @PodeExcluir, @PodeConsultar)";

                        SqlParameter[] novaPermissaoParametros =
                        {
                            new SqlParameter("@UsuarioId", permissaoMenu.Usuario.Id),
                            new SqlParameter("@MenuOpcaoId", permissaoMenu.Opcao.Id),
                            new SqlParameter("@PodeAdicionar", permissaoMenu.PodeAdicionar),
                            new SqlParameter("@PodeAlterar", permissaoMenu.PodeAlterar),
                            new SqlParameter("@PodeExcluir", permissaoMenu.PodeExcluir),
                            new SqlParameter("@PodeConsultar", permissaoMenu.PodeConsultar)
                        };

                        banco.ExecutarComando(novaPermissaoSql, novaPermissaoParametros);
                    }

                    // Atualizar usuário
                    string usuarioSql = "UPDATE Usuarios SET Nome = @Nome, Sobrenome = @Sobrenome, " +
                                        "Email = @Email, Senha = @Senha, " +
                                        "Usuario = @Usuario, Perfil = @Perfil, " +
                                        "Status = @Status, DataNascimento = @DataNascimento WHERE Id = @Id";

                    SqlParameter[] usuarioParametros =
                    {
                        new SqlParameter("@Nome", usuario.Nome),
                        new SqlParameter("@Sobrenome", usuario.Sobrenome),
                        new SqlParameter("@Email", usuario.Email),
                        new SqlParameter("@Senha", usuario.Senha),
                        new SqlParameter("@Usuario", usuario.Usuario),
                        new SqlParameter("@Perfil", usuario.Perfil),
                        new SqlParameter("@Status", usuario.Status),
                        new SqlParameter("@DataNascimento", usuario.DataNascimento),
                        new SqlParameter("@Id", usuario.Id)
                    };

                    banco.ExecutarComando(usuarioSql, usuarioParametros);

                    // Se todas as operações foram bem-sucedidas, commit na transação
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Se houver qualquer exceção, rollback na transação para desfazer as alterações
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao salvar as alterações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static bool OpcaoLiberada(string opcao, List<PermissaoMenu> usuarioAcessos, Func<PermissaoMenu, bool> propriedade)
        {
            foreach (var item in usuarioAcessos)
            {
                if (item.Opcao.Nome == opcao)
                {
                    return propriedade(item);
                }
            }
            return false;
        }

        // Métodos específicos chamando o método genérico para verificar diferentes propriedades booleanas
        public bool OpcaoLiberadaAdicionar(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return OpcaoLiberada(opcao, usuarioAcessos, x => x.PodeAdicionar);
        }

        public bool OpcaoLiberadaAlterar(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return OpcaoLiberada(opcao, usuarioAcessos, x => x.PodeAlterar);
        }

        public bool OpcaoLiberadaExcluir(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return OpcaoLiberada(opcao, usuarioAcessos, x => x.PodeExcluir);
        }

        public bool OpcaoLiberadaConsultar(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return OpcaoLiberada(opcao, usuarioAcessos, x => x.PodeConsultar);
        }


        public void AdicionarPermissaoMenu(PermissaoMenu permissaoMenu)
        {
            try
            {
                string sql = "INSERT INTO PermissaoMenu (UsuarioId, MenuOpcaoId, PodeAdicionar, PodeAlterar, PodeExcluir, PodeConsultar) " +
                             "VALUES (@UsuarioId, @MenuOpcaoId, @PodeAdicionar, @PodeAlterar, @PodeExcluir, @PodeConsultar)";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@UsuarioId", permissaoMenu.Usuario.Id),
                    new SqlParameter("@MenuOpcaoId", permissaoMenu.Opcao.Id),
                    new SqlParameter("@PodeAdicionar", permissaoMenu.PodeAdicionar),
                    new SqlParameter("@PodeAlterar", permissaoMenu.PodeAlterar),
                    new SqlParameter("@PodeExcluir", permissaoMenu.PodeExcluir),
                    new SqlParameter("@PodeConsultar", permissaoMenu.PodeConsultar)
                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar permissão de menu", ex);
            }
        }
        public void AtualizarPermissaoMenu(PermissaoMenu permissaoMenu)
        {
            try
            {
                string sql = "UPDATE PermissaoMenu " +
                             "SET PodeAdicionar = @PodeAdicionar, PodeAlterar = @PodeAlterar, " +
                             "PodeExcluir = @PodeExcluir, PodeConsultar = @PodeConsultar " +
                             "WHERE UsuarioId = @UsuarioId AND MenuOpcaoId = @MenuOpcaoId";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@UsuarioId", permissaoMenu.Usuario.Id),
                    new SqlParameter("@MenuOpcaoId", permissaoMenu.Opcao.Id),
                    new SqlParameter("@PodeAdicionar", permissaoMenu.PodeAdicionar),
                    new SqlParameter("@PodeAlterar", permissaoMenu.PodeAlterar),
                    new SqlParameter("@PodeExcluir", permissaoMenu.PodeExcluir),
                    new SqlParameter("@PodeConsultar", permissaoMenu.PodeConsultar)
                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar permissão de menu", ex);
            }
        }
        public void RemoverPermissaoMenu(int usuarioId, int menuOpcaoId)// Não está sendo utilizado.
        {
            try
            {
                string sql = "DELETE FROM PermissaoMenu WHERE UsuarioId = @UsuarioId AND MenuOpcaoId = @MenuOpcaoId";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@UsuarioId", usuarioId),
                    new SqlParameter("@MenuOpcaoId", menuOpcaoId)
                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao remover permissão de menu", ex);
            }
        }
        public PermissaoMenu ObterPermissaoMenu(int usuarioId, int menuOpcaoId)
        {
            try
            {
                string sql = "SELECT * FROM PermissaoMenu WHERE UsuarioId = @UsuarioId AND MenuOpcaoId = @MenuOpcaoId";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@UsuarioId", usuarioId),
                    new SqlParameter("@MenuOpcaoId", menuOpcaoId)
                };

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new PermissaoMenu
                    {
                        Usuario = new Usuarios { Id = Convert.ToInt32(row["UsuarioId"]) },
                        Opcao = new Opcoes { Id = Convert.ToInt32(row["MenuOpcaoId"]) },
                        PodeAdicionar = Convert.ToBoolean(row["PodeAdicionar"]),
                        PodeAlterar = Convert.ToBoolean(row["PodeAlterar"]),
                        PodeExcluir = Convert.ToBoolean(row["PodeExcluir"]),
                        PodeConsultar = Convert.ToBoolean(row["PodeConsultar"])
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao obter permissão de menu", ex);
                return null;
            }
        }
        public List<PermissaoMenu> ObterPermissoesPorUsuario(int usuarioId)
        {
            List<PermissaoMenu> listaPermissoes = new List<PermissaoMenu>();

            try
            {
                // Ajusta a consulta SQL para filtrar permissões do usuário
                string sql = @"
            SELECT mo.id, mo.nome AS nomeOpcao, mo.descricao AS descricaoOpcao, mo.nivel, 
                   pm.PodeAdicionar, pm.PodeAlterar, pm.PodeExcluir, pm.PodeConsultar
            FROM MenuOpcoes mo
            INNER JOIN PermissaoMenu pm ON mo.id = pm.MenuOpcaoId
            WHERE pm.UsuarioId = @UsuarioId
            AND (pm.PodeAdicionar = 1 OR pm.PodeAlterar = 1 OR pm.PodeExcluir = 1 OR pm.PodeConsultar = 1)";

                SqlParameter parametro = new SqlParameter("@UsuarioId", usuarioId);

                DataTable dataTable = banco.ExecutarConsulta(sql, new[] { parametro });

                foreach (DataRow row in dataTable.Rows)
                {
                    PermissaoMenu permissao = new PermissaoMenu
                    {
                        Usuario = new Usuarios { Id = usuarioId },
                        Opcao = new Opcoes
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Nome = Convert.ToString(row["nomeOpcao"]),
                            Descricao = Convert.ToString(row["descricaoOpcao"]),
                            Nivel = Convert.ToByte(row["nivel"])
                        },
                        PodeAdicionar = row["PodeAdicionar"] != DBNull.Value && Convert.ToBoolean(row["PodeAdicionar"]),
                        PodeAlterar = row["PodeAlterar"] != DBNull.Value && Convert.ToBoolean(row["PodeAlterar"]),
                        PodeExcluir = row["PodeExcluir"] != DBNull.Value && Convert.ToBoolean(row["PodeExcluir"]),
                        PodeConsultar = row["PodeConsultar"] != DBNull.Value && Convert.ToBoolean(row["PodeConsultar"])
                    };

                    listaPermissoes.Add(permissao);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao obter permissões do usuário", ex);
            }

            return listaPermissoes;
        }

        public List<PermissaoMenu> ObterPermissoesPorUsuarioAnttigo(int usuarioId)
        {
            List<PermissaoMenu> listaPermissoes = new List<PermissaoMenu>();

            try
            {
                string sql = @"SELECT mo.id, mo.nome AS nomeOpcao, mo.descricao AS descricaoOpcao, mo.nivel, 
               pm.PodeAdicionar, pm.PodeAlterar, pm.PodeExcluir, pm.PodeConsultar
               FROM MenuOpcoes mo
               LEFT JOIN PermissaoMenu pm ON mo.id = pm.MenuOpcaoId AND pm.UsuarioId = @UsuarioId";

                SqlParameter parametro = new SqlParameter("@UsuarioId", usuarioId);

                DataTable dataTable = banco.ExecutarConsulta(sql, new[] { parametro });

                foreach (DataRow row in dataTable.Rows)
                {
                    PermissaoMenu permissao = new PermissaoMenu
                    {
                        Usuario = new Usuarios { Id = usuarioId },
                        Opcao = new Opcoes
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Nome = Convert.ToString(row["nomeOpcao"]),
                            Descricao = Convert.ToString(row["descricaoOpcao"]),
                            Nivel = Convert.ToByte(row["nivel"])
                        },
                        PodeAdicionar = row["PodeAdicionar"] != DBNull.Value && Convert.ToBoolean(row["PodeAdicionar"]),
                        PodeAlterar = row["PodeAlterar"] != DBNull.Value && Convert.ToBoolean(row["PodeAlterar"]),
                        PodeExcluir = row["PodeExcluir"] != DBNull.Value && Convert.ToBoolean(row["PodeExcluir"]),
                        PodeConsultar = row["PodeConsultar"] != DBNull.Value && Convert.ToBoolean(row["PodeConsultar"])
                    };

                    listaPermissoes.Add(permissao);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao obter permissões do usuário", ex);
            }

            return listaPermissoes;
        }
        public List<Opcoes> ObterOpcoesMenuExceto(string tipo)
        {
            List<Opcoes> listaOpcoes = new List<Opcoes>();

            try
            {
                string sql = "";
                if (tipo == "CHEFE")
                {
                    sql = @"SELECT id, nome, descricao, nivel
                            FROM MenuOpcoes
                            WHERE nome NOT IN ('CONFIGURAR MENU', 'USUARIOS DO SISTEMA', 'SENHAS','CATEGORIA DE SENHAS')";
                }
                else if (tipo == "USUARIO")
                {
                    sql = @"SELECT id, nome, descricao, nivel
                            FROM MenuOpcoes
                            WHERE nome NOT IN ('CONFIGURAR MENU', 'USUARIOS DO SISTEMA', 'SENHAS','CATEGORIA DE SENHAS')";
                }

                DataTable dataTable = banco.ExecutarConsulta(sql, null);

                foreach (DataRow row in dataTable.Rows)
                {
                    Opcoes opcao = new Opcoes
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Nome = Convert.ToString(row["nome"]),
                        Descricao = Convert.ToString(row["descricao"]),
                        Nivel = Convert.ToByte(row["nivel"])
                    };

                    listaOpcoes.Add(opcao);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao obter opções de menu", ex);
            }

            return listaOpcoes;
        }
        public bool AdicionaPermissaoDoTipo(string tipo, int usuarioId)
        {
            try
            {
                string sqlMenuOpcoes = "SELECT Id FROM MenuOpcoes WHERE Nome NOT IN ('CONFIGURAR MENU', 'USUARIOS DO SISTEMA', 'SENHAS', 'CATEGORIA DE SENHAS')";
                List<int> opcoesIds = new List<int>();

                DataTable dataTable = banco.ExecutarConsulta(sqlMenuOpcoes, null);

                foreach (DataRow row in dataTable.Rows)
                {
                    opcoesIds.Add(Convert.ToInt32(row["Id"]));
                }

                foreach (int menuOpcaoId in opcoesIds)
                {
                    string sqlPermissao = "INSERT INTO PermissaoMenu (UsuarioId, MenuOpcaoId, PodeAdicionar, PodeAlterar, PodeExcluir, PodeConsultar) " +
                        "VALUES (@UsuarioId, @MenuOpcaoId, @PodeAdicionar, @PodeAlterar, @PodeExcluir, @PodeConsultar)";

                    bool podeAdicionar = false;
                    bool podeAlterar = false;
                    bool podeExcluir = false;
                    bool podeConsultar = false;

                    switch (tipo)
                    {
                        case "Admin":
                            podeAdicionar = true;
                            podeAlterar = true;
                            podeExcluir = true;
                            podeConsultar = true;
                            break;
                        case "Chefe":
                            podeAdicionar = true;
                            podeAlterar = true;
                            podeExcluir = true;
                            podeConsultar = true;
                            break;
                        case "Usuário":
                            podeAdicionar = true;
                            podeAlterar = true;
                            podeConsultar = true;
                            break;
                        case "Visualisação":
                            podeConsultar = true;
                            break;
                        default:
                            throw new ArgumentException("Tipo de usuário inválido", nameof(tipo));
                    }

                    var parametros = new SqlParameter[]
                    {
                        new SqlParameter("@UsuarioId", usuarioId),
                        new SqlParameter("@MenuOpcaoId", menuOpcaoId),
                        new SqlParameter("@PodeAdicionar", podeAdicionar),
                        new SqlParameter("@PodeAlterar", podeAlterar),
                        new SqlParameter("@PodeExcluir", podeExcluir),
                        new SqlParameter("@PodeConsultar", podeConsultar)
                    };

                    banco.ExecutarComando(sqlPermissao, parametros);
                }

                return true;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar permissões do tipo: " + tipo, ex);
                return false;
            }
        }




    }
}
