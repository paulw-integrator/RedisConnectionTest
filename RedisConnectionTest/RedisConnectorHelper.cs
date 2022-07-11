using System;
using StackExchange.Redis;

namespace RedisConnectionTest
{
    class RedisConnectorHelper
    {
        static RedisConnectorHelper()
        {
            RedisConnectorHelper.lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect("Coned-Dev-Redis-POC.redis.cache.windows.net:6380,password=6HH2iQjEIzEGa3Tgl1q5whpJ2WIsPLnMdAzCaN6FbP4=,ssl=True,abortConnect=False");  //localhost
            });
        }

        private static Lazy<ConnectionMultiplexer> lazyConnection;

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
    }
}
