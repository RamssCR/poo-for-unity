namespace PooForUnity;

public class Enemy : Character
{
    protected readonly int Damage;

    public Enemy(string name, int health, int damage) : base(name, health)
    {
        Damage = damage;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} dealt {Damage} damage.");
    }
}

public class Boss : Enemy
{
    public Boss(string name, int health, int damage) : base(name, health, damage) {}

    public override void Attack()
    {
        Console.WriteLine($"{Name} dealt {Damage} damage.");
    }
}