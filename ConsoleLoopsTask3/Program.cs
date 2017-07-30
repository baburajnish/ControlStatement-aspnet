using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoopsTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i <=20; i++)
            {
                Console.WriteLine(i);
                i = i + 4;
            }
            Console.ReadLine();
        }
    }
}
