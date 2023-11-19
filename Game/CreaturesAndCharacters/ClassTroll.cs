namespace CreaturesAndCharacters.Enemies
{
    public class Troll : Creature
    {
        public Troll()
        {
            Name = "Troll";
            Health = 80;
            Krit = 28;
        }

        public override void Attack(Character player)
        {
            int damage = new Random().Next(10, 20);
            int rn = new Random().Next(1, 6);
            switch (rn)
            {
                case 5:
                    damage += Krit;
                    player.Health -= damage;
                    Console.WriteLine($"Troll krit you for {damage} damage");
                    damage -= Krit;
                    Console.WriteLine($"Character has {player.Health} hp");
                    break;
                default:
                    player.Health -= damage;
                    Console.WriteLine($"Troll attacks you for {damage} damage");
                    Console.WriteLine($"Character has {player.Health} hp");
                    break;
            }
        }
    }
}
