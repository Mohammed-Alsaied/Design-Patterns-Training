using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class FranceShoppingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 25;
    }


}