namespace PooForUnity;

public abstract class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Mana { get; protected set; }
    public int Health { get; protected set; }

    protected Character(string name, int mana, int health, int level = 1)
    {
        Name = name;
        Mana = mana;
        Level = level;
        Health = Math.Max(0, health);
    }

    public void Attack(Character target, int damage)
    {
        target.Health -= damage;
        Console.WriteLine($"{Name} attacked {target.Name} with a raw damage of {damage}!");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public abstract void UseSkill(Character target);

    public void ModifyMana(int mana) => Mana += mana;

    public void ModifyHealth(int health) => Health += health;
}

public class Warrior : Character
{
    private readonly PowerStrike _powerStrike;

    public Warrior(string name, int mana, int health, int level, PowerStrike skill) : base(name, mana, health, level)
    {
        Health = health * 2;
        _powerStrike = skill;
    }

    public override void UseSkill(Character target)
    {
        _powerStrike.Execute(this, target);
        Console.WriteLine($"{Name} attacked {target.Name} with {_powerStrike.Name}!");
        Console.WriteLine($"Target HP: {target}");
    }

    public override string ToString()
    {
        return $"{Name} (HP: {Health}, Mana: {Mana}, Level: {Level})";
    }
}

public class Mage : Character
{
    private readonly Fireball _fireball;

    public Mage(string name, int mana, int health, int level, Fireball skill) : base(name, mana, health, level)
    {
        Health = health / 2;
        _fireball = skill;
    }

    public override void UseSkill(Character target)
    {
        _fireball.Execute(this, target);
        Console.WriteLine($"{Name} attacked {target.Name} with {_fireball.Name}!");
    }
}

public class Cleric : Character
{
    private readonly Heal _heal;

    public Cleric(string name, int mana, int health, int level, Heal skill) : base(name, mana, health, level)
    {
        const int buff = 10;
        Health = health + buff;
        Mana = mana + buff;
        _heal = skill;
    }

    public override void UseSkill(Character target)
    {
        _heal.Execute(this, target);
        Console.WriteLine($"{Name} healed  {target.Name} with {_heal.Name}!");
    }
}