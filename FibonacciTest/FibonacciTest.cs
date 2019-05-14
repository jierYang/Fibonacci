using System;
using Xunit;

namespace FibonacciTest
{
    public class FibonacciTest
    {
        [Fact]
        public void Input1ShouldGet1()
        {
            var number = 1;

            var result = Fibonacci.Fibonacci.GetFibonacciSequence(number);

            Assert.Equal(1,result[0]);
        }

        [Fact]
        public void Input2ShouldGet1()
        {
            var number = 2;

            var result = Fibonacci.Fibonacci.GetFibonacciSequence(number);

            Assert.Equal(1,result[1]);
        }

        [Fact]
        public void Input3ShouldGet2()
        {
            var number = 3;

            var result = Fibonacci.Fibonacci.GetFibonacciSequence(number);

            Assert.Equal(2,result[2]);
        }

        [Fact]
        public void Input120ShouldGetFib()
        {
            var number = 120;

            var result = Fibonacci.Fibonacci.GetFibonacciSequence(number);

            Assert.Equal("5358359254990966640871840", result[119].ToString());
        }
    }
}