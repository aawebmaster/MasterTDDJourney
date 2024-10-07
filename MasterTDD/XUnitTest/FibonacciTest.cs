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
        
        [Fact]
        public void Return_Error_for_Negetive_Position()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Fibonacci.Fibonacci.NthFibonacci(-1));
        }
     
        [Fact]
        public void Return_0_for_Position_0()
        {
            Assert.Equal(0 , Fibonacci.Fibonacci.NthFibonacci(0));
        }
        
        [Fact]
        public void Return_1_for_Position_1()
        {
            Assert.Equal(1 , Fibonacci.Fibonacci.NthFibonacci(1));
        }
        
        [Fact]
        public void Return_1_for_Position_2()
        {
            Assert.Equal(1 , Fibonacci.Fibonacci.NthFibonacci(2));
        }
        
        [Fact]
        public void Return_2_for_Position_3()
        {
            Assert.Equal(2 , Fibonacci.Fibonacci.NthFibonacci(3));
        }
        
        [Fact]
        public void Return_3_for_Position_4()
        {
            Assert.Equal(3 , Fibonacci.Fibonacci.NthFibonacci(4));
        }
        
        [Fact]
        public void Return_5_for_Position_5()
        {
            Assert.Equal(5 , Fibonacci.Fibonacci.NthFibonacci(5));
        }
         [Fact]
        public void Return_8_for_Position_6()
        {
            Assert.Equal(8 , Fibonacci.Fibonacci.NthFibonacci(6));
        }
        
        [Fact]
        public void Return_13_for_Position_7()
        {
            Assert.Equal(13 , Fibonacci.Fibonacci.NthFibonacci(7));
        }
        
        [Fact]
        public void Return_8_for_Position_8()
        {
            Assert.Equal(21 , Fibonacci.Fibonacci.NthFibonacci(8));
        }
        
        [Fact]
        public void Return_8_for_Position_9()
        {
            Assert.Equal(34 , Fibonacci.Fibonacci.NthFibonacci(9));
        }
        
        [Fact]
        public void Return_8_for_Position_10()
        {
            Assert.Equal(55 , Fibonacci.Fibonacci.NthFibonacci(10));
        }
        
        [Fact]
          public void Return_1597_for_Position_17()
        {
            Assert.Equal(1597 , Fibonacci.Fibonacci.NthFibonacci(17));
        }
        
        [Fact]
        public void Return_514229_for_Position_29()
        {
            Assert.Equal(514229 , Fibonacci.Fibonacci.NthFibonacci(29));
        }
    }
}