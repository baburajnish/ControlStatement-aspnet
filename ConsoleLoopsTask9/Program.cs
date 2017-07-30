using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoopsTask9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                Console.Write(i);
                if (i == 5) 
                {
                    Console.WriteLine();
                }
                else if (i >= 10)
                {
                    Console.WriteLine();
                }
               
              
            } 

            
            Console.ReadLine();
        }
    }
}
