namespace Uke5;

public class ClothingItem : InventoryItem, ISellable
{
    public string Size { get; set; }
    public string Color { get; set; }

    public ClothingItem(string name, int amount, double price, string size, string color)
        : base(name, amount, price)
    {
        Size = size;
        Color = color;
    }
    public double CalculatePrice()
    {
        return Price;
    }
}