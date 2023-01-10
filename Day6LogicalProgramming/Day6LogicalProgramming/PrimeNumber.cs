using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class PrimeNumber
    {
        public static void CheckprimeNumber()
        {
            int n, i, m = 0, flag = 0;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for(i=2;i<=m;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine("Entered number is not a prime number");
                    flag = 1;
                    break;

                }
            }
            if (flag == 0)
                Console.WriteLine("Entered number is prime number");
        }
    }
}
