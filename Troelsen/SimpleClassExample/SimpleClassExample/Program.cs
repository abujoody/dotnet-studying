using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    static class Test
    {
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
    class Program
    {
        static void Main(string[] args)
        {
            //Test ts = new Test();

            Console.WriteLine(Test.i);
        }
    }
}
