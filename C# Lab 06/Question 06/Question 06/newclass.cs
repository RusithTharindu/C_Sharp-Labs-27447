using System;

namespace Question_06
{
    internal class newclass
    {
        public void Arraycal(int size)
        {
            int i;
            
            int[] array = new int[size];

            for(i=0; i<size; i++)
            {
                Console.Write("Enter a value for "+i+": ");
                array[i] = int.Parse(Console.ReadLine());

            }

            for(i = 0; i < size; i++)
            {
                if(i %2 != 0)
                {
                    int x = 0;
                    array[i] = x;
                }

                Console.Write(" " + array[i]);
            }



        }

    }
}
