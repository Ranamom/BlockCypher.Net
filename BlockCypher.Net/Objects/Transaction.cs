using Newtonsoft.Json;
using System;

namespace BlockCypher.Net.Objects
{
    public class Transaction
    {
        [JsonProperty("block_hash")]
        public string BlockHash { get; set; }

        [JsonProperty("block_height")]
        public long BlockHeight { get; set; }

        [JsonProperty("block_index")]
        public long BlockIndex { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("addresses")]
        public string[] Addresses { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("fees")]
        public long Fees { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("preference")]
        public string Preference { get; set; }

        [JsonProperty("confirmed")]
        public DateTimeOffset Confirmed { get; set; }

        [JsonProperty("received")]
        public DateTimeOffset Received { get; set; }

        [JsonProperty("ver")]
        public long Ver { get; set; }

        [JsonProperty("double_spend")]
        public bool DoubleSpend { get; set; }

        [JsonProperty("vin_sz")]
        public long VinSz { get; set; }

        [JsonProperty("vout_sz")]
        public long VoutSz { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("confidence")]
        public long Confidence { get; set; }

        [JsonProperty("inputs")]
        public Input[] Inputs { get; set; }

        [JsonProperty("outputs")]
        public Output[] Outputs { get; set; }
    }

    public partial class Input
    {
        [JsonProperty("prev_hash")]
        public string PrevHash { get; set; }

        [JsonProperty("output_index")]
        public long OutputIndex { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("output_value")]
        public long OutputValue { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }

        [JsonProperty("addresses")]
        public string[] Addresses { get; set; }

        [JsonProperty("script_type")]
        public string ScriptType { get; set; }

        [JsonProperty("age")]
        public long Age { get; set; }
    }

    public partial class Output
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("spent_by")]
        public string SpentBy { get; set; }

        [JsonProperty("addresses")]
        public string[] Addresses { get; set; }

        [JsonProperty("script_type")]
        public string ScriptType { get; set; }
    }
}

