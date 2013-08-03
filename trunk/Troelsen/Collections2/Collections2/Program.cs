using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListTtest();
            //StackTtest();
            //QueueTtest();
            SortedSetTtest();
        }

        static void SortedSetTtest()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {FirstName= "Homer", LastName="Simpson", Age=47},
                new Person {FirstName= "Marge", LastName="Simpson", Age=45},
                new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
                new Person {FirstName= "Bart", LastName="Simpson", Age=8}
            };
            
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine() ;
            
            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
            
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        private static void QueueTtest()
        {
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person
            {
                FirstName = "Homer",
                LastName = "Simpson",
                Age = 47
            });
            peopleQ.Enqueue(new Person
            {
                FirstName = "Marge",
                LastName = "Simpson",
                Age = 45
            });
            peopleQ.Enqueue(new Person
            {
                FirstName = "Lisa",
                LastName = "Simpson",
                Age = 9
            });

            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);

            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());

            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error! {0}", e.Message);
            }
        }

        private static void StackTtest()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            Console.WriteLine("Firstperson is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Poppedoff {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Poppedoff {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person item is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Poppedoff {0}", stackOfPeople.Pop());
            try
            {
                Console.WriteLine("\nFirstperson is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Poppedoff {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message);
            }

        }

        private static void ListTtest()
        {
            List<Person> people = new List<Person>()
            {
                new Person() {FirstName = "Homer", LastName = "Simpson", Age = 47},
                new Person() {FirstName = "Marge", LastName = "Simpson", Age = 45},
                new Person() {FirstName = "Lisa", LastName = "Simpson", Age = 9},
                new Person() {FirstName = "Bart", LastName = "Simpson", Age = 8}
            };

            Console.WriteLine("Items in list: {0}", people.Count);

            foreach (Person p in people)
                Console.WriteLine(p);

            Console.WriteLine("\n->Inserting new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list: {0}", people.Count);

            Person[] arrayOfPeople = people.ToArray();
            for (int i = 0; i < arrayOfPeople.Length; ++i)
            {
                Console.WriteLine("First Names: {0}", arrayOfPeople[i].FirstName);
            }
        }
    }
}
