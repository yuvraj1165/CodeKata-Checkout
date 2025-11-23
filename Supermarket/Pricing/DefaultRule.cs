namespace Supermarket.Pricing
{
    public class DefaultRule(int unitPrice) : IPricingRule
    {
        public int CalculatePrice(int quantity)
        {
            return quantity * unitPrice;
        }
    }
}
