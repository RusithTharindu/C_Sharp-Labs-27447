using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float radi, area, circum;
            Console.Write("Enter the radius of the circle:");
            radi = Convert.ToInt32(Console.ReadLine());

            area = (float)(3.14 * radi * radi);
            circum = (float)(2 * 3.14 * radi); 
            Console.WriteLine("The area is " + area);
            Console.WriteLine("The Circumference is "+ circum);

            Console.ReadKey();
        }
    }
}
