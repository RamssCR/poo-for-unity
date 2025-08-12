using PooForUnity;

// Weapons
Weapon axe = new("Axe", 15);
Weapon sword = new("Sword", 10);
Weapon zweihander = new("Zweihander", 25);

// Players
Player hermit = new("Kendall", 100, axe);
Player knight = new("Zell", 150, sword);

// Enemies
Enemy glob = new("Glob", 32, 5);
Boss dragon = new("Dragon", 500, 20);

// Attacking enemies
hermit.Attack();
glob.TakeDamage(15);

dragon.Attack();
knight.TakeDamage(20);

// Changing weapons
knight.ChangeWeapon(zweihander);
knight.Attack();