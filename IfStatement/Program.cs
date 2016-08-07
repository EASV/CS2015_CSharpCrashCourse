using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your name");
            string inputText = Console.ReadLine();
            if(inputText == "Lars")
            {
                Console.WriteLine("Your name is Lars");
            }
            else {
                Console.WriteLine("Your name is NOT Lars");

            }
            Console.WriteLine("Bye bye");
            Console.ReadLine();
        }
    }
}
