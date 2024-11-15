using System;
using System.Collections;

namespace Lab07
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int[] ages = { 36, 53, 51, 21, 41, 19 };

            string[] names = { "Holland", "Turner", "Powell", "Vicious", "Lyndon", "Spears" };

            for (int i = 0; i < names.Length; i++)
            {
                people.Add(new Person(names[i], ages[i]));
            }

            people.Sort();

            foreach(Person person in people)
            {
                Console.WriteLine(person);
            }

            people.Sort(new PersonNameComparer());

            foreach(Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }

}

