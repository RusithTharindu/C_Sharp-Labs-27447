using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, area;

            Console.Write("Enter the radius of circle: ");
            r = Convert.ToDouble(Console.ReadLine());

            area = 3.141 * r * r ;

            Console.WriteLine("The area is " +area+ "");

            Console.ReadKey();
        }
    }
}
