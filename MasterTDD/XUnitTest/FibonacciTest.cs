using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Fibonacci;

namespace XUnitTest
{
    public class FibonacciTest
    {
        
        [Theory]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-5)]
        public void Return_Error_for_Negetive_Position(int input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Fibonacci.Fibonacci.NthFibonacci(input));
        }
     
        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,2)]
        [InlineData(4,3)]
        [InlineData(5,5)]
        [InlineData(6,8)]
        [InlineData(7,13)]
        [InlineData(8,21)]
        [InlineData(9,34)]
        [InlineData(10,55)]
        [InlineData(17,1597)]
        [InlineData(29,514229)]
        public void Return_Integer_for_Positions(int input, int expected)
        {
            Assert.Equal(expected , Fibonacci.Fibonacci.NthFibonacci(input));
        }

    }
}