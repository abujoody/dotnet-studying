using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing! 1, 2, 3");

            Message msg = new Message();
            msg.speak();
        }
    }
}
