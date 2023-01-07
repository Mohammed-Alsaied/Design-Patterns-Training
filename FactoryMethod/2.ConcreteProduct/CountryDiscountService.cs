namespace FactoryMethod
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentfier;

        public CountryDiscountService(string countryIdentfier)
        {
            _countryIdentfier = countryIdentfier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentfier)
                {
                    case "BE":
                        return 20;
                    default:
                        return 10;
                }
            }
        }
    }
}
