using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] ;
            int i;
            Console.WriteLine("ODD and EVEN checker\n");

            for( i = 0 ; i < 10 ; i++)
            {
                Console.Write("Enter the "+i+" number: ");
                numbers[i] = int.Parse(Console.ReadLine());

            }

            for (i = 0; i < 10 ; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("The number " + numbers[i] +" is an EVEN number");
                }

                else
                {
                    Console.WriteLine("The number " + numbers[i] + " is an ODD number");
                }

            }


            Console.ReadKey();
        }
    }
}
