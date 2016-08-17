using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            


            var person = new Person();
            person.Name = "Lars Bilde";
            person.BirthDate = DateTime.Now.AddYears(-25);
            person.Gender = Gender.Male;
            persons.Add(person);

            var person2 = new Person() {
                Name = "Ole Eriksen",
                BirthDate = DateTime.Now.AddYears(-125),
                Gender = Gender.Female
            };
            persons.Add(person2);

            Console.WriteLine("For loop below:");
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine(persons[i]);
            }

            Console.WriteLine("Foreach loop below:");
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
