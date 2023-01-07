using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;

    }
}