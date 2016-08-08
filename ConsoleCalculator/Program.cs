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
            int firstNumber = InputUtils.GetInputNumber("Type your first number");

            int secondNumber = InputUtils.GetInputNumber("Type your second number");

            Console.WriteLine("You wrote the numbers: " + firstNumber + " and " + secondNumber + " added it results in " + (firstNumber + secondNumber));

            Console.ReadLine();

        }

        
    }
}
