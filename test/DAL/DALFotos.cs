using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Model;
using test.Data.Model;
using Controle.Model;

namespace test.Data
{
    public class DALFotos
    {
        private Banco banco = new Banco();
        private Operacao operacao= new Operacao();
        private CTLOrdemDeServico ctlOS = new CTLOrdemDeServico();
        public List<Fotos> ListaDeFotos = new List<Fotos>();


        public void AdicionarFotosNaLista(List<Fotos> fotos)
        {
            ListaDeFotos.AddRange(fotos);
        }
        public List<string> AdicionarFotos(List<Fotos> fotos)
        {
            string sql = "INSERT INTO Fotos (OrdemDeServicoId, Foto, Descricao) " +
                         "VALUES (@OrdemDeServicoId, @Foto, @Descricao)";

            List<string> erros = new List<string>();

            try
            {
                foreach (var foto in fotos)
                {
                    SqlParameter[] parametros =
                    {
                        new SqlParameter("@OrdemDeServicoId", foto.Os.Id),
                        new SqlParameter("@Foto", foto.Foto),
                        new SqlParameter("@Descricao", foto.Descricao)
                    };

                    try
                    {
                        banco.ExecutarComando(sql, parametros);
                    }
                    catch (Exception ex)
                    {
                        erros.Add($"Erro ao adicionar foto com a descrição '{foto.Descricao}'. Erro: {ex.Message}");
                    }
                }

                return erros;
            }
            catch (Exception ex)
            {
                erros.Add("Erro ao adicionar fotos: " + ex.Message);
                return erros;
            }
        }
        public bool ExcluirFoto(int fotoId)
        {
            try
            {
                string sql = "DELETE FROM Fotos WHERE Id = @FotoId";
                SqlParameter[] parametros = { new SqlParameter("@FotoId", fotoId) };
                banco.ExecutarComando(sql, parametros);
                return true; // Retorne true para indicar sucesso
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao excluir a foto", ex);
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir a foto", ex);
                return false; // Retorne false para indicar falha
            }
        }
        public Fotos BuscarFotoPorId(int id)
        {
            try
            {
                Fotos foto = null;
                using (SqlConnection connection = banco.Abrir())
                {
                    string query = "SELECT * FROM Fotos WHERE FotoId = @FotoId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FotoId", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foto = new Fotos
                            {
                                Id = (int)reader["FotoId"],
                                Os = ctlOS.BuscarOrdemDeServicoPorId((int)reader["OrdemDeServicoId"]),
                                Foto = (byte[])reader["Foto"],
                             //   Descricao = (string)reader["Descricao"]
                            };
                        }
                    }
                }

                return foto;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("buscar a foto por ID", ex);
                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("buscar a foto por ID", ex);
                return null;
            }
        }
        public List<Fotos> ListarFotos()
        {
            List<Fotos> fotos = new List<Fotos>();
            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    string query = "SELECT FotoId, Descricao, OrdemDeServicoId, Foto FROM Fotos";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ordemDeServicoId = (int)reader["OrdemDeServicoId"];
                             
                            OrdemDeServico ordemDeServico = ctlOS.BuscarOrdemDeServicoPorId(ordemDeServicoId);
                            Fotos foto = new Fotos
                            {
                                Id = (int)reader["FotoId"],
                                Descricao = reader["Descricao"].ToString(),
                                Os = ordemDeServico, 
                                Foto = (byte[])reader["Foto"]
                            };
                            fotos.Add(foto);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao listar as fotos", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar as fotos", ex);
            }
            return fotos;
        }
        public List<Fotos> ListarFotosDaOrdemDeServico(int ordemDeServicoId)
        {
            List<Fotos> fotos = new List<Fotos>();

            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    string query = "SELECT * FROM Fotos WHERE OrdemDeServicoID = @OrdemDeServicoID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrdemDeServicoID", ordemDeServicoId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fotos foto = new Fotos
                            {
                                Id = (int)reader["FotoId"],
                                Descricao = reader["Descricao"].ToString(),
                                Os = ctlOS.BuscarOrdemDeServicoPorId((int)reader["OrdemDeServicoId"]), // Possível causa de recursão
                                Foto = (byte[])reader["Foto"]
                            };
                            fotos.Add(foto);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao listar as fotos da ordem de serviço", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro geral: " + ex.Message);
                Console.WriteLine("Detalhes: " + ex.ToString());
                operacao.HandleException("Erro ao listar as fotos da ordem de serviço", ex);
            }

            return fotos;
        }


    }
}
