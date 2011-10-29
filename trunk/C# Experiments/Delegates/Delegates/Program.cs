using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    class Test
    {
        public string Foo(int x, int y)
        {
            Console.WriteLine("Test. x = {0}, y = {1}", x, y);
            return "test";
        }
    }

    class Program
    {
        delegate string DelTest(int x, int y);
        static void Main(string[] args)
        {
            Test ts = new Test();
            DelTest del = new DelTest(ts.Foo);
            del(5, 6);
        }
    }
}
