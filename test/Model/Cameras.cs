using test.Classes;

namespace Controle.Model
{
    public class Cameras : Pai
    {
        public string Ip { get; set; }
        public string Local { get; set; }
        public string Audio { get; set; }
        public string Situacao { get; set; }

        public Cameras() : base()
        {
            Ip = "";
            Local = "";
            Audio = "";
            Situacao = "";
        }

        public Cameras(int id, string ip, string local, string audio, string situacao) : base(id)
        {
            Ip = ip;
            Local = local;
            Audio = audio;
            Situacao = situacao;
        }
    }
}
