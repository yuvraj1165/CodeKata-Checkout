namespace Supermarket.Pricing
{
    public interface IPricingRule
    {
        int CalculatePrice(int quantity);
    }
}
