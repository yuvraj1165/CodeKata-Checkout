namespace Supermarket;

public class CheckoutService : ICheckout
{
    public CheckoutService()
    {
    }

    public int GetTotalPrice()
    {
        return 0;
    }

    public void Scan(string item)
    {
        throw new NotImplementedException();
    }
}