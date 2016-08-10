using EmployeeConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuSelection = -1;
            while (menuSelection != 0)
            {
                Console.WriteLine("What do you wanna do? ");
                Console.WriteLine("Press 0 to Exit");
                Console.WriteLine("Press 1 to create Employee");
                var valueSelectedAsString = Console.ReadLine();
                if (int.TryParse(valueSelectedAsString, out menuSelection))
                {
                    if (menuSelection == 0)
                    {
                        Console.WriteLine("Bye bye");
                    }
                    else if (menuSelection == 1)
                    {
                        Console.WriteLine("Create employee code here!!");

                    }
                    else
                    {
                        Console.WriteLine("Not a valid Number, please try again ");

                    }
                }
                else
                {
                    Console.WriteLine("Not a Number, please try again ");
                }
            }

            Console.ReadLine();
        }
    }
}
