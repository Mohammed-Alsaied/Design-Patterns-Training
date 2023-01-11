using FactoryMethod;

Console.Title = "Factory Method";

var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("BE"),
};
//
foreach (var factory in factories)
{
    var discountServices = factory.CreateDiscountService();
    Console.WriteLine($"Percentage  {discountServices.DiscountPercentage}"
        + $" Coming from  {discountServices}");


}