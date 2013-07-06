using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
    class Factorial
    {
        public uint calc(uint i)
        {
            if (i == 0)
                return 1;
            else
                return i * calc(i - 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Factorial fact = new Factorial();
            Console.WriteLine("Factorial: {0}", fact.calc(5));
        }
    }
}
