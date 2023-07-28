using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ODD and EVEN checker\n");
            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());

            if(num % 2  == 0) 
            {
                Console.WriteLine("This is an EVEN number");
            }
            else
            {
                Console.WriteLine("This is an ODD number");
            }

            Console.ReadKey();

        }
    }
}
