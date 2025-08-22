namespace PooForUnity;

public class Item
{
    public string Name { get; }
    public int Weight { get; }
    public bool Stackable { get; }

    public Item(string name, int weight, bool stackable)
    {
        Name = name;
        Weight = weight;
        Stackable = stackable;
    }
    
    public override string ToString() => Name;
}

public class ItemSlot
{
    public Item Item { get; }
    public int Quantity { get; private set; }

    public ItemSlot(Item item, int quantity = 1)
    {
        Item = item;
        Quantity = item.Stackable ? quantity : 1;
    }
    
    public float TotalWeight => Item.Weight * Quantity;

    public void Add(int amount = 1)
    {
        if (Item.Stackable) Quantity += amount;
    }

    public void Remove(int amount = 1)
    {
        Quantity -= amount;
        if (Quantity < 0) Quantity = 0;
    }
}