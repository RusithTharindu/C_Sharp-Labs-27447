using System;

namespace Question_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            newclass obj = new newclass();
            int size = 0 ;

            Console.Write("Enter size value for array: ");
            size = int.Parse(Console.ReadLine());

            obj.Arraycal(size);

            Console.ReadKey();
        }
    }
}
