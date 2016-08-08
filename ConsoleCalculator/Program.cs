using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your first number");
            var firstNumberAsString = Console.ReadLine();

            int firstNumber;

            while (!int.TryParse(firstNumberAsString, out firstNumber)) {
                Console.WriteLine("Thats not a number, please try again");
                firstNumberAsString = Console.ReadLine();

            }
            Console.WriteLine("You wrote the number: " + firstNumber);

            Console.WriteLine("Type your second number");
            var secondNumberAsString = Console.ReadLine();

            int secondNumber;

            while (!int.TryParse(secondNumberAsString, out secondNumber))
            {
                Console.WriteLine("Thats not a number, please try again");
                secondNumberAsString = Console.ReadLine();

            }

            Console.WriteLine("You wrote the number: " + secondNumber);


            Console.WriteLine("You wrote the numbers: " + firstNumber + " and " + secondNumber + " added it results in " + (firstNumber + secondNumber));

            Console.ReadLine();
        }
    }
}
