namespace Supermarket.Tests;

[TestFixture]
public class Tests
{
    CheckoutService _checkoutService;

    [SetUp]
    public void Setup()
    {
        _checkoutService = new CheckoutService();
    }

    [Test]
    public void GivenEmptyBasket_WhenCheckoutDone_TotalShouldIsZero()
    {
        var basketTotal = _checkoutService.GetTotalPrice();
        Assert.That(basketTotal, Is.EqualTo(0));
    }

    [Test]
    public void GivenOneItemA_WhenCheckoutDone_TotalShouldBe50()
    {
        _checkoutService.Scan("A");
        var basketTotal = _checkoutService.GetTotalPrice();
        Assert.That(basketTotal, Is.EqualTo(50));
    }
}