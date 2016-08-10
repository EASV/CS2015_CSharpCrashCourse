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

        public void CreateEmployee(string email, string name = "Unknown", string department = "Unknown", int salaryLevel = 1)
        {
            Employee empl = new Employee() {
                Name = name,
                Department = department,
                Email = email,
                SalaryLevel = salaryLevel
            };

            employessAsList.Add(empl);


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
