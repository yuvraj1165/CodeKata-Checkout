namespace Supermarket;

public class CheckoutService : ICheckout
{
    private readonly IPriceProvider _priceProvider;
    public List<string> _scannedItems { get; set; }
    public Dictionary<string, int> _uniqueScannedItems { get; set; }
    public CheckoutService()
    {
        _scannedItems = new List<string>();
        _uniqueScannedItems = new Dictionary<string, int>();
        _priceProvider = new PriceProvider();
    }

    public int GetTotalPrice()
    {
        if (_scannedItems.Count == 0)
            return 0;
        else
        {
            return _uniqueScannedItems.Sum(item => _priceProvider.GetPriceRule(item.Key).CalculatePrice(item.Value));
        }
    }

    public void Scan(string item)
    {
        _scannedItems.Add(item);

        if (_uniqueScannedItems.ContainsKey(item))
            _uniqueScannedItems[item] += 1;
        else
            _uniqueScannedItems.Add(item, 1);
    }
}