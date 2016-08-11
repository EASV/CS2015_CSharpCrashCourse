using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsole
{
    public class EmployeeManager
    {
        /// <summary>
        /// Array needs to know its size upfront
        /// </summary>
        private Employee[] employess = new Employee[10];
        
        private List<Employee> employessAsList = new List<Employee>();

        public string CreateEmployee(string email)
        {
            if(email == "" || email == null)
            {
                return "No Employee Created, please specify an Email";

            }

            Employee empl = new Employee() {
                Email = email
            };

            Console.WriteLine("Type Name:");
            var name = Console.ReadLine();
            empl.Name = name != "" ? name : "Unknown";

            Console.WriteLine("Type Department:");
            var department = Console.ReadLine();
            empl.Department = department != "" ? department : "Unknown";
            /*if (department != "") {
                empl.Department = department;
            }
            else {
                empl.Department = "Unknown";
            }*/

            Console.WriteLine("Type SalaryLevel:");
            int salaryLevel;
            empl.SalaryLevel = int.TryParse(Console.ReadLine(), out salaryLevel) ? salaryLevel : 1;

            Console.WriteLine("Type WeeklyHours:");
            int weeklyHours;
            empl.WeeklyWorkHours = int.TryParse(Console.ReadLine(), out weeklyHours) ? weeklyHours : 7;
          
            employessAsList.Add(empl);

            return "Employee Created Successfully";

        }

        public void PrintAllEmployees() {
            /*
             ------- Using while loop to treverse list --------
            int i = 0;
            while (i < employessAsList.Count)
            {
                Console.WriteLine(employessAsList[i]);
                i++;
            }
                
             ------- Using for loop to treverse list --------
            
            for (int j = 0; j < employessAsList.Count; j++) {
                Console.WriteLine(employessAsList[j]);
            }
            */

            //------------ Using foreach loop to treverse list (prefered) -------
            foreach (var impl in employessAsList)
            {
                Console.WriteLine(impl + "\n\n\n");
            }
        }
    }
}
