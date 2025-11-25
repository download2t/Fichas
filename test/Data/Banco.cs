using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test.Data.Model
{
    internal class Banco
    {     
      //  private static string connectionString = @"Data Source=172.16.2.2;Initial Catalog=db_controle;Persist Security Info=True;User ID=sa;Password=xxxxxx";
        private static string connectionString = @"Data Source=172.16.10.169;Initial Catalog=db_controle;Persist Security Info=True;User ID=sa;Password=SanmaMacaco,#21";
        public SqlConnection Abrir()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                return cnn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro SQL ao abrir a conexão. Detalhes: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao abrir a conexão. Detalhes: " + ex.Message);
                return null;
            }
        }

        public void Fechar(SqlConnection connection)
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro SQL ao fechar a conexão. Detalhes: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao fechar a conexão. Detalhes: " + ex.Message);
            }
        }
        public object ExecutarConsultaScalar(string sql, SqlParameter[] parameters)
        {
            object result = null;

            using (SqlConnection connection = Abrir())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        result = command.ExecuteScalar();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao executar a consulta no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }

        public void ExecutarComando(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = Abrir())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao executar o comando no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int ExecutarComandoRetornandoId(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = Abrir())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        // Adicionar a instrução para obter o ID gerado
                        command.CommandText += " SELECT SCOPE_IDENTITY();";

                        // Executar o comando e obter o ID
                        int idGerado = Convert.ToInt32(command.ExecuteScalar());

                        transaction.Commit();
                        return idGerado;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao executar o comando no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; // Indica falha
                }
            }
        }

        public bool ExecutarComandos(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = Abrir())
            {

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocorreu um erro ao executar o comando no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public object ExecutarComandoScalar(string sql, SqlParameter[] parameters)
        {
            object result = null;

            using (SqlConnection connection = Abrir())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        result = command.ExecuteScalar();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao executar o comando no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }



        public DataTable ExecutarConsulta(string sql, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = Abrir())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao executar a consulta no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dataTable;
        }
        public DataTable ExecutarConsulta(string sql)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = Abrir())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao executar a consulta no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dataTable;
        }
    }
}
