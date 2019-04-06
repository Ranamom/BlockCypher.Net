using BlockCypher.Net;
using Newtonsoft.Json;
using System.IO;

namespace BlockCypher.ConcoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new BlockcypherClient("btc");
            string[] addresses = new string[] { "3CcF942kYVRotGrfYQxD4QNn4aKVywpRxb" };
            foreach (var a in addresses)
            {
                var result = client.GetFullAddressInfo(a, 565000);
                File.WriteAllText($"C:\\blockzi\\{a}.json", JsonConvert.SerializeObject(result));
            }
        }
    }
}
