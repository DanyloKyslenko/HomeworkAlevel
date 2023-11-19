namespace Weapons
{
    interface IWeapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Krit { get; set; }

    }
    interface IHiddenCharacteristics
    {
        public void HiddenCharacteristics()
        {

        }
    }
}