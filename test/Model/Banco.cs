using System;
using System.Data;
using System.Data.SqlClient;

namespace test.Model
{
    internal class Banco
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\sanma\OneDrive\Área de Trabalho\PROJETOS\test\test\db_sistema.mdf"";Integrated Security=True"; 

        public SqlConnection Abrir()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            return cnn;
        }

        public void Fechar(SqlConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void ExecutarComando(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = Abrir())
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ExecutarConsulta(string sql, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Abrir())
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
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
            }

            return dataTable;
        }
    }
}
