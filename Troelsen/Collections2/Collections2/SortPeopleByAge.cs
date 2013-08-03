using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            if (first.Age > second.Age)
                return 1;
            if (first.Age < second.Age)
                return -1;

            return 0;
        }
    }
}
