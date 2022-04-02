using IntraDayTradeHistory.Models;

namespace IntraDayTradeHistory.Services.Abstract
{
    public interface ITradeHistoryApiService
    {
        Task<TradeResponseModel> GetAllAsync();
    }
}
