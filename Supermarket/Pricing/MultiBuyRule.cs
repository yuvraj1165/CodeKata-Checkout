namespace Supermarket.Pricing
{
    public class MultiBuyRule(int unitPrice, int offerOnQuantity, int offerPrice) : IPricingRule
    {
        public int CalculatePrice(int quantity)
        {
            var quantityConsideredForMultiBuyOffer = quantity / offerOnQuantity;
            var quantityWithoutOffer = quantity % offerOnQuantity;

            return quantityConsideredForMultiBuyOffer * offerPrice + quantityWithoutOffer * unitPrice;
        }
    }
}
