using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreBoard
{
    class Person
    {
        private LinkedList<string> people;
        public Person(int seed)
        {
            people = new LinkedList<string>();
            if (seed == 0)
            {
                people.AddLast("Gregory");
                people.AddLast("Michael");
                people.AddLast("Julian");
                people.AddLast("Nathan");
                people.AddLast("Emmanuel");
            }
            if (seed == 1)
            {
                people.AddLast("Michael");
                people.AddLast("Julian");
                people.AddLast("Nathan");
                people.AddLast("Emmanuel");
                people.AddLast("Gregory");
            }
            if (seed == 2)
            {
                people.AddLast("Julian");
                people.AddLast("Nathan");
                people.AddLast("Emmanuel");
                people.AddLast("Gregory");
                people.AddLast("Michael");
            }
            if (seed == 3)
            {
                people.AddLast("Nathan");
                people.AddLast("Emmanuel");
                people.AddLast("Gregory");
                people.AddLast("Michael");
                people.AddLast("Julian");
            }
            if (seed == 4)
            {
                people.AddLast("Emmanuel");
                people.AddLast("Gregory");
                people.AddLast("Michael");
                people.AddLast("Julian");
                people.AddLast("Nathan");
            }
            if (seed == 5)
            {
                people.AddLast("Julian");
                people.AddLast("Nathan");
                people.AddLast("Emmanuel");
                people.AddLast("Gregory");
                people.AddLast("Howard");
                people.AddLast("Michael");
            }
            if (seed == 6)
            {
                people.AddLast("Nathan");
                people.AddLast("Emmanuel");
                people.AddLast("Gregory");
                people.AddLast("Howard");
                people.AddLast("Michael");
                people.AddLast("Julian");
            }
            if (seed == 7)
            {
                people.AddLast("Emmanuel");
                people.AddLast("Gregory");
                people.AddLast("Howard");
                people.AddLast("Michael");
                people.AddLast("Julian");
                people.AddLast("Nathan");
            }
            if (seed == 8)
            {
                people.AddLast("Michael");
                people.AddLast("Julian");
                people.AddLast("Nathan");
                people.AddLast("Emmanuel");
                people.AddLast("Gregory");
                people.AddLast("Howard");
            }
            if (seed == 9)
            {
                people.AddLast("Howard");
                people.AddLast("Michael");
                people.AddLast("Julian");
                people.AddLast("Nathan");
                people.AddLast("Emmanuel");
                people.AddLast("Gregory");
            }
            if (seed == 10)
            {
                people.AddLast("Gregory");
                people.AddLast("Howard");
                people.AddLast("Michael");
                people.AddLast("Julian");
                people.AddLast("Nathan");
                people.AddLast("Emmanuel");
            }
        }

        public string Peep()
        {
            return people.First();
        }

        public void Pop()
        {
            string temp = people.Last();
            people.RemoveLast();
            people.AddFirst(temp);
        }

        public void Poop()
        {
            string temp = people.First();
            people.RemoveFirst();
            people.AddLast(temp);
        }
    }
}
