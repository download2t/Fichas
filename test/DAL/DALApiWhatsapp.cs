using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Controle.Model;

namespace Controle.Data
{
    public class DALApiWhatsApp
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<bool> EnviarMensagem(ApiWhatsApp apiWhatsApp, string message)
        {
            try
            {
                // Criando o objeto de mensagem no formato JSON
                var content = new StringContent(
                    $"{{ \"chatId\": \"{apiWhatsApp.Telefone}\", \"contentType\": \"string\", \"content\": \"{message}\" }}",
                    Encoding.UTF8,
                    "application/json");

                // Configurando os headers
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("x-api-key", apiWhatsApp.ApiKey);

                // Enviando a mensagem via POST para a API do WhatsApp
                HttpResponseMessage response = await client.PostAsync(apiWhatsApp.ApiPath, content);

                // Verificando se a requisição foi bem-sucedida
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                // Log de erro
                Console.WriteLine($"Erro ao enviar mensagem: {ex.Message}");
                return false;
            }
        }
        public async Task<string> ObterQrCode(ApiWhatsApp apiWhatsApp)
        {
            try
            {
                string urlQrCode = $"{apiWhatsApp.ApiPath}/session/qr/{apiWhatsApp.ApiKey}/image";

                // Configuração dos headers necessários
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("x-api-key", apiWhatsApp.ApiKey);

                // Faz a requisição GET para obter o QR code como JSON
                HttpResponseMessage response = await client.GetAsync(urlQrCode);

                // Verifica se a requisição foi bem sucedida
                if (response.IsSuccessStatusCode)
                {
                    // Lê o conteúdo da resposta como uma string JSON
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Converte a resposta para um objeto JSON
                    dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                    // Verifica o sucesso da operação e obtém o QR code codificado
                    if (result.success == true && result.qr != null)
                    {
                        return result.qr;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter QR code: {ex.Message}");
                return null;
            }
        }
    }
}
