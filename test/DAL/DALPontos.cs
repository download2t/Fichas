using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Classes;
using test.Controllers;
using test.Data.Model;
using test.Model;

namespace test.Data
{
    public class DALPontos
    {
        private Banco banco = new Banco();

        public bool GerarMes()
        {
            try
            {
                string sql = @"
                    -- Inserir registros na tabela Pontos com base nos valores da tabela PontoM
                    INSERT INTO Pontos (CodPontoM, CodFuncionarios, SalarioBase, VrPontos, NPontos, ValorPontoTotal, SalarioTotal, Status)
                    SELECT
                        PM.codPontoM,
                        F.CodFuncionarios,
                        F.SalBase AS SalarioBase,
                        (PM.TotalDistribuicao / TotalPontos.Pontos) AS VrPontos,
                        Fun.Pontos AS NPontos,
                        (Fun.Pontos * (PM.TotalDistribuicao / TotalPontos.Pontos)) AS ValorPontoTotal,
                        (Fun.Pontos * (PM.TotalDistribuicao / TotalPontos.Pontos)) + F.SalBase AS SalarioTotal,
                        'Realizado' AS Status
                    FROM
                        PontoM PM
                        INNER JOIN Funcionarios F ON F.Ativo = 'S' AND F.CodFuncao IS NOT NULL
                        INNER JOIN Funcao Fun ON F.CodFuncao = Fun.CodFuncao
                        CROSS JOIN (
                            SELECT SUM(Fun.Pontos) AS Pontos
                            FROM Funcionarios F
                            INNER JOIN Funcao Fun ON F.CodFuncao = Fun.CodFuncao
                            WHERE F.Ativo = 'S' AND F.CodFuncao IS NOT NULL
                        ) AS TotalPontos
                    WHERE NOT EXISTS (
                        SELECT 1
                        FROM Pontos P
                        WHERE P.CodPontoM = PM.codPontoM
                          AND P.CodFuncionarios = F.CodFuncionarios
                          AND (P.Status IS NULL OR P.Status <> 'Realizado')
                    )
                    AND NOT EXISTS (
                        SELECT 1
                        FROM Pontos Q
                        WHERE Q.CodPontoM = PM.codPontoM
                          AND (Q.Status IS NOT NULL AND Q.Status = 'Realizado')
                    );";

                banco.ExecutarComando(sql, null);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o mês: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExcluirMensal(string codPontoM)
        {
            try
            {
                string sql = "DELETE FROM Pontos WHERE CodPontoM = @CodPontoM";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@CodPontoM", codPontoM)
                };

                banco.ExecutarComando(sql, parametros);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o registro mensal: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Pontos> ConsultaLista(string procurar = "", string mesFiltro = null, int? anoFiltro = null)
        {
            List<Pontos> listaPontos = new List<Pontos>();

            try
            {
                string sql = @"SELECT 
                            P.CodPontoM,
                            P.CodFuncionarios,
                            F.Nome AS NomeFuncionario,
                            F.SalBruto AS SalarioBruto,
                            P.VrPontos,
                            P.NPontos,
                            P.ValorPontoTotal,
                            P.SalarioTotal
                        FROM 
                            Pontos P
                        INNER JOIN 
                            Funcionarios F ON P.CodFuncionarios = F.Id";

                if (!string.IsNullOrEmpty(procurar))
                {
                    sql += " WHERE F.Nome LIKE @Procurar";
                }

                if (!string.IsNullOrEmpty(mesFiltro) && anoFiltro.HasValue)
                {
                    sql += " AND EXISTS (SELECT 1 FROM PontoM PM WHERE PM.CodPontoM = P.CodPontoM AND PM.Mes = @MesFiltro AND PM.Ano = @AnoFiltro)";
                }

                sql += " ORDER BY P.CodPontoM DESC, P.CodFuncionarios DESC";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@Procurar", $"%{procurar}%"),
                    new SqlParameter("@MesFiltro", mesFiltro),
                    new SqlParameter("@AnoFiltro", anoFiltro)
                };

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                foreach (DataRow row in dataTable.Rows)
                {
                    CTLFuncionarios func = new CTLFuncionarios();
                    Funcionario funcionario = func.BuscarFuncionarioPorId(Convert.ToInt32(row["CodFuncionarios"]));

                    listaPontos.Add(new Pontos
                    {
                        CodPontoM = row["CodPontoM"].ToString(),
                        Funcionarios = funcionario,
                        SalarioBase = Convert.ToDecimal(row["SalarioBruto"]),
                        VrPontos = Convert.ToDecimal(row["VrPontos"]),
                        NPontos = Convert.ToInt32(row["NPontos"]),
                        ValorPontoTotal = Convert.ToDecimal(row["ValorPontoTotal"]),
                        SalarioTotal = Convert.ToDecimal(row["SalarioTotal"])
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao consultar a lista de pontos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaPontos;
        }


        public List<Pontos> GetLista()
        {
            return new List<Pontos>(); // Você precisa implementar a lógica para retornar a lista de pontos
        }
    }
}
