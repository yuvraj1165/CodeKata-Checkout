namespace Supermarket
{
    public class PriceProvider : IPriceProvider
    {
        private readonly Dictionary<string, int> _prices = new()
        {
            { "A", 50 },
            { "B", 30 },
            { "C", 20 },
            { "D", 15 }
        };

        public int GetPrice(string sku)
        {
            return _prices[sku];
        }
    }
}
