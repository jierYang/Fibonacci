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

            Assert.Equal(1, result[0]);
        }

        [Fact]
        public void Input2ShouldGet1()
        {
            var number = 2;

            var result = Fibonacci.Fibonacci.GetFibonacciSequence(number);

            Assert.Equal(1, result[1]);
        }

        [Fact]
        public void Input3ShouldGet1()
        {
            var number = 3;

            var result = Fibonacci.Fibonacci.GetFibonacciSequence(number);

            Assert.Equal(1, result[2]);
        }

        [Fact]
        public void Input4ShouldGet3()
        {
            var number = 4;

            var result = Fibonacci.Fibonacci.GetFibonacciSequence(number);

            Assert.Equal(3, result[3]);
        }
        
        [Fact]
        public void Input12ShouldGetFib()
        {
            var number = 12;

            var result = Fibonacci.Fibonacci.GetFibonacciSequence(number);

            Assert.Equal(355, result[11]);
        }

        [Fact]
        public void Input120ShouldGetFib()
        {
            var number = 120;

            var result = Fibonacci.Fibonacci.GetFibonacciSequence(number);

            Assert.Equal(result[116] + result[117] + result[118], result[119]);
        }
    }
}