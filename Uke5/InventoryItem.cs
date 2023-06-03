namespace Uke5;

public class InventoryItem
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public double Price { get; set; }

    public InventoryItem(string name, int amount, double price)
    {
        Name = name;
        Amount = amount;
        Price = price;
    }
}