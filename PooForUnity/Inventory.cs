namespace PooForUnity;

public class Inventory
{
    private readonly HashSet<ItemSlot> _slots;
    private readonly float _maxWeight;

    public Inventory(float maxWeight = 20)
    {
        _slots = new HashSet<ItemSlot>();
        _maxWeight = maxWeight;
    }

    private float CurrentWeight => _slots.Sum(slot => slot.TotalWeight);

    public bool AddItem(Item item, int quantity = 1)
    {
        var isMaximumWeight = CurrentWeight + item.Weight * quantity > _maxWeight;
        if (isMaximumWeight)
        {
            Console.WriteLine("Inventory is too heavy!");
            return false;
        }
        
        var slot = _slots.FirstOrDefault(slot => slot.Item.Name == item.Name);
        if (slot != null && item.Stackable)
            slot.Add(quantity);
        else
            _slots.Add(new ItemSlot(item, quantity));
        return true;
    }

    public void RemoveItem(string name, int quantity = 1)
    {
        var slot = _slots.FirstOrDefault(slot => slot.Item.Name == name);
        slot?.Remove(quantity);
        
        if (slot?.Quantity == 0) _slots.Remove(slot);
    }

    public void PrintInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var slot in _slots)
        {
            Console.WriteLine($"- {slot.Item.Name} x{slot.Quantity} (Total Weight: {slot.TotalWeight})");
        }
        Console.WriteLine($"Current Weight: {CurrentWeight}");
    }
}