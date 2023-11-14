using Weapons;
using CreaturesAndCharacters;
using CreaturesAndCharacters.Enemies;
using CreaturesAndCharacters.Characters;
using static System.Net.Mime.MediaTypeNames;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon staff = new MageWeapon("Staff", 25, 50);
            Weapon grimoire = new MageWeapon("Grimoire", 25, 60);
            Weapon dagger = new AssasinWeapon("Dagger", 20, 40);
            Weapon knife = new AssasinWeapon("Knife", 15, 30);
            Weapon halberd = new KnightWeapon("Halberd", 40, 80);
            Weapon twohandedsword = new KnightWeapon("Two-HandedSword", 50, 100);
            bool Alive = true;
            Random randomc = new Random();
            int coins = 0;
                while (Alive == true)
                {
                    Console.WriteLine("Choose a character: 1 - Mage , 2 - Assasin , 3 - Knight\n 5 - info 6 - exit\n");
                    int ChoiseC;
                    int.TryParse(Console.ReadLine(), out ChoiseC);
                    bool Game = true;
                    int killedcreatures = 0;
                    switch (ChoiseC)
                    {
                        case 1:
                            Console.WriteLine("Choose a Weapon: 1 - Staff , 2 - Grimoire");
                            int choiseWM;
                            int.TryParse(Console.ReadLine(), out choiseWM);
                            if (choiseWM == 1)
                            {
                                Mage mage = new Mage(100, staff);
                                while (Game == true)
                                {
                                    {
                                        Creature[] creatures = new Creature[] { new Goblin(), new Troll(), new Slime() };
                                        int index = randomc.Next(creatures.Length);
                                        Creature creature = creatures[index];
                                        if (killedcreatures == 5)
                                        {
                                            Console.WriteLine("\nYou have defeated all the enemies of the dungeon, the reward is received\n");
                                            coins += 200;
                                            Console.WriteLine($"\nYour gold - {coins}\n");
                                            Game = false;
                                            break;
                                        }
                                        Console.WriteLine($"\nYou meet {creature.Name} , it has {creature.Health} hp\n");
                                        while (creature.Health > 0 && Game == true)
                                        {
                                            Console.WriteLine("1 - Attack , 2 - Defend , 3 - Buy Heal 100c/hp\n");
                                            int choisemove;
                                            int.TryParse(Console.ReadLine(), out choisemove);
                                            if (choisemove == 1)
                                            {
                                                mage.Attack(creature);
                                                if (creature.Health <= 0)
                                                {
                                                    killedcreatures++;
                                                }
                                                else
                                                {
                                                    creature.Attack(mage);
                                                    if (mage.Health <= 0)
                                                    {
                                                        Game = false;
                                                        Console.WriteLine("\nYou lose\n");
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (choisemove == 2)
                                            {
                                                mage.Defend();
                                            }
                                            else if (choisemove == 3)
                                            {
                                                mage.Heal(mage, coins);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect input , try again\n");
                                            }
                                        }
                                    }
                                }
                            }



                            else if (choiseWM == 2)
                            {
                                Mage mage = new Mage(100, grimoire);
                                while (Game == true)
                                {
                                    {

                                        Creature[] creatures = new Creature[] { new Goblin(), new Troll(), new Slime() };
                                        int index = randomc.Next(creatures.Length);
                                        Creature creature = creatures[index];
                                        if (killedcreatures == 5)
                                        {
                                            Console.WriteLine("\nYou have defeated all the enemies of the dungeon, the reward is received\n");
                                            coins += 100;
                                            Console.WriteLine($"\nYour gold - {coins}\n");
                                            Game = false;
                                            break;
                                        }
                                        Console.WriteLine($"\nYou meet {creature.Name} , it has {creature.Health} hp\n");
                                        while (creature.Health > 0 && Game == true)
                                        {
                                            Console.WriteLine(" 1 - Attack , 2 - Defend , 3 - Buy Heal 100c/hp\n");
                                            int choisemove;
                                            int.TryParse(Console.ReadLine(), out choisemove);
                                            if (choisemove == 1)
                                            {
                                                mage.Attack(creature);
                                                if (creature.Health <= 0)
                                                {
                                                    killedcreatures++;
                                                }
                                                else
                                                {
                                                    creature.Attack(mage);
                                                    if (mage.Health <= 0)
                                                    {
                                                        Game = false;
                                                        Console.WriteLine("\nYou lose\n");
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (choisemove == 2)
                                            {
                                                mage.Defend();
                                            }
                                            else if (choisemove == 3)
                                            {
                                                mage.Heal(mage, coins);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect input , try again\n");
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input . Create character again\n");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Choose a Weapon: 1 - Dagger , 2 - Knife");
                            int choiseWA;
                            int.TryParse(Console.ReadLine(), out choiseWA);
                            if (choiseWA == 1)
                            {
                                Assasin assasin = new Assasin(150, dagger);
                                while (Game == true)
                                {
                                    {
                                        Creature[] creatures = new Creature[] { new Goblin(), new Goblin(), new Troll(), new Slime() };
                                        int index = randomc.Next(creatures.Length);
                                        Creature creature = creatures[index];
                                        if (killedcreatures == 5)
                                        {
                                            Console.WriteLine("\nYou have defeated all the enemies of the dungeon, the reward is received\n");
                                            coins += 100;
                                            Console.WriteLine($"\nYour gold - {coins}\n");
                                            Game = false;
                                            break;
                                        }
                                        Console.WriteLine($"\nYou meet {creature.Name} , it has {creature.Health} hp\n");
                                        while (creature.Health > 0 && Game == true)
                                        {
                                            Console.WriteLine("Choise 1 - Attack , 2 - Defend , 3 - Buy Heal 100c/hp\n");
                                            int choisemove = Convert.ToInt32(Console.ReadLine());
                                            if (choisemove == 1)
                                            {
                                                assasin.Attack(creature);
                                                if (creature.Health <= 0)
                                                {
                                                    killedcreatures++;
                                                }
                                                else
                                                {
                                                    creature.Attack(assasin);
                                                    if (assasin.Health <= 0)
                                                    {
                                                        Game = false;
                                                        Console.WriteLine("\nYou lose\n");
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (choisemove == 2)
                                            {
                                                assasin.Defend();
                                            }
                                            else if (choisemove == 3)
                                            {
                                                assasin.Heal(assasin, coins);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect input , try again\n");
                                            }
                                        }
                                    }
                                }
                            }
                            else if (choiseWA == 2)
                            {
                                Assasin assasin = new Assasin(150, knife);
                                while (Game == true)
                                {
                                    {
                                        Creature[] creatures = new Creature[] { new Goblin(), new Troll(), new Troll(), new Slime() };
                                        int index = randomc.Next(creatures.Length);
                                        Creature creature = creatures[index];
                                        if (killedcreatures == 5)
                                        {
                                            Console.WriteLine("\nYou have defeated all the enemies of the dungeon, the reward is received\n");
                                            coins += 100;
                                            Console.WriteLine($"\nYour gold - {coins}\n");
                                            Game = false;
                                            break;
                                        }
                                        Console.WriteLine($"\nYou meet {creature.Name} , it has {creature.Health} hp\n");
                                        while (creature.Health > 0 && Game == true)
                                        {
                                            Console.WriteLine("Choose 1 - Attack , 2 - Defend , 3 - Buy Heal 100c/hp\n");
                                            int choisemove;
                                            int.TryParse(Console.ReadLine(), out choisemove);
                                            if (choisemove == 1)
                                            {
                                                assasin.Attack(creature);
                                                if (creature.Health <= 0)
                                                {
                                                    killedcreatures++;
                                                }
                                                else
                                                {
                                                    creature.Attack(assasin);
                                                    if (assasin.Health <= 0)
                                                    {
                                                        Game = false;
                                                        Console.WriteLine("\nYou lose\n");
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (choisemove == 2)
                                            {
                                                assasin.Defend();
                                            }
                                            else if (choisemove == 3)
                                            {
                                                assasin.Heal(assasin, coins);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect input , try again\n");
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorect input . Create character again\n");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Choose a Weapon: 1 - Halberd , 2 - Two-handed sword");
                            int choiseWK;
                            int.TryParse(Console.ReadLine(), out choiseWK);
                            if (choiseWK == 1)
                            {
                                Knight knight = new Knight(250, halberd);
                                while (Game == true)
                                {
                                    {
                                        Creature[] creatures = new Creature[] { new Zombi(), new Troll(), new Troll(), new Slime() };
                                        int index = randomc.Next(creatures.Length);
                                        Creature creature = creatures[index];
                                        if (killedcreatures == 5)
                                        {
                                            Console.WriteLine("\nYou have defeated all the enemies of the dungeon, the reward is received\n");
                                            coins += 300;
                                            Console.WriteLine($"\nYour gold - {coins}\n");
                                            Game = false;
                                            break;
                                        }
                                        Console.WriteLine($"\nYou meet {creature.Name} , it has {creature.Health} hp\n");
                                        while (creature.Health > 0 && Game == true)
                                        {
                                            Console.WriteLine("Choise 1 - Attack , 2 - Defend , 3 - Buy Heal 100c/hp\n");
                                            int choisemove = Convert.ToInt32(Console.ReadLine());
                                            if (choisemove == 1)
                                            {
                                                knight.Attack(creature);
                                                if (creature.Health <= 0)
                                                {
                                                    killedcreatures++;
                                                }
                                                else
                                                {
                                                    creature.Attack(knight);
                                                    if (knight.Health <= 0)
                                                    {
                                                        Game = false;
                                                        Console.WriteLine("\nYou lose\n");
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (choisemove == 2)
                                            {
                                                knight.Defend();
                                            }
                                            else if (choisemove == 3)
                                            {
                                                knight.Heal(knight, coins);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect input , try again\n");
                                            }
                                        }
                                    }
                                }
                            }
                            else if (choiseWK == 2)
                            {
                                Knight knight = new Knight(250, twohandedsword);
                                while (Game == true)
                                {
                                    {
                                        Creature[] creatures = new Creature[] { new Zombi(), new Troll(), new Troll(), new Slime() };
                                        int index = randomc.Next(creatures.Length);
                                        Creature creature = creatures[index];
                                        if (killedcreatures == 5)
                                        {
                                            Console.WriteLine("\nYou have defeated all the enemies of the dungeon, the reward is received\n");
                                            coins += 300;
                                            Console.WriteLine($"\nYour gold - {coins}\n");
                                            Game = false;
                                            break;
                                        }
                                        Console.WriteLine($"\nYou meet {creature.Name} , it has {creature.Health} hp\n");
                                        while (creature.Health > 0 && Game == true)
                                        {
                                            Console.WriteLine("Choose 1 - Attack , 2 - Defend , 3 - Buy Heal 100c/hp\n");
                                            int choisemove;
                                            int.TryParse(Console.ReadLine(), out choisemove);
                                            if (choisemove == 1)
                                            {
                                                knight.Attack(creature);
                                                if (creature.Health <= 0)
                                                {
                                                    killedcreatures++;
                                                }
                                                else
                                                {
                                                    creature.Attack(knight);
                                                    if (knight.Health <= 0)
                                                    {
                                                        Game = false;
                                                        Console.WriteLine("\nYou lose\n");
                                                        break;
                                                    }
                                                }
                                            }
                                            else if (choisemove == 2)
                                            {
                                                knight.Defend();
                                            }
                                            else if (choisemove == 3)
                                            {
                                                knight.Heal(knight, coins);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect input , try again\n");
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorect input . Create character again\n");
                            }
                            break;
                        case 5:
                            Console.WriteLine("\nВ игре присутствуют 3 героя и 4 монстра , у всех героев разный шанс на крит урон , шанс на крит у врагов - 25%." +
                                " \nУ каждого героя есть 2 оружия на выбор у них разный урон и разный крит . " +
                                "\nОружия обладают скрытыми характеристиками такими как прокачка урона или крита после убийства врага ." +
                                " \nВсе герои имеют разное здоровье но лечение работает на всех одинаково 100 монет за 50 хп ." +
                                "\nЗа игру на каждом персонаже вы получаете разное количество монет ," +
                                " чем больше награда тем сильнее попадаются монстры ." +
                                "\nЕсли играть за Мага (средний шанс на всё , монстры - лёгкие)- 100 хп 100 монет ," +
                                " \nАссасин (много крита но средние монстры)- 150 хп 200 монет" +
                                " , \nРыцарь (маленький шанс крита и прокачки , сильные монстры)250 хп 300 монет\n");
                            break;
                        case 6:
                            Console.WriteLine("\nBye-bye\n");
                            Alive = false;
                            break;
                        default:
                            Console.WriteLine("Incorrect input , try again");
                            break;

                    }
                }

        }
    }
}