using Xunit;

namespace CalculatorAPP.Test
{
    public class CalculatorTest
    {
        // NomeDaFuncao__EntradaDeValores__ResultadoEsperado
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsSUM()
        {
            var numeber1 = 2;
            var number2 = 2;

            var calculator = new Calculator();
            var result = calculator.Add(numeber1, number2);

            Assert.Equal(4, result);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsSUM()
        {
            var double1 = 2.2;
            var double2 = 2.1;

            var calculator = new Calculator();
            var result = calculator.AddDouble(double1, double2);

            Assert.Equal(4.3, result, 1);
        }
    }
}
