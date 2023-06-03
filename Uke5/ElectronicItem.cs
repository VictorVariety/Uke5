namespace Uke5;

public class ElectronicItem : InventoryItem, ISellable
{
    public string Brand { get; set; }
    public bool IsBattery { get; set; }

    public ElectronicItem(string name, int amount, double price, string brand, bool battery)
        : base(name, amount, price)
    {
        Brand = brand;
        IsBattery = false;
    }

    public double CalculatePrice()
    {
        return Price;
    }
}