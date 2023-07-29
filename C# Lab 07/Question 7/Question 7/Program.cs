using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            double[] array1 = new double[size];
            double[] array2 = new double[size];

            
            Console.WriteLine("Enter values for array1:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array1[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter values for array2:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array2[i] = double.Parse(Console.ReadLine());
            }

            //Scalar Sum
            double scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += array1[i] + array2[i];
            }
            Console.WriteLine("Scalar Sum: " + scalarSum);

            //Vector Sum
            double[] vectorSum = new double[size];
            for (int i = 0; i < size; i++)
            {
                vectorSum[i] = array1[i] + array2[i];
            }
            Console.Write("Vector Sum: ");
            PrintArray(vectorSum);

            //Vector Product
            double[] vectorProduct = new double[size];
            for (int i = 0; i < size; i++)
            {
                vectorProduct[i] = array1[i] * array2[i];
            }
            Console.Write("Vector Product: ");
            PrintArray(vectorProduct);

            //Scalar Product and sum
            double[] scalarProduct = new double[size];
            double scalarProductSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarProduct[i] = array1[i] * array2[i];
                scalarProductSum += scalarProduct[i];
            }
            Console.Write("Scalar Product: ");
            PrintArray(scalarProduct);
            Console.WriteLine("Sum of Scalar Product: " + scalarProductSum);
            Console.ReadKey();
        }

        static void PrintArray(double[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }
}
