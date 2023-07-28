using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, op, ans;

            Console.Write("Enter the first Number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSelect your operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division\n");
            

            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                ans = num1 + num2;
            }

            else if (op == 2)
            {
                ans = num1 - num2;
            }

            else if(op == 3)
            {
                ans = num1 * num2;
            }

            else
            {
                ans = num1 / num2;    
            }
            

            Console.WriteLine("The answer is : " + ans);

            Console.ReadKey();
        }
    }
}
