namespace CreaturesAndCharacters
{
    public abstract class Creature
    {
        public int Health { get; set; }
        public string? Name { get; set; }
        public int Krit { get; set; }


        public abstract void Attack(Character player);
    }
}