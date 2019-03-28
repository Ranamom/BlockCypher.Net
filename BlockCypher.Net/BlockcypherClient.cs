using BlockCypeher.Objects;
using BlockCypher.Net.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net;

namespace BlockCypher.Net
{
    public class BlockcypherClient: IBlockcypherClient
    {
        private WebClient wc = new WebClient();
        private readonly string _currency;
        private readonly string _network;
        private readonly string _version;


        private readonly string _baseUrl = "https://api.blockcypher.com";
        #region Endpoints
        private const string AddressBalanceEndpoint = "addrs/{}/balance";
        private const string AddressEndpoint = "addrs/{}";
        
        #endregion
        public BlockcypherClient(string currency, string net="main", string version="v1")
        {
            _currency = currency;
            _network = net;
            _version = version;
        }

        private T GetResult<T>(string url)
        {
            var result = wc.DownloadString(url);
            return JsonConvert.DeserializeObject<T>(result);
        }
        private string GetRequestUrl(string endpoint)
        {
            string address = $"{_baseUrl}/{_version}/{_currency}/{_network}/{endpoint}";
            return address;
        }
        private string FillPathParameter(string path, params string[] values)
        {
            foreach (var value in values)
            {
                var index = path.IndexOf("{}", StringComparison.Ordinal);
                if (index >= 0)
                {
                    path = path.Remove(index, 2);
                    path = path.Insert(index, value);
                }
            }
            return path;
        }

        public AddressInfo GetAddressInfo(string address)
        {
            string url = FillPathParameter(GetRequestUrl(AddressEndpoint), address);
            return GetResult<AddressInfo>(url);
        }
    }
}
