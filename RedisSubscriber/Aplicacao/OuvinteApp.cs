using StackExchange.Redis;
using RedisSubscriber.Interfaces.Servico;
using RedisSubscriber.Interfaces.Aplicacao;

namespace RedisSubscriber.Aplicacao
{
    public class OuvinteApp : IOuvinteApp
    {
        public OuvinteApp(IOuvinteServ serv) => this._serv = serv;

        private readonly IOuvinteServ _serv;

        public ISubscriber Inscrever() => this._serv.Inscrever();
    }
}
