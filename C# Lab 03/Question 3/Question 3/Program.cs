using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a num: ");
            int num = int.Parse(Console.ReadLine());

            int total = 0;

            for (int tmp = num; tmp != 0; tmp /= 10)
            {
                int x = tmp % 10;
                total += x;
            }

            Console.WriteLine("total of the numbers: " + total);
            Console.ReadKey();

        }
    }
}
