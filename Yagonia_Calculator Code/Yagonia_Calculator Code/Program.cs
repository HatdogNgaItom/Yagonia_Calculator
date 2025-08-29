using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_Calculator_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jack Anthony Dolino Yagonia
            //IT306
            //Practice
            // Greet the user and explain the program.
            Console.WriteLine("Welcome to the Simple C# Calculator!");
            Console.WriteLine("-----------------------------------");
            Console.Write("Please enter a starting number: ");

            string inputStart = Console.ReadLine();

            double startValue;
            if (double.TryParse(inputStart, out startValue))
            {
                Console.WriteLine("Invalid input. Using 0 as the starting value.");
                startValue = 0.0;
            }

            Calculator myCalculator = new Calculator(startValue);
            Console.WriteLine($"Calculator initialized with a starting value of {startValue}.");
            Console.WriteLine();

            Console.Write("Enter a number to add: ");
            string inputToAdd = Console.ReadLine();

            double numberToAdd;
            if (double.TryParse(inputToAdd, out numberToAdd))
            {
                Console.WriteLine("Invalid input. Adding 0 instead.");
                numberToAdd = 0.0;
            }

            double finalResult = myCalculator.Add(numberToAdd);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"The final result is: {finalResult}");
        }
    }
}
