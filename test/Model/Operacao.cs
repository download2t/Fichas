using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // biblioteca para usar o Regex
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Drawing;

namespace test.Model
{
    public class Operacao
    {

        public void HandleException(string message, Exception ex)
        {
            Console.WriteLine($"{message}: {ex.Message}");

            // Exibir uma mensagem de erro para o usuário (você pode usar um MessageBox ou uma caixa de diálogo)
            MessageBox.Show($"Ocorreu um erro: {message}\nDetalhes do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool IsForeignKeyViolation(SqlException ex)
        {
            foreach (SqlError error in ex.Errors)
            {
                if (error.Number == 547)
                {
                    // Número de erro 547 é comum para violações de chave estrangeira no SQL Server
                    return true;
                }
            }
            return false;
        }
        public static void ValidarValorKeyPress(TextBox textBox, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        public static bool IsTelefone(string telefone)
        {
            // Utilizamos uma expressão regular que aceita os formatos mencionados
            Regex Rgx = new Regex(@"^(?:(?:\+|00)\d{2}|0)?\d{2,5}\d{4,8}$");

            return Rgx.IsMatch(telefone);
        }
        public static bool IsEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        public static async Task<string> ConsultarCepAsync(string cep)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();

                        // Realize a análise manual do JSON para extrair os campos desejados
                        var json = JObject.Parse(data);

                        if (json != null)
                        {
                            string logradouro = json["logradouro"].ToString();
                            string bairro = json["bairro"].ToString();
                            string uf = json["uf"].ToString();
                            string localidade = json["localidade"].ToString();

                            // Retorne os campos desejados em um formato que você preferir (por exemplo, como uma string)
                            return $"Logradouro: {logradouro}, Bairro: {bairro}, UF: {uf}, Cidade: {localidade}";
                        }
                    }

                    return null; // Retorna nulo se a análise falhar ou se a solicitação não for bem-sucedida
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro na consulta de CEP: {ex.Message}");
                    return null;
                }
            }
        }

        public static string FormatarDocumento(string documento)
        {
            // Remova todos os caracteres não numéricos
            string documentoLimpo = new string(documento.Where(char.IsDigit).ToArray());


            if (documentoLimpo.Length == 11) // CPF
            {
                return string.Format("{0:000\\.000\\.000\\-00}", long.Parse(documentoLimpo));
            }
            else if (documentoLimpo.Length == 14) // CNPJ
            {
                return string.Format("{0:00\\.000\\.000\\/0000\\-00}", long.Parse(documentoLimpo));
            }
            return documento; // Retorna o documento original se não for CPF nem CNPJ
        }


        public static string FormatarCep(string cep)
        {
            if (cep.Length == 8)
            {
                return string.Format("{0:00000-000}", long.Parse(cep));
            }
            return cep;
        }
        public static string FormatarTelefone2(string telefone)
        {
            if (string.IsNullOrEmpty(telefone))
                return string.Empty;

            // Remove todos os caracteres não numéricos
            var numeros = new string(telefone.Where(char.IsDigit).ToArray());

            // Verifica se o número contém o código do país, DDD e número
            if (numeros.Length == 12) // +55 (DDD) 0000-0000
            {
                return $"+55 ({numeros.Substring(2, 2)}) {numeros.Substring(4, 4)}-{numeros.Substring(8, 4)}";
            }
            else if (numeros.Length == 11) // (DDD) 0000-0000 (sem código do país)
            {
                return $"({numeros.Substring(0, 2)}) {numeros.Substring(2, 4)}-{numeros.Substring(6, 4)}";
            }
            else if (numeros.Length == 8) // 0000-0000 (sem DDD e código do país)
            {
                return $"{numeros.Substring(0, 4)}-{numeros.Substring(4, 4)}";
            }
            else
            {
                // Retorna o número como está se não corresponder aos comprimentos esperados
                return telefone;
            }
        }


        public static string FormatarTelefone(string telefone)
        {
            // Remove espaços em branco e traços
            telefone = telefone.Replace(" ", "").Replace("-", "");

            try
            {
                if (telefone.Length == 11)
                {
                    return string.Format("({0}) {1}-{2}",
                        telefone.Substring(0, 2),
                        telefone.Substring(2, 5),
                        telefone.Substring(7, 4));
                }
                else if (telefone.Length == 10)
                {
                    return string.Format("({0}) {1}-{2}",
                        telefone.Substring(0, 2),
                        telefone.Substring(2, 4),
                        telefone.Substring(6, 4));
                }
                else if (telefone.Length == 9)
                {
                    return string.Format("{0}-{1}",
                        telefone.Substring(0, 5),
                        telefone.Substring(5, 4));
                }
                else if (telefone.Length == 8)
                {
                    return string.Format("{0}-{1}",
                        telefone.Substring(0, 4),
                        telefone.Substring(4, 4));
                }
            }
            catch (FormatException)
            {
                return "Formato inválido";
            }
            catch (Exception ex)
            {
                return "Erro ao formatar: " + ex.Message;
            }

            return telefone;
        }
        public static string FormatStatus(char status)
        {
            switch (status)
            {
                case 'E':
                    return "Enviado";
                case 'A':
                    return "Agendado";
                case 'N':
                    return "Não Enviado";
                default:
                    return "Desconhecido";
            }
        }

        public static Form CriarFormFoto(Image foto)
        {
            Form formFoto = new Form
            {
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.Sizable,
                MaximizeBox = true,
                MinimizeBox = true,
                Size = foto.Size
            };

            // PictureBox para exibir a imagem
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = foto,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            // ToolStrip para os botões de ação
            ToolStrip toolStrip = new ToolStrip();

            // Botão para salvar a imagem
            ToolStripButton salvarButton = new ToolStripButton("Salvar");
            salvarButton.Click += (sender, e) =>
            {
                try
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Salvar a imagem com formato padrão
                            pictureBox.Image.Save(saveFileDialog.FileName);
                        }
                    }
                }
                catch (System.Runtime.InteropServices.ExternalException ex)
                {
                    MessageBox.Show($"Erro ao salvar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            toolStrip.Items.Add(salvarButton);

            // Botão para imprimir a imagem
            ToolStripButton imprimirButton = new ToolStripButton("Imprimir");
            imprimirButton.Click += (sender, e) =>
            {
                try
                {
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += (s, ev) =>
                    {
                        if (pictureBox.Image != null)
                        {
                            ev.Graphics.DrawImage(pictureBox.Image, 0, 0);
                        }
                        else
                        {
                            ev.Graphics.DrawString("Nenhuma imagem para imprimir.", new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
                        }
                    };

                    PrintDialog printDialog = new PrintDialog
                    {
                        Document = printDocument
                    };
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.Print();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao imprimir a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            toolStrip.Items.Add(imprimirButton);

            // Adicionando controles ao formulário
            formFoto.Controls.Add(pictureBox);
            formFoto.Controls.Add(toolStrip);

            // Posicionamento do ToolStrip
            toolStrip.Dock = DockStyle.Top;

            // Lidando com o evento de duplo clique para fechar o formulário
            formFoto.MouseDoubleClick += (sender, e) => formFoto.Close();

            return formFoto;
        }


    }//////////////////////
}

