using System;

namespace DemoProject3
{
    public class Program
    {
        /// <summary>
        /// Main entry point for the application
        /// </summary>
        public static void Main(string[] args)
        {
            var name = args.Length > 0
                ? args[0]
                : "World";
            
            // Demo comment
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
