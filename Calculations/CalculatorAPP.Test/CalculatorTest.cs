using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace CalculatorAPP.Test
{
    public class CalculatorFixture 
    {
        public Calculator Calc => new Calculator();
    }


    public class CalculatorTest: IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream _memoryStream;


        public CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            _memoryStream = new MemoryStream();
        }


        // NomeDaFuncao__EntradaDeValores__ResultadoEsperado
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsSUM()
        {
            var numeber1 = 2;
            var number2 = 2;

            var calculator = _calculatorFixture.Calc;
            var result = calculator.Add(numeber1, number2);

            Assert.Equal(4, result);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsSUM()
        {
            var double1 = 2.2;
            var double2 = 2.1;

            var calculator = _calculatorFixture.Calc;
            var result = calculator.AddDouble(double1, double2);

            Assert.Equal(4.3, result, 1);
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue()
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(1);
            Assert.True(result);
        }


        [Fact]
        public void IsOdd_GivenEvenValue_ReturnsFalse()
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(2);
            Assert.False(result);
        }

        [Theory]
        [InlineData(1,true)]
        [InlineData(2,false)]
        public void IsOdd_TestOddAndEven(int value,bool expected)
        {
            var calc = _calculatorFixture.Calc;
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }


    }
}
