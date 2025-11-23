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

    [Test]
    public void GivenOneItemA_WhenCheckoutDone_TotalShouldBe50()
    {
        var checkout = new CheckoutService();
        checkout.Scan("A");
        var basketTotal = checkout.GetTotalPrice();
        Assert.That(basketTotal, Is.EqualTo(50));
    }
}