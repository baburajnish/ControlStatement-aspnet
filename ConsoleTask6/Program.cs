using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month number:");
            byte month = byte.Parse(Console.ReadLine());
            if(month==1)
            {
                Console.WriteLine("Jan");
            }
            else if (month==2) 
            {
                Console.WriteLine("Feb");
            }
            else if (month==3)
            {
                Console.WriteLine("March");
            }
            else if (month==4)
            {
                Console.WriteLine("April");
            }
            else if (month==5)
            {
                Console.WriteLine("May");
            }
            else if (month==6)
            {
                Console.WriteLine("June");
            }
            else if (month==7)
            {
                Console.WriteLine("July");
            }
            else if (month==8)
            {
                Console.WriteLine("Agt");
            }
            else if (month==9)
            {
                Console.WriteLine("Seb");
            }
            else if (month==10)
            {
                Console.WriteLine("Oct");
            }
            else if (month==11)
            {
                Console.WriteLine("Nov");
            }
            else if (month==12)
            {
                Console.WriteLine("Des");
            }
            else 
            {
                Console.WriteLine("In valid month number");
            }
            Console.ReadLine();

        }
    }
}
