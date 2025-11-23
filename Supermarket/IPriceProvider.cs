namespace Supermarket
{
    public interface IPriceProvider
    {
        IPricingRule GetPriceRule(string sku);
    }
}
