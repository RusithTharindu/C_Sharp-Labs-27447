using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter 2 numbers: ");
            string[] tokens = Console.ReadLine().Split();
            num1 = int.Parse(tokens[0]);
            num2 = int.Parse(tokens[1]);

            int sum = num1 + num2;
            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is " + sum + ".");

            Console.ReadKey();
        }
    }
}
