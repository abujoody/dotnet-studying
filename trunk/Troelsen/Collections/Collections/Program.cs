using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListTest();
            //ListTest();
            //StackTest();
            //BitTest();
            //QueueTest();
        }

        private static void QueueTest()
        {
            Queue q = new Queue();
            q.Enqueue("111");
            q.Enqueue("222");
            q.Enqueue("333");

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
        }

        private static void BitTest()
        {
            BitArray ba = new BitArray(new bool[] { true, 5 < 7, true != false });
            foreach (bool flag in ba)
            {
                Console.WriteLine(flag);
            }
        }

        private static void StackTest()
        {
            Stack st = new Stack();
            st.Push(new object());
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Count);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Count);
        }

        private static void ListTest()
        {
            SortedList sl = new SortedList();
            sl.Add("test", 44);
            sl.Add("test2", 55);

            IList keys = sl.GetKeyList();
            foreach (object key in keys)
            {
                Console.WriteLine(key);
            }

            IList values = sl.GetValueList();
            foreach (object val in values)
            {
                Console.WriteLine(val);
            }
        }

        private static void ArrayListTest()
        {
            ArrayList al = new ArrayList(5);
            al.Add(555);
            al.Add("ddd");

            ArrayList al2 = new ArrayList(2);
            al2.Add("XXXXXX");
            al2.Add("YYY");
            al2.Add("ddfgdfg");

            al.AddRange(al2);

            foreach (object obj in al)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
