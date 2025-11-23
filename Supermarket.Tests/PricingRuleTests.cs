using Supermarket.Pricing;

namespace Supermarket.Tests;

public class PricingRuleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GivenAUnitPrice_WhenDefaultRuleApplied_ReturnsUnitPrice()
    {
        var unitPrice = 20;
        var rule = new DefaultRule(unitPrice);

        int total = rule.CalculatePrice(1);

        Assert.That(total, Is.EqualTo(unitPrice));
    }

    [Test]
    public void GivenAMultiBuyOffer_WhenMultiBuyRuleApplied_ReturnsOfferPrice()
    {
        var unitPrice = 50;
        var offerOnQuantity = 3;
        var offerPrice = 130;
        var rule = new MultiBuyRule(unitPrice, offerOnQuantity, offerPrice);

        int total = rule.CalculatePrice(offerOnQuantity);

        Assert.That(total, Is.EqualTo(offerPrice));
    }
}
