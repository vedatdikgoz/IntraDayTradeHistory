using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace IntraDayTradeHistory.Models
{
    public class TradeListModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("conract")]
        public string Conract { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

    }

   

}
