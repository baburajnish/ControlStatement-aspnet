using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoletTask12
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
                Console.WriteLine("i is greter than j");
            }  
                else 
                {
                    if(j >i)
                    {
                      Console.WriteLine("j is greter than i"); 
                    }
                   
                 else
                {
                    Console.WriteLine("i is qual to j"); 
                }
                }
            Console.ReadLine();
        }
    }
}

