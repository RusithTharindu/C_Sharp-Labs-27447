using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    class Animal
    {
        public void Animals() 
        {
            Console.Write("I am Animal ");
        }
    }

    class Dog
    {
        public void Dogs()
        {
            Console.Write("I have four legs.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal obj1 = new Animal();
            Dog obj2 = new Dog();

            obj1.Animals();
            obj2.Dogs();

            Console.ReadKey(); 

        }
    }
}
