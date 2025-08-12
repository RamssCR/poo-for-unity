namespace PooForUnity;

public class Player : Character
{
    private Weapon _weapon;

    public Player(string name, int health, Weapon weapon) : base(name, health)
    {
        _weapon = weapon;
    }

    public override void Attack()
    {
        _weapon.Use();
    }

    public void ChangeWeapon(Weapon weapon)
    {
        Console.WriteLine($"{_weapon.Name} was changed for {weapon.Name}");
        _weapon = weapon;
    }
}