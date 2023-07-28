using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Enter the first Number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            num3 = num1 + num2;

            Console.WriteLine("The answer is : " + num3);

            Console.ReadKey();
        }
    }
}
