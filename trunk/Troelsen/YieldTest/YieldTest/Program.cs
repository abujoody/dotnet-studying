using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage g = new Garage();
            foreach (string car in g)
            {
                string carName = car ?? "no car";
                Console.WriteLine(carName);
            }

            Console.WriteLine("\n\n\n\n");

            foreach (string car in g.NamedEnumerator())
            {
                string carName = car ?? "no car";
                Console.WriteLine(carName);
            }
        }
    }
}
