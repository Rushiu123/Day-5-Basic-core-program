using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Basic_Core_Programs
{
    internal class EvenOdd
    {
        public static void evenOdd()
        {
            Console.Write("Enter a number to check even or odd : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", n);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", n);
                Console.WriteLine("Press any key to exit")
                Console.ReadLine();
            }
        }
    }
}
