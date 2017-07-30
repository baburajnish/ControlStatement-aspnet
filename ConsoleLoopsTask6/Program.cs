using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoopsTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                if (i <= 5)
                {
                    Console.Write(i);
                }
                else 
                {
                    Console.WriteLine(i);
                }
               
                
            }
            Console.ReadLine();
        }
    }
}
