namespace Weapons
{
    public class KnightWeapon : Weapon
    {
        public KnightWeapon(string name, int damage, int krit)
        : base(name, damage, krit)
        {

        }

        public override void HiddenCharacteristics()
        {
            var random = new Random();
            var randomNumber = random.Next(1, 5);
            switch (randomNumber)
            {
                case 2:
                    if (Name == "Halberd")
                    {
                        Krit += 30;
                    }
                    else if (Name == "TwoHandedSword")
                    {
                        Damage += 20;
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
