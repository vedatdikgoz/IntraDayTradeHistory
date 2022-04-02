using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace IntraDayTradeHistory.Models
{
    public class TradeResponseModel
    {
        [JsonProperty("intraDayTradeHistoryList")]
        public List<TradeListModel> Data { get; set; }


        [JsonProperty("resultCode")]
        public string Code { get; set; }

        [JsonProperty("resultDescription")]
        public string Description { get; set; }
    }


  
}
