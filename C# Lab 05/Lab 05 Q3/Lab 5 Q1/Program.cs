using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, no1, no2;
            Console.Write("Enter 1 for addition\nEnter 2 for Substraction\nEnter 3 for Multiplication\nEnter 4 for Division\nEnter your Choice: ");
            op = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.Write("Enter number 1: ");
            no1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            no2 = int.Parse(Console.ReadLine());


            CalculateValues obj = new CalculateValues();

            if (op == 1)
            {
                obj.Addition(no1,no2);
            }
            else if(op == 2) 
            {
                obj.Subtraction(no1,no2);
            }
            else if( op == 3)
            {
                obj.Multiplication(no1,no2);
            }
            else
            {
                obj.Division(no1,no2);
            }
                Console.ReadKey();  
        }
    }
}
