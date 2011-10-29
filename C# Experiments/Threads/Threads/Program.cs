using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        ThreadStart ts = new ThreadStart(SomeMethod);
        Thread th = new Thread(ts);
        th.Start();

        for (int i = 0; i < 50; ++i)
        {
            Console.WriteLine("III = {0}", i);
        }
    }

    static void SomeMethod()
    {
        for (int j = 0; j < 50; ++j)
        {
            Console.WriteLine("\tJJJ = {0}", j);
        }
    }
}
