using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using test.Classes;
using test.Model;

namespace test.Data
{
    public class UsuariosDAO
    {
        private Banco banco = new Banco();

        public void AdicionarUsuario(Usuarios usuario)
        {
            using (SqlConnection connection = banco.Abrir()) // Usando o método Abrir da classe Banco
            {
                string sql = "INSERT INTO Usuarios (Nome, Sobrenome, Email, Senha, Usuario, Perfil, Status, DataCadastro, DataNascimento) " +
                             "VALUES (@Nome, @Sobrenome, @Email, @Senha, @Usuario, @Perfil, @Status, @DataCadastro, @DataNascimento)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Nome", usuario.Nome);
                command.Parameters.AddWithValue("@Sobrenome", usuario.Sobrenome);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Senha", usuario.Senha);
                command.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                command.Parameters.AddWithValue("@Perfil", usuario.Perfil);
                command.Parameters.AddWithValue("@Status", usuario.Status);
                command.Parameters.AddWithValue("@DataCadastro", usuario.DataCadastro);
                command.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
                command.ExecuteNonQuery();
            }
        }

        public void AtualizarUsuario(Usuarios usuario)
        {
            using (SqlConnection connection = banco.Abrir())
            {
                string sql = "UPDATE Usuarios SET Nome = @Nome, Sobrenome = @Sobrenome, " +
                             "Email = @Email, Senha = @Senha, " +
                             "Usuario = @Usuario, Perfil = @Perfil, " +
                             "Status = @Status, DataNascimento = @DataNascimento WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Nome", usuario.Nome);
                command.Parameters.AddWithValue("@Sobrenome", usuario.Sobrenome);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Senha", usuario.Senha);
                command.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                command.Parameters.AddWithValue("@Perfil", usuario.Perfil);
                command.Parameters.AddWithValue("@Status", usuario.Status);
                command.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
                command.Parameters.AddWithValue("@Id", usuario.Id);
                command.ExecuteNonQuery();
            }
        }
        public void AtualizarUsuarioSemSenha(Usuarios usuario)
        {
            using (SqlConnection connection = banco.Abrir())
            {
                string sql = "UPDATE Usuarios SET Nome = @Nome, Sobrenome = @Sobrenome, " +
                             "Email = @Email,  " +
                             "Usuario = @Usuario, Perfil = @Perfil, " +
                             "Status = @Status, DataNascimento = @DataNascimento WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Nome", usuario.Nome);
                command.Parameters.AddWithValue("@Sobrenome", usuario.Sobrenome);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                command.Parameters.AddWithValue("@Perfil", usuario.Perfil);
                command.Parameters.AddWithValue("@Status", usuario.Status);
                command.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
                command.Parameters.AddWithValue("@Id", usuario.Id);
                command.ExecuteNonQuery();
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
                        throw;
                    }
                }
            }
        }


        public void ExcluirUsuario(int usuarioId)
        {
            using (SqlConnection connection = banco.Abrir())
            {
                string sql = "DELETE FROM Usuarios WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", usuarioId);
                command.ExecuteNonQuery();
            }
        }

        public Usuarios BuscarUsuarioPorId(int id)
        {
            Usuarios usuario = null;
            using (SqlConnection connection = banco.Abrir())
            {
                string query = "SELECT * FROM Usuarios WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuarios
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nome = reader["Nome"].ToString(),
                            Sobrenome = reader["Sobrenome"].ToString(),
                            Email = reader["Email"].ToString(),
                            Senha = reader["Senha"].ToString(),
                            Usuario = reader["Usuario"].ToString(),
                            Perfil = reader["Perfil"].ToString(),
                            Status = reader["Status"].ToString(),
                            DataCadastro = Convert.ToDateTime(reader["DataCadastro"]),
                            DataNascimento = Convert.ToDateTime(reader["DataNascimento"])
                        };
                    }
                }
            }

            return usuario;
        }

        public List<Usuarios> ListarUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            using (SqlConnection connection = banco.Abrir())
            {
                string sql = "SELECT * FROM Usuarios";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Usuarios usuario = new Usuarios
                    {
                        Id = (int)reader["Id"],
                        Nome = (string)reader["Nome"],
                        Sobrenome = (string)reader["Sobrenome"],
                        Email = (string)reader["Email"],
                        Senha = (string)reader["Senha"],
                        Usuario = (string)reader["Usuario"],
                        Perfil = (string)reader["Perfil"],
                        Status = (string)reader["Status"],
                        DataCadastro = Convert.ToDateTime(reader["DataCadastro"]),
                        DataNascimento = Convert.ToDateTime(reader["DataNascimento"])
                    };
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }
        public Usuarios AutenticarUsuario(string username, string password)
        {
            Usuarios usuario = null;
            using (SqlConnection connection = banco.Abrir())
            {
                string query = "SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Senha = @Senha";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", username);
                command.Parameters.AddWithValue("@Senha", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuarios
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nome = reader["Nome"].ToString(),
                            Sobrenome = reader["Sobrenome"].ToString(),
                            Email = reader["Email"].ToString(),
                            Senha = reader["Senha"].ToString(),
                            Usuario = reader["Usuario"].ToString(),
                            Perfil = reader["Perfil"].ToString(),
                            Status = reader["Status"].ToString(),
                            DataCadastro = Convert.ToDateTime(reader["DataCadastro"]),
                            DataNascimento = Convert.ToDateTime(reader["DataNascimento"])
                        };
                    }
                }
            }
            return usuario;
        }
        public List<Usuarios> PesquisarUsuariosPorNome(string valorPesquisa)
        {
            List<Usuarios> usuariosEncontrados = new List<Usuarios>();

            using (SqlConnection connection = banco.Abrir())
            {
                string query = "SELECT * FROM Usuarios WHERE Nome LIKE @ValorPesquisa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuarios usuario = new Usuarios
                        {
                            Id = (int)reader["Id"],
                            Nome = (string)reader["Nome"],
                            Sobrenome = (string)reader["Sobrenome"],
                            Email = (string)reader["Email"],
                            Usuario = (string)reader["Usuario"],
                            DataNascimento = reader["DataNascimento"] as DateTime?,
                            Senha = (string)reader["Senha"],
                            Status = (string)reader["Status"],
                            Perfil = (string)reader["Perfil"],
                            DataCadastro = reader["DataCadastro"] as DateTime?
                        };

                        usuariosEncontrados.Add(usuario);
                    }
                }
            }

            return usuariosEncontrados;
        }

        public List<Usuarios> PesquisarUsuariosPorEmail(string valorPesquisa)
        {
            List<Usuarios> usuariosEncontrados = new List<Usuarios>();

            using (SqlConnection connection = banco.Abrir())
            {
                string query = "SELECT * FROM Usuarios WHERE Email LIKE @ValorPesquisa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ValorPesquisa", "%" + valorPesquisa + "%");

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuarios usuario = new Usuarios
                        {
                            Id = (int)reader["Id"],
                            Nome = (string)reader["Nome"],
                            Sobrenome = (string)reader["Sobrenome"],
                            Email = (string)reader["Email"],
                            Usuario = (string)reader["Usuario"],
                            DataNascimento = reader["DataNascimento"] as DateTime?,
                            Senha = (string)reader["Senha"],
                            Status = (string)reader["Status"],
                            Perfil = (string)reader["Perfil"],
                            DataCadastro = reader["DataCadastro"] as DateTime?
                        };

                        usuariosEncontrados.Add(usuario);
                    }
                }
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

    }
}
