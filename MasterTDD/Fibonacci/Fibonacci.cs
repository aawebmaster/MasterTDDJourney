using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
       public static int NthFibonacci(int position)
       {
            
            if (position < 0)
                throw new ArgumentOutOfRangeException(nameof(position), "Position must be non-negative.");

            if (position < 2)
                return position;

            int a = 0, b = 1;

            for (int i = 2; i <= position; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}