using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();

            GetUserData();
        }

        private static void Test1()
        {
            Console.Beep();

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.ReadLine();

            Console.Title = "Hehehe";
            Console.BufferHeight = 100;
            Console.WindowWidth = 100;

            Console.ReadLine();

            Console.WindowHeight = 50;
            Console.WindowWidth = 50;

            Console.ReadLine();

            Console.WindowTop = 25;
            Console.WindowLeft = 25;

            Console.ReadLine();
        }

        private static void GetUserData()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hello {0}! You are {1} years old",
                userName, userAge);

            Console.ForegroundColor = prevColor;
        }
    }
}
