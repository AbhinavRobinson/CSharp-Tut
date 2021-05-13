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
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
    }
}