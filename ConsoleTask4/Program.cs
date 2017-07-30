using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter i value :");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter j value :");
            int j = int.Parse(Console.ReadLine());
            if (i > j)
            {
                Console.WriteLine("i is greter then j");
                Console.WriteLine("Value of i : "+i);
            }
            else
            {
                Console.WriteLine("j is greter then i");
                Console.WriteLine("Value of j : " + j);

            }
            Console.ReadLine();

        }
    }
}
