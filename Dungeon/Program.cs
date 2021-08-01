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
                    "1) Altmer -\n" +
                    "2) Argonian -\n" +
                    "3) Bosmer -\n" +
                    "4) Breton -\n" +
                    "5) Dunmer -\n" +
                    "6) Imperial -\n" +
                    "7) Khajit -\n" +
                    "8) Nord -\n" +
                    "9) Orsimer -\n" +
                    "0) Redguard -\n");
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
            

        }
    }
}
