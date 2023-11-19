namespace CreaturesAndCharacters.Enemies
{
    public class Goblin : Creature
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 50;
            Krit = 30;
        }

        public override void Attack(Character player)
        {
            int damage = new Random().Next(3, 11);
            int rn = new Random().Next(1, 6);
            switch (rn)
            {
                case 5:
                    damage += Krit;
                    player.Health -= damage;
                    Console.WriteLine($"Goblin krit you for {damage} damage");
                    damage -= Krit;
                    Console.WriteLine($"Character has {player.Health} hp");
                    break;
                default:
                    player.Health -= damage;
                    Console.WriteLine($"Goblin attacks you for {damage} damage");
                    Console.WriteLine($"Character has {player.Health} hp");
                    break;
            }
        }
    }
}
