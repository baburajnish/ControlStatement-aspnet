using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter m1 marks :");
            float m1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter m3 marks :");
            float m2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter m3 marks :");
            float m3 = float.Parse(Console.ReadLine());
            float totalMarks = m1 + m2 + m3;
            float avgMarks = totalMarks / 3;
            if (m1 < 35 || m2 < 35 || m3 < 35) 
            {
                Console.WriteLine("Fail");
            }
            else if (avgMarks >= 60)
            {
                Console.WriteLine("First class");
            }
            else if (avgMarks >= 50)
            {
                Console.WriteLine("Second class");
            }
            else 
            {
                Console.WriteLine("Third class");
            }
            Console.ReadLine();
        }
    }
}
