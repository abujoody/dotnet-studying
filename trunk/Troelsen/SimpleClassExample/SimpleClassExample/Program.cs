using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Test
    {
        protected internal enum XY { X, Y };

        public static int i;// = 4;

        /*public Test()
        {
            Console.WriteLine("ctor");
            //i = 666;
        }*/

        static Test()
        {
            Console.WriteLine("static ctor");
            i = 7777;
        }
    }

    class Point
    {
        //Point xx = new Point(); - very bad idea

        public const int ttt = 555;
        public readonly int rrr = 33;

        public Point() { rrr = 44; /*ttt = 3; - bad idea */ }

        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Test ts = new Test();

            Console.WriteLine(Test.i);

            Test.XY ttt = Test.XY.X;

            Car cr = new Car();
            cr.Pet = "Hehehe";
            Console.WriteLine(cr.Pet);
            cr.Pet2 = "Hehehe2222";
            Console.WriteLine(cr.Pet2);

            Point pt = new Point { X = 12, Y = 15 };

            Console.WriteLine(Point.ttt);
        }
    }
}
