using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string test = "dd";
                object hh = new int[5];
                test = (string)hh;
                Console.WriteLine(test);
            }
            catch (Exception)
            {
                Console.WriteLine("!!!!!!!!!!!!!!!");
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
