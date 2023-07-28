using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int newsalary, taxpay, salary;

            Console.Write("Enter your salary amount: ");
            salary = int.Parse(Console.ReadLine());

            if (salary <= 10000)
            {
                taxpay = 700;
            }

            else if (salary > 10000 && salary < 50000)
            {
                taxpay = 1500;
            }

            else
            {
                taxpay = 2500;
            }

            newsalary = salary + taxpay;
            Console.WriteLine("Your new salary with the tax is " + newsalary + ".");

            Console.ReadKey();
        }
    }
}
