
using Xunit;

namespace CalculatorAPP.Test
{
    public class CalculationsTest
    {

        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }


        [Theory]
        [IsOddOrEvenDataAttribute]
        public void IsOdd_TestOddAndEvenByAttibute(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }
    }
}
