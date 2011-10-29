using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace new__Les2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            Console.WriteLine("Dog. Age = {0}, Weight = {1}", dog.age, dog.weight);

            int c = dog.temp2;

            byte a = 1;
            byte b = 2;
            //byte res = a + b;

            string[] test = new string[4] { "dfgdfga1234", "b", "c", "d" };

            foreach (string s in test)
            {
                s. = "test";
                Console.WriteLine(s);
            }

            Console.ReadLine();

            foreach (string s in test)
            {
                st";
                Console.WriteLine(s);
            }

            test[0].Reverse();
            Console.WriteLine(test[0]);

        }
    }

    class Animal
    {
        public uint age;
        public double weight;
        internal double temp;
        protected internal int temp2;
    }
}
