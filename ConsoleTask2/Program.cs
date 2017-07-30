using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter i value :");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter j value :");
            int j = int.Parse(Console.ReadLine());
            if (j == 0)
            {
                Console.WriteLine("Plaese enter second number other than zero");
                j = int.Parse(Console.ReadLine());

            }
            int div = i / j;
            Console.WriteLine("Divition value is : "+div);
            Console.ReadLine();

        }
    }
}
