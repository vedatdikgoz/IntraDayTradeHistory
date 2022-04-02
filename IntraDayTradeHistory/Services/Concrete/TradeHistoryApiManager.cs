using IntraDayTradeHistory.Models;
using IntraDayTradeHistory.Services.Abstract;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

namespace IntraDayTradeHistory.Services.Concrete
{
    public class TradeHistoryApiManager : ITradeHistoryApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TradeHistoryApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
            //_httpClient.BaseAddress = new Uri("http://seffaflik.epias.com.tr/transparency/service/market/intra-day-trade-history?endDate=2022-01-26&startDate=2022-01-26");
            _httpClient.BaseAddress = new Uri("http://www.denemedenen.com/");
           
            //NOTLAR
            //xml json formatına dönüştürülemedi. internette json a dönüştürüldü. Lokalde yayınlanıp işlem yapıldı.
            //Tarihe göre arama yapılamadı.
            //CleanCode yazılamadı. Ödevde istenilenler eksikte olsa yapıldı.
        }
        public async Task<TradeResponseModel> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("");


            if (response.IsSuccessStatusCode)
            {

                return JsonConvert.DeserializeObject<TradeResponseModel>(await response.Content
                    .ReadAsStringAsync());

            }
            return null;
        }


    }
}
