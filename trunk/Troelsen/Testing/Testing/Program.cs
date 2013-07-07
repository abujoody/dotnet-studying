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

            // V3
            /*for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg[{0}]: {1}", i, args[i]); 
            }*/

            string[] cmdArgs = Environment.GetCommandLineArgs();
            int i = 0;
            foreach (string arg in cmdArgs)
            {
                Console.WriteLine("Arg[i++]: {1}", i, arg);
            }

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
