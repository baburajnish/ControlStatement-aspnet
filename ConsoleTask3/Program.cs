using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask3
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
                Console.WriteLine("i greter then j");
            }
            else {
                Console.WriteLine("j greter then i");

            }
            Console.ReadLine();

        }
    }
}
