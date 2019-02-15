using StackExchange.Redis;
using RedisSubscriber.Interfaces.Servico;
using RedisSubscriber.Interfaces.Repositorio;

namespace RedisSubscriber.Servicos
{
    public class OuvinteServ : IOuvinteServ
    {
        public OuvinteServ(IOuvinteRep rep) => this._rep = rep;

        private readonly IOuvinteRep _rep;

        public ISubscriber Inscrever() => this._rep.Inscrever();
    }
}
