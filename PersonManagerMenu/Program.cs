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
                            Console.WriteLine("We create Person");
                            break;
                        case 2:
                            Console.WriteLine("Show All Persons");
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
