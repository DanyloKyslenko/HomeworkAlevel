namespace CreaturesAndCharacters.Enemies
{
    public class Zombi : Creature
    {
        public Zombi()
        {
            Name = "Zombi";
            Health = 160;
            Krit = 43;
        }
        public override void Attack(Character player)
        {
            int damage = new Random().Next(5, 40);
            int rn = new Random().Next(1, 6);
            switch (rn)
            {
                case 5:
                    damage += Krit;
                    player.Health -= damage;
                    Console.WriteLine($"Zombi krit you for {damage} damage");
                    damage -= Krit;
                    Console.WriteLine($"Character has {player.Health} hp");
                    break;
                default:
                    player.Health -= damage;
                    Console.WriteLine($"Zombi attacks you for {damage} damage");
                    Console.WriteLine($"Character has {player.Health} hp");
                    break;
            }
        }
    }
}
