using BlockCypeher.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BlockCypher.Net.Interfaces
{
    public interface IBlockcypherClient
    {
        AddressInfo GetAddressInfo(string address);
        AddressFullInfo GetFullAddressInfo(string address);

        Transaction GetFullTransaction(string txId);
    }
}
