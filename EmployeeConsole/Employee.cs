using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsole
{
    
   /// <summary>
   /// Remeber to make employee public, so other classes can access it
   /// </summary>
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int SalaryLevel { get; set; }
        public string Department { get; set; }
        public double WeeklyWorkHours { get; set; }

        public double CalculatedSalery {
            get{ return SalaryLevel * 700.0; }
        }

        public double GetCalculatedSalery() {
            return SalaryLevel * 700.0;
        }
        
        public override string ToString()
        {
            return $" Name: {Name} \t\t\n Email: {Email} \t\t\n SalaryLevel: {SalaryLevel} \t\n Salary: {GetCalculatedSalery()} \t\n WeeklyWorkHours: {WeeklyWorkHours} \t\n Department: {Department} ";
        }
    }
}
