using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using test.Classes;
using test.Model;
using test.Data.Model;
using test.Controllers;

namespace test.Data
{
    public class DALUsuarios
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();
          CTLSetores aCTLSetores = new CTLSetores();

        public bool AdicionarUsuario(Usuarios usuario)
        {
            try
            {
                string sql = "INSERT INTO Usuarios (Nome, Sobrenome, Email, Senha, Usuario, Perfil, Status, DataCadastro, DataNascimento, SetorID) " +
                             "VALUES (@Nome, @Sobrenome, @Email, @Senha, @Usuario, @Perfil, @Status, @DataCadastro, @DataNascimento, @Setor);" +
                             " SELECT SCOPE_IDENTITY();"; // Retornar o ID gerado

                SqlParameter[] parametros =
                {
                        new SqlParameter("@Nome", usuario.Nome),
                        new SqlParameter("@Sobrenome", usuario.Sobrenome),
                        new SqlParameter("@Email", usuario.Email),
                        new SqlParameter("@Senha", usuario.Senha),
                        new SqlParameter("@Usuario", usuario.Usuario),
                        new SqlParameter("@Perfil", usuario.Perfil),
                        new SqlParameter("@Status", usuario.Status),
                        new SqlParameter("@DataCadastro", usuario.DataCadastro),
                        new SqlParameter("@DataNascimento", usuario.DataNascimento),
                        new SqlParameter("@Setor", usuario.Setor.Id)

                    };

                // Obter o ID gerado
                int usuarioId = banco.ExecutarComandoRetornandoId(sql, parametros);

                if (usuarioId > 0)
                {
                    // Atualize a propriedade Id do usuário com o ID gerado
                    usuario.Id = usuarioId;

                    // Adicionar permissões para o usuário
                    CTLPermissaoMenu aCTL = new CTLPermissaoMenu();
                    aCTL.AdicionaPermissaoDoTipo(usuario.Perfil, usuarioId);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao adicionar o usuário", ex);
                return false;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar o usuário", ex);
                return false;
            }
        }

        public void AtualizarUsuario(Usuarios usuario)
        {
            try
            {
                string sql = "UPDATE Usuarios SET Nome = @Nome, Sobrenome = @Sobrenome, " +
                             "Email = @Email, Senha = @Senha, " +
                             "Usuario = @Usuario, Perfil = @Perfil, " +
                             "Status = @Status, DataNascimento = @DataNascimento, SetorID = @Setor WHERE Id = @Id";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", usuario.Nome),
                    new SqlParameter("@Sobrenome", usuario.Sobrenome),
                    new SqlParameter("@Email", usuario.Email),
                    new SqlParameter("@Senha", usuario.Senha),
                    new SqlParameter("@Usuario", usuario.Usuario),
                    new SqlParameter("@Perfil", usuario.Perfil),
                    new SqlParameter("@Status", usuario.Status),
                    new SqlParameter("@DataNascimento", usuario.DataNascimento),
                    new SqlParameter("@Setor", usuario.Setor.Id),
                    new SqlParameter("@Id", usuario.Id)
                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (SqlException ex)
            {
                operacao.HandleException("atualizar o usuário", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("atualizar o usuário", ex);
            }
        }
        public void AtualizarUsuarioSemSenha(Usuarios usuario)
        {
            try
            {
                string sql = "UPDATE Usuarios SET Nome = @Nome, Sobrenome = @Sobrenome, " +
                             "Email = @Email,  " +
                             "Usuario = @Usuario, Perfil = @Perfil, " +
                             "Status = @Status, DataNascimento = @DataNascimento, SetorId = @Setor WHERE Id = @Id";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", usuario.Nome),
                    new SqlParameter("@Sobrenome", usuario.Sobrenome),
                    new SqlParameter("@Email", usuario.Email),
                    new SqlParameter("@Usuario", usuario.Usuario),
                    new SqlParameter("@Perfil", usuario.Perfil),
                    new SqlParameter("@Status", usuario.Status),
                    new SqlParameter("@DataNascimento", usuario.DataNascimento),
                    new SqlParameter("@Setor", usuario.Setor.Id),
                    new SqlParameter("@Id", usuario.Id)
                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (SqlException ex)
            {
                operacao.HandleException("atualizar o usuário sem senha", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("atualizar o usuário sem senha", ex);
            }
        }
        public bool AlterarSenha(Usuarios usuario)
        {
            using (SqlConnection connection = banco.Abrir())
            {
                string sql = "UPDATE Usuarios SET Senha = @Senha WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Senha", usuario.Senha);
                    command.Parameters.AddWithValue("@Id", usuario.Id);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        operacao.HandleException("alterar senha do usuário", ex);
                    }
                }
            }
            return false;
        }
        public bool ExcluirUsuario(int usuarioId)
        {
            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    // Definir o comando para chamar o procedimento armazenado
                    string sql = "ExcluirUsuarioComPermissoes"; // procedure do banco vai excluir também as permissões do menu.
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UsuarioId", usuarioId);

                        command.ExecuteNonQuery(); // Executar o procedimento armazenado
                    }
                }

                return true; // Retorne true para indicar sucesso
            }
            catch (SqlException ex)
            {
                Operacao operacao = new Operacao();
                if (operacao.IsForeignKeyViolation(ex))
                {
                    // Trate a violação de chave estrangeira (se aplicável) ou outra exceção específica
                    MessageBox.Show("Não foi possível excluir o usuário selecionado devido a referências em outros registros.");
                }
                else
                {
                    // Trate outras exceções do SQL Server, se necessário
                    operacao.HandleException("Erro ao excluir o usuário", ex);
                }
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                // Trate outras exceções genéricas, se aplicável
                operacao.HandleException("Erro ao excluir o usuário", ex);
                return false; // Retorne false para indicar falha
            }
        }

        public Usuarios BuscarUsuarioPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM Usuarios WHERE Id = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateUsuarioFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar usuário por ID", ex);
                return null;
            }
        }

        public Usuarios BuscarUsuarioPorNome(string nome)
        {
            Usuarios usuario = null;

            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    string query = "SELECT * FROM Usuarios WHERE Usuario = @Usuario";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Usuario", nome);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = CreateUsuarioFromDataReader(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException("buscar o usuário por nome", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("buscar o usuário por nome", ex);
            }

            return usuario;
        }

        public List<Usuarios> ListarUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();

            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    string sql = "SELECT * FROM Usuarios";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Usuarios usuario = CreateUsuarioFromDataReader(reader);
                        usuarios.Add(usuario);
                    }
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException("listar usuários", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("listar usuários", ex);
            }

            return usuarios;
        }
        public Usuarios AutenticarUsuario(string username, string password)
        {
            Usuarios usuario = null;

            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    string query = "SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Senha = @Senha AND Status = 'Ativo'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Usuario", username);
                    command.Parameters.AddWithValue("@Senha", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = CreateUsuarioFromDataReader(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException("autenticar o usuário", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("autenticar o usuário", ex);
            }

            return usuario;
        }

        public List<Usuarios> PesquisarUsuariosPorCriterio(string criterio, string valorPesquisa)
        {
            List<Usuarios> usuariosEncontrados = new List<Usuarios>();

            try
            {
                string query = "SELECT * FROM Usuarios WHERE ";
                List<SqlParameter> parametros = new List<SqlParameter>();

                if (criterio == "ID" && int.TryParse(valorPesquisa, out int id))
                {
                    query += "Id = @ValorPesquisa";
                    parametros.Add(new SqlParameter("@ValorPesquisa", id));
                }
                else if (criterio == "Nome")
                {
                    query += "Nome LIKE @ValorPesquisa";
                    parametros.Add(new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%"));
                }
                else if (criterio == "Email")
                {
                    query += "Email LIKE @ValorPesquisa";
                    parametros.Add(new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%"));
                }
                else
                {
                    throw new ArgumentException("Critério de pesquisa não reconhecido.");
                }

                DataTable dataTable = banco.ExecutarConsulta(query, parametros.ToArray());

                foreach (DataRow row in dataTable.Rows)
                {
                    Usuarios usuario = CreateUsuarioFromDataRow(row);
                    usuariosEncontrados.Add(usuario);
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException($"pesquisar usuários por {criterio.ToLower()}", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException($"pesquisar usuários por {criterio.ToLower()}", ex);
            }

            return usuariosEncontrados;
        }


        public static string CriptografarSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);
                string hashString = BitConverter.ToString(hash).Replace("-", "").ToLower();
                return hashString;
            }
        }
        public bool VerificarAdministrador(int idUsuario)
        {
            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    string sql = "SELECT COUNT(*) FROM Usuarios WHERE Id = @Id AND Perfil = 'Admin'";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idUsuario);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException("verificar se o usuário é administrador", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("verificar se o usuário é administrador", ex);
            }

            return false; // Em caso de erro ou se o usuário não for encontrado, assume-se que não é um administrador
        }
        private Usuarios CreateUsuarioFromDataReader(SqlDataReader reader)
        {
            CTLSetores aCTLSetores = new CTLSetores();
            int setorId = Convert.ToInt32(reader["SetorId"]);
            Setores setor = aCTLSetores.BuscarSetorPorId(setorId);

            return new Usuarios
            {
                Id = Convert.ToInt32(reader["Id"]),
                Nome = reader["Nome"].ToString(),
                Sobrenome = reader["Sobrenome"].ToString(),
                Email = reader["Email"].ToString(),
                Senha = reader["Senha"].ToString(),
                Usuario = reader["Usuario"].ToString(),
                Perfil = reader["Perfil"].ToString(),
                Status = reader["Status"].ToString(),
                Setor = setor,
                DataCadastro = Convert.ToDateTime(reader["DataCadastro"]),
                DataNascimento = Convert.ToDateTime(reader["DataNascimento"])
            };
        }
        private Usuarios CreateUsuarioFromDataRow(DataRow row)
        {
            CTLSetores aCTLSetores = new CTLSetores();
            int setorId = Convert.ToInt32(row["SetorId"]);
            Setores setor = aCTLSetores.BuscarSetorPorId(setorId);

            return new Usuarios
            {
                Id = Convert.ToInt32(row["Id"]),
                Nome = row["Nome"].ToString(),
                Sobrenome = row["Sobrenome"].ToString(),
                Email = row["Email"].ToString(),
                Senha = row["Senha"].ToString(),
                Usuario = row["Usuario"].ToString(),
                Perfil = row["Perfil"].ToString(),
                Status = row["Status"].ToString(),
                Setor = setor,
                DataCadastro = Convert.ToDateTime(row["DataCadastro"]),
                DataNascimento = Convert.ToDateTime(row["DataNascimento"])
            };
        }


    }
}
