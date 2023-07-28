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
            int range;
            int sum = 0;
            Console.Write("Enter a positive integer: ");
            range = int.Parse(Console.ReadLine());

            for (int i = 0; i < range; i++) 
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine("sum of all the odd numbers from to the given positive integer: "+sum);

            Console.ReadKey();
        }
    }
}
