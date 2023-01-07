using AbstractFactory.ClientClass;
using AbstractFactory.Creator;

Console.Title = "Abstract Factory";

var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
var ShoppingCartForBelgium = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
ShoppingCartForBelgium.CalculateCosts();

var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var ShoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
ShoppingCartForFrance.CalculateCosts();