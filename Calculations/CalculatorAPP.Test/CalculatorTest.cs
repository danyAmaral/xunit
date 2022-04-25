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
    }
}
