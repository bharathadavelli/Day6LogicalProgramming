using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class FibonacciSeries
    {
        public static void fibonacciseries()
        {
            Console.WriteLine("Fibonacci Series");
            Console.WriteLine("Enter the number of terms you want to print : ");
            int length = Convert.ToInt32(Console.ReadLine());
            int third = 0, first = 0, second = 1, temp;
            Console.Write(first + " " + second + " ");
            for (int i = 2; i < length; i++)
            {
                third = first + second;
                temp = second;
                Console.Write(third + " ");
                second = third;
                first = temp;
            }

        }
    }
}
