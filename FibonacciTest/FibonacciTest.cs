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
    }
}