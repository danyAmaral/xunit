using System.Collections.Generic;
using Xunit;

namespace CalculatorAPP.Test
{
    public class FibonacciTest
    {
        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            var fibonacci = new Fibonacci();

            Assert.All(fibonacci.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void FiboIncludes13()
        {
            var fibonacci = new Fibonacci();
            Assert.Contains(13, fibonacci.FiboNumbers);
        }

        [Fact]
        public void FiboDoesNotIncludes13()
        {
            var fibonacci = new Fibonacci();
            Assert.DoesNotContain(4, fibonacci.FiboNumbers);
        }


        [Fact]
        public void CheckCollection()
        {
            var fibonacci = new Fibonacci();
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13, 20 };
            Assert.Equal(expectedCollection, fibonacci.FiboNumbers);
        }
    }
}
