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
            Employee employee = new Employee()
            {
                Name = "Lars Bilde",
                Email = "theEmail@Email.com",
                Department = "The cool place",
                SalaryLevel = 10000,
                WeeklyWorkHours = 2
            };

            Console.WriteLine(employee);

            Console.WriteLine("\n\n\nOnly the salary: " + employee.CalculatedSalery);
            
            if (employee.CalculatedSalery > 2000)
            {
                Console.WriteLine($"You are filthy rich earning {employee.CalculatedSalery} $");
            }
            else
            {
                Console.WriteLine("Talk to the boss, u need more money");
            }

            Console.ReadLine();
        }
    }
}
