using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class Couponcode
    {
        public static void CouponNumberGenerator()
        {
            Console.Write("Enter the number of Distinct Coupon number you want : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int[] coupon = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                coupon[i] = random.Next(1000, 10000);
                int check = coupon[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (coupon[i] == coupon[j])
                    {
                        i--;
                    }
                    else
                        {
                            Console.WriteLine("Coupon " + (i + 1) + " : " + coupon[i]);
                        }
                }
            }
        }
    }
}

