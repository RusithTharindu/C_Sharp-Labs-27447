using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class FindValues
    {
        
        public void findArea(double r)
        {
            double area;

            Console.Write("Enter the radius value: ");
            r = Convert.ToDouble(Console.ReadLine());

            area = 3.14 * r * r ;
            Console.WriteLine("The area is: "+area);

        }

        public void findCircumference(double r)
        {
            double circ;

            Console.Write("Enter the radius value: ");
            r = Convert.ToDouble(Console.ReadLine());

            circ = 2 * 3.14 * r;
            Console.WriteLine("Circumference is :" + circ + "");
            
        }

    }
}
