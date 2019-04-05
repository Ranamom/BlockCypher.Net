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
            string[] addresses = new string[] { "3DM7vsj1CotMH1ix7X69scG2NjtzcmRYq7" };
            foreach (var a in addresses)
            {
                var result = client.GetAddressInfo(a);
                File.WriteAllText($"C:\\blockzi\\{a}.json", JsonConvert.SerializeObject(result.Transactions));
            }
        }
    }
}
