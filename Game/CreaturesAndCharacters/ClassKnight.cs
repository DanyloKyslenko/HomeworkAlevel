using Weapons;

namespace CreaturesAndCharacters.Characters
{
    public class Knight : Character
    {
        public Knight(int health, Weapon weapon)
        {
            Health = health;
            Weapon = weapon;
        }
        public void Attack(Creature creature)
        {
            var rand = new Random();
            var Kritchance = rand.Next(1, 5);
            switch (Kritchance)
            {
                case 2:
                    Console.WriteLine("\nCritical damage worked");
                    Weapon.Damage += Weapon.Krit;
                    creature.Health -= Weapon.Damage;
                    Console.WriteLine($"{Weapon.Name} attack {creature.Name} for {Weapon.Damage} damage.");
                    Console.WriteLine($"{creature.Name} has {creature.Health} hp");
                    Weapon.Damage -= Weapon.Krit;
                    if (creature.Health <= 0)
                    {
                        Weapon.HiddenCharacteristics();
                    }
                    break;
                default:
                    creature.Health -= Weapon.Damage;
                    Console.WriteLine($"{Weapon.Name} attack {creature.Name} for {Weapon.Damage} damage.");
                    Console.WriteLine($"{creature.Name} has {creature.Health} hp");
                    if (creature.Health <= 0)
                    {
                        Weapon.HiddenCharacteristics();
                    }
                    break;
            }
        }
        public void Defend()
        {
            Console.WriteLine($"{GetType().Name} Blocks the attack.");
        }
        public void Heal(Character player, int balance)
        {
            if (player.Health < 100 && balance > 100)
            {
                player.Health += healing;
                Console.WriteLine($"You have successfully restored health.  Health now {player.Health}");
            }
            else if (player.Health > 100)
            {
                Console.WriteLine($"You have enough health.  Health now {player.Health}");
            }
            else if (balance < 100)
            {
                Console.WriteLine($"You don't have enough coins.  Сoins now {balance}");
            }
        }
    }
}
