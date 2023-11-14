using System;
using System.Collections.Generic;
namespace Weapons
{
    public class MageWeapon : Weapon
    {
        public MageWeapon(string name, int damage, int krit)
        : base(name, damage, krit)
        {

        }

        public override void HiddenCharacteristics()
        {
            var random = new Random();
            var randomNumber = random.Next(1, 4);
            switch (randomNumber)
            {
                case 2:
                    if (Name == "Staff")
                    {
                        Damage += 15;
                    }
                    else if (Name == "SpellBook")
                    {
                        Krit += 15;
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
