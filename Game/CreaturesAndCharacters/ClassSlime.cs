namespace CreaturesAndCharacters.Enemies
{
    public class Slime : Creature
    {
        public Slime()
        {
            Name = "Slime";
            Health = 120;
            Krit = 40;
        }

        public override void Attack(Character player)
        {
            int damage = new Random().Next(20, 30);
            int rn = new Random().Next(1, 6);
            switch (rn)
            {
                case 5:
                    damage += Krit;
                    player.Health -= damage;
                    Console.WriteLine($"Slime krit you for {damage} damage");
                    damage -= Krit;
                    Console.WriteLine($"Character has {player.Health} hp");
                    break;
                default:
                    player.Health -= damage;
                    Console.WriteLine($"Slime attacks you for {damage} damage");
                    Console.WriteLine($"Character has {player.Health} hp");
                    break;
            }
        }
    }
}
