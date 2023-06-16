using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ConvertValues
    {
        public int Convertingvalues(int km)
        {
            //declaration
            int m;

            //user input 
            Console.WriteLine("Enter the kilometer value: ");
            km = int.Parse(Console.ReadLine());

            //conversion
            m = km * 1000;
            Console.WriteLine("It is " + m + " meters");

            return m;
        }
    }
}
