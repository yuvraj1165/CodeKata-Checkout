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

    [Test]
    public void GivenTwoItemA_WhenCheckoutDone_TotalShouldBe100()
    {
        _checkoutService.Scan("A");
        _checkoutService.Scan("A");
        var basketTotal = _checkoutService.GetTotalPrice();
        Assert.That(basketTotal, Is.EqualTo(100));
    }

    [Test]
    public void GivenOneItemB_WhenCheckoutDone_TotalShouldBe30()
    {
        _checkoutService.Scan("B");
        var basketTotal = _checkoutService.GetTotalPrice();
        Assert.That(basketTotal, Is.EqualTo(30));
    }

    [Test]
    public void GivenOneItemC_WhenCheckoutDone_TotalShouldBe20()
    {
        _checkoutService.Scan("C");
        var basketTotal = _checkoutService.GetTotalPrice();
        Assert.That(basketTotal, Is.EqualTo(20));
    }

    [Test]
    public void GivenItemD_WhenCheckoutDone_TotalShouldBe15()
    {
        _checkoutService.Scan("D");
        var basketTotal = _checkoutService.GetTotalPrice();
        Assert.That(basketTotal, Is.EqualTo(15));
    }

    [Test]
    public void GivenUnknownItem_WhenCheckoutDone_ItShouldThrowError()
    {
        var ex = Assert.Throws<KeyNotFoundException>(() =>
        {
            _checkoutService.Scan("E");
            _checkoutService.GetTotalPrice();
        });

        Assert.That(ex.Message, Is.EqualTo("SKU E not found"));
    }
}