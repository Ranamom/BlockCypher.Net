using BlockCypher.Net;
using System;

namespace BlockCypher.ConcoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new BlockcypherClient("btc");
            string[] addresses = new string[] { "1Nh7uHdvY6fNwtQtM1G5EZAFPLC33B59rB", "1DEP8i3QJCsomS4BSMY2RpU1upv62aGvhD" };
            foreach(var a in addresses)
            {
                var result = client.GetAddressInfo(a);
            }
        }
    }
}
