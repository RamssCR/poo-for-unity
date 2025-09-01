namespace PooForUnity;

public abstract class Skill
{
    public string Name { get; }
    protected int ManaCost { get; }
    protected int Power { get; }

    protected Skill(string name, int manaCost, int power)
    {
        Name = name;
        ManaCost = manaCost;
        Power = power;
    }
    
    public abstract void Execute(Character caster, Character target);
}

public class Fireball : Skill
{
    public Fireball(string name, int manaCost, int power) : base(name, manaCost, power) { }

    public override void Execute(Character caster, Character target)
    {
        caster.ModifyMana(-ManaCost);
        target.ModifyHealth(-Power);
    }
}

public class Heal : Skill
{
    public Heal(string name, int manaCost, int power) : base(name, manaCost, power) { }

    public override void Execute(Character caster, Character target)
    {
        caster.ModifyMana(-ManaCost);
        target.ModifyHealth(Power);
    }
}

public class PowerStrike : Skill
{
    public PowerStrike(string name, int manaCost, int power) : base(name, manaCost, power) { }

    public override void Execute(Character caster, Character target)
    {
        const int buff = 2;
        caster.ModifyMana(-ManaCost);
        target.ModifyHealth(-Power * buff);
    }
}