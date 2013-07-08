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

            int a, b = 0;
            MetTest(out a, ref b);

            ParamsTest(7, 777, 877);

            NamedArgs(b: 55, c: "str", a: 666);
        }

        private static void VarTest()
        {
            var testInt = 55;
            testInt = 7;
            Console.WriteLine(testInt);
            Console.WriteLine(testInt.GetType());
        }

        private static void MetTest(out int he, ref int xx)
        {
            he = 5;
            //xx = 6;

            Console.WriteLine("");
        }

        private static void ParamsTest(params int[] pr)
        {
            foreach (var vr in pr)
                Console.WriteLine(vr);
        }

        private static void NamedArgs(int a, int b, string c)
        {
            
        }
    }
}
