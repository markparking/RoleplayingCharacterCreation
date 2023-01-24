using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Menu
    {
        Character character = new Character();
        Stats stats = new Stats();
        private string check;
        public void MainMenu()
        {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(50, 11);
                Console.WriteLine("Welcome Traveller!");
                Console.SetCursorPosition(50, 12);
                Console.WriteLine("Create new Character (1)");
                Console.SetCursorPosition(50, 13);
                Console.WriteLine("Show Current Character (2)");
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("Calculate Character Age (3)");
                Console.SetCursorPosition(50, 15);
                Console.WriteLine("Exit (4)");
                Console.SetCursorPosition(50, 16);
                Console.WriteLine("Input:");
                Console.SetCursorPosition(57, 16);
                check = Console.ReadLine();

                switch (check)
                {
                    case "1":
                        CreateCharacterMenu();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Name: " + character.Name);
                    Console.WriteLine("Class: " + character.Class);
                    Console.WriteLine("Race: " + character.Race);
                    Console.WriteLine("Birthday: " + character.Birthday);
                    Console.WriteLine("Level: " + character.Level);
                    Console.WriteLine("Stats:");
                    Console.WriteLine("Str: " + stats.Strength);
                    Console.WriteLine("Dex: " + stats.Dexterity);
                    Console.WriteLine("Int: " + stats.Intelligence);
                    Console.WriteLine("Con: " + stats.Constitution);
                    Console.WriteLine("Wis: " + stats.Wisdom);
                    Console.WriteLine("Char: " + stats.Charisma);


                    Console.ReadKey();
                    MainMenu();
                        break;
                    
                    case "3":
                    Console.Clear();
                    DateTime birthday = character.Birthday;
                    int age = CalculateAge.Age(birthday);
                    Console.WriteLine("Your current Characters age is: " + age);
                    Console.ReadKey();
                    MainMenu();
                        break;
                    case "4":
                    Console.Clear();
                    Console.WriteLine("Farewell Traveller");
                    Console.ReadKey();
                    Environment.Exit(0);
                        break;

                default:
                        Console.Clear();
                        Console.WriteLine("Please only use 1, 2 or 3");
                        Console.ReadKey();
                        MainMenu();
                        break;
                }
        }
        public void CreateCharacterMenu()
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("What is your name, brave Adventurer?");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("Input:");
            Console.SetCursorPosition(57, 14);
            character.Name = Console.ReadLine();
            Console.Clear();
            Classes();
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Well, {0}. What class are you?", character.Name);
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Please write your class:");
            Console.SetCursorPosition(75, 12);
            character.Class = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Tell me, {0} the {1}... What is your Race?", character.Name, character.Class);
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Please write your race:");
            Console.SetCursorPosition(75, 12);
            character.Race = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Well, {0}. When is your birthday?", character.Name);
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Please write your birthday (dd/mm/yyyy)");
            Console.SetCursorPosition(50, 13);
            character.Birthday = DateTime.Parse(Console.ReadLine());
            Console.Clear();
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Tell me, {0}, What is your level?", character.Name);
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Please write your level:");
            Console.SetCursorPosition(75, 12);
            character.Level = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            StatStrRollMenu();
        }
        public void Classes()
        {
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Sugested Classes:");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("Warrior");
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("Mage");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("Rogue");
            Console.SetCursorPosition(10, 14);
            Console.WriteLine("Bard");
            Console.SetCursorPosition(10, 15);
            Console.WriteLine("Cleric");

        }
        public void StatStrRollMenu()
        {
            Console.Clear();
            Dice dice = new Dice();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Time to roll for your Strength Stat!");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Roll the dice(1)");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("Input:");
            Console.SetCursorPosition(57, 14);
            check = Console.ReadLine();
            switch (check)
            {
                case "1":
                    Console.Clear();
                    int str = dice.NewRoll();
                    stats.Strength = str;
                    Console.WriteLine("Your Strength is {0}, Huh? Thats nice.", str);
                    Console.ReadKey();
                    StatDexRollMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please only use 1");
                    Console.ReadKey();
                    StatStrRollMenu();
                    break;
            }
        }
        public void StatDexRollMenu()
        {
            Console.Clear();
            Dice dice = new Dice();
            Stats stats = new Stats();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Time to roll for your Dexterity Stat!");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Roll the dice(1)");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("Input:");
            Console.SetCursorPosition(57, 14);
            check = Console.ReadLine();
            switch (check)
            {
                case "1":
                    Console.Clear();
                    int dex = dice.NewRoll();
                    stats.Dexterity = dex;
                    Console.WriteLine("Your Dexterity is {0}, Huh? Gotta be quick on your feet!", dex);
                    Console.ReadKey();
                    StatIntRollMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please only use 1");
                    Console.ReadKey();
                    StatDexRollMenu();
                    break;
            }
        }
        public void StatIntRollMenu()
        {
            Console.Clear();
            Dice dice = new Dice();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Time to roll for your Intelligence Stat!");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Roll the dice(1)");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("Input:");
            Console.SetCursorPosition(57, 14);
            check = Console.ReadLine();
            switch (check)
            {
                case "1":
                    Console.Clear();
                    int Int = dice.NewRoll();
                    stats.Intelligence = Int;
                    Console.WriteLine("Your Intelligence is {0}, Huh? Your mind be the best weapon you can have!", Int);
                    Console.ReadKey();
                    StatConRollMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please only use 1");
                    Console.ReadKey();
                    StatIntRollMenu();
                    break;
            }
            
        }
        public void StatConRollMenu()
        {
            Console.Clear();
            Dice dice = new Dice();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Time to roll for your Constitution Stat!");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Roll the dice(1)");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("Input:");
            Console.SetCursorPosition(57, 14);
            check = Console.ReadLine();
            switch (check)
            {
                case "1":
                    Console.Clear();
                    int con = dice.NewRoll();
                    stats.Constitution = con;
                    Console.WriteLine("Your Constitution is {0}, Huh? Your mind be the best weapon you can have!", con);
                    Console.ReadKey();
                    StatWisRollMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please only use 1");
                    Console.ReadKey();
                    StatConRollMenu();
                    break;
            }
        }
        public void StatWisRollMenu()
        {
            Console.Clear();
            Dice dice = new Dice();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Time to roll for your Wisdom Stat!");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Roll the dice(1)");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("Input:");
            Console.SetCursorPosition(57, 14);
            check = Console.ReadLine();
            switch (check)
            {
                case "1":
                    Console.Clear();
                    int wis = dice.NewRoll();
                    stats.Wisdom = wis;
                    Console.WriteLine("Your Wisdom is {0}, Huh? A smart choice may be needed...", wis);
                    Console.ReadKey();
                    StatCarRollMenu();

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please only use 1");
                    Console.ReadKey();
                    StatWisRollMenu();
                    break;
            }
        }
        public void StatCarRollMenu()
        {
            Console.Clear();
            Dice dice = new Dice();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Time to roll for your Charisma Stat!");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Roll the dice(1)");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("Input:");
            Console.SetCursorPosition(57, 14);
            check = Console.ReadLine();
            switch (check)
            {
                case "1":
                    Console.Clear();
                    int car = dice.NewRoll();
                    stats.Charisma = car;
                    Console.WriteLine("Your Charisma is {0}, Huh? A silver tongue will always be a fierce weapon!", car);
                    Console.ReadKey();
                    Console.Clear();
                    Console.SetCursorPosition(50, 11);
                    Console.WriteLine("Let the Adventure Begin!");
                    Console.ReadKey();
                    MainMenu();

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please only use 1");
                    Console.ReadKey();
                    StatCarRollMenu();
                    break;
            }
        }
    }
}
