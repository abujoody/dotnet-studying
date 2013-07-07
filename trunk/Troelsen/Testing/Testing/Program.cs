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

            // V4
            Console.WriteLine("Logical drives: ");
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine(drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET version: {0}", Environment.Version);

            Console.WriteLine("New line: {0}", Environment.NewLine);
            Console.WriteLine("Exit code: {0}", Environment.ExitCode);
            Console.WriteLine("64 bit: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("Machine name: {0}", Environment.MachineName);
            Console.WriteLine("System directory: {0}", Environment.SystemDirectory);
            Console.WriteLine("User name: {0}", Environment.UserName);

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
