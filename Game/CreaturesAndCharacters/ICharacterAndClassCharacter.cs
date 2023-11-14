using Weapons;

namespace CreaturesAndCharacters
{
    interface ICharacter
    {
        public int Health { get; set; }
        public Weapon Weapon { get; set; }
        void Attack(Creature creature)
        {

        }
        void Defend()
        {

        }
        void Heal()
        {

        }
    }
    public abstract class Character : ICharacter
    {
        public int Health { get; set; }
        public Weapon Weapon { get; set; }
        public int healing = 50;
        void Attack(Creature creature)
        {

        }
        void Defend()
        {

        }
        void Heal()
        {

        }
    }
}
