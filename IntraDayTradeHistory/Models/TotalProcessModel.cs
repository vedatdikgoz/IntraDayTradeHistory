namespace IntraDayTradeHistory.Models
{
    public class TotalProcessModel
    {
        public DateTime Tarih { get; set; }
        public string Conract { get; set; }
        public float ToplamIslemTutari { get; set; }
        public float ToplamIslemMiktari { get; set; }
        public float AgirlikOrtalamaFiyat { get; set; }
    }
}
