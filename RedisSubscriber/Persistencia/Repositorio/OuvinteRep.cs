using StackExchange.Redis;
using RedisSubscriber.Interfaces.Repositorio;
using RedisSubscriber.Persistencia.Contexto.Interfaces;

namespace RedisSubscriber.Persistencia.Repositorio
{
    public class OuvinteRep : IOuvinteRep
    {
        public OuvinteRep(IConexaoOuvinte conexao) => this._conexao = conexao;

        private readonly IConexaoOuvinte _conexao;

        public ISubscriber Inscrever() => this._conexao.Inscrito;
    }
}
