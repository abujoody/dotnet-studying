using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldTest
{
    class Garage : IEnumerable
    {
        string[] cars = new string[] { "Test1", "Test1", null };

        // interface implementation
        public IEnumerator GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        // named iterator
        public IEnumerable NamedEnumerator()
        {
            yield return "sdf";

            if (5 > 3)
                yield return "777";

            if ("777".Length > 8)
                Console.WriteLine("#######");

            yield break;

            yield return "XXXXXXXXXXXXXXXX";
        }
    }
}
