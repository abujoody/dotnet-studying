using System;

namespace Testing
{
    class Program
    {
        static int Main(string[] args)
        {
            // V1
            /*Console.WriteLine("Testing! 1, 2, 3");

            Message msg = new Message();
            msg.speak();*/

            // V2
            ConfigureCUI();

            Console.ReadLine();

            return 0;
        }

        private static void ConfigureCUI()
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************");
            Console.WriteLine("**** Welcome to My Rocking App ****");
            Console.WriteLine("***********************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
