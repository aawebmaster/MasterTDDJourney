using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
        public static int NthFibonacci(int position){
            
            if(position <0 )
                throw new ArgumentOutOfRangeException("Position must be non-negative.");

            if (position < 2)
                return position;
            
            return (NthFibonacci(position-1)+ NthFibonacci(position-2));

        }
    }
}