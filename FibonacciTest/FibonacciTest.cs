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

            Assert.Equal(result[0], 1);
        }
        
        [Fact]
        public void Input2ShouldGet1()
        {
            var number = 2;

            var result = Fibonacci.Fibonacci.GetFibonacciSequence(number);

            Assert.Equal(result[1], 1);
        }
    }
}