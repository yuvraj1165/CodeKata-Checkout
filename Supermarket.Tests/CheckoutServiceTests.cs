namespace Supermarket.Tests;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GivenEmptyBasket_WhenCheckoutDone_TotalShouldIsZero()
    {
        var basketTotal = new CheckoutService().GetTotalPrice();

        Assert.That(basketTotal, Is.EqualTo(0));
    }
}