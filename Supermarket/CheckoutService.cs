namespace Supermarket;

public class CheckoutService : ICheckout
{
    private readonly IPriceProvider _priceProvider;
    public List<string> _scannedItems { get; set; }
    public CheckoutService()
    {
        _scannedItems = new List<string>();
        _priceProvider = new PriceProvider();
    }

    public int GetTotalPrice()
    {
        if (_scannedItems.Count == 0)
            return 0;
        else
            return _scannedItems.Sum(sku => _priceProvider.GetPrice(sku));
    }

    public void Scan(string item)
    {
        _scannedItems.Add(item);
    }
}