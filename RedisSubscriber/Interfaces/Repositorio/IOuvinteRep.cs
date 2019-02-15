using StackExchange.Redis;

namespace RedisSubscriber.Interfaces.Repositorio
{
    public interface IOuvinteRep
    {
        ISubscriber Inscrever();
    }
}
