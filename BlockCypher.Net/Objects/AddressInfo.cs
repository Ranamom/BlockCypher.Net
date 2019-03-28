using Newtonsoft.Json;
using System;

namespace BlockCypeher.Objects
{

    public partial class AddressInfo
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("total_received")]
        public long TotalReceived { get; set; }

        [JsonProperty("total_sent")]
        public long TotalSent { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }

        [JsonProperty("unconfirmed_balance")]
        public long UnconfirmedBalance { get; set; }

        [JsonProperty("final_balance")]
        public long FinalBalance { get; set; }

        [JsonProperty("n_tx")]
        public long NTx { get; set; }

        [JsonProperty("unconfirmed_n_tx")]
        public long UnconfirmedNTx { get; set; }

        [JsonProperty("final_n_tx")]
        public long FinalNTx { get; set; }

        [JsonProperty("txrefs")]
        public TransactionInfo[] Transactions { get; set; }

        [JsonProperty("tx_url")]
        public Uri TxUrl { get; set; }
    }

    public partial class TransactionInfo
    {
        [JsonProperty("tx_hash")]
        public string TxHash { get; set; }

        [JsonProperty("block_height")]
        public long BlockHeight { get; set; }

        [JsonProperty("tx_input_n")]
        public long TxInputN { get; set; }

        [JsonProperty("tx_output_n")]
        public long TxOutputN { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("ref_balance")]
        public long RefBalance { get; set; }

        [JsonProperty("spent")]
        public bool Spent { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("confirmed")]
        public DateTimeOffset Confirmed { get; set; }

        [JsonProperty("double_spend")]
        public bool DoubleSpend { get; set; }
    }

    //public partial class AddressInfo
    //{
    //    public static AddressInfo FromJson(string json) => JsonConvert.DeserializeObject<AddressInfo>(json, BlockCypeher.Objects.Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this AddressInfo self) => JsonConvert.SerializeObject(self, BlockCypeher.Objects.Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}
}