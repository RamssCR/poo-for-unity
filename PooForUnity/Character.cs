namespace PooForUnity;

public abstract class Character
{
    protected readonly string Name;
    public int Health { get; protected set; }

    protected Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage.");
    }
    
    public abstract void Attack();
}