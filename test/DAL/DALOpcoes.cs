using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using test.Model;
using test.Data.Model;

namespace test.DAL
{
    public class DALOpcoes
    {
        private Banco banco = new Banco();

        public bool SalvarMenu(HashSet<Opcoes> opcoes)
        {    
            var sql = "INSERT INTO MenuOpcoes (nome, descricao, nivel) SELECT @nome, @descricao, @nivel " +
                        "WHERE NOT EXISTS (SELECT 1 FROM MenuOpcoes" +
                        " WHERE nome = @nome AND descricao = @descricao AND nivel = @nivel)";
            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    foreach (var item in opcoes)
                    {
                        SqlParameter[] parametros =
                        {
                            new SqlParameter("@nome", item.Nome),
                            new SqlParameter("@descricao", item.Descricao),
                            new SqlParameter("@nivel", item.Nivel)
                        };

                        banco.ExecutarComando(sql, parametros);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public HashSet<Opcoes> CriarOpcoes(List<Dictionary<string, string>> todosTags)
        {
            var hashSetOpcoes = new HashSet<Opcoes>();

            int nivel = 1;
            foreach (var tags in todosTags)
            {
                foreach (var tag in tags.Keys)
                {
                    string descricao = tag; // Assumindo que a descrição é o próprio texto da tag
                    hashSetOpcoes.Add(new Opcoes(tag, descricao));
                }
                nivel++;
            }

            return hashSetOpcoes;
        }
        public HashSet<Opcoes> Criar(MenuStrip menu) // antigo que travata direto com menustrip
        {
            var hashSetOpcoes = new HashSet<Opcoes>();

            // Nível 1
            foreach (ToolStripMenuItem item1 in menu.Items)
            {
                var descricao1 = item1.Text;

                if (item1.HasDropDownItems)
                {
                    // Nível 2
                    foreach (ToolStripMenuItem item2 in item1.DropDownItems)
                    {
                        var descricao2 = descricao1 + " / " + item2.Text;

                        if (item2.HasDropDownItems)
                        {
                            // Nível 3
                            foreach (ToolStripMenuItem item3 in item2.DropDownItems)
                            {
                                var descricao3 = descricao2 + " / " + item3.Text;

                                if (item3.HasDropDownItems)
                                {
                                    // Nível 4
                                    foreach (ToolStripMenuItem item4 in item3.DropDownItems)
                                    {
                                        var descricao4 = descricao3 + " / " + item4.Text;
                                        hashSetOpcoes.Add(new Opcoes(item4.Name, descricao4, 4));
                                    }
                                }
                                else
                                {
                                    hashSetOpcoes.Add(new Opcoes(item3.Name, descricao3, 3));
                                }
                            }
                        }
                        else
                        {
                            hashSetOpcoes.Add(new Opcoes(item2.Name, descricao2, 2));
                        }
                    }
                }
                else
                {
                    hashSetOpcoes.Add(new Opcoes(item1.Name, descricao1, 1));
                }
            }

            return hashSetOpcoes;
        }    
        public List<Opcoes> ObterOpcoesDoMenuDoBanco()
        {
            List<Opcoes> opcoesMenu = new List<Opcoes>();

            try
            {
                using (SqlConnection connection = banco.Abrir())
                {
                    // Execute sua query SQL para buscar as opções do menu
                    string query = "SELECT * FROM MenuOpcoes"; // Exemplo de query fictícia

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Preencha a lista de Opcoes com os dados do banco
                        int id = reader.GetInt32(0);
                        string nome = reader.GetString(1);
                        string descricao = reader.GetString(2);
                        byte nivel = reader.GetByte(3);

                        Opcoes opcao = new Opcoes(id,nome, descricao, nivel);
                        opcoesMenu.Add(opcao);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Trate qualquer exceção que possa ocorrer ao acessar o banco de dados
                Console.WriteLine("Erro ao obter opções do menu: " + ex.Message);
            }

            return opcoesMenu;
        }
    }

}

