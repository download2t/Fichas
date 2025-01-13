using System.Threading.Tasks;
using Controle.Model;
using Controle.Data;

namespace Controle.Controller
{
    public class CTLApiWhatsApp
    {
        private DALApiWhatsApp apiWhatsAppDAL = new DALApiWhatsApp();

        public async Task<bool> EnviarMensagem(ApiWhatsApp apiWhatsApp, string message)
        {
            return await apiWhatsAppDAL.EnviarMensagem(apiWhatsApp, message);
        }

        public async Task<string> ObterQrCode(ApiWhatsApp apiWhatsApp)
        {
            return await apiWhatsAppDAL.ObterQrCode(apiWhatsApp);
        }
    }
}
