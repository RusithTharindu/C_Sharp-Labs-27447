using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Q1
{
    internal class CalculateValues
    {
        public void Addition(int no1, int no2)
        {
            int ans;
            ans= no1 + no2;
            Console.WriteLine("Your answer is: " + ans);
        }

        public void Subtraction(int no1, int no2)
        {
            int ans;
            ans= no1 - no2;
            Console.WriteLine("Your answer is: " + ans);

        }

        public void Multiplication(int no1, int no2)
        {
            int ans;
            ans= no1 * no2;
            Console.WriteLine("Your answer is: " + ans);
        }
        public void Division(int no1, int no2)
        {
            int ans;
            ans= no1 / no2;
            Console.WriteLine("Your answer is: " + ans);
        }


    }
}
