namespace Supermarket;

public class CheckoutService : ICheckout
{
    public List<string> _scannedItems { get; set; }
    public CheckoutService()
    {
        _scannedItems = new List<string>();
    }

    public int GetTotalPrice()
    {
        if (_scannedItems.Count == 0)
            return 0;
        else
            return 50;
    }

    public void Scan(string item)
    {
        _scannedItems.Add(item);
    }
}