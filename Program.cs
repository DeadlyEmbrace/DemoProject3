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
            var name = "World";
            
            if(args.Length > 0)
            {
                name = args[0];
            }

            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
