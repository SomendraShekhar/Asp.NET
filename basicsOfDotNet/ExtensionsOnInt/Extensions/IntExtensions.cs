using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class IntExtensions
    {
        public static bool Isodd(this int i)
        {
            return i % 2 == 0;
        }

        public static bool isEven(this int i)
        {
            return i % 2 != 0;
        }
        public static bool isPrime(this int i)
        {
            int Flag = 0;
            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    Flag = 1;
                    break;
                }
            }
            if (Flag == 0)
                return true;
            return false;
        }
        public static bool isDivisible(this int i,int value)
        {
            return i % value == 0;
        }
    }
}
