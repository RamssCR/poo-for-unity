using PooForUnity;

// Creating Skills
Fireball fireball = new("Fire ball", 6, 10);
PowerStrike powerStrike = new("Power Strike", 7, 20);
Heal heal = new("Raw Healing", 10, 15);

// Creating Characters
Warrior warrior = new("Warrior", 20, 50, 3, powerStrike);
Mage mage = new("Mage", 30, 48, 4, fireball);
Cleric cleric = new("Cleric", 40, 45, 10, heal);

// Combat Simulation
warrior.Attack(mage, 20); // Basic Attack
cleric.UseSkill(mage); // Cleric heals mage
warrior.UseSkill(cleric); // Cleric dies
mage.UseSkill(warrior); // Mage attacks warrior
warrior.Attack(mage, 25); // Mage dies