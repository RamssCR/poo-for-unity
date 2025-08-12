namespace PooForUnity;

public class Weapon
{
    public string Name { get; }
    public int Damage { get; }

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public void Use()
    {
        Console.WriteLine($"{Name} dealt {Damage} damage points");
    }
}