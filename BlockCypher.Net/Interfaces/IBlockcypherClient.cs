using BlockCypeher.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockCypher.Net.Interfaces
{
    public interface IBlockcypherClient
    {
        AddressInfo GetAddressInfo(string address);
    }
}
