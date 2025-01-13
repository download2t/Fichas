using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Data.Model;
using test.Data;
using test.Model;

namespace test.Data
{
    public class DALPontosM
    {
        private Banco banco = new Banco();

        public string Salvar(PontosM pontosM)
        {
            if (pontosM.TotalDistribuicao < 0)
            {
                return "O valor da TotalDistribuicao não pode ser negativo.";
            }

            if (pontosM.Ano <= 0)
            {
                return "O ano deve ser maior que zero.";
            }

            try
            {
                var sql = @"
                    INSERT INTO PontoM ( ValorRecisao, TotalDistribuicao, Mes, Ano)
                    VALUES (@ValorRecisao, @TotalDistribuicao, @Mes, @Ano);";

                var parametros = new SqlParameter[]
                {
                    new SqlParameter("@ValorRecisao", pontosM.ValorRecisao),
                    new SqlParameter("@TotalDistribuicao", pontosM.TotalDistribuicao),
                    new SqlParameter("@Mes", pontosM.Mes),
                    new SqlParameter("@Ano", pontosM.Ano)
                };

                banco.ExecutarComando(sql, parametros);

                return "ok";
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2601 || sqlEx.Number == 2627)
                {
                    return "Já existe uma entrada com a mesma combinação de mês e ano na tabela PontoM.";
                }
                else
                {
                    return "Erro ao inserir dados na tabela PontoM: " + sqlEx.Message;
                }
            }
            catch (Exception ex)
            {
                return "Erro ao acessar o banco de dados: " + ex.Message;
            }
        }

        public bool GerarMes()
        {
            string sql = @" INSERT INTO Pontos (CodPontoM, CodFuncionarios, SalarioBase, VrPontos, NPontos, ValorPontoTotal, SalarioTotal, Status)
                                SELECT PM.codPontoM,
                                       F.Id AS CodFuncionarios,
                                       F.SalBruto AS SalarioBase,
                                       (PM.TotalDistribuicao / TotalPontos.Pontos) AS VrPontos,
                                       Fun.Pontos AS NPontos,
                                       (Fun.Pontos * (PM.TotalDistribuicao / TotalPontos.Pontos)) AS ValorPontoTotal,
                                       (Fun.Pontos * (PM.TotalDistribuicao / TotalPontos.Pontos)) + F.SalBruto AS SalarioTotal,
                                       'Realizado' AS Status
                                FROM PontoM PM
                                INNER JOIN Funcionarios F ON F.Ativo = 'S' AND F.CargoId IS NOT NULL
                                INNER JOIN Cargos Fun ON F.CargoId = Fun.Id
                                CROSS JOIN (
                                    SELECT SUM(Fun.Pontos) AS Pontos
                                    FROM Funcionarios F
                                    INNER JOIN Cargos Fun ON F.CargoId = Fun.Id
                                    WHERE F.Ativo = 'S' AND F.CargoId IS NOT NULL
                                ) AS TotalPontos
                                WHERE NOT EXISTS (
                                    SELECT 1
                                    FROM Pontos P
                                    WHERE P.CodPontoM = PM.codPontoM
                                      AND P.CodFuncionarios = F.Id
                                      AND (P.Status IS NULL OR P.Status <> 'Realizado')
                                )
                                AND NOT EXISTS (
                                    SELECT 1
                                    FROM Pontos Q
                                    WHERE Q.CodPontoM = PM.codPontoM
                                      AND (Q.Status IS NOT NULL AND Q.Status = 'Realizado')
                                )";

            try
            {
                banco.ExecutarComando(sql, null);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar os registros de pontos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExcluirMensal(string codPontoM)
        {
            string sql = "DELETE FROM Pontos WHERE CodPontoM = @CodPontoM";

            try
            {
                SqlParameter[] parametros =
                {
                    new SqlParameter("@CodPontoM", codPontoM)
                };
                banco.ExecutarComando(sql, parametros);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir os registros mensais: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<PontosM> ConsultaLista(string procurar = "")
        {
            List<PontosM> listaPontos = new List<PontosM>();

            string sql = @"SELECT codPontoM, ValorRecisao, TotalDistribuicao, Mes, Ano
                   FROM PontoM";

            if (!string.IsNullOrEmpty(procurar))
            {
                sql += " WHERE Mes LIKE @Procurar";
            }

            try
            {
                SqlParameter[] parametros =
                {
            new SqlParameter("@Procurar", $"%{procurar}%"),

        };

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                foreach (DataRow row in dataTable.Rows)
                {
                    PontosM ponto = new PontosM
                    {
                        CodPontoM = row["codPontoM"].ToString(),
                        ValorRecisao = Convert.ToDecimal(row["ValorRecisao"]),
                        TotalDistribuicao = Convert.ToDecimal(row["TotalDistribuicao"]),
                        Mes = row["Mes"].ToString(),
                        Ano = Convert.ToInt32(row["Ano"])
                    };
                    listaPontos.Add(ponto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar a lista de pontos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaPontos;
        }



        public List<PontosM> GetLista()
        {
            return ConsultaLista();
        }
    }
}
