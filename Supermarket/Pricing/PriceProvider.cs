namespace Supermarket.Pricing
{
    public class PriceProvider : IPriceProvider
    {
        private readonly Dictionary<string, IPricingRule> _prices = new()
        {
            { "A", new MultiBuyRule(50,3,130) },
            { "B", new MultiBuyRule(30,2,45)  },
            { "C", new DefaultRule(20) },
            { "D", new DefaultRule(15) }
        };

        public IPricingRule GetPriceRule(string sku)
        {
            if (!_prices.ContainsKey(sku))
                throw new KeyNotFoundException($"SKU {sku} not found");

            return _prices[sku];
        }
    }
}
