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
            EmployeeManager employeeManager = new EmployeeManager();
            int menuSelection = -1;
            while (menuSelection != 0)
            {
                Console.WriteLine("What do you wanna do? ");
                Console.WriteLine("Press 0 to Exit");
                Console.WriteLine("Press 1 to create Employee");
                Console.WriteLine("Press 2 to show Employees");
                var valueSelectedAsString = Console.ReadLine();
                if (int.TryParse(valueSelectedAsString, out menuSelection))
                {
                    switch (menuSelection)
                    {
                        case 0:
                            Console.WriteLine("Bye bye");
                            break;
                        case 1:
                            Console.WriteLine("Type Email:");
                            employeeManager.CreateEmployee(Console.ReadLine());
                            break;
                        case 2:
                            employeeManager.PrintAllEmployees();
                            break;
                        default:
                            Console.WriteLine("Not a valid Number, please try again ");
                            break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Not a Number, please try again ");
                    menuSelection = -1;
                }
                /// Just a Comment
            }
            Console.ReadLine();
        }
    }
}
