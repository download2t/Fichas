using Controle.Model;
using Controle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Data.Model;
using test.Model;

namespace Controle.DAL
{
    internal class DALCameras
    {
        private Banco banco = new Banco();
        private Operacao operacao;

        public DALCameras()
        {
            operacao = new Operacao();
        }

        public bool AdicionarCamera(Cameras camera)
        {
            try
            {
                string sql = "INSERT INTO Cameras (Ip, Local, Audio, Situacao) VALUES (@Ip, @Local, @Audio, @Situacao)";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Ip", camera.Ip),
                    new SqlParameter("@Local", camera.Local),
                    new SqlParameter("@Audio", camera.Audio),
                    new SqlParameter("@Situacao", camera.Situacao)
                };

                banco.ExecutarComando(sql, parametros);
                return true; // Indica sucesso
            }
            catch (SqlException ex)
            {
                operacao.HandleException("adicionar a câmera", ex);
                return false; // Indica falha
            }
            catch (Exception ex)
            {
                operacao.HandleException("adicionar a câmera", ex);
                return false; // Indica falha
            }
        }

        public bool AtualizarCamera(Cameras camera)
        {
            try
            {
                string sql = "UPDATE Cameras SET Ip = @Ip, Local = @Local, Audio = @Audio, Situacao = @Situacao WHERE CodCamera = @CodCamera";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Ip", camera.Ip),
                    new SqlParameter("@Local", camera.Local),
                    new SqlParameter("@Audio", camera.Audio),
                    new SqlParameter("@Situacao", camera.Situacao),
                    new SqlParameter("@CodCamera", camera.Id)
                };

                banco.ExecutarComando(sql, parametros);
                return true; // Indica sucesso
            }
            catch (SqlException ex)
            {
                operacao.HandleException("atualizar a câmera", ex);
                return false; // Indica falha
            }
            catch (Exception ex)
            {
                operacao.HandleException("atualizar a câmera", ex);
                return false; // Indica falha
            }
        }

        public bool ExcluirCamera(int cameraId)
        {
            try
            {
                string sql = "DELETE FROM Cameras WHERE CodCamera = @CodCamera";
                SqlParameter[] parametros = { new SqlParameter("@CodCamera", cameraId) };
                banco.ExecutarComando(sql, parametros);
                return true; // Retorne true para indicar sucesso
            }
            catch (SqlException ex)
            {
                if (operacao.IsForeignKeyViolation(ex))
                {
                    MessageBox.Show("Não foi possível excluir a câmera selecionada, pois ela está sendo utilizada em outros registros. " +
                                    "Por favor, remova todas as referências desta câmera em outros registros antes de tentar excluí-la novamente.");
                }
                else
                {
                    operacao.HandleException("Erro ao excluir a câmera", ex);
                }
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir a câmera", ex);
                return false; // Retorne false para indicar falha
            }
        }

        public Cameras BuscarCameraPorId(int id)
        {
            try
            {
                DataTable dataTable = ExecutarConsulta("SELECT * FROM Cameras WHERE CodCamera = @CodCamera", new SqlParameter("@CodCamera", id));
                if (dataTable.Rows.Count > 0)
                {
                    return MapDataRowToCamera(dataTable.Rows[0]);
                }
                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("buscar a câmera por ID", ex);
                return null;
            }
        }

        public List<Cameras> ListarCameras()
        {
            try
            {
                DataTable dataTable = ExecutarConsulta("SELECT * FROM Cameras ORDER BY CodCamera DESC");
                List<Cameras> cameras = new List<Cameras>();

                foreach (DataRow row in dataTable.Rows)
                {
                    cameras.Add(MapDataRowToCamera(row));
                }

                return cameras;
            }
            catch (Exception ex)
            {
                operacao.HandleException("listar as câmeras", ex);
                return new List<Cameras>();
            }
        }
        public List<Cameras> PesquisarCamera(string pesquisa)
        {
            try
            {
                List<Cameras> cameras = new List<Cameras>();
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = banco.Abrir())
                {
                    // Prepara a consulta SQL com parâmetros
                    string sql = "SELECT * FROM Cameras " +
                                 "WHERE (CAST(CodCamera AS VARCHAR) LIKE @Pesquisa OR " +
                                 "Ip LIKE @Pesquisa OR " +
                                 "Local LIKE @Pesquisa OR " +
                                 "Audio LIKE @Pesquisa OR " +
                                 "Situacao LIKE @Pesquisa) " +
                                 "ORDER BY CodCamera DESC";

                    SqlCommand command = new SqlCommand(sql, connection);

                    // Usa LIKE para permitir a pesquisa por qualquer parte da string
                    command.Parameters.AddWithValue("@Pesquisa", $"%{pesquisa}%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Cameras camera = MapDataRowToCamera(row);
                    cameras.Add(camera);
                }

                return cameras;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("listar as câmeras", ex);
                return new List<Cameras>();
            }
            catch (Exception ex)
            {
                operacao.HandleException("listar as câmeras", ex);
                return new List<Cameras>();
            }
        }

        private DataTable ExecutarConsulta(string sql, params SqlParameter[] parametros)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        if (parametros != null)
                        {
                            command.Parameters.AddRange(parametros);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("executar consulta", ex);
            }
            return dataTable;
        }

        private Cameras MapDataRowToCamera(DataRow row)
        {
            return new Cameras
            {
                Id = (int)row["CodCamera"],
                Ip = (string)row["Ip"],
                Local = (string)row["Local"],
                Audio = (string)row["Audio"],
                Situacao = (string)row["Situacao"]
            };
        }
    }
}
