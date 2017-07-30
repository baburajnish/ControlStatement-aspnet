using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter i value :");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter j value :");
            int j = int.Parse(Console.ReadLine());
            int div = i / j;
            Console.WriteLine("div value is : "+div);
            Console.ReadLine();
        }
    }
}
