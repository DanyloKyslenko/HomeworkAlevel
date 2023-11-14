namespace Weapons
{
    public class Weapon : IWeapon, IHiddenCharacteristics
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Krit { get; set; }
        public Weapon(string name, int damage, int krit)
        {
            Name = name;
            Damage = damage;
            Krit = krit;
        }
        public virtual void HiddenCharacteristics()
        {

        }
    }
}
