using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Lab07
{
    public class Person : IComparable<Person>
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name.PadRight(20)}\t{age}";
        }

        public int CompareTo(Person? obj)
        {
            return this.age - obj.age;
        }
    }

    public class PersonNameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            Person person1 = x;
            Person person2 = y;

            if (person1 == null || person2 == null)
            {
                throw new ArgumentException("Both objects to compare must be of type Person");
            }

            return person1.name.CompareTo(person2.name);
        }
    }
}