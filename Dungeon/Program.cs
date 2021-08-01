using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;//added
using DungeonLibrary;//added

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string playerName;
            bool raceSelection = true;
            bool weaponSelection = true;

            Console.Title = "The Adamantite Crypt";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
___________.__                _____       .___                             __  .__  __           _________                        __   
\__    ___/|  |__   ____     /  _  \    __| _/____    _____ _____    _____/  |_|__|/  |_  ____   \_   ___ \_______ ___.__._______/  |_ 
  |    |   |  |  \_/ __ \   /  /_\  \  / __ |\__  \  /     \\__  \  /    \   __\  \   __\/ __ \  /    \  \/\_  __ <   |  |\____ \   __\
  |    |   |   Y  \  ___/  /    |    \/ /_/ | / __ \|  Y Y  \/ __ \|   |  \  | |  ||  | \  ___/  \     \____|  | \/\___  ||  |_> >  |  
  |____|   |___|  /\___  > \____|__  /\____ |(____  /__|_|  (____  /___|  /__| |__||__|  \___  >  \______  /|__|   / ____||   __/|__|  
                \/     \/          \/      \/     \/      \/     \/     \/                   \/          \/        \/     |__|         
");
            Console.ResetColor();
            Thread.Sleep(2500);
            Race playerRace = Race.Imperial;
            Console.WriteLine("What is thy name?");
            playerName = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine($"Most well {playerName}.  Choose thy race");

            do
            {
                Console.WriteLine(
                    "1) Altmer - Lower life but higher hit and block chance.\n" +
                    "2) Argonian - Higher life but less hit and block chance.\n" +
                    "3) Bosmer - Lower life but higher hit and block chance.\n" +
                    "4) Breton - Higher life but less hit and block chance.\n" +
                    "5) Dunmer - Slightly higher life and hit chance but lower block chance.\n" +
                    "6) Imperial - Standard\n" +
                    "7) Khajit - Lower life but higher hit and block chance.\n" +
                    "8) Nord - Higher life but less hit and block chance.\n" +
                    "9) Orsimer - Higher life but less hit and block chance.\n" +
                    "0) Redguard - Lower life but higher hit and block chance.\n");
                ConsoleKey raceChoice = Console.ReadKey(true).Key;
                Console.Clear();
                switch (raceChoice)
                {
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        playerRace = Race.Redguard;
                        raceSelection = false;
                        break;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        playerRace = Race.Altmer;
                        raceSelection = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        playerRace = Race.Argonian;
                        raceSelection = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        playerRace = Race.Bosmer;
                        raceSelection = false;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        playerRace = Race.Breton;
                        raceSelection = false;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        playerRace = Race.Dunmer;
                        raceSelection = false;
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        raceSelection = false;
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        playerRace = Race.Khajit;
                        raceSelection = false;
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        playerRace = Race.Nord;
                        raceSelection = false;
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        playerRace = Race.Orsimer;
                        raceSelection = false;
                        break;
                    default:
                        Console.WriteLine($"{raceSelection} was not a valid option. Prithee choose again");
                        break;
                }
            } while (raceSelection);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
___________.__                _____       .___                             __  .__  __           _________                        __   
\__    ___/|  |__   ____     /  _  \    __| _/____    _____ _____    _____/  |_|__|/  |_  ____   \_   ___ \_______ ___.__._______/  |_ 
  |    |   |  |  \_/ __ \   /  /_\  \  / __ |\__  \  /     \\__  \  /    \   __\  \   __\/ __ \  /    \  \/\_  __ <   |  |\____ \   __\
  |    |   |   Y  \  ___/  /    |    \/ /_/ | / __ \|  Y Y  \/ __ \|   |  \  | |  ||  | \  ___/  \     \____|  | \/\___  ||  |_> >  |  
  |____|   |___|  /\___  > \____|__  /\____ |(____  /__|_|  (____  /___|  /__| |__||__|  \___  >  \______  /|__|   / ____||   __/|__|  
                \/     \/          \/      \/     \/      \/     \/     \/                   \/          \/        \/     |__|         
");
            Console.WriteLine($"I welcome you to THE ADMANTITE CRYPT {playerName} the {playerRace}");
            Console.ResetColor();



            Weapon shortBow = new Weapon("Short Bow", 15, 6, 1, false);
            Weapon longBow = new Weapon("Long Bow", 20, 7, 1, true);
            Weapon shortSword = new Weapon("Short Sword", 10, 4, 1, false);
            Weapon longSword = new Weapon("Long Sword", 15, 10, 1, true);
            Weapon greatSword = new Weapon("Great Sword", 20, 8, 1, true);
            //CAPTURES USER INPUT TO CHOOOSE THEIR DESIRED WEAPON
            Console.WriteLine($"Choose your weapon {playerName} the {playerRace}!");
            ConsoleKey weaponChoice;
            Player player = new Player(playerName, 50, 50, 20, 10, shortSword, playerRace);
            do
            {
                Console.WriteLine(
                   "1) Short Bow\n" +
                   "2) Long Bow\n" +
                   "3) Short Sword\n" +
                   "4) Long Sword\n" +
                   "5) Great Sword\n");
                weaponChoice = Console.ReadKey(true).Key;
                switch (weaponChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        player.EquippedWeapon = shortBow;
                        weaponSelection = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        player.EquippedWeapon = longBow;
                        weaponSelection = false;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        player.EquippedWeapon = shortSword;
                        weaponSelection = false;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        player.EquippedWeapon = longSword;
                        weaponSelection = false;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        player.EquippedWeapon = greatSword;
                        weaponSelection = false;
                        break;
                    default:
                        break;
                }
            } while (weaponSelection); //end do while

            Console.WriteLine(player);
        }
    }
}
