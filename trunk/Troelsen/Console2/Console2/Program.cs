using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            VarTest();
        }

        private static void VarTest()
        {
            var testInt = 55;
            testInt = 7;
            Console.WriteLine(testInt);
            Console.WriteLine(testInt.GetType());
        }
    }
}
