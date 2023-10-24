using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // biblioteca para usar o Regex
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace test.Model
{
    public class Operacao
    {
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

        public static string FormatarTelefone(string telefone)
        {
            // Remove espaços em branco e traços
            telefone = telefone.Replace(" ", "").Replace("-", "");

            if (telefone.Length == 10)
            {
                return string.Format("({0:00}) {1:0000}-{2:0000}", long.Parse(telefone.Substring(0, 2)), long.Parse(telefone.Substring(2, 4)), long.Parse(telefone.Substring(6, 4)));
            }
            else if (telefone.Length == 11)
            {
                return string.Format("({0:00}) {1:0000}-{2:0000}", long.Parse(telefone.Substring(0, 2)), long.Parse(telefone.Substring(2, 4)), long.Parse(telefone.Substring(6, 4)));
            }
            else if (telefone.Length == 12)
            {
                return string.Format("({0:00}) {1:0000}-{2:0000}", long.Parse(telefone.Substring(0, 2)), long.Parse(telefone.Substring(3, 4)), long.Parse(telefone.Substring(7, 4)));
            }
            else
            {
                return telefone;
            }
        }


    }//////////////////////
}

