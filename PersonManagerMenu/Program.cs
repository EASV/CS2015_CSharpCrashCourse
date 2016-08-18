using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersonManagerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            var gw = new Gateway();
            int menuChoice = -1;
            while(menuChoice != 0)
            {
                Console.WriteLine(string.Join(
                Environment.NewLine,
                "Welcome To the Menu",
                "1: Create Person",
                "2: Print all Persons",
                "0: Exit the program"));
                 if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    Console.Clear();
                    switch (menuChoice)
                    {
                        case 1:
                            Console.WriteLine("Type the persons Name");
                            var name = Console.ReadLine();

                            Console.WriteLine("Type the persons BirthDate - example: 1978-04-26");
                            var birthDate = Console.ReadLine();

                            Console.WriteLine("Type the persons Email - example: mymail@aplace.com");
                            var email = Console.ReadLine();

                            Console.WriteLine("Type the persons Gender - example: Male or Female");
                            var gender = Console.ReadLine();

                            var person = new Person()
                            {
                                Name = name,
                                BirthDate = DateTime.Parse(birthDate),
                                Email = email,
                                Gender = "Male".ToLower().Equals(gender.ToLower()) ? Gender.Male : Gender.Female
                            };

                            gw.Add(person);

                            Console.WriteLine("Press enter to to go back to menu");
                            Console.ReadLine();
                            Console.Clear();

                            break;
                        case 2:
                            Console.WriteLine("Getting data....");
                            var persons = gw.ReadAll();
                            foreach (var item in persons)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("Press enter to to go back to menu");
                            Console.ReadLine();
                            Console.Clear();

                            break;
                        case 0:
                            Console.WriteLine("Bye");
                            Thread.Sleep(2000);
                            break;
                        default:
                            Console.WriteLine("Write 1, 2 or 0");
                            break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please type a number");
                    menuChoice = -1;
                    Console.Clear();

                }
            }

        }
    }
}
