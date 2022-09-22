namespace AccountAPI.Models.CoinApi
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Coin
    {
        public string AssetId { get; set; }
        public string Name { get; set; }
        public int TypeIsCrypto { get; set; }
        public string DataStart { get; set; }
        public string DataEnd { get; set; }
        public DateTime DataQuoteStart { get; set; }
        public DateTime DataQuoteEnd { get; set; }
        public DateTime DataOrderbookStart { get; set; }
        public DateTime DataOrderbookEnd { get; set; }
        public DateTime DataTradeStart { get; set; }
        public DateTime DataTradeEnd { get; set; }
        public int DataSymbolsCount { get; set; }
        public double Volume1hrsUsd { get; set; }
        public double Volume1dayUsd { get; set; }
        public double Volume1mthUsd { get; set; }
        public double PriceUsd { get; set; }
    }

}
