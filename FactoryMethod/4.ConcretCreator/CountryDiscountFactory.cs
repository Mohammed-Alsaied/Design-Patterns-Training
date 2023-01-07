namespace FactoryMethod
{
    /// <summary>
    /// ConcreteCreator
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentfier;

        public CountryDiscountFactory(string countryIdentfier)
        {
            _countryIdentfier = countryIdentfier;
        }


        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentfier);
        }

    }
}
