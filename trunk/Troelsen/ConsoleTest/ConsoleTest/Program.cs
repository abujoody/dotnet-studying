using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Numerics;

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

            //Test6();

            //ObjectTest();

            //DataTypeFunctionality();

            //ParseFromString();

            //DateAndTime();

            //BigIntegers();

            //Strings();

            StringBuilderTest();
        }

        static void StringBuilderTest()
        {
            StringBuilder sb = new StringBuilder("test");
            sb.Append("5555555588888888");
            sb.Append(false);
            Console.WriteLine(sb);
        }

        static void Strings()
        {
            //Basic
            string str = "Test string";
            Console.WriteLine("Length: {0}", str.Length);
            Console.WriteLine("To upper: {0}", str.ToUpper());
            Console.WriteLine("Insert: {0}", str.Insert(1, "XXX"));
            Console.WriteLine("Contains X: {0}", str.Contains("X"));
            Console.WriteLine("s -> |: {0}", str.Replace('s', '|'));

            Console.WriteLine("{0} {1}", "ttt" + "xxx", "yyy");
            Console.WriteLine("{0} {1}", string.Concat("ttt", "xxx"), "yyy");

            string str2 = @"D:\Temp\Test";
            Console.WriteLine(str2);
            string str3 = @"D:\Temp\    
                    Test
            555";
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            string s1 = "sss";
            string s2 = "sss";

            Console.WriteLine("s1 == s2? : {0}", s1 == s2);
        }

        static void BigIntegers()
        {
            BigInteger bi = BigInteger.Parse(
                "99999999999999999999999999999999999999999999999");
            BigInteger bi2 = BigInteger.Parse(
                "7777777777777777777777777777777777777777777777");

            Console.WriteLine("Bi: {0}", bi);
            Console.WriteLine("Bi2: {0}", bi2);
            Console.WriteLine("Bi / Bi2 = {0}",
                BigInteger.Divide(bi, bi2));
            Console.WriteLine("Bi * Bi2 = {0}",
                BigInteger.Multiply(bi, bi2));
            Console.WriteLine("Bi + Bi2 = {0}",
                bi + bi2);
        }

        static void DateAndTime()
        {
            DateTime dt = new DateTime(2013, 10, 11, 17, 15, 58);
            dt = dt.AddDays(2);
            Console.WriteLine("DateTime: {0}", dt);

            TimeSpan ts = new TimeSpan(5, 4, 3);
            ts = ts.Subtract(new TimeSpan(1, 5, 4));

            Console.WriteLine("TimeSpan: {0}", ts);
        }

        static void ParseFromString()
        {
            Console.WriteLine("=> Data type parsing:");

            bool b = bool.Parse("true");
            b = bool.Parse("tRue");
            b = bool.Parse("false");
            b = bool.Parse("faLse");

            int i = int.Parse("777");
            Console.WriteLine("Int from 777: {0}", i);

            if (int.TryParse("aaa", out i) == true)
                Console.WriteLine("Int from aaa: {0}", i);
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.Epsilon: {0}", double.NaN);
            Console.WriteLine("double.PositiveInfinity: {0}",
            double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}",
            double.NegativeInfinity);
            Console.WriteLine();

            Console.WriteLine("bool.FalseString: {0} ", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);

            Console.WriteLine("\n=> char type Functionality:");
            char myChar = 'а';
            Console.WriteLine("char.IsDigit ('а') : {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter ('а') : {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace(\"Hello There\", 5): {0}",
            char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace(\"Hello There\", 6): {0}",
            char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}",
            char.IsPunctuation('?'));
            Console.WriteLine();
        }

        private static void ObjectTest()
        {
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.Equals(12) = {0}", 12.Equals(12));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
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
