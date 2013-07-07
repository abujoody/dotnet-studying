using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();

            //GetUserData();

            //Test2();

            //Test3();

            //Test4();

            //LocalVarDeclarations();

            Test6();
        }

        private static void Test6()
        {
            //bool bad; bool tmp = bad;
            //- compilation error
            //"Use of unassigned local variable 'bad'"

            bool b = new bool();
            int i = new int();
            char c = new char(); // - space or '\0' ???
            double d = new double();
            DateTime dt = new DateTime();

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", b, i, c, d, dt);
            Console.WriteLine(); 
        }

        private static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            
            int myInt = 0;
            string myString;
            myString = "This is my character data";
            
            bool bl = true, b2 = false, b3 = bl;
            
            System.Boolean b4 = false;
            Console.WriteLine("Yourdata: {0}, {1}, {2}, {3}, {4}, {5}",
            myInt, myString, bl, b2, b3, b4);
            Console.WriteLine ();
        }

        private static void Test4()
        {
            System.Decimal dc = 301.5M;
            Console.WriteLine("Decimal:{0}", dc);
        }

        private static void Test3()
        {
            string userMsg = string.Format("65535 as Hex = {0:X}", 65535);
            MessageBox.Show(userMsg);
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

        private static void Test2()
        {
            Console.WriteLine("99999:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);

            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
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
