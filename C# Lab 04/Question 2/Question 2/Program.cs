using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindValues obj = new FindValues();
            double r = 0;
            obj.findArea(r);
            obj.findCircumference(r);

            Console.ReadKey();
        }
    }
}
