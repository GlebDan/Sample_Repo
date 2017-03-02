using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_6
{
    public class Person : IComparable
    {
        protected string name;
        protected int age;
        public string Name { get {return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person ()
        {
            Random rnd = new Random();
            Name = "Sample";
            Age = rnd.Next(5, 65);
        }

        public Person(string sz, int a)
        {
            Name = sz;
            Age = a;
        }

        public override string ToString()
        {
            return Name+": "+Age;
        }

        public static bool operator > (Person p1, Person p2)
        {
            if (p1.Age>p2.Age)
               return true;
            else
               return false;

        }

        public static bool operator <(Person p1, Person p2)
        {
            if (p1.Age < p2.Age)
                return true;
            else
                return false;

        }

        public void Print(Person p)
        {
                Console.Write(p.Name+": "+p.Age+", ");
        }

        public int CompareTo(object obj)
        {
            Person other = obj as Person;
            if (this.Age == other.Age)
            {
                return this.Name.CompareTo(other.Name);
            }
            else
                return other.Age.CompareTo(this.Age);
        }
    }
}
