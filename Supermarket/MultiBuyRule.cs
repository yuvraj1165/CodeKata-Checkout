namespace Supermarket
{
    public class MultiBuyRule(int unitPrice, int offerOnQuantity, int offerPrice) : IPricingRule
    {
        public int CalculatePrice(int quantity)
        {
            var quantityConsidetedForMultiBuyOffer = quantity / offerOnQuantity;
            var quantityWithoutOffer = quantity % offerOnQuantity;

            return (quantityConsidetedForMultiBuyOffer * offerPrice) + (quantityWithoutOffer * unitPrice);
        }
    }
}
