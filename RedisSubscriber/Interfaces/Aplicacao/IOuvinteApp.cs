using StackExchange.Redis;

namespace RedisSubscriber.Interfaces.Aplicacao
{
    public interface IOuvinteApp
    {
        ISubscriber Inscrever();
    }
}
