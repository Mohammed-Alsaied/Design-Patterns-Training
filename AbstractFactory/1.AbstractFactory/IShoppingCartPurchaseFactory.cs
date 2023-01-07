using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();

        IShippingCostsService CreateShoppingCostsService();
    }
}
