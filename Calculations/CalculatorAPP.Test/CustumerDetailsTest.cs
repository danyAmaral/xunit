using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace CalculatorAPP.Test
{
    [Collection("Customer")]
    public  class CustumerDetailsTest
    {
        private readonly CustomerFixture _customerFixture;
        public CustumerDetailsTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void GetFullName_GivenFirtAndLastName_ReturnsFullName()
        {
            var customer = _customerFixture.Customer;

            Assert.Equal("Dani Amaral", customer.GetFullName("Dani", "Amaral"));
        }

    }
}
