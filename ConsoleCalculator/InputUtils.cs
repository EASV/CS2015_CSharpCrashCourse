using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class InputUtils
    {
        public static int GetInputNumber(string message)
        {
            Console.WriteLine(message);
            var numberAsString = Console.ReadLine();

            int number;

            while (!int.TryParse(numberAsString, out number))
            {
                Console.WriteLine("Thats not a number, please try again");
                numberAsString = Console.ReadLine();

            }
            Console.WriteLine("You wrote the number: " + number);

            return number;
        }
    }
}
