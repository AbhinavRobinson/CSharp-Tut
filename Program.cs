using System;

namespace CSharp_Tut
{
    class Program
    {
        public static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
            PlayGame();
        }

        private static void PlayGame()
        {
            while (true)
            {
                // Set correct Number
                var random = new Random();
                var correctNum = random.Next(1, 10);
                Console.WriteLine("Guess a number between 1 and 10!");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out var guess))
                    {
                        PrintColorMessage("Please enter a valid number!", ConsoleColor.Red);
                        continue;
                    }

                    if (guess != correctNum) PrintColorMessage("Incorrect, Please try again ...", ConsoleColor.Red);
                    else break;
                }

                PrintColorMessage("Correct (0-0)", ConsoleColor.Green);
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine();
                if (answer?.ToUpper() == "N") break;
            }

            PrintColorMessage("Okay Bye Now...", ConsoleColor.Green);
        }

        private static void GetAppInfo()
        {
            // Set app vars
            const string appName = "NumberGusser";
            const string appVersion = "1.0.0";
            const string appAuthor = "Abhinav Robinson";

            // Change Console text color
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
        
        private static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What's your name?");

            // Get input
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", userName);
            PrintColorMessage("Let's play a game :)", ConsoleColor.Yellow);
        }

        private static void PrintColorMessage(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}