using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class BelgiumShoppingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 20;
    }
}