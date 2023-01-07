using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ClientClass
{
    /// <summary>
    /// Client class 
    /// </summary>
    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostsService _shippingCostsService;
        private int _orderCosts;

        // Constructor
        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostsService = factory.CreateShoppingCostsService();
            // assume that the total cost of all the items we ordered = 200 euro
            _orderCosts = 200;
        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Total costs =" +
                $" {_orderCosts - _orderCosts / 100 * _discountService.DiscountPercentage + _shippingCostsService.ShippingCosts}");
        }
    }
}