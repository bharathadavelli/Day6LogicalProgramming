using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class PerfectNumber
    {
        public static void checkperfectnumber()
        {
            int number, sum=0, n;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i< number;i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
                if (sum == n )
                {
                Console.WriteLine(" Entered number is a perfect number");
                }
                else
                {
                    Console.WriteLine(" It's not a Perfect Number.");
                }
        }
    }
}
