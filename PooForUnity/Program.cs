using PooForUnity;

var potion = new Item("Potion", 1, true);
var gold = new Item("Gold", 2, true);
var sword = new Item("Sword", 5, false);

Inventory inventory = new();

inventory.AddItem(potion, 3);
inventory.AddItem(gold, 2);
inventory.AddItem(sword);
inventory.AddItem(sword);
inventory.AddItem(potion, 10); // Inventory full

inventory.PrintInventory();

inventory.RemoveItem("Sword");
inventory.PrintInventory();