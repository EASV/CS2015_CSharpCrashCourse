using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarConsole.Model;

namespace CarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new Car() {
                Color = "Red",
                LicenceNumber = "333",
                Make = "Toyota",
                Year = 2001
            };
            
            Console.WriteLine(theCar.ToString());

            theCar.Drive();
            theCar.Break();
            theCar.Drive();
            theCar.Break();

            Console.ReadLine();
        }
    }
}
