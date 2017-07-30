using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your latter:");
            char latter = char.Parse(Console.ReadLine());
            if (latter == 'a')
            {
                Console.WriteLine("It is vowel");
            }
            else if (latter == 'e')
            {
                Console.WriteLine("It is vowel");
            }
            else if (latter == 'i')
            {
                Console.WriteLine("It is vowel");
            }
            else if (latter == 'o')
            {
                Console.WriteLine("It is vowel");
            }
            else if (latter == 'u')
            {
                Console.WriteLine("It is vowel");
            }
            else 
            {
                Console.WriteLine("It is not vowel");
            }
          
            Console.ReadLine();

        }
    }
}
