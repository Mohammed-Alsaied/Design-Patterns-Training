namespace FactoryMethod
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>

    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;

        public CodeDiscountService(Guid code)
        {
            _code = code;
        }

        //Logic 
        public override int DiscountPercentage
        {
            get => 15;
        }
    }
}
