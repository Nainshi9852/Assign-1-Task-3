using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Addition
            int sum = num1 + num2;
            Console.WriteLine($"Addition: {num1} + {num2} = {sum}");

            // Subtraction
            int difference = num1 - num2;
            Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");

            // Multiplication
            int product = num1 * num2;
            Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

            // Division
            if (num2 != 0)
            {
                double division = (double)num1 / num2;
                Console.WriteLine($"Division: {num1} / {num2} = {division}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            // Modulus (remainder after division)
            if (num2 != 0)
            {
                int modulus = num1 % num2;
                Console.WriteLine($"Modulus: {num1} % {num2} = {modulus}");
            }
            else
            {
                Console.WriteLine("Modulus by zero is not allowed.");
            }
            Console.ReadKey();
        }
    }
}
