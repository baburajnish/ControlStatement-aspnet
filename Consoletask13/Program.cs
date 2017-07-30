using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoletask13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age :");
            byte age = byte.Parse(Console.ReadLine());
            if (age >= 58)
            {
                Console.WriteLine("Senior citizen");
            }
            else
            {
                if (age >= 25)
                {
                    Console.WriteLine("Working citizen");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("collage student");
                }
                else if (age >= 4)
                {
                    Console.WriteLine("School boy ");
                }
                else if (age >= 1)
                {
                    Console.WriteLine("Playing kid ");
                }
                else
                {
                    Console.WriteLine("In valid age ");
                }
            }
            Console.ReadLine();
        }
    }
}
