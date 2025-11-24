namespace Supermarket.Pricing
{
    public interface IPriceProvider
    {
        IPricingRule GetPriceRule(string sku);
    }
}
