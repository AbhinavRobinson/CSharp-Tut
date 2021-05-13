using System;

namespace CSharp_Tut
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Set app vars
            string appName = "NumberGusser";
            string appVersion = "1.0.0";
            string appAuthor = "Abhinav Robinson";
            
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
            
            // Set correct Number
            int correctNum = 7;
            
            // init guess var
            int guess = 0;
            
            Console.WriteLine("Guess a number between 1 and 10!");

            while (true)
            {
                guess = Int32.Parse(Console.ReadLine() ?? string.Empty);
                Console.ForegroundColor = ConsoleColor.Red;
                if (guess != correctNum) Console.WriteLine("Incorrect, Try again :D");
                else break;
                Console.ResetColor();
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct (0-0)");
            Console.ResetColor();
        }
    }
}