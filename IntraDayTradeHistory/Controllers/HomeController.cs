using IntraDayTradeHistory.Models;
using IntraDayTradeHistory.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace IntraDayTradeHistory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITradeHistoryApiService _tradeHistoryService;

        public HomeController(ITradeHistoryApiService tradeHistoryService)
        {
            _tradeHistoryService = tradeHistoryService;
        }

        public async Task<IActionResult> Index()
        {

            var result = await _tradeHistoryService.GetAllAsync();
            List<TradeListModel> model = new List<TradeListModel>(result.Data);
            var trades=model.GroupBy(x => x.Conract).Select(x=> new TotalProcessModel{
                Conract=x.Key,
                Tarih = DateTime.ParseExact(x.Key.Substring(2,8), "yyMMddHH", CultureInfo.InvariantCulture),             
                ToplamIslemTutari =  x.Sum(i => (float)(i.Price * i.Quantity) / 10),
                ToplamIslemMiktari= x.Sum(i=> (float)i.Quantity/10),
                AgirlikOrtalamaFiyat = x.Sum(i => (float)(i.Price * i.Quantity) / 10) / (x.Sum(i => (float)i.Quantity / 10))
                
            }).ToList();
                

            return View(trades);

        }


    }
}