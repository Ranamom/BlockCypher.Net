using BlockCypeher.Objects;
using System.Transactions;

namespace BlockCypher.Net.Interfaces
{
    public interface IBlockcypherClient
    {
        AddressInfo GetAddressInfo(string address);
        AddressFullInfo GetFullAddressInfo(string address, int? before = null, int? after = null, int? limit = null, int? confirmations = null);
        Transaction GetFullTransaction(string txId);
    }
}
