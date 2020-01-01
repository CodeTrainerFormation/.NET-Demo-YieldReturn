using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Person person in GetPersons())
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }

            foreach (Person person in GetPersonsYield())
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }

            Console.ReadLine();
        }

        static IEnumerable<Person> GetPersonsYield()
        {
            yield return new Person()
            {
                FirstName = "Ted",
                LastName = "Mosby",
                ID = 0,
            };
            Console.WriteLine();
            yield return new Person()
            {
                FirstName = "Barney",
                LastName = "Stinson",
                ID = 1,
            };
            Console.WriteLine();
        }

        static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person()
                {
                    FirstName = "Ted",
                    LastName = "Mosby",
                    ID = 0,
                },
                new Person()
                {
                    FirstName = "Barney",
                    LastName = "Stinson",
                    ID = 1,
                }
            };
        }
    }
}
