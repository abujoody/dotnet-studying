using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    struct testArr { };

    class Program
    {
        static void Main(string[] args)
        {
            /*VarTest();

            int a, b = 0;
            MetTest(out a, ref b);

            ParamsTest(7, 777, 877);

            NamedArgs(b: 55, c: "str", a: 666);*/

            Parent[] testArr = new Parent[] { new Parent(), new Child() };

            int[,] x = new int [2, 2];
            int[][][][] y = new int[2][][][];
            int[,] myArray = new int[4,2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            int[][] myJaggedArray = new int[3][] 
                        {
                           new int[] {1,3,5,7,9},
                           new int[] {0,2,4,6},
                           new int[] {11,22}
                        };

            int[] t1 = { 7, 4 };
            int[] t2 = new int[3];
            t1.CopyTo(t2, 0);

            Array.Sort(t2);

            Console.WriteLine("{0},{1},{2}", t2[0], t2[1], t2[2]);
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
