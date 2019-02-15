using StackExchange.Redis;

namespace RedisSubscriber.Interfaces.Servico
{
    public interface IOuvinteServ
    {
        ISubscriber Inscrever();
    }
}
