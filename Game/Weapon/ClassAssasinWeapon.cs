namespace Weapons
{
    public class AssasinWeapon : Weapon
    {
        public AssasinWeapon(string name, int damage, int krit)
        : base(name, damage, krit)
        {

        }

        public override void HiddenCharacteristics()
        {
            var random = new Random();
            var randomNumber = random.Next(1, 3);
            switch (randomNumber)
            {
                case 2:
                    if (Name == "Dagger")
                    {
                        Damage += 20;
                        Krit += 20;
                    }
                    else if (Name == "Knife")
                    {
                        Krit += 40;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
