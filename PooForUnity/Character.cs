namespace PooForUnity;

public abstract class Character
{
    private string _name;
    public int Health { get; protected set; }

    protected Character(string name, int health)
    {
        _name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{_name} takes {damage} damage.");
    }
    
    public abstract void Attack();
}