using Uke5;

var shirt = new ClothingItem("T-Shirt", 50, 20.99, "Large", "Black");
var salePrice = shirt.CalculatePrice();
Console.WriteLine($"Shirt price is {salePrice}");

var ipad = new ElectronicItem("Ipad", 30, 499.99, "Apple", true);

Console.WriteLine($"Ipad cost {ipad.CalculatePrice()}");



