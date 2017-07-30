using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEtcBillTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer type :");
            Console.WriteLine("Press1 for Industry :");
            Console.WriteLine("Press2 for Industry :");
            Console.WriteLine("Press3 for Industry :");
            byte cType = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter consumed units :");
            ulong cUnits = ulong.Parse(Console.ReadLine());
            ulong totalBill;
            if (cType == 1)
            {
                totalBill = cUnits * 8;
                Console.WriteLine("totalBill is : " + totalBill);
            }
            else if (cType > 100)
            {
                totalBill = cUnits * 9;
                Console.WriteLine("totalBill is : " + totalBill);
            }

            if (cType == 2)
            {
                totalBill = cUnits * 5;
                Console.WriteLine("totalBill is : " + totalBill);
            }
            else if (cType > 100)
            {
                totalBill = cUnits * 6;
                Console.WriteLine("totalBill is : " + totalBill);
            }

            if (cType == 3)
            {
                totalBill = cUnits * 2;
                Console.WriteLine("totalBill is : " + totalBill);
            }
            else if (cType > 100)
            {
                totalBill = cUnits * 3;
                Console.WriteLine("totalBill is : " + totalBill);
            }


            Console.ReadLine();
        }
    }
}

