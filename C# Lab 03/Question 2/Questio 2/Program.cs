using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Questio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letters = { "a", "b", "A", "g", "z", "Q", "E", "i", "O", "u" };
            int count=0;

            for(int i=0; i<letters.Length; i++) 
            {
                if (letters[i] == "a" || letters[i] == "A" || letters[i] == "e" || letters[i] == "E" || letters[i] == "I" || letters[i] == "i" || letters[i] == "o" || letters[i] == "O" || letters[i] == "u" || letters[i] == "U") 
                {
                    count++;
                }
            }

            Console.WriteLine("Count of vowels in the given array: "+count);

            Console.ReadLine();
        }
    }
}
