using System;

namespace CSharp_Tut
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Set app vars
            const string appName = "NumberGusser";
            const string appVersion = "1.0.0";
            const string appAuthor = "Abhinav Robinson";

            // Change Console text color
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What's your name?");

            // Get input
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", userName);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Let's play a game :)");
            Console.ResetColor();

            while (true)
            {
                // Set correct Number
                var random = new Random();
                var correctNum = random.Next(1, 10);
                Console.WriteLine("Guess a number between 1 and 10!");
                while (true)
                {
                    string input = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (!int.TryParse(input, out var guess))
                    {
                        Console.WriteLine("Please enter a valid number!");
                        Console.ResetColor();
                        continue;
                    }

                    if (guess != correctNum) Console.WriteLine("Incorrect, Please try again ...");
                    else break;
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct (0-0)");
                Console.ResetColor();
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine();
                if (answer?.ToUpper() == "N") break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Okay Bye Now...");
            Console.ResetColor();
        }
    }
}